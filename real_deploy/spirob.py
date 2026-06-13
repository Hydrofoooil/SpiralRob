"""
SpiRob 三绳软体机器人 —— 位置控制封装 + 交互式控制台。

三个 MKS 电机各绕一个线盘, 各收/放一根绳; 三根绳的相对收紧量决定机器人弯曲姿态。

坐标与方向约定:
  - 每根绳一个"拉入量" pull, 单位 = 圈 (rev): 正 = 收紧/拉短, 负 = 放松。
  - 以 set_zero_here() 时的姿态为各绳零点。务必在"松弛/中性"姿态下置零。
  - 实际收紧对应电机正转还是反转, 取决于线盘绕向 —— 用 directions[i] (+1/-1) 翻转,
    不必改接线。先用点动 (jog) 确认: 正 pull 应当"收紧"该绳。

安全 (软体本体和绳都很容易被拉坏, 务必遵守):
  - 第一次先用很小的 pull (如 0.1-0.3 圈) 和较低速度 (默认 120 RPM) 试。
  - max_pull 是每根绳的软上限(圈), 必须按你的线盘半径/绳长标定后再调大。
  - 空闲时用 relax() 松轴, 避免长时间堵转发热 / 持续张力。

运行:
    python real_deploy/spirob.py [--port /dev/ttyUSB0] [--baud 38400] [--addrs 1,2,3]
"""
from __future__ import annotations

import argparse
import contextlib
import math
import time

from mks_servo import COUNTS_PER_REV, MODE_SR_vFOC, MksBus, MksError, MksServo, RUN_STOPPED


class SpiRob:
    def __init__(self, bus: MksBus, addresses=(1, 2, 3), directions=(1, 1, 1),
                 max_pull: float = 1.0, cable_angles_deg=(90.0, 210.0, 330.0),
                 payout_exp: float = 2.0):
        self.bus = bus
        self.cables = [MksServo(bus, a) for a in addresses]
        self.directions = list(directions)
        self.max_pull = max_pull          # 每根绳允许的最大|拉入量|(圈), 标定后再调大
        self.speed = 120                  # 位置指令默认速度 RPM
        self.acc = 2                      # 默认加速度档
        # 放线非线性指数: 收线侧线性, 放线(负向)侧 ∝ 弯曲量^payout_exp。
        # =1 线性对称(老行为); >1 小弯曲时放线少、大弯曲才放足 (默认 2.0)。
        self.payout_exp = payout_exp
        # 三根绳在触手横截面上的安装角(度), 用于"弯曲向量 <-> 三绳拉入量"联动映射;
        # 默认 90/210/330 (互成 120°, 绳1 在 +Y)。装反/朝向不对就改这里或 directions。
        self._cable_angles_rad = [math.radians(a) for a in cable_angles_deg]

    # ----------------------------------------------------------------- 初始化
    def setup(self) -> None:
        """把三台电机配置到"总线 FOC + 干净应答 + 使能"状态。可重复调用 (幂等)。"""
        for c in self.cables:
            c.set_response_mode(reply=True, active_complete=False)  # 先让应答变干净
            c.set_work_mode(MODE_SR_vFOC)                           # 串口控制必须 SR_xxx
            c.enable(True)                                          # 总线模式下用指令使能
        print(f"已初始化 {len(self.cables)} 台电机: 地址 {[c.addr for c in self.cables]}")

    def set_zero_here(self) -> None:
        """在当前(应为松弛/中性)姿态下, 把三根绳都置零。绝对位置指令以此为基准。"""
        for c in self.cables:
            c.set_zero()
        print("已在当前姿态置零 (三绳零点)。")

    # ------------------------------------------------------------------- 位置
    def _clamp(self, pull: float) -> float:
        return max(-self.max_pull, min(self.max_pull, pull))

    def set_pull(self, pulls, speed: int | None = None, acc: int | None = None) -> None:
        """
        让三根绳到达各自的绝对拉入量 (圈)。pulls = (c1, c2, c3)。
        正 = 收紧, 负 = 放松; 会按 max_pull 截断。三条指令依次下发 (近乎同时)。
        """
        speed = self.speed if speed is None else speed
        acc = self.acc if acc is None else acc
        for c, dir_, pull in zip(self.cables, self.directions, pulls):
            target = self._clamp(pull)
            coord = round(dir_ * target * COUNTS_PER_REV)
            c.move_abs_coord(coord, speed=speed, acc=acc)

    def set_one(self, idx: int, pull: float, speed: int | None = None,
                acc: int | None = None) -> None:
        """单根绳 idx(0-2) 绝对到 pull 圈。"""
        speed = self.speed if speed is None else speed
        acc = self.acc if acc is None else acc
        c = self.cables[idx]
        coord = round(self.directions[idx] * self._clamp(pull) * COUNTS_PER_REV)
        c.move_abs_coord(coord, speed=speed, acc=acc)

    def read_pull(self):
        """返回三根绳当前拉入量(圈), 已按 direction 归一 (正=收紧)。"""
        return [c.read_coord() / COUNTS_PER_REV * d
                for c, d in zip(self.cables, self.directions)]

    # --------------------------------------------- 触手联动 (弯曲向量 <-> 三绳)
    # 把整条触手看作 3 自由度: 弯曲向量 (bx,by) (方向=朝哪弯, 模长=弯多少) + 收缩 c。
    # 恒曲率腱驱动映射: 第 i 根绳拉入量 pull_i = bx*cos(βi) + by*sin(βi) + c。
    # (bx,by) 项在 120° 均布下三绳和为 0 = 纯弯曲(不改总长); c 是公共项 = 整体收缩。
    def pulls_from_bend(self, bx: float, by: float, contraction: float = 0.0):
        """
        弯曲向量 + 收缩 -> 三绳拉入量(圈)。
        收线侧线性; 放线侧按 payout_exp 非线性衰减(小弯曲少放线, 大弯曲才放足)。
        最后超 max_pull 时整体等比缩小, 保持弯曲方向。
        """
        m = math.hypot(bx, by)                          # 弯曲量
        if self.payout_exp != 1.0 and self.max_pull > 0:
            alpha = min(1.0, m / self.max_pull) ** (self.payout_exp - 1.0)
        else:
            alpha = 1.0                                 # 线性
        pulls = []
        for a in self._cable_angles_rad:
            bp = bx * math.cos(a) + by * math.sin(a)
            if bp < 0:
                bp *= alpha                             # 只衰减放线(负向), 收线不动
            pulls.append(bp + contraction)
        peak = max(abs(p) for p in pulls)
        if peak > self.max_pull > 0 and peak > 1e-9:
            pulls = [p * self.max_pull / peak for p in pulls]
        return pulls

    def bend_from_pulls(self, pulls):
        """三绳拉入量 -> 弯曲向量 (bx,by,c)。pulls_from_bend 的逆 (120° 均布精确)。"""
        c = sum(pulls) / len(pulls)
        bx = (2.0 / 3.0) * sum(p * math.cos(a) for p, a in zip(pulls, self._cable_angles_rad))
        by = (2.0 / 3.0) * sum(p * math.sin(a) for p, a in zip(pulls, self._cable_angles_rad))
        return bx, by, c

    def set_bend(self, bx: float, by: float, contraction: float = 0.0,
                 speed: int | None = None, acc: int | None = None) -> None:
        """整条触手联动: 给定弯曲向量(bx,by)+收缩c, 三绳协调收放到对应位置。"""
        self.set_pull(self.pulls_from_bend(bx, by, contraction), speed=speed, acc=acc)

    def wait_until_stopped(self, timeout: float = 15.0, poll: float = 0.05) -> bool:
        """轮询 F1H 直到三台都停止 (或超时)。位置流式控制可不调用。"""
        time.sleep(0.1)  # 给电机一点时间进入加速状态, 避免一上来就读到"停止"
        t0 = time.monotonic()
        while time.monotonic() - t0 < timeout:
            if all(c.read_run_status() == RUN_STOPPED for c in self.cables):
                return True
            time.sleep(poll)
        return False

    # ------------------------------------------------------------------- 点动
    def jog(self, idx: int, rpm: int) -> None:
        """点动电机 idx(0-2): rpm 正负=方向, 0=停。用于收放绳找零位/确认方向。"""
        if rpm == 0:
            self.cables[idx].stop()
        else:
            self.cables[idx].run_speed(rpm, acc=self.acc)

    # ------------------------------------------------------------- 全局状态/急停
    def relax(self) -> None:
        """松开全部电机 (松轴): 绳松弛、不再有张力。空闲休息用。"""
        for c in self.cables:
            c.enable(False)
        print("已松轴 (relax)。")

    def hold(self) -> None:
        """锁住全部电机 (保持当前姿态)。"""
        for c in self.cables:
            c.enable(True)
        print("已锁轴 (hold)。")

    def stop(self) -> None:
        """三绳减速停。"""
        for c in self.cables:
            c.stop(acc=self.acc)

    def estop(self) -> None:
        """紧急停机全部。"""
        for c in self.cables:
            try:
                c.emergency_stop()
            except MksError as e:
                print(f"  addr {c.addr:#x} 急停异常: {e}")
        print("已紧急停机。")

    def shutdown(self) -> None:
        """
        安全收尾 (退出 / Ctrl+C 时调用)。
        先给每台发"停止"(F6 00 00) 再松轴: 速度点动属于速度模式, 必须显式停, 只松轴(F3)
        停不下来 —— 这正是点动后退出仍一直转的原因。各电机独立 try, 一台失败不影响其它台。
        """
        for c in self.cables:
            try:
                c.stop(acc=self.acc)      # F6 00 00: 取消速度目标, 真正停车
            except MksError as e:
                print(f"  addr {c.addr:#x} 停止异常: {e}")
        for c in self.cables:
            try:
                c.enable(False)           # 再松轴
            except MksError as e:
                print(f"  addr {c.addr:#x} 松轴异常: {e}")

    # ---------------------------------------------------- 诊断 / 校准 / 回零
    def diagnose(self) -> None:
        """读三台的状态与限位/保护配置, 诊断"正反转一定圈数就停"的原因。"""
        run_names = {0: "查询失败", 1: "停止", 2: "加速", 3: "减速", 4: "全速", 5: "回零", 6: "校准"}
        for c in self.cables:
            print(f"--- 电机 addr {c.addr:#x} ---")
            try:
                run = c.read_run_status(); coord = c.read_coord(); rpm = c.read_speed()
                enabled = c.read_enabled(); stall = c.read_stall()
                io = c.read_io(); aerr = c.read_angle_error()
            except MksError as e:
                print(f"  状态读取失败: {e}")
                continue
            try:
                pa = c.read_params_all()           # 47H, 老固件可能不支持
            except MksError:
                pa = None
            print(f"  运行状态 : {run_names.get(run, run)}    使能: {'锁轴' if enabled else '★松轴★'}"
                  f"    堵转: {'★已堵转★' if stall else '正常'}")
            print(f"  当前坐标 : {coord / COUNTS_PER_REV:+.3f} 圈 ({coord})    转速 {rpm:+d} RPM"
                  f"    角度误差 {aerr * 360 / 51200:+.1f}°")
            print(f"  限位输入 : IN_1(左限/回零)={(io >> 0) & 1}  IN_2(右限)={(io >> 1) & 1}")
            reasons = []
            if pa is not None:
                print(f"  配置     : 限位使能(EndLimit)={'开' if pa['end_limit'] else '关'}  "
                      f"限位重映射={'开' if pa['limit_remap'] else '关'}  "
                      f"堵转保护={'开' if pa['stall_protect'] else '关'}")
                if pa["end_limit"]:
                    reasons.append("EndLimit 限位已开 → 触发左/右限位后该方向停 (看 IN_1/IN_2)")
                if pa["stall_protect"] and not stall:
                    reasons.append("堵转保护开启中 → 绳张力一大就会停并松轴")
            else:
                print("  配置     : (固件不支持 47H 整包读取, 跳过限位/保护配置)")
            if stall:
                reasons.append("已堵转 → 绳张力过大触发保护并松轴; 解除: clear_stall 或重新 enable")
            if not enabled:
                reasons.append("当前松轴 → 可能被保护自动关断, 或还没 enable")
            print("  ▶ " + ("; ".join(reasons) if reasons else
                            f"未见电机侧限位/堵转。若用位置控制(p/m/键盘), 多半是软件 max_pull="
                            f"{self.max_pull}圈 截断了目标 (用 --max-pull 调大); 点动/速度模式不受此限。"))

    def go_zero_all(self, speed=None, acc=None) -> None:
        """三绳回到坐标 0 (即 set_zero 设的零点)。"""
        speed = self.speed if speed is None else speed
        acc = self.acc if acc is None else acc
        for c in self.cables:
            c.move_abs_coord(0, speed=speed, acc=acc)
        print("三绳回零中 (-> 坐标 0)。")

    def set_current_all(self, ma: int, save: bool = True) -> None:
        """设置三台工作电流(mA)。⚠️ 别超电机额定、别设最大值; 加电流=加力矩+发热+对软体的力。"""
        for c in self.cables:
            try:
                st = c.set_current(ma, save=save)
                print(f"  addr {c.addr:#x}: 工作电流 -> {ma} mA ({'已保存' if st == 1 else '仅本次'})")
            except MksError as e:
                print(f"  addr {c.addr:#x}: 设置失败 {e}")

    def read_current_all(self):
        """读三台工作电流(mA); 读不到为 None。"""
        out = []
        for c in self.cables:
            try:
                out.append(c.read_params_all()["current"])
            except MksError:
                out.append(None)
        return out

    def calibrate_all(self, return_to_zero: bool = False) -> None:
        """
        逐台校准编码器 (Windows 'Cal' 同款), 校准后恢复总线 FOC + 使能, 可选回到零点。
        ⚠️ 校准时电机会自转, 必须空载 / 松开绳! 详见 MksServo.calibrate。
        """
        for c in self.cables:
            print(f"  校准 addr {c.addr:#x} ...", end=" ", flush=True)
            try:
                ok = c.calibrate()
                print("成功" if ok else "完成(未确认)")
            except MksError as e:
                print(f"失败: {e}")
        for c in self.cables:                      # 校准后恢复总线 FOC + 使能
            try:
                c.set_work_mode(MODE_SR_vFOC)
                c.enable(True)
            except MksError as e:
                print(f"  addr {c.addr:#x} 重新初始化异常: {e}")
        if return_to_zero:
            self.go_zero_all()


# ====================================================================== 交互式
HELP = """\
命令:
  z                     在当前姿态置零(三绳零点) —— 必须在松弛/中性姿态下做
  p <c1> <c2> <c3>      位置: 三绳绝对拉入量(圈), 正=收紧 负=放松, 例: p 0.3 0 0
  m <i> <revs>          单绳 i(1-3) 绝对到 revs 圈, 例: m 1 0.3
  j <i> <rpm>           点动: 电机 i(1-3) 以 rpm 转 (找零位用); rpm=0 停
  r                     读取三绳当前拉入量(圈)及转速
  diag                  诊断限位/堵转/保护/坐标 (查"正反转几圈就停"的原因)
  home                  三绳回到零点 (坐标 0)
  cal                   校准编码器(需空载/松绳!), 完成后可选回零
  cur [ma]              查看/设置三台工作电流(mA); 不带参数=查看 (35D 默认 800)
  v <rpm>               设置后续位置指令的速度 (默认 120)
  relax / hold / stop   松轴 / 锁轴 / 减速停
  k                     单绳键盘直控 (u/i/o 收, j/k/l 放; 单键实时, tmux 可用)
  t                     触手联动键盘控制 (WASD 控整条触手弯曲; 推荐, 更协调)
  b <bx> <by> [c]       触手联动: 设弯曲向量+收缩(协调三绳), 例: b 0.3 0 0
  Ctrl+C                急停: 立即停全部电机, 留在控制台 (随时可按, 代替原 e 命令)
  setup                 重新初始化(SR_vFOC + 使能)
  ? / h                 显示本帮助
  q                     停机松轴并退出 (或 Ctrl+D)
"""


def repl(robot: SpiRob) -> None:
    print(HELP)
    while True:
        try:
            line = input("spirob> ").strip()
        except EOFError:                    # Ctrl+D: 退出
            print()
            break
        except KeyboardInterrupt:           # Ctrl+C: 急停, 留在控制台
            print()
            robot.estop()
            continue
        if not line:
            continue
        parts = line.split()
        cmd = parts[0].lower()
        try:
            if cmd in ("q", "quit", "exit"):
                break
            elif cmd in ("?", "h", "help"):
                print(HELP)
            elif cmd == "z":
                robot.set_zero_here()
            elif cmd == "p":
                pulls = [float(x) for x in parts[1:4]]
                if len(pulls) != 3:
                    print("用法: p <c1> <c2> <c3>")
                    continue
                robot.set_pull(pulls)
                print(f"-> 目标拉入量(截断后) {[round(robot._clamp(x), 3) for x in pulls]} 圈")
            elif cmd == "m":
                idx = int(parts[1]) - 1
                robot.set_one(idx, float(parts[2]))
                print(f"-> 绳{idx + 1} 目标 {robot._clamp(float(parts[2])):.3f} 圈")
            elif cmd == "j":
                idx = int(parts[1]) - 1
                rpm = int(parts[2])
                robot.jog(idx, rpm)
                print(f"-> 绳{idx + 1} 点动 {rpm} RPM" if rpm else f"-> 绳{idx + 1} 停")
            elif cmd == "r":
                pulls = robot.read_pull()
                speeds = [c.read_speed() for c in robot.cables]
                for i, (p, s) in enumerate(zip(pulls, speeds), 1):
                    print(f"  绳{i}: {p:+.3f} 圈   {s:+d} RPM")
            elif cmd == "v":
                robot.speed = int(parts[1])
                print(f"-> 速度设为 {robot.speed} RPM")
            elif cmd == "relax":
                robot.relax()
            elif cmd == "hold":
                robot.hold()
            elif cmd == "stop":
                robot.stop()
            elif cmd == "setup":
                robot.setup()
            elif cmd in ("k", "keys"):
                keyboard_control(robot)
            elif cmd in ("t", "tentacle"):
                tentacle_control(robot)
            elif cmd == "b":
                vals = [float(x) for x in parts[1:4]]
                if len(vals) < 2:
                    print("用法: b <bx> <by> [contraction]")
                    continue
                bx, by = vals[0], vals[1]
                c = vals[2] if len(vals) > 2 else 0.0
                robot.set_bend(bx, by, c)
                print(f"-> 弯曲({bx:+.2f},{by:+.2f}) 收缩{c:+.2f} -> 绳 "
                      + " ".join(f"{p:+.2f}" for p in robot.pulls_from_bend(bx, by, c)))
            elif cmd == "diag":
                robot.diagnose()
            elif cmd == "cal":
                print("⚠️  编码器校准会让电机自转约一圈, 必须先松开绳 / 脱开负载!")
                if input("  确认已空载? 输入 yes 继续: ").strip().lower() == "yes":
                    robot.calibrate_all(return_to_zero=False)
                    if input("  校准完成。装好绳后回到零点? y/n: ").strip().lower() == "y":
                        robot.go_zero_all()
                else:
                    print("已取消校准。")
            elif cmd == "home":
                robot.go_zero_all()
            elif cmd == "cur":
                if len(parts) < 2:
                    for c, ma in zip(robot.cables, robot.read_current_all()):
                        print(f"  addr {c.addr:#x}: 工作电流 {ma} mA")
                else:
                    print("⚠️ 加电流=加力矩, 也加发热和对软体的力; 别超 35D 额定、别设最大值, 从小幅加起。")
                    robot.set_current_all(int(parts[1]))
            else:
                print(f"未知命令: {cmd} (输入 ? 看帮助)")
        except KeyboardInterrupt:
            # 命令执行中按 Ctrl+C: 急停, 但留在控制台继续操作
            print()
            robot.estop()
        except MksError as e:
            print(f"[协议错误] {e}")
        except (IndexError, ValueError):
            print("参数错误 (输入 ? 看帮助)")
    # 退出收尾(停车+松轴)统一在 main() 的 finally 做, 同时覆盖键盘模式与异常退出


# ====================================================== 键盘直控 (共用底座)
def _keyboard_ready() -> bool:
    import sys
    try:
        import os, select, termios  # noqa: F401
    except ImportError:
        print("当前平台不支持键盘直控 (需要 termios, 仅 Linux/macOS)。")
        return False
    if not sys.stdin.isatty():
        print("当前不是交互式终端(TTY), 无法用键盘直控 (例如被管道/重定向了)。")
        return False
    return True


@contextlib.contextmanager
def _raw_terminal():
    """stdin 设成 cbreak: 单键即时、关回显、保留信号(Ctrl+C 仍触发急停); 退出恢复。"""
    import sys
    import termios
    fd = sys.stdin.fileno()
    old = termios.tcgetattr(fd)
    try:
        new = termios.tcgetattr(fd)
        new[3] &= ~(termios.ICANON | termios.ECHO)
        new[3] |= termios.ISIG
        new[6][termios.VMIN] = 1
        new[6][termios.VTIME] = 0
        termios.tcsetattr(fd, termios.TCSADRAIN, new)
        termios.tcflush(fd, termios.TCIFLUSH)             # 清掉残留输入
        yield fd
    finally:
        termios.tcsetattr(fd, termios.TCSADRAIN, old)     # 务必恢复终端


def _read_key_batch(fd) -> str:
    """阻塞读一个键, 再把"连发"缓冲的同批按键一次读完 (合并去拖尾)。"""
    import os
    import select
    data = os.read(fd, 1)
    while select.select([fd], [], [], 0.0)[0]:
        more = os.read(fd, 64)
        if not more:
            break
        data += more
    return data.decode("latin-1", "ignore")


def _iter_keys(keys: str):
    """逐键产出; Esc/方向键等 CSI 转义序列整段跳过 (避免 tmux 下误触发/误退)。"""
    i = 0
    while i < len(keys):
        ch = keys[i]; i += 1
        if ch == "\x1b":
            if i < len(keys) and keys[i] == "[":
                i += 1
                while i < len(keys) and not ("\x40" <= keys[i] <= "\x7e"):
                    i += 1
                i += 1                                    # 跳过 CSI final byte
            continue
        yield ch


# --------------------------------------------------- 模式1: 单绳键盘直控
KEY_HELP = """\
单绳键盘直控 (按键即生效, 无需回车; tmux 下同样可用):
  收紧 +    u   i   o      (绳1 绳2 绳3)
  放松 -    j   k   l
  space     全部减速停 (不改目标)        0   三绳回中性
  z         当前姿态置零 (并清零目标)    - / =  步长 ∓0.01 圈
  r         打印三绳坐标/转速            , / .  速度 ∓10 RPM
  x / g     松轴 / 锁轴                  ?   帮助
  Ctrl+C    急停 (留在键盘模式)          q   退出键盘模式
按住某键不放 = 该绳持续收/放; 松开即停在当前目标 (连发自动合并, 不会拖尾)。
"""


def keyboard_control(robot: SpiRob) -> None:
    """单绳键盘直控: u/i/o 收, j/k/l 放, 增量绝对位置。仅 Unix TTY, tmux 下可用。"""
    if not _keyboard_ready():
        return
    IN = {"u": 0, "i": 1, "o": 2}
    OUT = {"j": 0, "k": 1, "l": 2}
    step = 0.05
    try:
        targets = [round(p, 4) for p in robot.read_pull()]   # 从当前实际位置接续
    except MksError:
        targets = [0.0, 0.0, 0.0]
    print(KEY_HELP)
    print(f"[单绳键盘] 步长 {step} 圈  速度 {robot.speed} RPM  (按 q 退出)")
    with _raw_terminal() as fd:
        while True:
            try:
                changed = set(); quit_ = False
                for ch in _iter_keys(_read_key_batch(fd)):
                    if ch == "q":
                        quit_ = True; break
                    elif ch in IN:
                        j = IN[ch]; targets[j] = robot._clamp(targets[j] + step); changed.add(j)
                    elif ch in OUT:
                        j = OUT[ch]; targets[j] = robot._clamp(targets[j] - step); changed.add(j)
                    elif ch == " ":
                        robot.stop()
                    elif ch == "0":
                        targets = [0.0, 0.0, 0.0]; robot.set_pull(targets); changed.clear()
                    elif ch == "z":
                        robot.set_zero_here(); targets = [0.0, 0.0, 0.0]; changed.clear()
                    elif ch in ("-", "_"):
                        step = max(0.01, round(step - 0.01, 3)); print(f"[步长] {step} 圈")
                    elif ch in ("=", "+"):
                        step = min(robot.max_pull, round(step + 0.01, 3)); print(f"[步长] {step} 圈")
                    elif ch == ",":
                        robot.speed = max(1, robot.speed - 10); print(f"[速度] {robot.speed} RPM")
                    elif ch == ".":
                        robot.speed = min(3000, robot.speed + 10); print(f"[速度] {robot.speed} RPM")
                    elif ch == "r":
                        pulls = robot.read_pull(); spd = [c.read_speed() for c in robot.cables]
                        print("  " + "   ".join(f"绳{k + 1} {p:+.2f}圈/{s:+d}RPM"
                                                for k, (p, s) in enumerate(zip(pulls, spd))))
                    elif ch == "x":
                        robot.relax()
                    elif ch == "g":
                        robot.hold()
                    elif ch == "?":
                        print(KEY_HELP)
                for j in changed:
                    robot.set_one(j, targets[j])          # F5 绝对坐标, 支持实时更新
                if quit_:
                    break
            except KeyboardInterrupt:                     # Ctrl+C: 急停, 留在键盘模式
                robot.estop()
            except MksError as e:
                print(f"[协议错误] {e}")
    print("退出键盘模式。")


# ------------------------------------------- 模式2: 触手联动 (整条触手当 3 DOF)
TENTACLE_HELP = """\
触手联动控制 (整条触手 = 3 自由度, 单键实时, 无需回车; tmux 下可用):
  w / s     向 +Y / -Y 弯 (前/后倾)        a / d   向 -X / +X 弯 (左/右倾)
  i / k     整体收紧 / 放松 (收缩自由度)    space   回正 (弯曲归零, 收缩不变)
  0         全部归零 (弯曲+收缩=0)          z       当前姿态置零
  - / =     弯曲步长 ∓                      , / .   速度 ∓10 RPM
  [ / ]     放线指数 ∓ (越大=小弯曲放线越少)  r       打印状态
  x / g     松轴 / 锁轴       ?  帮助       Ctrl+C 急停      q  退出
WASD = 触手往哪倒; 三根绳由弯曲向量(bx,by)+收缩(c)联动协调收放, 不再各管各的。
收线侧线性、放线侧按"放线指数"非线性: 小弯曲少放线(绳不松), 大弯曲才放足。
"""


def tentacle_control(robot: SpiRob) -> None:
    """触手联动: WASD 控弯曲方向/大小, i/k 控收缩; 三绳由恒曲率映射协调。仅 Unix TTY。"""
    if not _keyboard_ready():
        return
    step = 0.02
    lim = robot.max_pull
    try:
        bx, by, c = (round(v, 4) for v in robot.bend_from_pulls(robot.read_pull()))
    except MksError:
        bx, by, c = 0.0, 0.0, 0.0
    print(TENTACLE_HELP)
    print(f"[触手联动] 弯曲步长 {step}  速度 {robot.speed} RPM  放线指数 {robot.payout_exp}  (按 q 退出)")
    with _raw_terminal() as fd:
        while True:
            try:
                dirty = False; quit_ = False
                for ch in _iter_keys(_read_key_batch(fd)):
                    if ch == "q":
                        quit_ = True; break
                    elif ch == "w":
                        by = min(lim, round(by + step, 4)); dirty = True
                    elif ch == "s":
                        by = max(-lim, round(by - step, 4)); dirty = True
                    elif ch == "d":
                        bx = min(lim, round(bx + step, 4)); dirty = True
                    elif ch == "a":
                        bx = max(-lim, round(bx - step, 4)); dirty = True
                    elif ch == "i":
                        c = min(lim, round(c + step, 4)); dirty = True
                    elif ch == "k":
                        c = max(-lim, round(c - step, 4)); dirty = True
                    elif ch == " ":
                        bx = by = 0.0; dirty = True               # 回正 (保留收缩)
                    elif ch == "0":
                        bx = by = c = 0.0; dirty = True
                    elif ch == "z":
                        robot.set_zero_here(); bx = by = c = 0.0; dirty = True
                    elif ch in ("-", "_"):
                        step = max(0.005, round(step - 0.005, 4)); print(f"[弯曲步长] {step}")
                    elif ch in ("=", "+"):
                        step = min(lim, round(step + 0.005, 4)); print(f"[弯曲步长] {step}")
                    elif ch == "[":
                        robot.payout_exp = max(1.0, round(robot.payout_exp - 0.25, 2))
                        print(f"[放线指数] {robot.payout_exp} (1=对称, 越大=小弯曲放线越少)"); dirty = True
                    elif ch == "]":
                        robot.payout_exp = min(4.0, round(robot.payout_exp + 0.25, 2))
                        print(f"[放线指数] {robot.payout_exp} (1=对称, 越大=小弯曲放线越少)"); dirty = True
                    elif ch == ",":
                        robot.speed = max(1, robot.speed - 10); print(f"[速度] {robot.speed} RPM")
                    elif ch == ".":
                        robot.speed = min(3000, robot.speed + 10); print(f"[速度] {robot.speed} RPM")
                    elif ch == "r":
                        pulls = robot.pulls_from_bend(bx, by, c)
                        ang = math.degrees(math.atan2(by, bx)); mag = math.hypot(bx, by)
                        print(f"  弯曲 ({bx:+.2f},{by:+.2f}) |{mag:.2f}|@{ang:+.0f}°  收缩 {c:+.2f}"
                              f"  放线指数 {robot.payout_exp}"
                              "  -> 绳 " + " ".join(f"{p:+.2f}" for p in pulls))
                    elif ch == "x":
                        robot.relax()
                    elif ch == "g":
                        robot.hold()
                    elif ch == "?":
                        print(TENTACLE_HELP)
                if dirty:
                    robot.set_bend(bx, by, c)             # 三绳联动协调
                if quit_:
                    break
            except KeyboardInterrupt:
                robot.estop()
            except MksError as e:
                print(f"[协议错误] {e}")
    print("退出触手联动模式。")


def main() -> None:
    ap = argparse.ArgumentParser(description="SpiRob 三绳软体机器人 RS485 控制台")
    ap.add_argument("--port", default="/dev/ttyUSB0", help="串口 (默认 /dev/ttyUSB0)")
    ap.add_argument("--baud", type=int, default=38400, help="波特率 (出厂默认 38400)")
    ap.add_argument("--addrs", default="1,3,2",
                    help="绳i 对应的电机地址, 逗号分隔。默认 1,3,2 (绳1→电机1, 绳2→电机3, 绳3→电机2)")
    ap.add_argument("--dirs", default="1,1,1", help="各绳方向 +1/-1, 逗号分隔 (默认 1,1,1)")
    ap.add_argument("--max-pull", type=float, default=1.0, help="每根绳最大|拉入量|(圈), 标定后调大")
    ap.add_argument("--no-setup", action="store_true", help="跳过自动初始化")
    ap.add_argument("--keys", action="store_true", help="启动后直接进入单绳键盘直控")
    ap.add_argument("--tentacle", action="store_true", help="启动后直接进入触手联动键盘控制")
    ap.add_argument("--cable-angles", default="210,90,330",
                    help="绳i 安装角(度), 逗号分隔。默认 210,90,330 (绳1=8点, 绳2=12点, 绳3=4点)")
    ap.add_argument("--payout-exp", type=float, default=2.0,
                    help="放线非线性指数: 1=线性(对称), 越大=小弯曲时放线越少 (默认 2.0)")
    ap.add_argument("--current", type=int, default=None,
                    help="工作电流(mA); 不给则用驱动器默认(35D=800)。如 --current 1200")
    args = ap.parse_args()

    addrs = [int(x) for x in args.addrs.split(",")]
    dirs = [int(x) for x in args.dirs.split(",")]
    angles = [float(x) for x in args.cable_angles.split(",")]

    bus = MksBus(port=args.port, baudrate=args.baud)
    robot = SpiRob(bus, addresses=addrs, directions=dirs, max_pull=args.max_pull,
                   cable_angles_deg=angles, payout_exp=args.payout_exp)
    try:
        if not args.no_setup:
            robot.setup()
        if args.current is not None:
            robot.set_current_all(args.current)
        if args.tentacle:
            tentacle_control(robot)
        elif args.keys:
            keyboard_control(robot)
        else:
            repl(robot)
    finally:
        try:
            robot.shutdown()            # 停车 + 松轴: 覆盖命令行/键盘/异常所有退出路径
        except Exception as e:
            print(f"[收尾异常] {e}")
        bus.close()
        print("已退出。")


if __name__ == "__main__":
    main()
