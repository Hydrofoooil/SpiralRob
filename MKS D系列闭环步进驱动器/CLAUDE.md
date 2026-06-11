# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## 仓库性质

这是 Makerbase（MKS）SERVO D 系列闭环步进电机驱动器（SERVO28D / 35D / 42D / 57D）的官方资料包，服务于软体仿生机器人课程中对该驱动器的使用与二次开发。它**不是可构建的软件工程**：没有构建、测试、lint 命令，也不是 git 仓库。内容为协议手册（PDF）、示例代码（zip 压缩包）、Windows 上位机与调试工具（EXE）、固件升级文件（bin）、原理图（PDF）和外壳三维模型（STL/RAR）。

## 驱动器控制方式

驱动器支持一种硬件接口和三种总线协议，分别对应 `04_说明书/` 下三份 v1.0.9 手册（协议帧格式、CRC、完整命令表均以这三份 PDF 为准）：

1. **脉冲接口**（STEP/DIR/EN）：工作模式须设为 CR_vFOC 或 CR_CLOSE；默认 16 细分下 3200 脉冲/圈
2. **串口/RS485 自定义协议**：《RS485使用说明 v1.0.9.pdf》
3. **Modbus RTU**：《MODBUS_RTU使用说明 v1.0.9.pdf》
4. **CAN**：《CAN使用说明 v1.0.9.pdf》

## 目录导览

- `00`–`03_MKS SERVOxxD资料/`：各型号原理图（485 与 CAN 两种硬件版本）和外壳 STL
- `04_说明书/`：当前 v1.0.9 手册三份 + 57D 安装说明；旧版在 `历史版本/`
- `05_上位机软件/`：Windows 上位机 MKS_ServoD_Control V1.0.9.1（RS485 与 CAN 各一个 EXE）。`历史版本/MKS_ServoD_Control V1.0.6.2/` 内含**完整 C# WinForms 源码**（.NET Framework 4.0，逻辑集中在 `Form1.cs`）——研究上位机如何实现串口协议时看这里
- `06_例程-arduino系列/`：Arduino UNO 例程 1–14（1 = 脉冲控制，2–14 = 串口协议读写）
- `07_例程-STM32系列(脉冲_串口)/`：STM32 例程 1–14，编号与 Arduino 例程一一对应、功能相同
- `08_例程-STM32系列(CAN)/`：STM32 CAN 例程 15–27
- `09_例程_Modbus Poll/`：Modbus Poll 工作区文件（.mbp）
- `10_通用工具软件/`：Windows 调试工具（串口助手、Modbus Poll、cangaroo CAN 分析、USB 转 485 驱动）
- `11_B站视频.txt`：Bilibili 视频教程链接（GBK 编码）
- `12_升级文件/`：固件 IAP 升级 bin（V1.0.9，含 S28D/S57D）及两种升级方式的说明与视频
- `13_三维模型/`：42D/57D 三维模型（RAR）

## 文件命名即文档

- `09_例程_Modbus Poll/` 的 .mbp 是二进制工作区文件，内容不可读，但文件名编码了全部信息：`F4`/`F6`/`F16` 是 Modbus 功能码（0x04 读输入寄存器 / 0x06 写单寄存器 / 0x10 写多寄存器），括号内十六进制是驱动器命令地址。例如 `30_F16(FD) 电机运行_位置模式1_按脉冲数相对运动.mbp` = 用功能码 0x10 写命令 0xFD。
- 例程 zip 内除代码外通常还有对应的接线图 PDF。

## 操作注意

- 示例代码几乎都在 .zip 内，先解压或用 `unzip -p <zip> <member>` 直读单个文件；zip 成员名为中文 UTF-8。
- 部分文本文件是 GBK 编码（如 `11_B站视频.txt`），用 `iconv -f GBK -t UTF-8 <file>` 读取。
- STM32 例程为 Keil MDK 工程（STM32F103C8 + 标准外设库 StdPeriph）；驱动器相关代码集中在各工程的 `Hardware/` 目录（如 `mksServoxxD.c`、`Serial.c`、`mksPulse.c`），`Library/` 是 ST 官方库可忽略。本机（Linux）无 Keil，不能编译，仅作协议参考。
- Arduino 脉冲例程引脚约定：EN=D4、STP=D3、DIR=D2。
- Windows EXE 工具在本 Linux 环境不可直接运行；.rar 需 unrar/7z 解压。
