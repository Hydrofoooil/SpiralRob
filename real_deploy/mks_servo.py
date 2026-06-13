"""
MKS SERVO D 系列闭环步进驱动器 —— RS485 (MKS 自定义协议) Python 驱动。

对应手册/固件版本: V1.0.9 (《MKS SERVO42&57D 闭环步进电机 RS485 使用说明 v1.0.9》)。
只实现"总线(串口)控制模式"驱动 SpiRob 软体机器人所需的核心指令。

帧格式 (手册 第4章):
    下行 (PC -> 驱动器):  FA  addr  code  data...  checksum
    上行 (驱动器 -> PC):  FB  addr  code  data...  checksum
  - 数据为大端 (big-endian)
  - checksum = (该帧前面所有字节之和) & 0xFF        # 默认 CHECKSUM 8bit 校验
  - addr: 从机地址, 0x00 为广播(从机不应答), 出厂默认 0x01
  - 同一条指令各字节之间不能有 >1 字节的延时, 否则从机可能丢帧 (pyserial 一次 write 即可)

单位换算 (手册 1.11.2):
  - 16384 线编码器: 一圈(360°) = 16384 = 0x4000   —— 这是"坐标/编码器值", 与细分无关
  - 16 细分下一圈 = 3200 脉冲                        —— "脉冲数"与细分有关
  本驱动的位置控制一律用"坐标"(累加多圈编码器值, 16384/圈), 因此与细分设置无关, 最稳。

所有帧的 checksum/字节布局均已对照手册示例核对 (例如 FA 01 92 8D、FA 01 82 05 82、
FA 01 F5 01 2C 02 00 02 80 00 A1、FA 01 F6 02 80 02 75、FA 01 F7 F2)。
"""
from __future__ import annotations

import struct
import threading
import time

import serial


# ---- 帧头 / 地址 ----
TX_HEADER = 0xFA
RX_HEADER = 0xFB
BROADCAST_ADDR = 0x00

# ---- 工作模式 (82H, 手册 5.2.2) ----
MODE_CR_OPEN = 0x00   # 脉冲接口 开环
MODE_CR_CLOSE = 0x01  # 脉冲接口 闭环
MODE_CR_vFOC = 0x02   # 脉冲接口 FOC (出厂默认 —— 串口控制下必须改掉)
MODE_SR_OPEN = 0x03   # 总线接口 开环
MODE_SR_CLOSE = 0x04  # 总线接口 闭环
MODE_SR_vFOC = 0x05   # 总线接口 FOC   <- 串口/485 控制推荐

# 一圈对应的编码器坐标值 (与细分无关)
COUNTS_PER_REV = 16384  # 0x4000

# 波特率档位 (8AH, 手册 5.2.10); 出厂默认 38400
BAUD_CODES = {9600: 0x01, 19200: 0x02, 25000: 0x03, 38400: 0x04,
              57600: 0x05, 115200: 0x06, 256000: 0x07}

# F1H 电机运行状态码 (手册 9.2.1)
RUN_QUERY_FAIL, RUN_STOPPED, RUN_ACCEL, RUN_DECEL, RUN_FULL, RUN_HOMING, RUN_CAL = range(7)


class MksError(Exception):
    """协议层错误: 无应答 / 帧不符 / 校验失败 / 驱动器返回失败状态。"""


class MksBus:
    """
    一条 RS485 总线 = 一个 USB-转-485 适配器 = 一个串口。
    总线上可挂多台驱动器, 用 addr 区分。485 是半双工、一问一答, 用锁串行化每次收发。
    """

    def __init__(self, port: str = "/dev/ttyUSB0", baudrate: int = 38400,
                 timeout: float = 0.3):
        self.ser = serial.Serial(port=port, baudrate=baudrate, timeout=timeout)
        self._lock = threading.Lock()

    def close(self) -> None:
        try:
            self.ser.close()
        except Exception:
            pass

    def __enter__(self):
        return self

    def __exit__(self, *exc):
        self.close()

    @staticmethod
    def _checksum(frame_without_crc: bytes) -> int:
        return sum(frame_without_crc) & 0xFF

    def transfer(self, addr: int, code: int, data: bytes = b"",
                 resp_data_len: int = 1) -> bytes | None:
        """
        发送一条指令, 并(非广播时)读取一帧应答。

        resp_data_len: 应答帧 data 段的字节数 (不含 FB/addr/code/checksum)。
                       绝大多数"设置/运动"类指令返回 1 字节状态。
        返回: 应答的 data 段 bytes; 广播地址 (0x00) 恒返回 None。
        """
        body = bytes([TX_HEADER, addr & 0xFF, code & 0xFF]) + bytes(data)
        frame = body + bytes([self._checksum(body)])

        with self._lock:
            self.ser.reset_input_buffer()          # 丢弃可能残留的旧帧
            self.ser.write(frame)
            if addr == BROADCAST_ADDR:
                return None                        # 广播: 从机不应答
            n = 3 + resp_data_len + 1
            resp = self.ser.read(n)

        if len(resp) != n:
            raise MksError(
                f"addr={addr:#04x} code={code:#04x}: 应答超时/不完整 "
                f"(收到 {len(resp)}/{n} 字节: {resp.hex(' ') or '∅'})。"
                f" 检查: 串口/波特率是否正确、地址是否存在、电机是否上电。")
        if resp[0] != RX_HEADER or resp[1] != (addr & 0xFF) or resp[2] != (code & 0xFF):
            raise MksError(f"addr={addr:#04x} code={code:#04x}: 应答帧头/地址/命令不符: {resp.hex(' ')}")
        if self._checksum(resp[:-1]) != resp[-1]:
            raise MksError(f"addr={addr:#04x} code={code:#04x}: 校验和错误: {resp.hex(' ')}")
        return resp[3:-1]


class MksServo:
    """单台驱动器。持有所属总线 + 自身地址, 暴露我们需要的指令。"""

    def __init__(self, bus: MksBus, addr: int):
        self.bus = bus
        self.addr = addr

    # ------------------------------------------------------------------ 只读
    def read_coord(self) -> int:
        """读累加多圈编码器值(坐标), int48, 16384/圈, 有符号。31H (手册 5.1.2)。"""
        data = self.bus.transfer(self.addr, 0x31, resp_data_len=6)
        return int.from_bytes(data, "big", signed=True)

    def read_speed(self) -> int:
        """读实时转速 RPM (逆时针>0, 顺时针<0)。32H。"""
        data = self.bus.transfer(self.addr, 0x32, resp_data_len=2)
        return int.from_bytes(data, "big", signed=True)

    def read_enabled(self) -> bool:
        """读使能状态 (True=已使能/锁轴)。3AH。"""
        data = self.bus.transfer(self.addr, 0x3A, resp_data_len=1)
        return data[0] == 0x01

    def read_run_status(self) -> int:
        """读电机运行状态 (仅 SR 总线模式)。F1H。见 RUN_* 常量。"""
        data = self.bus.transfer(self.addr, 0xF1, resp_data_len=1)
        return data[0]

    def read_angle_error(self) -> int:
        """读位置角度误差 (39H), int32。51200 = 360°。误差大=电机在顶着负载(绳张力大)。"""
        data = self.bus.transfer(self.addr, 0x39, resp_data_len=4)
        return int.from_bytes(data, "big", signed=True)

    def read_io(self) -> int:
        """
        读 IO 端口状态 (34H), 1 字节位域 (手册 6.1):
          bit0=IN_1(回零/左限位)  bit1=IN_2(右限位, 仅57D)  bit2=OUT_1  bit3=OUT_2
        注: 9E 限位重映射开启后 bit0=En 状态, bit1=Dir 状态。
        """
        data = self.bus.transfer(self.addr, 0x34, resp_data_len=1)
        return data[0]

    def read_stall(self) -> bool:
        """读电机堵转状态 (3EH)。True=已堵转。开了堵转保护时, 堵转后驱动器会自动松轴。"""
        data = self.bus.transfer(self.addr, 0x3E, resp_data_len=1)
        return data[0] == 0x01

    def clear_stall(self) -> bool:
        """解除堵转状态 (3DH)。也可用 enable(False) 松轴来解除。"""
        data = self.bus.transfer(self.addr, 0x3D, resp_data_len=1)
        return data[0] == 0x01

    def read_params_all(self) -> dict:
        """
        47H 一次读全部配置 (手册 5.7.2)。重点看限位/保护是否开启 —— 用于诊断"转一定圈数就停"。
        需固件 ≥ V1.0.6; 不支持时 transfer 会抛 MksError。
        """
        d = self.bus.transfer(self.addr, 0x47, resp_data_len=34)
        return {
            "work_mode": d[0],
            "current": int.from_bytes(d[1:3], "big"),   # 83H 工作电流 mA
            "microstep": d[4],
            "stall_protect": d[8],      # 88H 电流过载(堵转)保护 0关1开
            "limit_trig_level": d[17],  # 90H 限位触发电平
            "limit_dir": d[18],         # 90H 限位方向
            "end_limit": d[21],         # 90H 限位使能  0关1开  ← 关键
            "limit_remap": d[29],       # 9E  限位重映射 0关1开  ← 关键
        }

    # ----------------------------------------------------- 校准 / 回零
    def calibrate(self, timeout: float = 25.0, poll: float = 0.3) -> bool:
        """
        80H 校准编码器 (对应 Windows 上位机的 'Cal' 按钮, 手册 5.2.1)。
        ⚠️ 电机会自转约一圈来学习磁编码器零位 —— 必须空载/可自由旋转! 绳或负载会破坏校准,
           甚至拉坏软体本体。校准前务必松开绳 / 脱开负载。
        阻塞直到完成 (轮询 F1H 是否仍在"校准运行"), 再用 40H 校准位确认。返回 True=成功。
        """
        st = self.bus.transfer(self.addr, 0x80, bytes([0x00]), resp_data_len=1)[0]
        if st == 0x02:
            raise MksError("校准启动失败 (status=2)")
        if st == 0x01:
            return True                          # 立即返回成功(少见)
        time.sleep(0.6)                          # 等校准真正开始
        t0 = time.monotonic()
        while time.monotonic() - t0 < timeout:
            try:
                if self.read_run_status() != RUN_CAL:   # 不再"校准运行" = 结束
                    break
            except MksError:
                pass
            time.sleep(poll)
        else:
            raise MksError("校准超时 (电机可能卡住/带载)")
        try:                                     # 40H: b7-b4 校准状态, 1=已校准
            ver = self.bus.transfer(self.addr, 0x40, resp_data_len=4)
            return (ver[0] >> 4) == 1
        except MksError:
            return True

    def go_zero(self, speed: int = 120, acc: int = 2) -> int:
        """回到零点(坐标 0)。需先 set_zero() 设过零点。等价 move_abs_coord(0)。"""
        return self.move_abs_coord(0, speed=speed, acc=acc)

    # ----------------------------------------------------------------- 配置
    def set_response_mode(self, reply: bool = True, active_complete: bool = False) -> None:
        """
        8CH 设置应答方式 (手册 5.2.12)。
        默认 (reply=True, active_complete=False): 只回"立即应答", 不在运动完成后再主动回一帧
        —— 这样总线干净、适合位置流式实时更新 (F5)。
        如需阻塞等待"运动完成", 改用 read_run_status() 轮询, 或开 active_complete=True 自行读两帧。
        """
        xx = 0x01 if reply else 0x00
        yy = 0x01 if active_complete else 0x00
        self._ok(self.bus.transfer(self.addr, 0x8C, bytes([xx, yy])), "设置应答方式")

    def set_work_mode(self, mode: int = MODE_SR_vFOC) -> None:
        """82H 设置工作模式 (写入 flash, 掉电保持)。串口控制必须为 SR_xxx; 出厂是 CR_vFOC。"""
        self._ok(self.bus.transfer(self.addr, 0x82, bytes([mode])), "设置工作模式")

    def set_current(self, ma: int, save: bool = True) -> int:
        """
        83H 设置工作电流(mA, 手册 5.2.3)。save=True 写 flash 掉电保持; False 仅当前运行有效。
        返回 0=失败 1=成功并保存 2=仅设置未保存。
        ⚠️ FOC 模式下这是电流上限; 不要设到电机额定最大值(波动可能烧驱动板)。
        各型号默认: 57D 3200 / 42D 1600 / 35D 800 / 28D 600 (mA)。
        """
        ma = max(0, int(ma))
        data = bytes([(ma >> 8) & 0xFF, ma & 0xFF])
        if not save:
            data += bytes([0x00])               # 控制字 00 = 仅设置不保存
        d = self.bus.transfer(self.addr, 0x83, data)
        if d[0] == 0x00:
            raise MksError("设置工作电流失败 (status=0)")
        return d[0]

    def enable(self, on: bool = True) -> None:
        """F3H 使能/失能 (仅总线模式有效)。on=True 锁轴, False 松轴。"""
        self._ok(self.bus.transfer(self.addr, 0xF3, bytes([0x01 if on else 0x00])), "使能")

    def set_zero(self) -> None:
        """92H 把当前位置设为零点 (坐标/脉冲零点)。绝对运动前必须先设零点。"""
        self._ok(self.bus.transfer(self.addr, 0x92), "设置零点")

    def set_address(self, new_addr: int) -> None:
        """
        8BH 修改从机地址 (写入 flash)。多机分配地址时, 总线上"单独"接一台再调用,
        成功后该电机以后用 new_addr 寻址。范围 0x00-0xFF (0x00 是广播, 勿用作从机地址)。
        """
        self._ok(self.bus.transfer(self.addr, 0x8B, bytes([new_addr & 0xFF])), "设置地址")

    # ------------------------------------------------------------- 位置/速度运动
    def move_abs_coord(self, coord: int, speed: int = 120, acc: int = 2) -> int:
        """
        F5H 按坐标值绝对运动 (手册 11.4)。coord 为目标坐标(16384/圈, 有符号), 相对零点。
        支持运动中实时更新 speed/coord (再发一条即可)。返回立即应答状态码 (见 _motion)。
        """
        data = self._speed_be(speed) + bytes([acc & 0xFF]) + struct.pack(">i", int(coord))
        return self._motion(self.bus.transfer(self.addr, 0xF5, data), "坐标绝对运动")

    def move_rel_coord(self, delta: int, speed: int = 120, acc: int = 2) -> int:
        """F4H 按坐标值相对运动 (相对当前位置, 手册 11.3)。"""
        data = self._speed_be(speed) + bytes([acc & 0xFF]) + struct.pack(">i", int(delta))
        return self._motion(self.bus.transfer(self.addr, 0xF4, data), "坐标相对运动")

    def run_speed(self, rpm: int, acc: int = 2) -> int:
        """
        F6H 速度模式 (手册 10.1)。rpm 的正负表示方向, 大小 0-3000。
        点动找零位/收放线时用; 摆姿态请用 move_abs_*。
        """
        speed = min(3000, abs(int(rpm)))
        direction = 1 if rpm < 0 else 0           # 手册: byte4 bit7 = 方向
        b4 = (direction << 7) | ((speed >> 8) & 0x0F)
        b5 = speed & 0xFF
        return self._motion(self.bus.transfer(self.addr, 0xF6, bytes([b4, b5, acc & 0xFF])),
                            "速度运行")

    def stop(self, acc: int = 2) -> int | None:
        """
        F6H 停止: acc!=0 减速停, acc=0 立即停 (转速>1000RPM 不建议立即停)。
        返回状态: 0=停止失败 1=停止开始 2=停止完成。
        注意: 电机本来就停着时驱动器回 0(无需停止), 属正常, 故此处不抛异常 —— 只有
        通信层(超时/校验错)才抛 MksError。需要确认是否真停可读 read_speed()/read_run_status()。
        """
        data = self.bus.transfer(self.addr, 0xF6, bytes([0x00, 0x00, acc & 0xFF]))
        return data[0] if data else None

    def emergency_stop(self) -> int | None:
        """
        F7H 紧急停机 (手册 9.2.3)。注意: 转速>1000RPM 不建议使用。
        返回状态: 0=失败 1=成功。电机本就停着时回 0 属正常, 同 stop() 不抛异常。
        """
        data = self.bus.transfer(self.addr, 0xF7)
        return data[0] if data else None

    # --------------------------------------------------------------- 圈数换算便捷
    def move_abs_rev(self, revs: float, speed: int = 120, acc: int = 2) -> int:
        return self.move_abs_coord(round(revs * COUNTS_PER_REV), speed, acc)

    def read_rev(self) -> float:
        return self.read_coord() / COUNTS_PER_REV

    # --------------------------------------------------------------------- 内部
    @staticmethod
    def _speed_be(speed: int) -> bytes:
        """F4/F5/FE 用: 2 字节大端速度 (0-3000), 无方向位 (方向由目标的正负决定)。"""
        s = max(0, min(3000, int(speed)))
        return bytes([(s >> 8) & 0xFF, s & 0xFF])

    @staticmethod
    def _ok(data, what):
        """设置类指令: status 0=失败, 非0=成功。"""
        if data is None:
            return None
        if data[0] == 0x00:
            raise MksError(f"{what} 失败 (status=0)")
        return data[0]

    @staticmethod
    def _motion(data, what):
        """运动类指令立即应答: 0失败 1开始 2完成 3触限位 5同步已接收。"""
        if data is None:
            return None
        if data[0] == 0x00:
            raise MksError(f"{what} 失败 (status=0)")
        return data[0]
