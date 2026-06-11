
namespace MKS_ServoD_Control
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.codeTip = new System.Windows.Forms.ToolTip(this.components);
            this.GB3_label_工作模式 = new System.Windows.Forms.Label();
            this.GB2_button_版本信息 = new System.Windows.Forms.Button();
            this.GB2_button_堵转标志位 = new System.Windows.Forms.Button();
            this.GB2_button_解除堵转 = new System.Windows.Forms.Button();
            this.GB2_button_回零状态 = new System.Windows.Forms.Button();
            this.GB2_button_使能状态 = new System.Windows.Forms.Button();
            this.GB2_button_位置角度误差 = new System.Windows.Forms.Button();
            this.GB2_button_累计脉冲数 = new System.Windows.Forms.Button();
            this.GB2_button_电机当前转速 = new System.Windows.Forms.Button();
            this.GB2_button_读编码值 = new System.Windows.Forms.Button();
            this.GB2_button_进位编码值 = new System.Windows.Forms.Button();
            this.GB3_button_细分设置 = new System.Windows.Forms.Button();
            this.GB3_label_细分设置 = new System.Windows.Forms.Label();
            this.GB4_button_使能驱动板 = new System.Windows.Forms.Button();
            this.GB4_button_关闭驱动板 = new System.Windows.Forms.Button();
            this.GB4_3_button_关闭上电自动运行 = new System.Windows.Forms.Button();
            this.GB4_3_button_开启上电自动运行 = new System.Windows.Forms.Button();
            this.GB4_3_button_停止 = new System.Windows.Forms.Button();
            this.GB4_3_button_开始 = new System.Windows.Forms.Button();
            this.GB4_4_button_停止 = new System.Windows.Forms.Button();
            this.GB4_4_button_开始 = new System.Windows.Forms.Button();
            this.GB3_label_按键锁定 = new System.Windows.Forms.Label();
            this.GB3_button_按键锁定 = new System.Windows.Forms.Button();
            this.GB3_label_保持电流 = new System.Windows.Forms.Label();
            this.GB3_button_保持电流 = new System.Windows.Forms.Button();
            this.GB3_label_从机分组 = new System.Windows.Forms.Label();
            this.GB3_button_从机分组 = new System.Windows.Forms.Button();
            this.GB3_label_从机应答 = new System.Windows.Forms.Label();
            this.GB3_button_从机应答 = new System.Windows.Forms.Button();
            this.GB3_label_通讯地址 = new System.Windows.Forms.Label();
            this.GB3_button_通讯地址 = new System.Windows.Forms.Button();
            this.GB3_label_串口波特率 = new System.Windows.Forms.Label();
            this.GB3_button_串口波特率 = new System.Windows.Forms.Button();
            this.GB3_label_细分插补 = new System.Windows.Forms.Label();
            this.GB3_button_细分插补 = new System.Windows.Forms.Button();
            this.GB3_label_堵转保护 = new System.Windows.Forms.Label();
            this.GB3_button_堵转保护 = new System.Windows.Forms.Button();
            this.GB3_label_自动熄屏 = new System.Windows.Forms.Label();
            this.GB3_button_自动熄屏 = new System.Windows.Forms.Button();
            this.GB3_label_电机方向 = new System.Windows.Forms.Label();
            this.GB3_button_电机方向 = new System.Windows.Forms.Button();
            this.GB3_label_使能设置 = new System.Windows.Forms.Label();
            this.GB3_button_使能设置 = new System.Windows.Forms.Button();
            this.GB3_label_电流值 = new System.Windows.Forms.Label();
            this.GB3_button_电流值 = new System.Windows.Forms.Button();
            this.GB3_button_工作模式 = new System.Windows.Forms.Button();
            this.GB3_button_校准编码器 = new System.Windows.Forms.Button();
            this.GB5_label_单圈回零 = new System.Windows.Forms.Label();
            this.GB5_button_单圈回零 = new System.Windows.Forms.Button();
            this.GB5_label_限位回零 = new System.Windows.Forms.Label();
            this.GB5_button_限位参数 = new System.Windows.Forms.Button();
            this.GB5_button_读取IO端口 = new System.Windows.Forms.Button();
            this.GB5_button_限位归零 = new System.Windows.Forms.Button();
            this.GB5_button_直接归零 = new System.Windows.Forms.Button();
            this.F1_button_恢复出厂配置 = new System.Windows.Forms.Button();
            this.GB5_button_无限位回零 = new System.Windows.Forms.Button();
            this.GB5_button_限位重映射 = new System.Windows.Forms.Button();
            this.GB5_label_无限位回零 = new System.Windows.Forms.Label();
            this.GB5_label_限位重映射 = new System.Windows.Forms.Label();
            this.GB4_button_紧急停止 = new System.Windows.Forms.Button();
            this.F1_button_复位重启电机 = new System.Windows.Forms.Button();
            this.GB2_button_读取所有参数 = new System.Windows.Forms.Button();
            this.GB5_button_EN回零与位置保护 = new System.Windows.Forms.Button();
            this.GB5_button_写IO端口 = new System.Windows.Forms.Button();
            this.GB5_label_EN回零与位置保护 = new System.Windows.Forms.Label();
            this.GB5_label_EN回零 = new System.Windows.Forms.Label();
            this.GB5_label_位置保护 = new System.Windows.Forms.Label();
            this.GB5_label_触发时间 = new System.Windows.Forms.Label();
            this.GB5_label_触发距离 = new System.Windows.Forms.Label();
            this.GB5_label_OUT2写入 = new System.Windows.Forms.Label();
            this.GB5_label_OUT1写入 = new System.Windows.Forms.Label();
            this.GB5_label_无限位返回距离 = new System.Windows.Forms.Label();
            this.GB5_label_无限位回零模式 = new System.Windows.Forms.Label();
            this.GB5_label_无限位回零电流 = new System.Windows.Forms.Label();
            this.GB5_comboBox_无限位返回距离 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_无限位回零模式 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_无限位回零电流 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_限位重映射 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_EN回零 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_位置保护 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_触发时间 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_触发距离 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_OUT2写入 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_OUT1写入 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_OUT2写入值 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_OUT1写入值 = new System.Windows.Forms.ComboBox();
            this.F1_groupBox1_连接设置 = new System.Windows.Forms.GroupBox();
            this.GB1_button_断开连接 = new System.Windows.Forms.Button();
            this.GB1_button_连接主板 = new System.Windows.Forms.Button();
            this.GB1_button_扫描 = new System.Windows.Forms.Button();
            this.GB1_comboBox_通讯地址 = new System.Windows.Forms.ComboBox();
            this.GB1_comboBox_波特率 = new System.Windows.Forms.ComboBox();
            this.GB1_comboBox_串口 = new System.Windows.Forms.ComboBox();
            this.GB1_label_通讯地址 = new System.Windows.Forms.Label();
            this.GB1_label_波特率 = new System.Windows.Forms.Label();
            this.GB1_label_串口 = new System.Windows.Forms.Label();
            this.GB2_comboBox_读编码值 = new System.Windows.Forms.ComboBox();
            this.F1_groupBox2_读取参数 = new System.Windows.Forms.GroupBox();
            this.GB2_textBox_堵转状态 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_回零状态 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_使能状态 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_误差值 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_脉冲数值 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_当前转速 = new System.Windows.Forms.TextBox();
            this.GB2_textBox_编码器值 = new System.Windows.Forms.TextBox();
            this.GB2_panel_十六or十进制 = new System.Windows.Forms.Panel();
            this.GB2_radioButton_十进制 = new System.Windows.Forms.RadioButton();
            this.GB2_radioButton_十六进制 = new System.Windows.Forms.RadioButton();
            this.GB2_checkbox_跟踪模式 = new System.Windows.Forms.CheckBox();
            this.F1_groupBox3_设置系统参数 = new System.Windows.Forms.GroupBox();
            this.GB3_comboBox_按键锁定 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_保持电流 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_从机分组 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_从机应答 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_通讯地址 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_串口波特率 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_细分插补 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_堵转保护 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_自动熄屏 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_电机方向 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_使能设置 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_细分设置 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_电流值 = new System.Windows.Forms.ComboBox();
            this.GB3_comboBox_工作模式 = new System.Windows.Forms.ComboBox();
            this.F1_groupBox4_电机控制 = new System.Windows.Forms.GroupBox();
            this.GB4_groupBox1_加速度参数 = new System.Windows.Forms.GroupBox();
            this.GB4_1_button_启动加速度 = new System.Windows.Forms.Button();
            this.GB4_1_comboBox_启动加速度 = new System.Windows.Forms.ComboBox();
            this.GB4_1_button_停止加速度 = new System.Windows.Forms.Button();
            this.GB4_1_comboBox_停止加速度 = new System.Windows.Forms.ComboBox();
            this.GB4_1_label_启动加速度 = new System.Windows.Forms.Label();
            this.GB4_1_label_停止加速度 = new System.Windows.Forms.Label();
            this.GB4_groupBox2_电机状态监控 = new System.Windows.Forms.GroupBox();
            this.GB4_2_label_目标方向 = new System.Windows.Forms.Label();
            this.GB4_2_label_目标速度 = new System.Windows.Forms.Label();
            this.GB4_2_label_目标加速度 = new System.Windows.Forms.Label();
            this.GB4_2_label_电机状态 = new System.Windows.Forms.Label();
            this.GB4_2_textBox_目标方向 = new System.Windows.Forms.TextBox();
            this.GB4_2_textBox_目标速度 = new System.Windows.Forms.TextBox();
            this.GB4_2_textBox_目标加速度 = new System.Windows.Forms.TextBox();
            this.GB4_2_textBox_电机状态 = new System.Windows.Forms.TextBox();
            this.GB4_groupBox3_电机速度控制模式 = new System.Windows.Forms.GroupBox();
            this.GB4_3_panel_正转or反转 = new System.Windows.Forms.Panel();
            this.GB4_3_radioButton_反转 = new System.Windows.Forms.RadioButton();
            this.GB4_3_radioButton_正转 = new System.Windows.Forms.RadioButton();
            this.GB4_3_comboBox_速度档位 = new System.Windows.Forms.ComboBox();
            this.GB4_3_label_提示 = new System.Windows.Forms.Label();
            this.GB4_3_label_速度档位 = new System.Windows.Forms.Label();
            this.GB4_groupBox4_电机位置控制模式 = new System.Windows.Forms.GroupBox();
            this.GB4_4_panel_正转or反转 = new System.Windows.Forms.Panel();
            this.GB4_4_radioButton_反转 = new System.Windows.Forms.RadioButton();
            this.GB4_4_radioButton_正转 = new System.Windows.Forms.RadioButton();
            this.GB4_4_label_提示 = new System.Windows.Forms.Label();
            this.GB4_4_textBox_脉冲数 = new System.Windows.Forms.TextBox();
            this.GB4_4_comboBox_速度档位 = new System.Windows.Forms.ComboBox();
            this.GB4_4_comboBox_模式切换 = new System.Windows.Forms.ComboBox();
            this.GB4_4_label_脉冲数 = new System.Windows.Forms.Label();
            this.GB4_4_label_速度档位 = new System.Windows.Forms.Label();
            this.GB4_1_label_注意 = new System.Windows.Forms.Label();
            this.buttonColdDown = new System.Windows.Forms.Timer(this.components);
            this.trackingMode = new System.Windows.Forms.Timer(this.components);
            this.F1_textBox_图片背景 = new System.Windows.Forms.TextBox();
            this.F1_pictureBox_图片2 = new System.Windows.Forms.PictureBox();
            this.F1_pictureBox_图片1 = new System.Windows.Forms.PictureBox();
            this.F1_pictureBox_图片3 = new System.Windows.Forms.PictureBox();
            this.F1_menuStrip_语言切换菜单 = new System.Windows.Forms.MenuStrip();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.F1_groupBox5_设置限位参数 = new System.Windows.Forms.GroupBox();
            this.GB5_label_回零模式 = new System.Windows.Forms.Label();
            this.GB5_label_设置零点 = new System.Windows.Forms.Label();
            this.GB5_label_回零速度 = new System.Windows.Forms.Label();
            this.GB5_label_回零方向 = new System.Windows.Forms.Label();
            this.GB5_comboBox_回零模式 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_设置零点 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_回零速度 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_回零方向 = new System.Windows.Forms.ComboBox();
            this.GB5_label_IN1 = new System.Windows.Forms.Label();
            this.GB5_label_IN2 = new System.Windows.Forms.Label();
            this.GB5_label_OUT1 = new System.Windows.Forms.Label();
            this.GB5_label_OUT2 = new System.Windows.Forms.Label();
            this.GB5_textBox_IN1 = new System.Windows.Forms.TextBox();
            this.GB5_textBox_IN2 = new System.Windows.Forms.TextBox();
            this.GB5_textBox_OUT1 = new System.Windows.Forms.TextBox();
            this.GB5_textBox_OUT2 = new System.Windows.Forms.TextBox();
            this.GB5_label_触发电平 = new System.Windows.Forms.Label();
            this.GB5_label_归零方向 = new System.Windows.Forms.Label();
            this.GB5_label_归零速度 = new System.Windows.Forms.Label();
            this.GB5_label_归零使能 = new System.Windows.Forms.Label();
            this.GB5_comboBox_触发电平 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_归零速度 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_归零方向 = new System.Windows.Forms.ComboBox();
            this.GB5_comboBox_归零使能 = new System.Windows.Forms.ComboBox();
            this.F1_groupBox6_数据日志 = new System.Windows.Forms.GroupBox();
            this.GB6_textBox_数据日志 = new System.Windows.Forms.TextBox();
            this.F1_label_注意 = new System.Windows.Forms.Label();
            this.F1_label_提示 = new System.Windows.Forms.Label();
            this.tipTip = new System.Windows.Forms.ToolTip(this.components);
            this.rangeTip = new System.Windows.Forms.ToolTip(this.components);
            this.F1_groupBox1_连接设置.SuspendLayout();
            this.F1_groupBox2_读取参数.SuspendLayout();
            this.GB2_panel_十六or十进制.SuspendLayout();
            this.F1_groupBox3_设置系统参数.SuspendLayout();
            this.F1_groupBox4_电机控制.SuspendLayout();
            this.GB4_groupBox1_加速度参数.SuspendLayout();
            this.GB4_groupBox2_电机状态监控.SuspendLayout();
            this.GB4_groupBox3_电机速度控制模式.SuspendLayout();
            this.GB4_3_panel_正转or反转.SuspendLayout();
            this.GB4_groupBox4_电机位置控制模式.SuspendLayout();
            this.GB4_4_panel_正转or反转.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片3)).BeginInit();
            this.F1_menuStrip_语言切换菜单.SuspendLayout();
            this.F1_groupBox5_设置限位参数.SuspendLayout();
            this.F1_groupBox6_数据日志.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeTip
            // 
            this.codeTip.AutoPopDelay = 5000;
            this.codeTip.InitialDelay = 0;
            this.codeTip.ReshowDelay = 0;
            this.codeTip.ToolTipTitle = "Code:";
            // 
            // GB3_label_工作模式
            // 
            this.GB3_label_工作模式.AutoSize = true;
            this.GB3_label_工作模式.Location = new System.Drawing.Point(20, 75);
            this.GB3_label_工作模式.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_工作模式.Name = "GB3_label_工作模式";
            this.GB3_label_工作模式.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_工作模式.TabIndex = 39;
            this.GB3_label_工作模式.Text = "工作模式";
            this.codeTip.SetToolTip(this.GB3_label_工作模式, "0x82");
            // 
            // GB2_button_版本信息
            // 
            this.GB2_button_版本信息.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_版本信息.Location = new System.Drawing.Point(13, 718);
            this.GB2_button_版本信息.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_版本信息.Name = "GB2_button_版本信息";
            this.GB2_button_版本信息.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_版本信息.TabIndex = 0;
            this.GB2_button_版本信息.Tag = "43";
            this.GB2_button_版本信息.Text = "读取版本信息";
            this.codeTip.SetToolTip(this.GB2_button_版本信息, "0x40");
            this.GB2_button_版本信息.UseVisualStyleBackColor = true;
            this.GB2_button_版本信息.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_堵转标志位
            // 
            this.GB2_button_堵转标志位.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_堵转标志位.Location = new System.Drawing.Point(13, 599);
            this.GB2_button_堵转标志位.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_堵转标志位.Name = "GB2_button_堵转标志位";
            this.GB2_button_堵转标志位.Size = new System.Drawing.Size(153, 29);
            this.GB2_button_堵转标志位.TabIndex = 1;
            this.GB2_button_堵转标志位.Tag = "5";
            this.GB2_button_堵转标志位.Text = "堵转标志位";
            this.codeTip.SetToolTip(this.GB2_button_堵转标志位, "0x3E");
            this.GB2_button_堵转标志位.UseVisualStyleBackColor = true;
            this.GB2_button_堵转标志位.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_解除堵转
            // 
            this.GB2_button_解除堵转.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_解除堵转.Location = new System.Drawing.Point(174, 599);
            this.GB2_button_解除堵转.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_解除堵转.Name = "GB2_button_解除堵转";
            this.GB2_button_解除堵转.Size = new System.Drawing.Size(108, 29);
            this.GB2_button_解除堵转.TabIndex = 2;
            this.GB2_button_解除堵转.Tag = "37";
            this.GB2_button_解除堵转.Text = "解除堵转";
            this.codeTip.SetToolTip(this.GB2_button_解除堵转, "0x3D");
            this.GB2_button_解除堵转.UseVisualStyleBackColor = true;
            this.GB2_button_解除堵转.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_回零状态
            // 
            this.GB2_button_回零状态.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_回零状态.Location = new System.Drawing.Point(13, 512);
            this.GB2_button_回零状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_回零状态.Name = "GB2_button_回零状态";
            this.GB2_button_回零状态.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_回零状态.TabIndex = 4;
            this.GB2_button_回零状态.Tag = "4";
            this.GB2_button_回零状态.Text = "上电自动回零状态";
            this.codeTip.SetToolTip(this.GB2_button_回零状态, "0x3B");
            this.GB2_button_回零状态.UseVisualStyleBackColor = true;
            this.GB2_button_回零状态.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_使能状态
            // 
            this.GB2_button_使能状态.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_使能状态.Location = new System.Drawing.Point(13, 425);
            this.GB2_button_使能状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_使能状态.Name = "GB2_button_使能状态";
            this.GB2_button_使能状态.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_使能状态.TabIndex = 6;
            this.GB2_button_使能状态.Tag = "3";
            this.GB2_button_使能状态.Text = "驱动板使能状态";
            this.codeTip.SetToolTip(this.GB2_button_使能状态, "0x3A");
            this.GB2_button_使能状态.UseVisualStyleBackColor = true;
            this.GB2_button_使能状态.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_位置角度误差
            // 
            this.GB2_button_位置角度误差.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_位置角度误差.Location = new System.Drawing.Point(13, 338);
            this.GB2_button_位置角度误差.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_位置角度误差.Name = "GB2_button_位置角度误差";
            this.GB2_button_位置角度误差.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_位置角度误差.TabIndex = 8;
            this.GB2_button_位置角度误差.Tag = "2";
            this.GB2_button_位置角度误差.Text = "位置角度误差";
            this.codeTip.SetToolTip(this.GB2_button_位置角度误差, "0x39");
            this.GB2_button_位置角度误差.UseVisualStyleBackColor = true;
            this.GB2_button_位置角度误差.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_累计脉冲数
            // 
            this.GB2_button_累计脉冲数.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_累计脉冲数.Location = new System.Drawing.Point(13, 251);
            this.GB2_button_累计脉冲数.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_累计脉冲数.Name = "GB2_button_累计脉冲数";
            this.GB2_button_累计脉冲数.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_累计脉冲数.TabIndex = 10;
            this.GB2_button_累计脉冲数.Tag = "1";
            this.GB2_button_累计脉冲数.Text = "输入累计脉冲数";
            this.codeTip.SetToolTip(this.GB2_button_累计脉冲数, "0x33");
            this.GB2_button_累计脉冲数.UseVisualStyleBackColor = true;
            this.GB2_button_累计脉冲数.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_电机当前转速
            // 
            this.GB2_button_电机当前转速.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_电机当前转速.Location = new System.Drawing.Point(13, 164);
            this.GB2_button_电机当前转速.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_电机当前转速.Name = "GB2_button_电机当前转速";
            this.GB2_button_电机当前转速.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_电机当前转速.TabIndex = 12;
            this.GB2_button_电机当前转速.Tag = "40";
            this.GB2_button_电机当前转速.Text = "电机当前转速";
            this.codeTip.SetToolTip(this.GB2_button_电机当前转速, "0x32");
            this.GB2_button_电机当前转速.UseVisualStyleBackColor = true;
            this.GB2_button_电机当前转速.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_读编码值
            // 
            this.GB2_button_读编码值.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_读编码值.Location = new System.Drawing.Point(135, 77);
            this.GB2_button_读编码值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_读编码值.Name = "GB2_button_读编码值";
            this.GB2_button_读编码值.Size = new System.Drawing.Size(146, 29);
            this.GB2_button_读编码值.TabIndex = 14;
            this.GB2_button_读编码值.Tag = "39";
            this.GB2_button_读编码值.Text = "读编码值";
            this.codeTip.SetToolTip(this.GB2_button_读编码值, "0x31");
            this.GB2_button_读编码值.UseVisualStyleBackColor = true;
            this.GB2_button_读编码值.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_进位编码值
            // 
            this.GB2_button_进位编码值.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_进位编码值.Location = new System.Drawing.Point(13, 77);
            this.GB2_button_进位编码值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_进位编码值.Name = "GB2_button_进位编码值";
            this.GB2_button_进位编码值.Size = new System.Drawing.Size(128, 29);
            this.GB2_button_进位编码值.TabIndex = 15;
            this.GB2_button_进位编码值.Tag = "0";
            this.GB2_button_进位编码值.Text = "进位编码器值";
            this.codeTip.SetToolTip(this.GB2_button_进位编码值, "0x30");
            this.GB2_button_进位编码值.UseVisualStyleBackColor = true;
            this.GB2_button_进位编码值.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_button_细分设置
            // 
            this.GB3_button_细分设置.Location = new System.Drawing.Point(323, 219);
            this.GB3_button_细分设置.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_细分设置.Name = "GB3_button_细分设置";
            this.GB3_button_细分设置.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_细分设置.TabIndex = 35;
            this.GB3_button_细分设置.Tag = "12";
            this.GB3_button_细分设置.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_细分设置, "0x84");
            this.GB3_button_细分设置.UseVisualStyleBackColor = true;
            this.GB3_button_细分设置.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_细分设置
            // 
            this.GB3_label_细分设置.AutoSize = true;
            this.GB3_label_细分设置.Location = new System.Drawing.Point(20, 224);
            this.GB3_label_细分设置.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_细分设置.Name = "GB3_label_细分设置";
            this.GB3_label_细分设置.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_细分设置.TabIndex = 33;
            this.GB3_label_细分设置.Text = "细分设置";
            this.codeTip.SetToolTip(this.GB3_label_细分设置, "0x84");
            // 
            // GB4_button_使能驱动板
            // 
            this.GB4_button_使能驱动板.Location = new System.Drawing.Point(16, 44);
            this.GB4_button_使能驱动板.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_button_使能驱动板.Name = "GB4_button_使能驱动板";
            this.GB4_button_使能驱动板.Size = new System.Drawing.Size(175, 30);
            this.GB4_button_使能驱动板.TabIndex = 0;
            this.GB4_button_使能驱动板.Tag = "6";
            this.GB4_button_使能驱动板.Text = "使能驱动板";
            this.codeTip.SetToolTip(this.GB4_button_使能驱动板, "0xF3");
            this.GB4_button_使能驱动板.UseVisualStyleBackColor = true;
            this.GB4_button_使能驱动板.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_button_关闭驱动板
            // 
            this.GB4_button_关闭驱动板.Location = new System.Drawing.Point(211, 44);
            this.GB4_button_关闭驱动板.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_button_关闭驱动板.Name = "GB4_button_关闭驱动板";
            this.GB4_button_关闭驱动板.Size = new System.Drawing.Size(175, 30);
            this.GB4_button_关闭驱动板.TabIndex = 1;
            this.GB4_button_关闭驱动板.Tag = "7";
            this.GB4_button_关闭驱动板.Text = "关闭驱动板";
            this.codeTip.SetToolTip(this.GB4_button_关闭驱动板, "0xF3");
            this.GB4_button_关闭驱动板.UseVisualStyleBackColor = true;
            this.GB4_button_关闭驱动板.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_3_button_关闭上电自动运行
            // 
            this.GB4_3_button_关闭上电自动运行.Location = new System.Drawing.Point(20, 240);
            this.GB4_3_button_关闭上电自动运行.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_button_关闭上电自动运行.Name = "GB4_3_button_关闭上电自动运行";
            this.GB4_3_button_关闭上电自动运行.Size = new System.Drawing.Size(333, 35);
            this.GB4_3_button_关闭上电自动运行.TabIndex = 1;
            this.GB4_3_button_关闭上电自动运行.Tag = "11";
            this.GB4_3_button_关闭上电自动运行.Text = "关闭上电自动运行";
            this.codeTip.SetToolTip(this.GB4_3_button_关闭上电自动运行, "0xFF");
            this.GB4_3_button_关闭上电自动运行.UseVisualStyleBackColor = true;
            this.GB4_3_button_关闭上电自动运行.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_3_button_开启上电自动运行
            // 
            this.GB4_3_button_开启上电自动运行.Location = new System.Drawing.Point(20, 197);
            this.GB4_3_button_开启上电自动运行.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_button_开启上电自动运行.Name = "GB4_3_button_开启上电自动运行";
            this.GB4_3_button_开启上电自动运行.Size = new System.Drawing.Size(333, 35);
            this.GB4_3_button_开启上电自动运行.TabIndex = 2;
            this.GB4_3_button_开启上电自动运行.Tag = "10";
            this.GB4_3_button_开启上电自动运行.Text = "开启上电自动运行";
            this.codeTip.SetToolTip(this.GB4_3_button_开启上电自动运行, "0xFF");
            this.GB4_3_button_开启上电自动运行.UseVisualStyleBackColor = true;
            this.GB4_3_button_开启上电自动运行.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_3_button_停止
            // 
            this.GB4_3_button_停止.Location = new System.Drawing.Point(203, 149);
            this.GB4_3_button_停止.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_button_停止.Name = "GB4_3_button_停止";
            this.GB4_3_button_停止.Size = new System.Drawing.Size(150, 31);
            this.GB4_3_button_停止.TabIndex = 3;
            this.GB4_3_button_停止.Tag = "9";
            this.GB4_3_button_停止.Text = "停止";
            this.codeTip.SetToolTip(this.GB4_3_button_停止, "0xF6");
            this.GB4_3_button_停止.UseVisualStyleBackColor = true;
            this.GB4_3_button_停止.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_3_button_开始
            // 
            this.GB4_3_button_开始.Location = new System.Drawing.Point(20, 149);
            this.GB4_3_button_开始.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_button_开始.Name = "GB4_3_button_开始";
            this.GB4_3_button_开始.Size = new System.Drawing.Size(150, 31);
            this.GB4_3_button_开始.TabIndex = 4;
            this.GB4_3_button_开始.Tag = "8";
            this.GB4_3_button_开始.Text = "开始";
            this.codeTip.SetToolTip(this.GB4_3_button_开始, "0xF6");
            this.GB4_3_button_开始.UseVisualStyleBackColor = true;
            this.GB4_3_button_开始.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_4_button_停止
            // 
            this.GB4_4_button_停止.Location = new System.Drawing.Point(201, 240);
            this.GB4_4_button_停止.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_button_停止.Name = "GB4_4_button_停止";
            this.GB4_4_button_停止.Size = new System.Drawing.Size(150, 31);
            this.GB4_4_button_停止.TabIndex = 1;
            this.GB4_4_button_停止.Tag = "38";
            this.GB4_4_button_停止.Text = "停止";
            this.codeTip.SetToolTip(this.GB4_4_button_停止, "相对脉冲：0xFD\r\n绝对脉冲：0xFE\r\n相对坐标：0xF4\r\n绝对坐标：0xF5");
            this.GB4_4_button_停止.UseVisualStyleBackColor = true;
            this.GB4_4_button_停止.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_4_button_开始
            // 
            this.GB4_4_button_开始.Location = new System.Drawing.Point(19, 240);
            this.GB4_4_button_开始.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_button_开始.Name = "GB4_4_button_开始";
            this.GB4_4_button_开始.Size = new System.Drawing.Size(150, 31);
            this.GB4_4_button_开始.TabIndex = 2;
            this.GB4_4_button_开始.Tag = "13";
            this.GB4_4_button_开始.Text = "开始";
            this.codeTip.SetToolTip(this.GB4_4_button_开始, "相对脉冲：0xFD\r\n绝对脉冲：0xFE\r\n相对坐标：0xF4\r\n绝对坐标：0xF5");
            this.GB4_4_button_开始.UseVisualStyleBackColor = true;
            this.GB4_4_button_开始.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_按键锁定
            // 
            this.GB3_label_按键锁定.AutoSize = true;
            this.GB3_label_按键锁定.Location = new System.Drawing.Point(20, 724);
            this.GB3_label_按键锁定.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_按键锁定.Name = "GB3_label_按键锁定";
            this.GB3_label_按键锁定.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_按键锁定.TabIndex = 0;
            this.GB3_label_按键锁定.Text = "按键锁定";
            this.codeTip.SetToolTip(this.GB3_label_按键锁定, "0x8F");
            // 
            // GB3_button_按键锁定
            // 
            this.GB3_button_按键锁定.Location = new System.Drawing.Point(323, 719);
            this.GB3_button_按键锁定.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_按键锁定.Name = "GB3_button_按键锁定";
            this.GB3_button_按键锁定.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_按键锁定.TabIndex = 2;
            this.GB3_button_按键锁定.Tag = "48";
            this.GB3_button_按键锁定.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_按键锁定, "0x8F");
            this.GB3_button_按键锁定.UseVisualStyleBackColor = true;
            this.GB3_button_按键锁定.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_保持电流
            // 
            this.GB3_label_保持电流.AutoSize = true;
            this.GB3_label_保持电流.Location = new System.Drawing.Point(20, 174);
            this.GB3_label_保持电流.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_保持电流.Name = "GB3_label_保持电流";
            this.GB3_label_保持电流.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_保持电流.TabIndex = 3;
            this.GB3_label_保持电流.Text = "保持电流";
            this.codeTip.SetToolTip(this.GB3_label_保持电流, "0x9B");
            // 
            // GB3_button_保持电流
            // 
            this.GB3_button_保持电流.Location = new System.Drawing.Point(323, 169);
            this.GB3_button_保持电流.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_保持电流.Name = "GB3_button_保持电流";
            this.GB3_button_保持电流.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_保持电流.TabIndex = 5;
            this.GB3_button_保持电流.Tag = "47";
            this.GB3_button_保持电流.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_保持电流, "0x9B");
            this.GB3_button_保持电流.UseVisualStyleBackColor = true;
            this.GB3_button_保持电流.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_从机分组
            // 
            this.GB3_label_从机分组.AutoSize = true;
            this.GB3_label_从机分组.Location = new System.Drawing.Point(20, 624);
            this.GB3_label_从机分组.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_从机分组.Name = "GB3_label_从机分组";
            this.GB3_label_从机分组.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_从机分组.TabIndex = 6;
            this.GB3_label_从机分组.Text = "从机分组";
            this.codeTip.SetToolTip(this.GB3_label_从机分组, "0x8D");
            // 
            // GB3_button_从机分组
            // 
            this.GB3_button_从机分组.Location = new System.Drawing.Point(323, 619);
            this.GB3_button_从机分组.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_从机分组.Name = "GB3_button_从机分组";
            this.GB3_button_从机分组.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_从机分组.TabIndex = 8;
            this.GB3_button_从机分组.Tag = "42";
            this.GB3_button_从机分组.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_从机分组, "0x8D");
            this.GB3_button_从机分组.UseVisualStyleBackColor = true;
            this.GB3_button_从机分组.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_从机应答
            // 
            this.GB3_label_从机应答.AutoSize = true;
            this.GB3_label_从机应答.Location = new System.Drawing.Point(20, 674);
            this.GB3_label_从机应答.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_从机应答.Name = "GB3_label_从机应答";
            this.GB3_label_从机应答.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_从机应答.TabIndex = 9;
            this.GB3_label_从机应答.Text = "从机应答";
            this.codeTip.SetToolTip(this.GB3_label_从机应答, "0x8C");
            // 
            // GB3_button_从机应答
            // 
            this.GB3_button_从机应答.Location = new System.Drawing.Point(323, 669);
            this.GB3_button_从机应答.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_从机应答.Name = "GB3_button_从机应答";
            this.GB3_button_从机应答.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_从机应答.TabIndex = 11;
            this.GB3_button_从机应答.Tag = "41";
            this.GB3_button_从机应答.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_从机应答, "0x8C");
            this.GB3_button_从机应答.UseVisualStyleBackColor = true;
            this.GB3_button_从机应答.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_通讯地址
            // 
            this.GB3_label_通讯地址.AutoSize = true;
            this.GB3_label_通讯地址.Location = new System.Drawing.Point(20, 574);
            this.GB3_label_通讯地址.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_通讯地址.Name = "GB3_label_通讯地址";
            this.GB3_label_通讯地址.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_通讯地址.TabIndex = 12;
            this.GB3_label_通讯地址.Text = "通讯地址";
            this.codeTip.SetToolTip(this.GB3_label_通讯地址, "0x8B");
            // 
            // GB3_button_通讯地址
            // 
            this.GB3_button_通讯地址.Location = new System.Drawing.Point(323, 569);
            this.GB3_button_通讯地址.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_通讯地址.Name = "GB3_button_通讯地址";
            this.GB3_button_通讯地址.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_通讯地址.TabIndex = 14;
            this.GB3_button_通讯地址.Tag = "24";
            this.GB3_button_通讯地址.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_通讯地址, "0x8B");
            this.GB3_button_通讯地址.UseVisualStyleBackColor = true;
            this.GB3_button_通讯地址.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_串口波特率
            // 
            this.GB3_label_串口波特率.AutoSize = true;
            this.GB3_label_串口波特率.Location = new System.Drawing.Point(20, 524);
            this.GB3_label_串口波特率.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_串口波特率.Name = "GB3_label_串口波特率";
            this.GB3_label_串口波特率.Size = new System.Drawing.Size(104, 19);
            this.GB3_label_串口波特率.TabIndex = 15;
            this.GB3_label_串口波特率.Text = "串口波特率";
            this.codeTip.SetToolTip(this.GB3_label_串口波特率, "0x8A");
            // 
            // GB3_button_串口波特率
            // 
            this.GB3_button_串口波特率.Location = new System.Drawing.Point(323, 519);
            this.GB3_button_串口波特率.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_串口波特率.Name = "GB3_button_串口波特率";
            this.GB3_button_串口波特率.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_串口波特率.TabIndex = 17;
            this.GB3_button_串口波特率.Tag = "23";
            this.GB3_button_串口波特率.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_串口波特率, "0x8A");
            this.GB3_button_串口波特率.UseVisualStyleBackColor = true;
            this.GB3_button_串口波特率.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_细分插补
            // 
            this.GB3_label_细分插补.AutoSize = true;
            this.GB3_label_细分插补.Location = new System.Drawing.Point(20, 474);
            this.GB3_label_细分插补.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_细分插补.Name = "GB3_label_细分插补";
            this.GB3_label_细分插补.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_细分插补.TabIndex = 18;
            this.GB3_label_细分插补.Text = "细分插补";
            this.codeTip.SetToolTip(this.GB3_label_细分插补, "0x89");
            // 
            // GB3_button_细分插补
            // 
            this.GB3_button_细分插补.Location = new System.Drawing.Point(323, 469);
            this.GB3_button_细分插补.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_细分插补.Name = "GB3_button_细分插补";
            this.GB3_button_细分插补.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_细分插补.TabIndex = 20;
            this.GB3_button_细分插补.Tag = "22";
            this.GB3_button_细分插补.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_细分插补, "0x89");
            this.GB3_button_细分插补.UseVisualStyleBackColor = true;
            this.GB3_button_细分插补.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_堵转保护
            // 
            this.GB3_label_堵转保护.AutoSize = true;
            this.GB3_label_堵转保护.Location = new System.Drawing.Point(20, 424);
            this.GB3_label_堵转保护.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_堵转保护.Name = "GB3_label_堵转保护";
            this.GB3_label_堵转保护.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_堵转保护.TabIndex = 21;
            this.GB3_label_堵转保护.Text = "堵转保护";
            this.codeTip.SetToolTip(this.GB3_label_堵转保护, "0x88");
            // 
            // GB3_button_堵转保护
            // 
            this.GB3_button_堵转保护.Location = new System.Drawing.Point(323, 419);
            this.GB3_button_堵转保护.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_堵转保护.Name = "GB3_button_堵转保护";
            this.GB3_button_堵转保护.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_堵转保护.TabIndex = 23;
            this.GB3_button_堵转保护.Tag = "21";
            this.GB3_button_堵转保护.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_堵转保护, "0x88");
            this.GB3_button_堵转保护.UseVisualStyleBackColor = true;
            this.GB3_button_堵转保护.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_自动熄屏
            // 
            this.GB3_label_自动熄屏.AutoSize = true;
            this.GB3_label_自动熄屏.Location = new System.Drawing.Point(20, 374);
            this.GB3_label_自动熄屏.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_自动熄屏.Name = "GB3_label_自动熄屏";
            this.GB3_label_自动熄屏.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_自动熄屏.TabIndex = 24;
            this.GB3_label_自动熄屏.Text = "自动熄屏";
            this.codeTip.SetToolTip(this.GB3_label_自动熄屏, "0x87");
            // 
            // GB3_button_自动熄屏
            // 
            this.GB3_button_自动熄屏.Location = new System.Drawing.Point(323, 369);
            this.GB3_button_自动熄屏.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_自动熄屏.Name = "GB3_button_自动熄屏";
            this.GB3_button_自动熄屏.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_自动熄屏.TabIndex = 26;
            this.GB3_button_自动熄屏.Tag = "20";
            this.GB3_button_自动熄屏.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_自动熄屏, "0x87");
            this.GB3_button_自动熄屏.UseVisualStyleBackColor = true;
            this.GB3_button_自动熄屏.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_电机方向
            // 
            this.GB3_label_电机方向.AutoSize = true;
            this.GB3_label_电机方向.Location = new System.Drawing.Point(20, 324);
            this.GB3_label_电机方向.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_电机方向.Name = "GB3_label_电机方向";
            this.GB3_label_电机方向.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_电机方向.TabIndex = 27;
            this.GB3_label_电机方向.Text = "电机方向";
            this.codeTip.SetToolTip(this.GB3_label_电机方向, "0x86");
            // 
            // GB3_button_电机方向
            // 
            this.GB3_button_电机方向.Location = new System.Drawing.Point(323, 319);
            this.GB3_button_电机方向.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_电机方向.Name = "GB3_button_电机方向";
            this.GB3_button_电机方向.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_电机方向.TabIndex = 29;
            this.GB3_button_电机方向.Tag = "19";
            this.GB3_button_电机方向.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_电机方向, "0x86");
            this.GB3_button_电机方向.UseVisualStyleBackColor = true;
            this.GB3_button_电机方向.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_使能设置
            // 
            this.GB3_label_使能设置.AutoSize = true;
            this.GB3_label_使能设置.Location = new System.Drawing.Point(20, 274);
            this.GB3_label_使能设置.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_使能设置.Name = "GB3_label_使能设置";
            this.GB3_label_使能设置.Size = new System.Drawing.Size(85, 19);
            this.GB3_label_使能设置.TabIndex = 30;
            this.GB3_label_使能设置.Text = "使能设置";
            this.codeTip.SetToolTip(this.GB3_label_使能设置, "0x85");
            // 
            // GB3_button_使能设置
            // 
            this.GB3_button_使能设置.Location = new System.Drawing.Point(323, 269);
            this.GB3_button_使能设置.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_使能设置.Name = "GB3_button_使能设置";
            this.GB3_button_使能设置.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_使能设置.TabIndex = 32;
            this.GB3_button_使能设置.Tag = "18";
            this.GB3_button_使能设置.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_使能设置, "0x85");
            this.GB3_button_使能设置.UseVisualStyleBackColor = true;
            this.GB3_button_使能设置.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_label_电流值
            // 
            this.GB3_label_电流值.AutoSize = true;
            this.GB3_label_电流值.Location = new System.Drawing.Point(20, 124);
            this.GB3_label_电流值.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB3_label_电流值.Name = "GB3_label_电流值";
            this.GB3_label_电流值.Size = new System.Drawing.Size(106, 19);
            this.GB3_label_电流值.TabIndex = 36;
            this.GB3_label_电流值.Text = "电流值(mA)";
            this.codeTip.SetToolTip(this.GB3_label_电流值, "0x83");
            // 
            // GB3_button_电流值
            // 
            this.GB3_button_电流值.Location = new System.Drawing.Point(323, 119);
            this.GB3_button_电流值.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_电流值.Name = "GB3_button_电流值";
            this.GB3_button_电流值.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_电流值.TabIndex = 38;
            this.GB3_button_电流值.Tag = "17";
            this.GB3_button_电流值.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_电流值, "0x83");
            this.GB3_button_电流值.UseVisualStyleBackColor = true;
            this.GB3_button_电流值.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_button_工作模式
            // 
            this.GB3_button_工作模式.Location = new System.Drawing.Point(323, 70);
            this.GB3_button_工作模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_工作模式.Name = "GB3_button_工作模式";
            this.GB3_button_工作模式.Size = new System.Drawing.Size(84, 29);
            this.GB3_button_工作模式.TabIndex = 41;
            this.GB3_button_工作模式.Tag = "16";
            this.GB3_button_工作模式.Text = "确认";
            this.codeTip.SetToolTip(this.GB3_button_工作模式, "0x82");
            this.GB3_button_工作模式.UseVisualStyleBackColor = true;
            this.GB3_button_工作模式.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB3_button_校准编码器
            // 
            this.GB3_button_校准编码器.Location = new System.Drawing.Point(139, 24);
            this.GB3_button_校准编码器.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_button_校准编码器.Name = "GB3_button_校准编码器";
            this.GB3_button_校准编码器.Size = new System.Drawing.Size(160, 32);
            this.GB3_button_校准编码器.TabIndex = 42;
            this.GB3_button_校准编码器.Tag = "14";
            this.GB3_button_校准编码器.Text = "校准编码器";
            this.codeTip.SetToolTip(this.GB3_button_校准编码器, "0x80");
            this.GB3_button_校准编码器.UseVisualStyleBackColor = true;
            this.GB3_button_校准编码器.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_label_单圈回零
            // 
            this.GB5_label_单圈回零.AutoSize = true;
            this.GB5_label_单圈回零.Font = new System.Drawing.Font("宋体", 12.5F);
            this.GB5_label_单圈回零.Location = new System.Drawing.Point(18, 54);
            this.GB5_label_单圈回零.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_单圈回零.Name = "GB5_label_单圈回零";
            this.GB5_label_单圈回零.Size = new System.Drawing.Size(94, 21);
            this.GB5_label_单圈回零.TabIndex = 0;
            this.GB5_label_单圈回零.Text = "单圈回零";
            this.codeTip.SetToolTip(this.GB5_label_单圈回零, "0x9A");
            // 
            // GB5_button_单圈回零
            // 
            this.GB5_button_单圈回零.Location = new System.Drawing.Point(628, 56);
            this.GB5_button_单圈回零.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_单圈回零.Name = "GB5_button_单圈回零";
            this.GB5_button_单圈回零.Size = new System.Drawing.Size(102, 29);
            this.GB5_button_单圈回零.TabIndex = 9;
            this.GB5_button_单圈回零.Tag = "49";
            this.GB5_button_单圈回零.Text = "确认";
            this.codeTip.SetToolTip(this.GB5_button_单圈回零, "0x9A");
            this.GB5_button_单圈回零.UseVisualStyleBackColor = true;
            this.GB5_button_单圈回零.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_label_限位回零
            // 
            this.GB5_label_限位回零.AutoSize = true;
            this.GB5_label_限位回零.Font = new System.Drawing.Font("宋体", 12.5F);
            this.GB5_label_限位回零.Location = new System.Drawing.Point(18, 120);
            this.GB5_label_限位回零.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_限位回零.Name = "GB5_label_限位回零";
            this.GB5_label_限位回零.Size = new System.Drawing.Size(94, 21);
            this.GB5_label_限位回零.TabIndex = 18;
            this.GB5_label_限位回零.Text = "限位回零";
            this.codeTip.SetToolTip(this.GB5_label_限位回零, "0x90");
            // 
            // GB5_button_限位参数
            // 
            this.GB5_button_限位参数.Location = new System.Drawing.Point(628, 122);
            this.GB5_button_限位参数.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_限位参数.Name = "GB5_button_限位参数";
            this.GB5_button_限位参数.Size = new System.Drawing.Size(102, 29);
            this.GB5_button_限位参数.TabIndex = 25;
            this.GB5_button_限位参数.Tag = "31";
            this.GB5_button_限位参数.Text = "确认";
            this.codeTip.SetToolTip(this.GB5_button_限位参数, "0x90");
            this.GB5_button_限位参数.UseVisualStyleBackColor = true;
            this.GB5_button_限位参数.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_读取IO端口
            // 
            this.GB5_button_读取IO端口.Location = new System.Drawing.Point(944, 54);
            this.GB5_button_读取IO端口.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_读取IO端口.Name = "GB5_button_读取IO端口";
            this.GB5_button_读取IO端口.Size = new System.Drawing.Size(140, 32);
            this.GB5_button_读取IO端口.TabIndex = 28;
            this.GB5_button_读取IO端口.Tag = "46";
            this.GB5_button_读取IO端口.Text = "读取IO端口";
            this.codeTip.SetToolTip(this.GB5_button_读取IO端口, "0x34");
            this.GB5_button_读取IO端口.UseVisualStyleBackColor = true;
            this.GB5_button_读取IO端口.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_限位归零
            // 
            this.GB5_button_限位归零.Location = new System.Drawing.Point(763, 120);
            this.GB5_button_限位归零.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_限位归零.Name = "GB5_button_限位归零";
            this.GB5_button_限位归零.Size = new System.Drawing.Size(152, 32);
            this.GB5_button_限位归零.TabIndex = 29;
            this.GB5_button_限位归零.Tag = "32";
            this.GB5_button_限位归零.Text = "限位归零";
            this.codeTip.SetToolTip(this.GB5_button_限位归零, "0x91");
            this.GB5_button_限位归零.UseVisualStyleBackColor = true;
            this.GB5_button_限位归零.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_直接归零
            // 
            this.GB5_button_直接归零.Location = new System.Drawing.Point(932, 120);
            this.GB5_button_直接归零.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_直接归零.Name = "GB5_button_直接归零";
            this.GB5_button_直接归零.Size = new System.Drawing.Size(152, 32);
            this.GB5_button_直接归零.TabIndex = 30;
            this.GB5_button_直接归零.Tag = "33";
            this.GB5_button_直接归零.Text = "直接归零";
            this.codeTip.SetToolTip(this.GB5_button_直接归零, "0x92");
            this.GB5_button_直接归零.UseVisualStyleBackColor = true;
            this.GB5_button_直接归零.Click += new System.EventHandler(this.Button_Click);
            // 
            // F1_button_恢复出厂配置
            // 
            this.F1_button_恢复出厂配置.Font = new System.Drawing.Font("宋体", 15F);
            this.F1_button_恢复出厂配置.Location = new System.Drawing.Point(975, 42);
            this.F1_button_恢复出厂配置.Margin = new System.Windows.Forms.Padding(4);
            this.F1_button_恢复出厂配置.Name = "F1_button_恢复出厂配置";
            this.F1_button_恢复出厂配置.Size = new System.Drawing.Size(350, 50);
            this.F1_button_恢复出厂配置.TabIndex = 5;
            this.F1_button_恢复出厂配置.Tag = "36";
            this.F1_button_恢复出厂配置.Text = "恢复出厂配置";
            this.codeTip.SetToolTip(this.F1_button_恢复出厂配置, "0x3F");
            this.F1_button_恢复出厂配置.UseVisualStyleBackColor = true;
            this.F1_button_恢复出厂配置.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_无限位回零
            // 
            this.GB5_button_无限位回零.Location = new System.Drawing.Point(504, 188);
            this.GB5_button_无限位回零.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_无限位回零.Name = "GB5_button_无限位回零";
            this.GB5_button_无限位回零.Size = new System.Drawing.Size(102, 29);
            this.GB5_button_无限位回零.TabIndex = 39;
            this.GB5_button_无限位回零.Tag = "35";
            this.GB5_button_无限位回零.Text = "确认";
            this.codeTip.SetToolTip(this.GB5_button_无限位回零, "0x94");
            this.GB5_button_无限位回零.UseVisualStyleBackColor = true;
            this.GB5_button_无限位回零.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_限位重映射
            // 
            this.GB5_button_限位重映射.Location = new System.Drawing.Point(982, 186);
            this.GB5_button_限位重映射.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_限位重映射.Name = "GB5_button_限位重映射";
            this.GB5_button_限位重映射.Size = new System.Drawing.Size(102, 29);
            this.GB5_button_限位重映射.TabIndex = 40;
            this.GB5_button_限位重映射.Tag = "51";
            this.GB5_button_限位重映射.Text = "确认";
            this.codeTip.SetToolTip(this.GB5_button_限位重映射, "0x9E");
            this.GB5_button_限位重映射.UseVisualStyleBackColor = true;
            this.GB5_button_限位重映射.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_label_无限位回零
            // 
            this.GB5_label_无限位回零.AutoSize = true;
            this.GB5_label_无限位回零.Font = new System.Drawing.Font("宋体", 12.5F);
            this.GB5_label_无限位回零.Location = new System.Drawing.Point(2, 186);
            this.GB5_label_无限位回零.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_无限位回零.Name = "GB5_label_无限位回零";
            this.GB5_label_无限位回零.Size = new System.Drawing.Size(115, 21);
            this.GB5_label_无限位回零.TabIndex = 31;
            this.GB5_label_无限位回零.Text = "无限位回零";
            this.codeTip.SetToolTip(this.GB5_label_无限位回零, "0x94");
            // 
            // GB5_label_限位重映射
            // 
            this.GB5_label_限位重映射.AutoSize = true;
            this.GB5_label_限位重映射.Font = new System.Drawing.Font("宋体", 12.5F);
            this.GB5_label_限位重映射.Location = new System.Drawing.Point(700, 190);
            this.GB5_label_限位重映射.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_限位重映射.Name = "GB5_label_限位重映射";
            this.GB5_label_限位重映射.Size = new System.Drawing.Size(115, 21);
            this.GB5_label_限位重映射.TabIndex = 31;
            this.GB5_label_限位重映射.Text = "限位重映射";
            this.codeTip.SetToolTip(this.GB5_label_限位重映射, "0x9E");
            // 
            // GB4_button_紧急停止
            // 
            this.GB4_button_紧急停止.Location = new System.Drawing.Point(16, 84);
            this.GB4_button_紧急停止.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_button_紧急停止.Name = "GB4_button_紧急停止";
            this.GB4_button_紧急停止.Size = new System.Drawing.Size(370, 30);
            this.GB4_button_紧急停止.TabIndex = 2;
            this.GB4_button_紧急停止.Tag = "52";
            this.GB4_button_紧急停止.Text = "紧急停止";
            this.codeTip.SetToolTip(this.GB4_button_紧急停止, "0xF7");
            this.GB4_button_紧急停止.UseVisualStyleBackColor = true;
            this.GB4_button_紧急停止.Click += new System.EventHandler(this.Button_Click);
            // 
            // F1_button_复位重启电机
            // 
            this.F1_button_复位重启电机.Font = new System.Drawing.Font("宋体", 15F);
            this.F1_button_复位重启电机.Location = new System.Drawing.Point(1385, 42);
            this.F1_button_复位重启电机.Margin = new System.Windows.Forms.Padding(4);
            this.F1_button_复位重启电机.Name = "F1_button_复位重启电机";
            this.F1_button_复位重启电机.Size = new System.Drawing.Size(350, 50);
            this.F1_button_复位重启电机.TabIndex = 6;
            this.F1_button_复位重启电机.Tag = "53";
            this.F1_button_复位重启电机.Text = "复位重启电机";
            this.codeTip.SetToolTip(this.F1_button_复位重启电机, "0x41");
            this.F1_button_复位重启电机.UseVisualStyleBackColor = true;
            this.F1_button_复位重启电机.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB2_button_读取所有参数
            // 
            this.GB2_button_读取所有参数.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_button_读取所有参数.Location = new System.Drawing.Point(13, 677);
            this.GB2_button_读取所有参数.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_button_读取所有参数.Name = "GB2_button_读取所有参数";
            this.GB2_button_读取所有参数.Size = new System.Drawing.Size(268, 29);
            this.GB2_button_读取所有参数.TabIndex = 1;
            this.GB2_button_读取所有参数.Tag = "54";
            this.GB2_button_读取所有参数.Text = "读取所有参数";
            this.codeTip.SetToolTip(this.GB2_button_读取所有参数, "0x47 & 0x48");
            this.GB2_button_读取所有参数.UseVisualStyleBackColor = true;
            this.GB2_button_读取所有参数.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_EN回零与位置保护
            // 
            this.GB5_button_EN回零与位置保护.Location = new System.Drawing.Point(628, 254);
            this.GB5_button_EN回零与位置保护.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_EN回零与位置保护.Name = "GB5_button_EN回零与位置保护";
            this.GB5_button_EN回零与位置保护.Size = new System.Drawing.Size(102, 29);
            this.GB5_button_EN回零与位置保护.TabIndex = 44;
            this.GB5_button_EN回零与位置保护.Tag = "56";
            this.GB5_button_EN回零与位置保护.Text = "确认";
            this.codeTip.SetToolTip(this.GB5_button_EN回零与位置保护, "0x9D");
            this.GB5_button_EN回零与位置保护.UseVisualStyleBackColor = true;
            this.GB5_button_EN回零与位置保护.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_button_写IO端口
            // 
            this.GB5_button_写IO端口.Location = new System.Drawing.Point(954, 252);
            this.GB5_button_写IO端口.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_button_写IO端口.Name = "GB5_button_写IO端口";
            this.GB5_button_写IO端口.Size = new System.Drawing.Size(130, 32);
            this.GB5_button_写IO端口.TabIndex = 45;
            this.GB5_button_写IO端口.Tag = "57";
            this.GB5_button_写IO端口.Text = "写IO端口";
            this.codeTip.SetToolTip(this.GB5_button_写IO端口, "0x36");
            this.GB5_button_写IO端口.UseVisualStyleBackColor = true;
            this.GB5_button_写IO端口.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB5_label_EN回零与位置保护
            // 
            this.GB5_label_EN回零与位置保护.AutoSize = true;
            this.GB5_label_EN回零与位置保护.Font = new System.Drawing.Font("宋体", 12.5F);
            this.GB5_label_EN回零与位置保护.Location = new System.Drawing.Point(18, 238);
            this.GB5_label_EN回零与位置保护.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_EN回零与位置保护.Name = "GB5_label_EN回零与位置保护";
            this.GB5_label_EN回零与位置保护.Size = new System.Drawing.Size(95, 42);
            this.GB5_label_EN回零与位置保护.TabIndex = 35;
            this.GB5_label_EN回零与位置保护.Text = "EN回零与\r\n位置保护";
            this.codeTip.SetToolTip(this.GB5_label_EN回零与位置保护, "0x9D");
            // 
            // GB5_label_EN回零
            // 
            this.GB5_label_EN回零.AutoSize = true;
            this.GB5_label_EN回零.Location = new System.Drawing.Point(123, 233);
            this.GB5_label_EN回零.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_EN回零.Name = "GB5_label_EN回零";
            this.GB5_label_EN回零.Size = new System.Drawing.Size(67, 19);
            this.GB5_label_EN回零.TabIndex = 36;
            this.GB5_label_EN回零.Text = "EN回零";
            // 
            // GB5_label_位置保护
            // 
            this.GB5_label_位置保护.AutoSize = true;
            this.GB5_label_位置保护.Location = new System.Drawing.Point(247, 233);
            this.GB5_label_位置保护.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_位置保护.Name = "GB5_label_位置保护";
            this.GB5_label_位置保护.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_位置保护.TabIndex = 37;
            this.GB5_label_位置保护.Text = "位置保护";
            // 
            // GB5_label_触发时间
            // 
            this.GB5_label_触发时间.AutoSize = true;
            this.GB5_label_触发时间.Location = new System.Drawing.Point(371, 233);
            this.GB5_label_触发时间.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_触发时间.Name = "GB5_label_触发时间";
            this.GB5_label_触发时间.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_触发时间.TabIndex = 38;
            this.GB5_label_触发时间.Text = "触发时间";
            // 
            // GB5_label_触发距离
            // 
            this.GB5_label_触发距离.AutoSize = true;
            this.GB5_label_触发距离.Location = new System.Drawing.Point(495, 233);
            this.GB5_label_触发距离.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_触发距离.Name = "GB5_label_触发距离";
            this.GB5_label_触发距离.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_触发距离.TabIndex = 39;
            this.GB5_label_触发距离.Text = "触发距离";
            // 
            // GB5_label_OUT2写入
            // 
            this.GB5_label_OUT2写入.AutoSize = true;
            this.GB5_label_OUT2写入.Location = new System.Drawing.Point(764, 233);
            this.GB5_label_OUT2写入.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_OUT2写入.Name = "GB5_label_OUT2写入";
            this.GB5_label_OUT2写入.Size = new System.Drawing.Size(49, 19);
            this.GB5_label_OUT2写入.TabIndex = 40;
            this.GB5_label_OUT2写入.Text = "OUT2";
            // 
            // GB5_label_OUT1写入
            // 
            this.GB5_label_OUT1写入.AutoSize = true;
            this.GB5_label_OUT1写入.Location = new System.Drawing.Point(863, 233);
            this.GB5_label_OUT1写入.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_OUT1写入.Name = "GB5_label_OUT1写入";
            this.GB5_label_OUT1写入.Size = new System.Drawing.Size(49, 19);
            this.GB5_label_OUT1写入.TabIndex = 41;
            this.GB5_label_OUT1写入.Text = "OUT1";
            // 
            // GB5_label_无限位返回距离
            // 
            this.GB5_label_无限位返回距离.AutoSize = true;
            this.GB5_label_无限位返回距离.Location = new System.Drawing.Point(123, 167);
            this.GB5_label_无限位返回距离.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_无限位返回距离.Name = "GB5_label_无限位返回距离";
            this.GB5_label_无限位返回距离.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_无限位返回距离.TabIndex = 32;
            this.GB5_label_无限位返回距离.Text = "返回距离";
            // 
            // GB5_label_无限位回零模式
            // 
            this.GB5_label_无限位回零模式.AutoSize = true;
            this.GB5_label_无限位回零模式.Location = new System.Drawing.Point(247, 167);
            this.GB5_label_无限位回零模式.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_无限位回零模式.Name = "GB5_label_无限位回零模式";
            this.GB5_label_无限位回零模式.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_无限位回零模式.TabIndex = 33;
            this.GB5_label_无限位回零模式.Text = "回零模式";
            // 
            // GB5_label_无限位回零电流
            // 
            this.GB5_label_无限位回零电流.AutoSize = true;
            this.GB5_label_无限位回零电流.Location = new System.Drawing.Point(371, 167);
            this.GB5_label_无限位回零电流.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_无限位回零电流.Name = "GB5_label_无限位回零电流";
            this.GB5_label_无限位回零电流.Size = new System.Drawing.Size(125, 19);
            this.GB5_label_无限位回零电流.TabIndex = 34;
            this.GB5_label_无限位回零电流.Text = "回零电流(mA)";
            // 
            // GB5_comboBox_无限位返回距离
            // 
            this.GB5_comboBox_无限位返回距离.FormattingEnabled = true;
            this.GB5_comboBox_无限位返回距离.Items.AddRange(new object[] {
            "0x0000",
            "0x2000",
            "0x4000"});
            this.GB5_comboBox_无限位返回距离.Location = new System.Drawing.Point(127, 190);
            this.GB5_comboBox_无限位返回距离.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_无限位返回距离.Name = "GB5_comboBox_无限位返回距离";
            this.GB5_comboBox_无限位返回距离.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_无限位返回距离.TabIndex = 35;
            this.rangeTip.SetToolTip(this.GB5_comboBox_无限位返回距离, "0x00~0xFFFFFFFF");
            // 
            // GB5_comboBox_无限位回零模式
            // 
            this.GB5_comboBox_无限位回零模式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_无限位回零模式.FormattingEnabled = true;
            this.GB5_comboBox_无限位回零模式.Items.AddRange(new object[] {
            "Limit Home",
            "noLimit Home"});
            this.GB5_comboBox_无限位回零模式.Location = new System.Drawing.Point(251, 190);
            this.GB5_comboBox_无限位回零模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_无限位回零模式.Name = "GB5_comboBox_无限位回零模式";
            this.GB5_comboBox_无限位回零模式.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_无限位回零模式.TabIndex = 36;
            // 
            // GB5_comboBox_无限位回零电流
            // 
            this.GB5_comboBox_无限位回零电流.FormattingEnabled = true;
            this.GB5_comboBox_无限位回零电流.Items.AddRange(new object[] {
            "0"});
            this.GB5_comboBox_无限位回零电流.Location = new System.Drawing.Point(375, 190);
            this.GB5_comboBox_无限位回零电流.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_无限位回零电流.Name = "GB5_comboBox_无限位回零电流";
            this.GB5_comboBox_无限位回零电流.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_无限位回零电流.TabIndex = 37;
            this.rangeTip.SetToolTip(this.GB5_comboBox_无限位回零电流, "42D: 0~3000\r\n57D: 0~5200\r\n28D: 0~3000\r\n35D: 0~3000");
            this.GB5_comboBox_无限位回零电流.DropDown += new System.EventHandler(this.ComboBox_DropDown);
            // 
            // GB5_comboBox_限位重映射
            // 
            this.GB5_comboBox_限位重映射.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_限位重映射.FormattingEnabled = true;
            this.GB5_comboBox_限位重映射.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB5_comboBox_限位重映射.Location = new System.Drawing.Point(833, 188);
            this.GB5_comboBox_限位重映射.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_限位重映射.Name = "GB5_comboBox_限位重映射";
            this.GB5_comboBox_限位重映射.Size = new System.Drawing.Size(135, 26);
            this.GB5_comboBox_限位重映射.TabIndex = 38;
            // 
            // GB5_comboBox_EN回零
            // 
            this.GB5_comboBox_EN回零.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_EN回零.FormattingEnabled = true;
            this.GB5_comboBox_EN回零.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB5_comboBox_EN回零.Location = new System.Drawing.Point(127, 256);
            this.GB5_comboBox_EN回零.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_EN回零.Name = "GB5_comboBox_EN回零";
            this.GB5_comboBox_EN回零.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_EN回零.TabIndex = 40;
            // 
            // GB5_comboBox_位置保护
            // 
            this.GB5_comboBox_位置保护.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_位置保护.FormattingEnabled = true;
            this.GB5_comboBox_位置保护.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB5_comboBox_位置保护.Location = new System.Drawing.Point(251, 256);
            this.GB5_comboBox_位置保护.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_位置保护.Name = "GB5_comboBox_位置保护";
            this.GB5_comboBox_位置保护.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_位置保护.TabIndex = 41;
            // 
            // GB5_comboBox_触发时间
            // 
            this.GB5_comboBox_触发时间.FormattingEnabled = true;
            this.GB5_comboBox_触发时间.Items.AddRange(new object[] {
            "0",
            "10",
            "20"});
            this.GB5_comboBox_触发时间.Location = new System.Drawing.Point(375, 256);
            this.GB5_comboBox_触发时间.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_触发时间.Name = "GB5_comboBox_触发时间";
            this.GB5_comboBox_触发时间.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_触发时间.TabIndex = 42;
            this.rangeTip.SetToolTip(this.GB5_comboBox_触发时间, "0~65535");
            // 
            // GB5_comboBox_触发距离
            // 
            this.GB5_comboBox_触发距离.FormattingEnabled = true;
            this.GB5_comboBox_触发距离.Items.AddRange(new object[] {
            "0",
            "14000",
            "28000"});
            this.GB5_comboBox_触发距离.Location = new System.Drawing.Point(499, 256);
            this.GB5_comboBox_触发距离.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_触发距离.Name = "GB5_comboBox_触发距离";
            this.GB5_comboBox_触发距离.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_触发距离.TabIndex = 43;
            this.rangeTip.SetToolTip(this.GB5_comboBox_触发距离, "0~65535");
            // 
            // GB5_comboBox_OUT2写入
            // 
            this.GB5_comboBox_OUT2写入.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_OUT2写入.FormattingEnabled = true;
            this.GB5_comboBox_OUT2写入.Items.AddRange(new object[] {
            "不写入",
            "写入0",
            "写入1",
            "保持不变"});
            this.GB5_comboBox_OUT2写入.Location = new System.Drawing.Point(763, 256);
            this.GB5_comboBox_OUT2写入.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_OUT2写入.Name = "GB5_comboBox_OUT2写入";
            this.GB5_comboBox_OUT2写入.Size = new System.Drawing.Size(95, 26);
            this.GB5_comboBox_OUT2写入.TabIndex = 44;
            // 
            // GB5_comboBox_OUT1写入
            // 
            this.GB5_comboBox_OUT1写入.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_OUT1写入.FormattingEnabled = true;
            this.GB5_comboBox_OUT1写入.Items.AddRange(new object[] {
            "不写入",
            "写入0",
            "写入1",
            "保持不变"});
            this.GB5_comboBox_OUT1写入.Location = new System.Drawing.Point(857, 256);
            this.GB5_comboBox_OUT1写入.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_OUT1写入.Name = "GB5_comboBox_OUT1写入";
            this.GB5_comboBox_OUT1写入.Size = new System.Drawing.Size(95, 26);
            this.GB5_comboBox_OUT1写入.TabIndex = 45;
            // 
            // GB5_comboBox_OUT2写入值
            // 
            this.GB5_comboBox_OUT2写入值.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_OUT2写入值.FormattingEnabled = true;
            this.GB5_comboBox_OUT2写入值.Items.AddRange(new object[] {
            "0",
            "1"});
            this.GB5_comboBox_OUT2写入值.Location = new System.Drawing.Point(301, 286);
            this.GB5_comboBox_OUT2写入值.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_OUT2写入值.Name = "GB5_comboBox_OUT2写入值";
            this.GB5_comboBox_OUT2写入值.Size = new System.Drawing.Size(115, 23);
            this.GB5_comboBox_OUT2写入值.TabIndex = 0;
            // 
            // GB5_comboBox_OUT1写入值
            // 
            this.GB5_comboBox_OUT1写入值.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_OUT1写入值.FormattingEnabled = true;
            this.GB5_comboBox_OUT1写入值.Items.AddRange(new object[] {
            "0",
            "1"});
            this.GB5_comboBox_OUT1写入值.Location = new System.Drawing.Point(301, 286);
            this.GB5_comboBox_OUT1写入值.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_OUT1写入值.Name = "GB5_comboBox_OUT1写入值";
            this.GB5_comboBox_OUT1写入值.Size = new System.Drawing.Size(115, 23);
            this.GB5_comboBox_OUT1写入值.TabIndex = 0;
            // 
            // F1_groupBox1_连接设置
            // 
            this.F1_groupBox1_连接设置.BackColor = System.Drawing.SystemColors.Control;
            this.F1_groupBox1_连接设置.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_button_断开连接);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_button_连接主板);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_button_扫描);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_comboBox_通讯地址);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_comboBox_波特率);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_comboBox_串口);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_label_通讯地址);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_label_波特率);
            this.F1_groupBox1_连接设置.Controls.Add(this.GB1_label_串口);
            this.F1_groupBox1_连接设置.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox1_连接设置.Location = new System.Drawing.Point(16, 44);
            this.F1_groupBox1_连接设置.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox1_连接设置.Name = "F1_groupBox1_连接设置";
            this.F1_groupBox1_连接设置.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox1_连接设置.Size = new System.Drawing.Size(309, 209);
            this.F1_groupBox1_连接设置.TabIndex = 7;
            this.F1_groupBox1_连接设置.TabStop = false;
            this.F1_groupBox1_连接设置.Text = "连接设置";
            // 
            // GB1_button_断开连接
            // 
            this.GB1_button_断开连接.Location = new System.Drawing.Point(168, 148);
            this.GB1_button_断开连接.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_button_断开连接.Name = "GB1_button_断开连接";
            this.GB1_button_断开连接.Size = new System.Drawing.Size(133, 42);
            this.GB1_button_断开连接.TabIndex = 0;
            this.GB1_button_断开连接.Text = "断开连接";
            this.GB1_button_断开连接.UseVisualStyleBackColor = true;
            this.GB1_button_断开连接.Click += new System.EventHandler(this.button18_Click);
            // 
            // GB1_button_连接主板
            // 
            this.GB1_button_连接主板.Location = new System.Drawing.Point(8, 148);
            this.GB1_button_连接主板.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_button_连接主板.Name = "GB1_button_连接主板";
            this.GB1_button_连接主板.Size = new System.Drawing.Size(133, 42);
            this.GB1_button_连接主板.TabIndex = 1;
            this.GB1_button_连接主板.Text = "连接主板";
            this.GB1_button_连接主板.UseVisualStyleBackColor = true;
            this.GB1_button_连接主板.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GB1_button_扫描
            // 
            this.GB1_button_扫描.Location = new System.Drawing.Point(237, 29);
            this.GB1_button_扫描.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_button_扫描.Name = "GB1_button_扫描";
            this.GB1_button_扫描.Size = new System.Drawing.Size(65, 29);
            this.GB1_button_扫描.TabIndex = 2;
            this.GB1_button_扫描.Text = "扫描";
            this.GB1_button_扫描.UseVisualStyleBackColor = true;
            this.GB1_button_扫描.Click += new System.EventHandler(this.GetPortNames);
            // 
            // GB1_comboBox_通讯地址
            // 
            this.GB1_comboBox_通讯地址.FormattingEnabled = true;
            this.GB1_comboBox_通讯地址.Items.AddRange(new object[] {
            "0x01",
            "0x02",
            "0x03",
            "0x04",
            "0x05",
            "0x06",
            "0x07",
            "0x08",
            "0x09",
            "0x0a",
            "0x0b",
            "0x0c",
            "0x0d",
            "0x0e",
            "0x0f",
            "0x10",
            "0xff"});
            this.GB1_comboBox_通讯地址.Location = new System.Drawing.Point(100, 107);
            this.GB1_comboBox_通讯地址.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_comboBox_通讯地址.Name = "GB1_comboBox_通讯地址";
            this.GB1_comboBox_通讯地址.Size = new System.Drawing.Size(128, 26);
            this.GB1_comboBox_通讯地址.TabIndex = 3;
            this.rangeTip.SetToolTip(this.GB1_comboBox_通讯地址, "0x00~0xFF");
            // 
            // GB1_comboBox_波特率
            // 
            this.GB1_comboBox_波特率.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB1_comboBox_波特率.FormattingEnabled = true;
            this.GB1_comboBox_波特率.Items.AddRange(new object[] {
            "9600",
            "19200",
            "25000",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.GB1_comboBox_波特率.Location = new System.Drawing.Point(100, 68);
            this.GB1_comboBox_波特率.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_comboBox_波特率.Name = "GB1_comboBox_波特率";
            this.GB1_comboBox_波特率.Size = new System.Drawing.Size(128, 26);
            this.GB1_comboBox_波特率.TabIndex = 4;
            // 
            // GB1_comboBox_串口
            // 
            this.GB1_comboBox_串口.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB1_comboBox_串口.FormattingEnabled = true;
            this.GB1_comboBox_串口.Location = new System.Drawing.Point(100, 29);
            this.GB1_comboBox_串口.Margin = new System.Windows.Forms.Padding(4);
            this.GB1_comboBox_串口.Name = "GB1_comboBox_串口";
            this.GB1_comboBox_串口.Size = new System.Drawing.Size(128, 26);
            this.GB1_comboBox_串口.TabIndex = 5;
            this.GB1_comboBox_串口.DropDown += new System.EventHandler(this.GetPortNames);
            // 
            // GB1_label_通讯地址
            // 
            this.GB1_label_通讯地址.AutoSize = true;
            this.GB1_label_通讯地址.Font = new System.Drawing.Font("宋体", 10F);
            this.GB1_label_通讯地址.Location = new System.Drawing.Point(10, 112);
            this.GB1_label_通讯地址.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB1_label_通讯地址.Name = "GB1_label_通讯地址";
            this.GB1_label_通讯地址.Size = new System.Drawing.Size(76, 17);
            this.GB1_label_通讯地址.TabIndex = 6;
            this.GB1_label_通讯地址.Text = "通讯地址";
            // 
            // GB1_label_波特率
            // 
            this.GB1_label_波特率.AutoSize = true;
            this.GB1_label_波特率.Font = new System.Drawing.Font("宋体", 10F);
            this.GB1_label_波特率.Location = new System.Drawing.Point(10, 73);
            this.GB1_label_波特率.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB1_label_波特率.Name = "GB1_label_波特率";
            this.GB1_label_波特率.Size = new System.Drawing.Size(59, 17);
            this.GB1_label_波特率.TabIndex = 7;
            this.GB1_label_波特率.Text = "波特率";
            // 
            // GB1_label_串口
            // 
            this.GB1_label_串口.AutoSize = true;
            this.GB1_label_串口.Font = new System.Drawing.Font("宋体", 10F);
            this.GB1_label_串口.Location = new System.Drawing.Point(12, 34);
            this.GB1_label_串口.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB1_label_串口.Name = "GB1_label_串口";
            this.GB1_label_串口.Size = new System.Drawing.Size(60, 17);
            this.GB1_label_串口.TabIndex = 8;
            this.GB1_label_串口.Text = "串  口";
            // 
            // GB2_comboBox_读编码值
            // 
            this.GB2_comboBox_读编码值.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB2_comboBox_读编码值.FormattingEnabled = true;
            this.GB2_comboBox_读编码值.Items.AddRange(new object[] {
            "进位",
            "累加",
            "原始"});
            this.GB2_comboBox_读编码值.Location = new System.Drawing.Point(13, 77);
            this.GB2_comboBox_读编码值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_comboBox_读编码值.Name = "GB2_comboBox_读编码值";
            this.GB2_comboBox_读编码值.Size = new System.Drawing.Size(114, 26);
            this.GB2_comboBox_读编码值.TabIndex = 17;
            // 
            // F1_groupBox2_读取参数
            // 
            this.F1_groupBox2_读取参数.BackColor = System.Drawing.SystemColors.Control;
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_版本信息);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_读取所有参数);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_堵转标志位);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_解除堵转);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_堵转状态);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_回零状态);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_回零状态);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_使能状态);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_使能状态);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_位置角度误差);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_误差值);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_累计脉冲数);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_脉冲数值);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_电机当前转速);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_当前转速);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_button_读编码值);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_textBox_编码器值);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_comboBox_读编码值);
            this.F1_groupBox2_读取参数.Controls.Add(this.GB2_panel_十六or十进制);
            this.F1_groupBox2_读取参数.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox2_读取参数.Location = new System.Drawing.Point(16, 283);
            this.F1_groupBox2_读取参数.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox2_读取参数.Name = "F1_groupBox2_读取参数";
            this.F1_groupBox2_读取参数.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox2_读取参数.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.F1_groupBox2_读取参数.Size = new System.Drawing.Size(309, 759);
            this.F1_groupBox2_读取参数.TabIndex = 8;
            this.F1_groupBox2_读取参数.TabStop = false;
            this.F1_groupBox2_读取参数.Text = "读取参数";
            // 
            // GB2_textBox_堵转状态
            // 
            this.GB2_textBox_堵转状态.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_堵转状态.Location = new System.Drawing.Point(13, 634);
            this.GB2_textBox_堵转状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_堵转状态.Name = "GB2_textBox_堵转状态";
            this.GB2_textBox_堵转状态.ReadOnly = true;
            this.GB2_textBox_堵转状态.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_堵转状态.TabIndex = 3;
            this.GB2_textBox_堵转状态.Tag = "5";
            // 
            // GB2_textBox_回零状态
            // 
            this.GB2_textBox_回零状态.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_回零状态.Location = new System.Drawing.Point(13, 547);
            this.GB2_textBox_回零状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_回零状态.Name = "GB2_textBox_回零状态";
            this.GB2_textBox_回零状态.ReadOnly = true;
            this.GB2_textBox_回零状态.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_回零状态.TabIndex = 5;
            this.GB2_textBox_回零状态.Tag = "4";
            // 
            // GB2_textBox_使能状态
            // 
            this.GB2_textBox_使能状态.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_使能状态.Location = new System.Drawing.Point(13, 460);
            this.GB2_textBox_使能状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_使能状态.Name = "GB2_textBox_使能状态";
            this.GB2_textBox_使能状态.ReadOnly = true;
            this.GB2_textBox_使能状态.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_使能状态.TabIndex = 7;
            this.GB2_textBox_使能状态.Tag = "3";
            // 
            // GB2_textBox_误差值
            // 
            this.GB2_textBox_误差值.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_误差值.Location = new System.Drawing.Point(13, 373);
            this.GB2_textBox_误差值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_误差值.Name = "GB2_textBox_误差值";
            this.GB2_textBox_误差值.ReadOnly = true;
            this.GB2_textBox_误差值.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_误差值.TabIndex = 9;
            this.GB2_textBox_误差值.Tag = "2";
            // 
            // GB2_textBox_脉冲数值
            // 
            this.GB2_textBox_脉冲数值.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_脉冲数值.Location = new System.Drawing.Point(13, 286);
            this.GB2_textBox_脉冲数值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_脉冲数值.Name = "GB2_textBox_脉冲数值";
            this.GB2_textBox_脉冲数值.ReadOnly = true;
            this.GB2_textBox_脉冲数值.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_脉冲数值.TabIndex = 11;
            this.GB2_textBox_脉冲数值.Tag = "1";
            // 
            // GB2_textBox_当前转速
            // 
            this.GB2_textBox_当前转速.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_当前转速.Location = new System.Drawing.Point(13, 199);
            this.GB2_textBox_当前转速.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_当前转速.Name = "GB2_textBox_当前转速";
            this.GB2_textBox_当前转速.ReadOnly = true;
            this.GB2_textBox_当前转速.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_当前转速.TabIndex = 13;
            this.GB2_textBox_当前转速.Tag = "40";
            // 
            // GB2_textBox_编码器值
            // 
            this.GB2_textBox_编码器值.BackColor = System.Drawing.SystemColors.Menu;
            this.GB2_textBox_编码器值.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GB2_textBox_编码器值.Location = new System.Drawing.Point(13, 112);
            this.GB2_textBox_编码器值.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_textBox_编码器值.Name = "GB2_textBox_编码器值";
            this.GB2_textBox_编码器值.ReadOnly = true;
            this.GB2_textBox_编码器值.Size = new System.Drawing.Size(268, 28);
            this.GB2_textBox_编码器值.TabIndex = 16;
            this.GB2_textBox_编码器值.Tag = "0";
            // 
            // GB2_panel_十六or十进制
            // 
            this.GB2_panel_十六or十进制.Controls.Add(this.GB2_radioButton_十进制);
            this.GB2_panel_十六or十进制.Controls.Add(this.GB2_radioButton_十六进制);
            this.GB2_panel_十六or十进制.Location = new System.Drawing.Point(13, 30);
            this.GB2_panel_十六or十进制.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_panel_十六or十进制.Name = "GB2_panel_十六or十进制";
            this.GB2_panel_十六or十进制.Size = new System.Drawing.Size(267, 36);
            this.GB2_panel_十六or十进制.TabIndex = 17;
            // 
            // GB2_radioButton_十进制
            // 
            this.GB2_radioButton_十进制.AutoSize = true;
            this.GB2_radioButton_十进制.Location = new System.Drawing.Point(169, 9);
            this.GB2_radioButton_十进制.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_radioButton_十进制.Name = "GB2_radioButton_十进制";
            this.GB2_radioButton_十进制.Size = new System.Drawing.Size(87, 23);
            this.GB2_radioButton_十进制.TabIndex = 0;
            this.GB2_radioButton_十进制.TabStop = true;
            this.GB2_radioButton_十进制.Text = "十进制";
            this.GB2_radioButton_十进制.UseVisualStyleBackColor = true;
            // 
            // GB2_radioButton_十六进制
            // 
            this.GB2_radioButton_十六进制.AutoSize = true;
            this.GB2_radioButton_十六进制.Location = new System.Drawing.Point(4, 9);
            this.GB2_radioButton_十六进制.Margin = new System.Windows.Forms.Padding(4);
            this.GB2_radioButton_十六进制.Name = "GB2_radioButton_十六进制";
            this.GB2_radioButton_十六进制.Size = new System.Drawing.Size(106, 23);
            this.GB2_radioButton_十六进制.TabIndex = 1;
            this.GB2_radioButton_十六进制.TabStop = true;
            this.GB2_radioButton_十六进制.Text = "十六进制";
            this.GB2_radioButton_十六进制.UseVisualStyleBackColor = true;
            // 
            // GB2_checkbox_跟踪模式
            // 
            this.GB2_checkbox_跟踪模式.Font = new System.Drawing.Font("宋体", 10F);
            this.GB2_checkbox_跟踪模式.Location = new System.Drawing.Point(13, 680);
            this.GB2_checkbox_跟踪模式.Name = "GB2_checkbox_跟踪模式";
            this.GB2_checkbox_跟踪模式.Size = new System.Drawing.Size(220, 24);
            this.GB2_checkbox_跟踪模式.TabIndex = 18;
            this.GB2_checkbox_跟踪模式.Text = "跟踪模式";
            this.GB2_checkbox_跟踪模式.CheckedChanged += new System.EventHandler(this.trackingMode_CheckedChanged);
            // 
            // F1_groupBox3_设置系统参数
            // 
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_按键锁定);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_按键锁定);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_按键锁定);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_保持电流);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_保持电流);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_保持电流);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_从机分组);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_从机分组);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_从机分组);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_从机应答);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_从机应答);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_从机应答);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_通讯地址);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_通讯地址);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_通讯地址);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_串口波特率);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_串口波特率);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_串口波特率);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_细分插补);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_细分插补);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_细分插补);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_堵转保护);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_堵转保护);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_堵转保护);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_自动熄屏);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_自动熄屏);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_自动熄屏);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_电机方向);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_电机方向);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_电机方向);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_使能设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_使能设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_使能设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_细分设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_细分设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_细分设置);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_电流值);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_电流值);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_电流值);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_label_工作模式);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_comboBox_工作模式);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_工作模式);
            this.F1_groupBox3_设置系统参数.Controls.Add(this.GB3_button_校准编码器);
            this.F1_groupBox3_设置系统参数.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox3_设置系统参数.Location = new System.Drawing.Point(354, 283);
            this.F1_groupBox3_设置系统参数.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox3_设置系统参数.Name = "F1_groupBox3_设置系统参数";
            this.F1_groupBox3_设置系统参数.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox3_设置系统参数.Size = new System.Drawing.Size(425, 759);
            this.F1_groupBox3_设置系统参数.TabIndex = 9;
            this.F1_groupBox3_设置系统参数.TabStop = false;
            this.F1_groupBox3_设置系统参数.Text = "设置系统参数";
            // 
            // GB3_comboBox_按键锁定
            // 
            this.GB3_comboBox_按键锁定.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_按键锁定.FormattingEnabled = true;
            this.GB3_comboBox_按键锁定.Items.AddRange(new object[] {
            "Lock",
            "UnLock"});
            this.GB3_comboBox_按键锁定.Location = new System.Drawing.Point(139, 721);
            this.GB3_comboBox_按键锁定.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_按键锁定.Name = "GB3_comboBox_按键锁定";
            this.GB3_comboBox_按键锁定.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_按键锁定.TabIndex = 1;
            // 
            // GB3_comboBox_保持电流
            // 
            this.GB3_comboBox_保持电流.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_保持电流.FormattingEnabled = true;
            this.GB3_comboBox_保持电流.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%"});
            this.GB3_comboBox_保持电流.Location = new System.Drawing.Point(139, 171);
            this.GB3_comboBox_保持电流.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_保持电流.Name = "GB3_comboBox_保持电流";
            this.GB3_comboBox_保持电流.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_保持电流.TabIndex = 4;
            // 
            // GB3_comboBox_从机分组
            // 
            this.GB3_comboBox_从机分组.FormattingEnabled = true;
            this.GB3_comboBox_从机分组.Items.AddRange(new object[] {
            "0x01",
            "0x02",
            "0x03",
            "0x04",
            "0x05",
            "0x06",
            "0x07",
            "0x08",
            "0x09",
            "0x0a",
            "0x0b",
            "0x0c",
            "0x0d",
            "0x0e",
            "0x0f",
            "0x10",
            "0xff"});
            this.GB3_comboBox_从机分组.Location = new System.Drawing.Point(139, 621);
            this.GB3_comboBox_从机分组.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_从机分组.Name = "GB3_comboBox_从机分组";
            this.GB3_comboBox_从机分组.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_从机分组.TabIndex = 7;
            this.rangeTip.SetToolTip(this.GB3_comboBox_从机分组, "0x01~0xFF");
            // 
            // GB3_comboBox_从机应答
            // 
            this.GB3_comboBox_从机应答.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_从机应答.FormattingEnabled = true;
            this.GB3_comboBox_从机应答.Items.AddRange(new object[] {
            "Respon",
            "notRespon",
            "notActive"});
            this.GB3_comboBox_从机应答.Location = new System.Drawing.Point(139, 671);
            this.GB3_comboBox_从机应答.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_从机应答.Name = "GB3_comboBox_从机应答";
            this.GB3_comboBox_从机应答.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_从机应答.TabIndex = 10;
            // 
            // GB3_comboBox_通讯地址
            // 
            this.GB3_comboBox_通讯地址.FormattingEnabled = true;
            this.GB3_comboBox_通讯地址.Items.AddRange(new object[] {
            "0x01",
            "0x02",
            "0x03",
            "0x04",
            "0x05",
            "0x06",
            "0x07",
            "0x08",
            "0x09",
            "0x0a",
            "0x0b",
            "0x0c",
            "0x0d",
            "0x0e",
            "0x0f",
            "0x10",
            "0xff"});
            this.GB3_comboBox_通讯地址.Location = new System.Drawing.Point(139, 571);
            this.GB3_comboBox_通讯地址.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_通讯地址.Name = "GB3_comboBox_通讯地址";
            this.GB3_comboBox_通讯地址.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_通讯地址.TabIndex = 13;
            this.rangeTip.SetToolTip(this.GB3_comboBox_通讯地址, "0x01~0xFF");
            // 
            // GB3_comboBox_串口波特率
            // 
            this.GB3_comboBox_串口波特率.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_串口波特率.FormattingEnabled = true;
            this.GB3_comboBox_串口波特率.Items.AddRange(new object[] {
            "9600",
            "19200",
            "25000",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.GB3_comboBox_串口波特率.Location = new System.Drawing.Point(139, 521);
            this.GB3_comboBox_串口波特率.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_串口波特率.Name = "GB3_comboBox_串口波特率";
            this.GB3_comboBox_串口波特率.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_串口波特率.TabIndex = 16;
            // 
            // GB3_comboBox_细分插补
            // 
            this.GB3_comboBox_细分插补.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_细分插补.FormattingEnabled = true;
            this.GB3_comboBox_细分插补.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB3_comboBox_细分插补.Location = new System.Drawing.Point(139, 471);
            this.GB3_comboBox_细分插补.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_细分插补.Name = "GB3_comboBox_细分插补";
            this.GB3_comboBox_细分插补.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_细分插补.TabIndex = 19;
            // 
            // GB3_comboBox_堵转保护
            // 
            this.GB3_comboBox_堵转保护.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_堵转保护.FormattingEnabled = true;
            this.GB3_comboBox_堵转保护.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB3_comboBox_堵转保护.Location = new System.Drawing.Point(139, 421);
            this.GB3_comboBox_堵转保护.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_堵转保护.Name = "GB3_comboBox_堵转保护";
            this.GB3_comboBox_堵转保护.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_堵转保护.TabIndex = 22;
            // 
            // GB3_comboBox_自动熄屏
            // 
            this.GB3_comboBox_自动熄屏.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_自动熄屏.FormattingEnabled = true;
            this.GB3_comboBox_自动熄屏.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB3_comboBox_自动熄屏.Location = new System.Drawing.Point(139, 371);
            this.GB3_comboBox_自动熄屏.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_自动熄屏.Name = "GB3_comboBox_自动熄屏";
            this.GB3_comboBox_自动熄屏.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_自动熄屏.TabIndex = 25;
            // 
            // GB3_comboBox_电机方向
            // 
            this.GB3_comboBox_电机方向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_电机方向.FormattingEnabled = true;
            this.GB3_comboBox_电机方向.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.GB3_comboBox_电机方向.Location = new System.Drawing.Point(139, 321);
            this.GB3_comboBox_电机方向.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_电机方向.Name = "GB3_comboBox_电机方向";
            this.GB3_comboBox_电机方向.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_电机方向.TabIndex = 28;
            // 
            // GB3_comboBox_使能设置
            // 
            this.GB3_comboBox_使能设置.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_使能设置.FormattingEnabled = true;
            this.GB3_comboBox_使能设置.Items.AddRange(new object[] {
            "L",
            "H",
            "Hold"});
            this.GB3_comboBox_使能设置.Location = new System.Drawing.Point(139, 271);
            this.GB3_comboBox_使能设置.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_使能设置.Name = "GB3_comboBox_使能设置";
            this.GB3_comboBox_使能设置.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_使能设置.TabIndex = 31;
            // 
            // GB3_comboBox_细分设置
            // 
            this.GB3_comboBox_细分设置.FormattingEnabled = true;
            this.GB3_comboBox_细分设置.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.GB3_comboBox_细分设置.Location = new System.Drawing.Point(139, 221);
            this.GB3_comboBox_细分设置.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_细分设置.Name = "GB3_comboBox_细分设置";
            this.GB3_comboBox_细分设置.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_细分设置.TabIndex = 34;
            this.tipTip.SetToolTip(this.GB3_comboBox_细分设置, "建议细分数设置为2的次方，如果设置值为非2的次方，位置角度会有误差");
            // 
            // GB3_comboBox_电流值
            // 
            this.GB3_comboBox_电流值.FormattingEnabled = true;
            this.GB3_comboBox_电流值.Items.AddRange(new object[] {
            "0"});
            this.GB3_comboBox_电流值.Location = new System.Drawing.Point(139, 121);
            this.GB3_comboBox_电流值.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_电流值.Name = "GB3_comboBox_电流值";
            this.GB3_comboBox_电流值.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_电流值.TabIndex = 37;
            this.rangeTip.SetToolTip(this.GB3_comboBox_电流值, "42D: 0~3000\r\n57D: 0~5200\r\n28D: 0~3000\r\n35D: 0~3000");
            this.GB3_comboBox_电流值.DropDown += new System.EventHandler(this.ComboBox_DropDown);
            // 
            // GB3_comboBox_工作模式
            // 
            this.GB3_comboBox_工作模式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB3_comboBox_工作模式.FormattingEnabled = true;
            this.GB3_comboBox_工作模式.Items.AddRange(new object[] {
            "CR_OPEN",
            "CR_CLOSE",
            "CR_vFOC",
            "SR_OPEN",
            "SR_CLOSE",
            "SR_vFOC"});
            this.GB3_comboBox_工作模式.Location = new System.Drawing.Point(139, 71);
            this.GB3_comboBox_工作模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB3_comboBox_工作模式.Name = "GB3_comboBox_工作模式";
            this.GB3_comboBox_工作模式.Size = new System.Drawing.Size(160, 26);
            this.GB3_comboBox_工作模式.TabIndex = 40;
            this.tipTip.SetToolTip(this.GB3_comboBox_工作模式, "CR：串口读写参数，脉冲控制运动\r\nSR：串口读写参数，串口控制运动\r\n\r\nOPEN：开环模式，无需安装磁铁，电流恒定\r\nCLOSE：闭环模式，需要安装磁铁，电流" +
        "恒定，刚性度高，适合对力矩或精度要求较高的情况下使用\r\nvFOC：FOC模式，需要安装磁铁，电流自动调节不恒定，电机噪音小，发热低，转速上限高，但刚性度相比CL" +
        "OSE模式低");
            // 
            // F1_groupBox4_电机控制
            // 
            this.F1_groupBox4_电机控制.BackColor = System.Drawing.SystemColors.Control;
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_button_使能驱动板);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_button_关闭驱动板);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_button_紧急停止);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_groupBox1_加速度参数);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_groupBox2_电机状态监控);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_groupBox3_电机速度控制模式);
            this.F1_groupBox4_电机控制.Controls.Add(this.GB4_groupBox4_电机位置控制模式);
            this.F1_groupBox4_电机控制.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox4_电机控制.Location = new System.Drawing.Point(806, 447);
            this.F1_groupBox4_电机控制.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox4_电机控制.Name = "F1_groupBox4_电机控制";
            this.F1_groupBox4_电机控制.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox4_电机控制.Size = new System.Drawing.Size(799, 595);
            this.F1_groupBox4_电机控制.TabIndex = 10;
            this.F1_groupBox4_电机控制.TabStop = false;
            this.F1_groupBox4_电机控制.Text = "电机控制";
            // 
            // GB4_groupBox1_加速度参数
            // 
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_button_启动加速度);
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_comboBox_启动加速度);
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_button_停止加速度);
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_comboBox_停止加速度);
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_label_启动加速度);
            this.GB4_groupBox1_加速度参数.Controls.Add(this.GB4_1_label_停止加速度);
            this.GB4_groupBox1_加速度参数.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GB4_groupBox1_加速度参数.Location = new System.Drawing.Point(16, 135);
            this.GB4_groupBox1_加速度参数.Name = "GB4_groupBox1_加速度参数";
            this.GB4_groupBox1_加速度参数.Size = new System.Drawing.Size(370, 135);
            this.GB4_groupBox1_加速度参数.TabIndex = 2;
            this.GB4_groupBox1_加速度参数.TabStop = false;
            this.GB4_groupBox1_加速度参数.Text = "加速度参数 ACC";
            // 
            // GB4_1_button_启动加速度
            // 
            this.GB4_1_button_启动加速度.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB4_1_button_启动加速度.Location = new System.Drawing.Point(269, 37);
            this.GB4_1_button_启动加速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_1_button_启动加速度.Name = "GB4_1_button_启动加速度";
            this.GB4_1_button_启动加速度.Size = new System.Drawing.Size(84, 29);
            this.GB4_1_button_启动加速度.TabIndex = 0;
            this.GB4_1_button_启动加速度.Tag = "28";
            this.GB4_1_button_启动加速度.Text = "确认";
            this.GB4_1_button_启动加速度.UseVisualStyleBackColor = true;
            this.GB4_1_button_启动加速度.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_1_comboBox_启动加速度
            // 
            this.GB4_1_comboBox_启动加速度.FormattingEnabled = true;
            this.GB4_1_comboBox_启动加速度.Items.AddRange(new object[] {
            "0",
            "8",
            "16",
            "32",
            "64",
            "128",
            "255"});
            this.GB4_1_comboBox_启动加速度.Location = new System.Drawing.Point(128, 39);
            this.GB4_1_comboBox_启动加速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_1_comboBox_启动加速度.Name = "GB4_1_comboBox_启动加速度";
            this.GB4_1_comboBox_启动加速度.Size = new System.Drawing.Size(124, 27);
            this.GB4_1_comboBox_启动加速度.TabIndex = 1;
            this.rangeTip.SetToolTip(this.GB4_1_comboBox_启动加速度, "0~255");
            // 
            // GB4_1_button_停止加速度
            // 
            this.GB4_1_button_停止加速度.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB4_1_button_停止加速度.Location = new System.Drawing.Point(269, 87);
            this.GB4_1_button_停止加速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_1_button_停止加速度.Name = "GB4_1_button_停止加速度";
            this.GB4_1_button_停止加速度.Size = new System.Drawing.Size(84, 29);
            this.GB4_1_button_停止加速度.TabIndex = 2;
            this.GB4_1_button_停止加速度.Tag = "29";
            this.GB4_1_button_停止加速度.Text = "确认";
            this.GB4_1_button_停止加速度.UseVisualStyleBackColor = true;
            this.GB4_1_button_停止加速度.Click += new System.EventHandler(this.Button_Click);
            // 
            // GB4_1_comboBox_停止加速度
            // 
            this.GB4_1_comboBox_停止加速度.FormattingEnabled = true;
            this.GB4_1_comboBox_停止加速度.Items.AddRange(new object[] {
            "0",
            "8",
            "16",
            "32",
            "64",
            "128",
            "255"});
            this.GB4_1_comboBox_停止加速度.Location = new System.Drawing.Point(128, 89);
            this.GB4_1_comboBox_停止加速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_1_comboBox_停止加速度.Name = "GB4_1_comboBox_停止加速度";
            this.GB4_1_comboBox_停止加速度.Size = new System.Drawing.Size(124, 27);
            this.GB4_1_comboBox_停止加速度.TabIndex = 3;
            this.rangeTip.SetToolTip(this.GB4_1_comboBox_停止加速度, "0~255");
            // 
            // GB4_1_label_启动加速度
            // 
            this.GB4_1_label_启动加速度.AutoSize = true;
            this.GB4_1_label_启动加速度.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB4_1_label_启动加速度.Location = new System.Drawing.Point(16, 42);
            this.GB4_1_label_启动加速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_1_label_启动加速度.Name = "GB4_1_label_启动加速度";
            this.GB4_1_label_启动加速度.Size = new System.Drawing.Size(104, 19);
            this.GB4_1_label_启动加速度.TabIndex = 5;
            this.GB4_1_label_启动加速度.Text = "启动加速度";
            // 
            // GB4_1_label_停止加速度
            // 
            this.GB4_1_label_停止加速度.AutoSize = true;
            this.GB4_1_label_停止加速度.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB4_1_label_停止加速度.Location = new System.Drawing.Point(16, 92);
            this.GB4_1_label_停止加速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_1_label_停止加速度.Name = "GB4_1_label_停止加速度";
            this.GB4_1_label_停止加速度.Size = new System.Drawing.Size(104, 19);
            this.GB4_1_label_停止加速度.TabIndex = 6;
            this.GB4_1_label_停止加速度.Text = "停止加速度";
            // 
            // GB4_groupBox2_电机状态监控
            // 
            this.GB4_groupBox2_电机状态监控.BackColor = System.Drawing.SystemColors.Control;
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_label_目标方向);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_label_目标速度);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_label_目标加速度);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_label_电机状态);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_textBox_目标方向);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_textBox_目标速度);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_textBox_目标加速度);
            this.GB4_groupBox2_电机状态监控.Controls.Add(this.GB4_2_textBox_电机状态);
            this.GB4_groupBox2_电机状态监控.Font = new System.Drawing.Font("宋体", 11F);
            this.GB4_groupBox2_电机状态监控.Location = new System.Drawing.Point(416, 35);
            this.GB4_groupBox2_电机状态监控.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox2_电机状态监控.Name = "GB4_groupBox2_电机状态监控";
            this.GB4_groupBox2_电机状态监控.Padding = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox2_电机状态监控.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GB4_groupBox2_电机状态监控.Size = new System.Drawing.Size(370, 235);
            this.GB4_groupBox2_电机状态监控.TabIndex = 3;
            this.GB4_groupBox2_电机状态监控.TabStop = false;
            this.GB4_groupBox2_电机状态监控.Text = "电机状态监控";
            // 
            // GB4_2_label_目标方向
            // 
            this.GB4_2_label_目标方向.AutoSize = true;
            this.GB4_2_label_目标方向.Location = new System.Drawing.Point(18, 40);
            this.GB4_2_label_目标方向.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_2_label_目标方向.Name = "GB4_2_label_目标方向";
            this.GB4_2_label_目标方向.Size = new System.Drawing.Size(85, 19);
            this.GB4_2_label_目标方向.TabIndex = 0;
            this.GB4_2_label_目标方向.Text = "目标方向";
            // 
            // GB4_2_label_目标速度
            // 
            this.GB4_2_label_目标速度.AutoSize = true;
            this.GB4_2_label_目标速度.Location = new System.Drawing.Point(18, 89);
            this.GB4_2_label_目标速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_2_label_目标速度.Name = "GB4_2_label_目标速度";
            this.GB4_2_label_目标速度.Size = new System.Drawing.Size(85, 19);
            this.GB4_2_label_目标速度.TabIndex = 1;
            this.GB4_2_label_目标速度.Text = "目标速度";
            // 
            // GB4_2_label_目标加速度
            // 
            this.GB4_2_label_目标加速度.AutoSize = true;
            this.GB4_2_label_目标加速度.Location = new System.Drawing.Point(18, 138);
            this.GB4_2_label_目标加速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_2_label_目标加速度.Name = "GB4_2_label_目标加速度";
            this.GB4_2_label_目标加速度.Size = new System.Drawing.Size(104, 19);
            this.GB4_2_label_目标加速度.TabIndex = 2;
            this.GB4_2_label_目标加速度.Text = "目标加速度";
            // 
            // GB4_2_label_电机状态
            // 
            this.GB4_2_label_电机状态.AutoSize = true;
            this.GB4_2_label_电机状态.Location = new System.Drawing.Point(18, 188);
            this.GB4_2_label_电机状态.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_2_label_电机状态.Name = "GB4_2_label_电机状态";
            this.GB4_2_label_电机状态.Size = new System.Drawing.Size(85, 19);
            this.GB4_2_label_电机状态.TabIndex = 3;
            this.GB4_2_label_电机状态.Text = "电机状态";
            // 
            // GB4_2_textBox_目标方向
            // 
            this.GB4_2_textBox_目标方向.BackColor = System.Drawing.SystemColors.Menu;
            this.GB4_2_textBox_目标方向.Location = new System.Drawing.Point(176, 37);
            this.GB4_2_textBox_目标方向.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_2_textBox_目标方向.Name = "GB4_2_textBox_目标方向";
            this.GB4_2_textBox_目标方向.ReadOnly = true;
            this.GB4_2_textBox_目标方向.Size = new System.Drawing.Size(175, 28);
            this.GB4_2_textBox_目标方向.TabIndex = 4;
            this.GB4_2_textBox_目标方向.Tag = "5";
            // 
            // GB4_2_textBox_目标速度
            // 
            this.GB4_2_textBox_目标速度.BackColor = System.Drawing.SystemColors.Menu;
            this.GB4_2_textBox_目标速度.Location = new System.Drawing.Point(176, 86);
            this.GB4_2_textBox_目标速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_2_textBox_目标速度.Name = "GB4_2_textBox_目标速度";
            this.GB4_2_textBox_目标速度.ReadOnly = true;
            this.GB4_2_textBox_目标速度.Size = new System.Drawing.Size(175, 28);
            this.GB4_2_textBox_目标速度.TabIndex = 5;
            this.GB4_2_textBox_目标速度.Tag = "5";
            // 
            // GB4_2_textBox_目标加速度
            // 
            this.GB4_2_textBox_目标加速度.BackColor = System.Drawing.SystemColors.Menu;
            this.GB4_2_textBox_目标加速度.Location = new System.Drawing.Point(176, 135);
            this.GB4_2_textBox_目标加速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_2_textBox_目标加速度.Name = "GB4_2_textBox_目标加速度";
            this.GB4_2_textBox_目标加速度.ReadOnly = true;
            this.GB4_2_textBox_目标加速度.Size = new System.Drawing.Size(175, 28);
            this.GB4_2_textBox_目标加速度.TabIndex = 6;
            this.GB4_2_textBox_目标加速度.Tag = "5";
            // 
            // GB4_2_textBox_电机状态
            // 
            this.GB4_2_textBox_电机状态.BackColor = System.Drawing.SystemColors.Menu;
            this.GB4_2_textBox_电机状态.Location = new System.Drawing.Point(176, 184);
            this.GB4_2_textBox_电机状态.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_2_textBox_电机状态.Name = "GB4_2_textBox_电机状态";
            this.GB4_2_textBox_电机状态.ReadOnly = true;
            this.GB4_2_textBox_电机状态.Size = new System.Drawing.Size(175, 28);
            this.GB4_2_textBox_电机状态.TabIndex = 7;
            this.GB4_2_textBox_电机状态.Tag = "5";
            // 
            // GB4_groupBox3_电机速度控制模式
            // 
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_panel_正转or反转);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_button_关闭上电自动运行);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_button_开启上电自动运行);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_button_停止);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_button_开始);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_comboBox_速度档位);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_label_提示);
            this.GB4_groupBox3_电机速度控制模式.Controls.Add(this.GB4_3_label_速度档位);
            this.GB4_groupBox3_电机速度控制模式.Location = new System.Drawing.Point(16, 295);
            this.GB4_groupBox3_电机速度控制模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox3_电机速度控制模式.Name = "GB4_groupBox3_电机速度控制模式";
            this.GB4_groupBox3_电机速度控制模式.Padding = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox3_电机速度控制模式.Size = new System.Drawing.Size(370, 286);
            this.GB4_groupBox3_电机速度控制模式.TabIndex = 4;
            this.GB4_groupBox3_电机速度控制模式.TabStop = false;
            this.GB4_groupBox3_电机速度控制模式.Text = "电机速度控制模式";
            // 
            // GB4_3_panel_正转or反转
            // 
            this.GB4_3_panel_正转or反转.Controls.Add(this.GB4_3_radioButton_反转);
            this.GB4_3_panel_正转or反转.Controls.Add(this.GB4_3_radioButton_正转);
            this.GB4_3_panel_正转or反转.Location = new System.Drawing.Point(50, 35);
            this.GB4_3_panel_正转or反转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_panel_正转or反转.Name = "GB4_3_panel_正转or反转";
            this.GB4_3_panel_正转or反转.Size = new System.Drawing.Size(300, 42);
            this.GB4_3_panel_正转or反转.TabIndex = 0;
            // 
            // GB4_3_radioButton_反转
            // 
            this.GB4_3_radioButton_反转.AutoSize = true;
            this.GB4_3_radioButton_反转.Location = new System.Drawing.Point(175, 11);
            this.GB4_3_radioButton_反转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_radioButton_反转.Name = "GB4_3_radioButton_反转";
            this.GB4_3_radioButton_反转.Size = new System.Drawing.Size(68, 23);
            this.GB4_3_radioButton_反转.TabIndex = 0;
            this.GB4_3_radioButton_反转.TabStop = true;
            this.GB4_3_radioButton_反转.Tag = "";
            this.GB4_3_radioButton_反转.Text = "反转";
            this.GB4_3_radioButton_反转.UseVisualStyleBackColor = true;
            // 
            // GB4_3_radioButton_正转
            // 
            this.GB4_3_radioButton_正转.AutoSize = true;
            this.GB4_3_radioButton_正转.Location = new System.Drawing.Point(17, 11);
            this.GB4_3_radioButton_正转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_radioButton_正转.Name = "GB4_3_radioButton_正转";
            this.GB4_3_radioButton_正转.Size = new System.Drawing.Size(68, 23);
            this.GB4_3_radioButton_正转.TabIndex = 1;
            this.GB4_3_radioButton_正转.TabStop = true;
            this.GB4_3_radioButton_正转.Tag = "";
            this.GB4_3_radioButton_正转.Text = "正转";
            this.GB4_3_radioButton_正转.UseVisualStyleBackColor = true;
            // 
            // GB4_3_comboBox_速度档位
            // 
            this.GB4_3_comboBox_速度档位.FormattingEnabled = true;
            this.GB4_3_comboBox_速度档位.Items.AddRange(new object[] {
            "1",
            "600",
            "1200",
            "1800",
            "2400",
            "3000"});
            this.GB4_3_comboBox_速度档位.Location = new System.Drawing.Point(176, 87);
            this.GB4_3_comboBox_速度档位.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_3_comboBox_速度档位.Name = "GB4_3_comboBox_速度档位";
            this.GB4_3_comboBox_速度档位.Size = new System.Drawing.Size(144, 26);
            this.GB4_3_comboBox_速度档位.TabIndex = 5;
            this.rangeTip.SetToolTip(this.GB4_3_comboBox_速度档位, "1-3000");
            // 
            // GB4_3_label_提示
            // 
            this.GB4_3_label_提示.AutoSize = true;
            this.GB4_3_label_提示.Font = new System.Drawing.Font("宋体", 9F);
            this.GB4_3_label_提示.Location = new System.Drawing.Point(52, 125);
            this.GB4_3_label_提示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_3_label_提示.Name = "GB4_3_label_提示";
            this.GB4_3_label_提示.Size = new System.Drawing.Size(190, 15);
            this.GB4_3_label_提示.TabIndex = 6;
            this.GB4_3_label_提示.Text = "提示：速度档位范围0-3000";
            // 
            // GB4_3_label_速度档位
            // 
            this.GB4_3_label_速度档位.AutoSize = true;
            this.GB4_3_label_速度档位.Location = new System.Drawing.Point(51, 90);
            this.GB4_3_label_速度档位.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_3_label_速度档位.Name = "GB4_3_label_速度档位";
            this.GB4_3_label_速度档位.Size = new System.Drawing.Size(85, 19);
            this.GB4_3_label_速度档位.TabIndex = 7;
            this.GB4_3_label_速度档位.Text = "速度档位";
            // 
            // GB4_groupBox4_电机位置控制模式
            // 
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_panel_正转or反转);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_button_停止);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_button_开始);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_label_提示);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_textBox_脉冲数);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_comboBox_速度档位);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_comboBox_模式切换);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_label_脉冲数);
            this.GB4_groupBox4_电机位置控制模式.Controls.Add(this.GB4_4_label_速度档位);
            this.GB4_groupBox4_电机位置控制模式.Location = new System.Drawing.Point(416, 295);
            this.GB4_groupBox4_电机位置控制模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox4_电机位置控制模式.Name = "GB4_groupBox4_电机位置控制模式";
            this.GB4_groupBox4_电机位置控制模式.Padding = new System.Windows.Forms.Padding(4);
            this.GB4_groupBox4_电机位置控制模式.Size = new System.Drawing.Size(370, 286);
            this.GB4_groupBox4_电机位置控制模式.TabIndex = 5;
            this.GB4_groupBox4_电机位置控制模式.TabStop = false;
            this.GB4_groupBox4_电机位置控制模式.Text = "电机位置控制模式";
            // 
            // GB4_4_panel_正转or反转
            // 
            this.GB4_4_panel_正转or反转.Controls.Add(this.GB4_4_radioButton_反转);
            this.GB4_4_panel_正转or反转.Controls.Add(this.GB4_4_radioButton_正转);
            this.GB4_4_panel_正转or反转.Location = new System.Drawing.Point(50, 35);
            this.GB4_4_panel_正转or反转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_panel_正转or反转.Name = "GB4_4_panel_正转or反转";
            this.GB4_4_panel_正转or反转.Size = new System.Drawing.Size(300, 42);
            this.GB4_4_panel_正转or反转.TabIndex = 0;
            // 
            // GB4_4_radioButton_反转
            // 
            this.GB4_4_radioButton_反转.AutoSize = true;
            this.GB4_4_radioButton_反转.Location = new System.Drawing.Point(175, 11);
            this.GB4_4_radioButton_反转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_radioButton_反转.Name = "GB4_4_radioButton_反转";
            this.GB4_4_radioButton_反转.Size = new System.Drawing.Size(68, 23);
            this.GB4_4_radioButton_反转.TabIndex = 0;
            this.GB4_4_radioButton_反转.TabStop = true;
            this.GB4_4_radioButton_反转.Tag = "";
            this.GB4_4_radioButton_反转.Text = "反转";
            this.GB4_4_radioButton_反转.UseVisualStyleBackColor = true;
            // 
            // GB4_4_radioButton_正转
            // 
            this.GB4_4_radioButton_正转.AutoSize = true;
            this.GB4_4_radioButton_正转.Location = new System.Drawing.Point(17, 11);
            this.GB4_4_radioButton_正转.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_radioButton_正转.Name = "GB4_4_radioButton_正转";
            this.GB4_4_radioButton_正转.Size = new System.Drawing.Size(68, 23);
            this.GB4_4_radioButton_正转.TabIndex = 1;
            this.GB4_4_radioButton_正转.TabStop = true;
            this.GB4_4_radioButton_正转.Tag = "";
            this.GB4_4_radioButton_正转.Text = "正转";
            this.GB4_4_radioButton_正转.UseVisualStyleBackColor = true;
            // 
            // GB4_4_label_提示
            // 
            this.GB4_4_label_提示.Font = new System.Drawing.Font("宋体", 9F);
            this.GB4_4_label_提示.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GB4_4_label_提示.Location = new System.Drawing.Point(22, 186);
            this.GB4_4_label_提示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_4_label_提示.Name = "GB4_4_label_提示";
            this.GB4_4_label_提示.Size = new System.Drawing.Size(320, 50);
            this.GB4_4_label_提示.TabIndex = 3;
            this.GB4_4_label_提示.Text = "提示1：在16细分时，3200脉冲 = 360°。\n提示2：坐标取值范围为 -2147483647到2147483647 或 0x00到0xFFFFFFFF。";
            // 
            // GB4_4_textBox_脉冲数
            // 
            this.GB4_4_textBox_脉冲数.Location = new System.Drawing.Point(180, 144);
            this.GB4_4_textBox_脉冲数.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_textBox_脉冲数.MaxLength = 65535;
            this.GB4_4_textBox_脉冲数.Name = "GB4_4_textBox_脉冲数";
            this.GB4_4_textBox_脉冲数.Size = new System.Drawing.Size(140, 28);
            this.GB4_4_textBox_脉冲数.TabIndex = 4;
            this.rangeTip.SetToolTip(this.GB4_4_textBox_脉冲数, "-2147483647~+2147483647 or 0x00~0xFFFFFFFF");
            // 
            // GB4_4_comboBox_速度档位
            // 
            this.GB4_4_comboBox_速度档位.FormattingEnabled = true;
            this.GB4_4_comboBox_速度档位.Items.AddRange(new object[] {
            "1",
            "600",
            "1200",
            "1800",
            "2400",
            "3000"});
            this.GB4_4_comboBox_速度档位.Location = new System.Drawing.Point(180, 99);
            this.GB4_4_comboBox_速度档位.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_comboBox_速度档位.Name = "GB4_4_comboBox_速度档位";
            this.GB4_4_comboBox_速度档位.Size = new System.Drawing.Size(140, 26);
            this.GB4_4_comboBox_速度档位.TabIndex = 5;
            this.rangeTip.SetToolTip(this.GB4_4_comboBox_速度档位, "1-3000");
            // 
            // GB4_4_comboBox_模式切换
            // 
            this.GB4_4_comboBox_模式切换.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB4_4_comboBox_模式切换.FormattingEnabled = true;
            this.GB4_4_comboBox_模式切换.Items.AddRange(new object[] {
            "RelPulses",
            "AbsPulses",
            "RelAxis",
            "AbsAxis"});
            this.GB4_4_comboBox_模式切换.Location = new System.Drawing.Point(54, 145);
            this.GB4_4_comboBox_模式切换.Margin = new System.Windows.Forms.Padding(4);
            this.GB4_4_comboBox_模式切换.Name = "GB4_4_comboBox_模式切换";
            this.GB4_4_comboBox_模式切换.Size = new System.Drawing.Size(115, 26);
            this.GB4_4_comboBox_模式切换.TabIndex = 6;
            // 
            // GB4_4_label_脉冲数
            // 
            this.GB4_4_label_脉冲数.AutoSize = true;
            this.GB4_4_label_脉冲数.Location = new System.Drawing.Point(54, 147);
            this.GB4_4_label_脉冲数.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_4_label_脉冲数.Name = "GB4_4_label_脉冲数";
            this.GB4_4_label_脉冲数.Size = new System.Drawing.Size(66, 19);
            this.GB4_4_label_脉冲数.TabIndex = 7;
            this.GB4_4_label_脉冲数.Text = "脉冲数";
            // 
            // GB4_4_label_速度档位
            // 
            this.GB4_4_label_速度档位.AutoSize = true;
            this.GB4_4_label_速度档位.Location = new System.Drawing.Point(54, 102);
            this.GB4_4_label_速度档位.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_4_label_速度档位.Name = "GB4_4_label_速度档位";
            this.GB4_4_label_速度档位.Size = new System.Drawing.Size(85, 19);
            this.GB4_4_label_速度档位.TabIndex = 8;
            this.GB4_4_label_速度档位.Text = "速度档位";
            // 
            // GB4_1_label_注意
            // 
            this.GB4_1_label_注意.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GB4_1_label_注意.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB4_1_label_注意.Location = new System.Drawing.Point(17, 40);
            this.GB4_1_label_注意.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB4_1_label_注意.Name = "GB4_1_label_注意";
            this.GB4_1_label_注意.Size = new System.Drawing.Size(336, 63);
            this.GB4_1_label_注意.TabIndex = 4;
            this.GB4_1_label_注意.Text = "注意:请仔细阅读使用说明书中的加速度参数相关说明后再进行修改。\r\n";
            // 
            // F1_textBox_图片背景
            // 
            this.F1_textBox_图片背景.BackColor = System.Drawing.Color.White;
            this.F1_textBox_图片背景.Enabled = false;
            this.F1_textBox_图片背景.Location = new System.Drawing.Point(354, 42);
            this.F1_textBox_图片背景.Margin = new System.Windows.Forms.Padding(4);
            this.F1_textBox_图片背景.Multiline = true;
            this.F1_textBox_图片背景.Name = "F1_textBox_图片背景";
            this.F1_textBox_图片背景.Size = new System.Drawing.Size(425, 211);
            this.F1_textBox_图片背景.TabIndex = 4;
            this.F1_textBox_图片背景.TabStop = false;
            // 
            // F1_pictureBox_图片2
            // 
            this.F1_pictureBox_图片2.BackColor = System.Drawing.Color.White;
            this.F1_pictureBox_图片2.Image = ((System.Drawing.Image)(resources.GetObject("F1_pictureBox_图片2.Image")));
            this.F1_pictureBox_图片2.Location = new System.Drawing.Point(569, 85);
            this.F1_pictureBox_图片2.Margin = new System.Windows.Forms.Padding(4);
            this.F1_pictureBox_图片2.Name = "F1_pictureBox_图片2";
            this.F1_pictureBox_图片2.Size = new System.Drawing.Size(165, 165);
            this.F1_pictureBox_图片2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F1_pictureBox_图片2.TabIndex = 2;
            this.F1_pictureBox_图片2.TabStop = false;
            // 
            // F1_pictureBox_图片1
            // 
            this.F1_pictureBox_图片1.BackColor = System.Drawing.Color.White;
            this.F1_pictureBox_图片1.Image = global::MKS_ServoD_Control.Properties.Resources.Makerbase;
            this.F1_pictureBox_图片1.Location = new System.Drawing.Point(385, 55);
            this.F1_pictureBox_图片1.Margin = new System.Windows.Forms.Padding(4);
            this.F1_pictureBox_图片1.Name = "F1_pictureBox_图片1";
            this.F1_pictureBox_图片1.Size = new System.Drawing.Size(363, 41);
            this.F1_pictureBox_图片1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F1_pictureBox_图片1.TabIndex = 1;
            this.F1_pictureBox_图片1.TabStop = false;
            // 
            // F1_pictureBox_图片3
            // 
            this.F1_pictureBox_图片3.BackColor = System.Drawing.Color.White;
            this.F1_pictureBox_图片3.Image = global::MKS_ServoD_Control.Properties.Resources._42D;
            this.F1_pictureBox_图片3.Location = new System.Drawing.Point(392, 88);
            this.F1_pictureBox_图片3.Margin = new System.Windows.Forms.Padding(4);
            this.F1_pictureBox_图片3.Name = "F1_pictureBox_图片3";
            this.F1_pictureBox_图片3.Size = new System.Drawing.Size(156, 157);
            this.F1_pictureBox_图片3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F1_pictureBox_图片3.TabIndex = 3;
            this.F1_pictureBox_图片3.TabStop = false;
            // 
            // F1_menuStrip_语言切换菜单
            // 
            this.F1_menuStrip_语言切换菜单.BackColor = System.Drawing.SystemColors.Control;
            this.F1_menuStrip_语言切换菜单.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.F1_menuStrip_语言切换菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言ToolStripMenuItem});
            this.F1_menuStrip_语言切换菜单.Location = new System.Drawing.Point(0, 0);
            this.F1_menuStrip_语言切换菜单.Name = "F1_menuStrip_语言切换菜单";
            this.F1_menuStrip_语言切换菜单.Size = new System.Drawing.Size(1924, 28);
            this.F1_menuStrip_语言切换菜单.TabIndex = 0;
            this.F1_menuStrip_语言切换菜单.Text = "F1_menuStrip_语言切换菜单";
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click_1);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // F1_groupBox5_设置限位参数
            // 
            this.F1_groupBox5_设置限位参数.BackColor = System.Drawing.SystemColors.Control;
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_单圈回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_回零模式);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_设置零点);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_回零速度);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_回零方向);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_回零模式);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_设置零点);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_回零速度);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_回零方向);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_单圈回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_IN1);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_IN2);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_OUT1);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_OUT2);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_textBox_IN1);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_textBox_IN2);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_textBox_OUT1);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_textBox_OUT2);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_限位回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_触发电平);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_归零方向);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_归零速度);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_归零使能);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_触发电平);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_归零速度);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_限位参数);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_归零方向);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_归零使能);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_读取IO端口);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_限位归零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_直接归零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_无限位回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_无限位返回距离);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_无限位回零模式);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_无限位回零电流);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_限位重映射);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_EN回零与位置保护);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_EN回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_位置保护);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_触发时间);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_触发距离);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_OUT2写入);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_label_OUT1写入);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_无限位返回距离);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_无限位回零模式);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_无限位回零电流);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_限位重映射);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_EN回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_位置保护);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_触发时间);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_触发距离);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_OUT2写入);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_comboBox_OUT1写入);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_无限位回零);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_限位重映射);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_EN回零与位置保护);
            this.F1_groupBox5_设置限位参数.Controls.Add(this.GB5_button_写IO端口);
            this.F1_groupBox5_设置限位参数.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox5_设置限位参数.Location = new System.Drawing.Point(806, 130);
            this.F1_groupBox5_设置限位参数.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox5_设置限位参数.Name = "F1_groupBox5_设置限位参数";
            this.F1_groupBox5_设置限位参数.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox5_设置限位参数.Size = new System.Drawing.Size(1106, 300);
            this.F1_groupBox5_设置限位参数.TabIndex = 11;
            this.F1_groupBox5_设置限位参数.TabStop = false;
            this.F1_groupBox5_设置限位参数.Text = "设置限位参数";
            // 
            // GB5_label_回零模式
            // 
            this.GB5_label_回零模式.AutoSize = true;
            this.GB5_label_回零模式.Location = new System.Drawing.Point(123, 35);
            this.GB5_label_回零模式.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_回零模式.Name = "GB5_label_回零模式";
            this.GB5_label_回零模式.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_回零模式.TabIndex = 1;
            this.GB5_label_回零模式.Text = "回零模式";
            // 
            // GB5_label_设置零点
            // 
            this.GB5_label_设置零点.AutoSize = true;
            this.GB5_label_设置零点.Location = new System.Drawing.Point(247, 35);
            this.GB5_label_设置零点.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_设置零点.Name = "GB5_label_设置零点";
            this.GB5_label_设置零点.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_设置零点.TabIndex = 2;
            this.GB5_label_设置零点.Text = "设置零点";
            // 
            // GB5_label_回零速度
            // 
            this.GB5_label_回零速度.AutoSize = true;
            this.GB5_label_回零速度.Location = new System.Drawing.Point(371, 35);
            this.GB5_label_回零速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_回零速度.Name = "GB5_label_回零速度";
            this.GB5_label_回零速度.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_回零速度.TabIndex = 3;
            this.GB5_label_回零速度.Text = "回零速度";
            // 
            // GB5_label_回零方向
            // 
            this.GB5_label_回零方向.AutoSize = true;
            this.GB5_label_回零方向.Location = new System.Drawing.Point(495, 35);
            this.GB5_label_回零方向.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_回零方向.Name = "GB5_label_回零方向";
            this.GB5_label_回零方向.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_回零方向.TabIndex = 4;
            this.GB5_label_回零方向.Text = "回零方向";
            // 
            // GB5_comboBox_回零模式
            // 
            this.GB5_comboBox_回零模式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_回零模式.FormattingEnabled = true;
            this.GB5_comboBox_回零模式.Items.AddRange(new object[] {
            "Disable",
            "DirMode",
            "NearMode"});
            this.GB5_comboBox_回零模式.Location = new System.Drawing.Point(127, 58);
            this.GB5_comboBox_回零模式.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_回零模式.Name = "GB5_comboBox_回零模式";
            this.GB5_comboBox_回零模式.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_回零模式.TabIndex = 5;
            // 
            // GB5_comboBox_设置零点
            // 
            this.GB5_comboBox_设置零点.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_设置零点.FormattingEnabled = true;
            this.GB5_comboBox_设置零点.Items.AddRange(new object[] {
            "Clear 0",
            "Set 0",
            "Hold 0"});
            this.GB5_comboBox_设置零点.Location = new System.Drawing.Point(251, 58);
            this.GB5_comboBox_设置零点.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_设置零点.Name = "GB5_comboBox_设置零点";
            this.GB5_comboBox_设置零点.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_设置零点.TabIndex = 6;
            // 
            // GB5_comboBox_回零速度
            // 
            this.GB5_comboBox_回零速度.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_回零速度.FormattingEnabled = true;
            this.GB5_comboBox_回零速度.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.GB5_comboBox_回零速度.Location = new System.Drawing.Point(375, 58);
            this.GB5_comboBox_回零速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_回零速度.Name = "GB5_comboBox_回零速度";
            this.GB5_comboBox_回零速度.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_回零速度.TabIndex = 7;
            // 
            // GB5_comboBox_回零方向
            // 
            this.GB5_comboBox_回零方向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_回零方向.FormattingEnabled = true;
            this.GB5_comboBox_回零方向.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.GB5_comboBox_回零方向.Location = new System.Drawing.Point(499, 58);
            this.GB5_comboBox_回零方向.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_回零方向.Name = "GB5_comboBox_回零方向";
            this.GB5_comboBox_回零方向.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_回零方向.TabIndex = 8;
            // 
            // GB5_label_IN1
            // 
            this.GB5_label_IN1.AutoSize = true;
            this.GB5_label_IN1.Location = new System.Drawing.Point(759, 36);
            this.GB5_label_IN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_IN1.Name = "GB5_label_IN1";
            this.GB5_label_IN1.Size = new System.Drawing.Size(39, 19);
            this.GB5_label_IN1.TabIndex = 10;
            this.GB5_label_IN1.Text = "IN1";
            // 
            // GB5_label_IN2
            // 
            this.GB5_label_IN2.AutoSize = true;
            this.GB5_label_IN2.Location = new System.Drawing.Point(803, 36);
            this.GB5_label_IN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_IN2.Name = "GB5_label_IN2";
            this.GB5_label_IN2.Size = new System.Drawing.Size(39, 19);
            this.GB5_label_IN2.TabIndex = 11;
            this.GB5_label_IN2.Text = "IN2";
            // 
            // GB5_label_OUT1
            // 
            this.GB5_label_OUT1.AutoSize = true;
            this.GB5_label_OUT1.Location = new System.Drawing.Point(847, 36);
            this.GB5_label_OUT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_OUT1.Name = "GB5_label_OUT1";
            this.GB5_label_OUT1.Size = new System.Drawing.Size(49, 19);
            this.GB5_label_OUT1.TabIndex = 12;
            this.GB5_label_OUT1.Text = "OUT1";
            // 
            // GB5_label_OUT2
            // 
            this.GB5_label_OUT2.AutoSize = true;
            this.GB5_label_OUT2.Location = new System.Drawing.Point(895, 36);
            this.GB5_label_OUT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_OUT2.Name = "GB5_label_OUT2";
            this.GB5_label_OUT2.Size = new System.Drawing.Size(49, 19);
            this.GB5_label_OUT2.TabIndex = 13;
            this.GB5_label_OUT2.Text = "OUT2";
            // 
            // GB5_textBox_IN1
            // 
            this.GB5_textBox_IN1.BackColor = System.Drawing.SystemColors.Menu;
            this.GB5_textBox_IN1.Location = new System.Drawing.Point(763, 56);
            this.GB5_textBox_IN1.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_textBox_IN1.Name = "GB5_textBox_IN1";
            this.GB5_textBox_IN1.ReadOnly = true;
            this.GB5_textBox_IN1.Size = new System.Drawing.Size(45, 28);
            this.GB5_textBox_IN1.TabIndex = 14;
            this.GB5_textBox_IN1.Tag = "5";
            // 
            // GB5_textBox_IN2
            // 
            this.GB5_textBox_IN2.BackColor = System.Drawing.SystemColors.Menu;
            this.GB5_textBox_IN2.Location = new System.Drawing.Point(807, 56);
            this.GB5_textBox_IN2.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_textBox_IN2.Name = "GB5_textBox_IN2";
            this.GB5_textBox_IN2.ReadOnly = true;
            this.GB5_textBox_IN2.Size = new System.Drawing.Size(45, 28);
            this.GB5_textBox_IN2.TabIndex = 15;
            this.GB5_textBox_IN2.Tag = "5";
            // 
            // GB5_textBox_OUT1
            // 
            this.GB5_textBox_OUT1.BackColor = System.Drawing.SystemColors.Menu;
            this.GB5_textBox_OUT1.Location = new System.Drawing.Point(851, 56);
            this.GB5_textBox_OUT1.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_textBox_OUT1.Name = "GB5_textBox_OUT1";
            this.GB5_textBox_OUT1.ReadOnly = true;
            this.GB5_textBox_OUT1.Size = new System.Drawing.Size(45, 28);
            this.GB5_textBox_OUT1.TabIndex = 16;
            this.GB5_textBox_OUT1.Tag = "5";
            // 
            // GB5_textBox_OUT2
            // 
            this.GB5_textBox_OUT2.BackColor = System.Drawing.SystemColors.Menu;
            this.GB5_textBox_OUT2.Location = new System.Drawing.Point(895, 56);
            this.GB5_textBox_OUT2.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_textBox_OUT2.Name = "GB5_textBox_OUT2";
            this.GB5_textBox_OUT2.ReadOnly = true;
            this.GB5_textBox_OUT2.Size = new System.Drawing.Size(45, 28);
            this.GB5_textBox_OUT2.TabIndex = 17;
            this.GB5_textBox_OUT2.Tag = "5";
            // 
            // GB5_label_触发电平
            // 
            this.GB5_label_触发电平.AutoSize = true;
            this.GB5_label_触发电平.Location = new System.Drawing.Point(123, 101);
            this.GB5_label_触发电平.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_触发电平.Name = "GB5_label_触发电平";
            this.GB5_label_触发电平.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_触发电平.TabIndex = 19;
            this.GB5_label_触发电平.Text = "触发电平";
            // 
            // GB5_label_归零方向
            // 
            this.GB5_label_归零方向.AutoSize = true;
            this.GB5_label_归零方向.Location = new System.Drawing.Point(247, 101);
            this.GB5_label_归零方向.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_归零方向.Name = "GB5_label_归零方向";
            this.GB5_label_归零方向.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_归零方向.TabIndex = 20;
            this.GB5_label_归零方向.Text = "归零方向";
            // 
            // GB5_label_归零速度
            // 
            this.GB5_label_归零速度.AutoSize = true;
            this.GB5_label_归零速度.Location = new System.Drawing.Point(371, 101);
            this.GB5_label_归零速度.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_归零速度.Name = "GB5_label_归零速度";
            this.GB5_label_归零速度.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_归零速度.TabIndex = 21;
            this.GB5_label_归零速度.Text = "归零速度";
            // 
            // GB5_label_归零使能
            // 
            this.GB5_label_归零使能.AutoSize = true;
            this.GB5_label_归零使能.Location = new System.Drawing.Point(495, 101);
            this.GB5_label_归零使能.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GB5_label_归零使能.Name = "GB5_label_归零使能";
            this.GB5_label_归零使能.Size = new System.Drawing.Size(85, 19);
            this.GB5_label_归零使能.TabIndex = 22;
            this.GB5_label_归零使能.Text = "归零使能";
            // 
            // GB5_comboBox_触发电平
            // 
            this.GB5_comboBox_触发电平.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_触发电平.FormattingEnabled = true;
            this.GB5_comboBox_触发电平.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.GB5_comboBox_触发电平.Location = new System.Drawing.Point(127, 124);
            this.GB5_comboBox_触发电平.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_触发电平.Name = "GB5_comboBox_触发电平";
            this.GB5_comboBox_触发电平.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_触发电平.TabIndex = 23;
            // 
            // GB5_comboBox_归零速度
            // 
            this.GB5_comboBox_归零速度.FormattingEnabled = true;
            this.GB5_comboBox_归零速度.Items.AddRange(new object[] {
            "1",
            "600",
            "1200",
            "1800",
            "2400",
            "3000"});
            this.GB5_comboBox_归零速度.Location = new System.Drawing.Point(375, 124);
            this.GB5_comboBox_归零速度.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_归零速度.Name = "GB5_comboBox_归零速度";
            this.GB5_comboBox_归零速度.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_归零速度.TabIndex = 24;
            this.rangeTip.SetToolTip(this.GB5_comboBox_归零速度, "1~3000");
            // 
            // GB5_comboBox_归零方向
            // 
            this.GB5_comboBox_归零方向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_归零方向.FormattingEnabled = true;
            this.GB5_comboBox_归零方向.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.GB5_comboBox_归零方向.Location = new System.Drawing.Point(251, 124);
            this.GB5_comboBox_归零方向.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_归零方向.Name = "GB5_comboBox_归零方向";
            this.GB5_comboBox_归零方向.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_归零方向.TabIndex = 26;
            // 
            // GB5_comboBox_归零使能
            // 
            this.GB5_comboBox_归零使能.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GB5_comboBox_归零使能.FormattingEnabled = true;
            this.GB5_comboBox_归零使能.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.GB5_comboBox_归零使能.Location = new System.Drawing.Point(499, 124);
            this.GB5_comboBox_归零使能.Margin = new System.Windows.Forms.Padding(4);
            this.GB5_comboBox_归零使能.Name = "GB5_comboBox_归零使能";
            this.GB5_comboBox_归零使能.Size = new System.Drawing.Size(115, 26);
            this.GB5_comboBox_归零使能.TabIndex = 27;
            // 
            // F1_groupBox6_数据日志
            // 
            this.F1_groupBox6_数据日志.BackColor = System.Drawing.SystemColors.Control;
            this.F1_groupBox6_数据日志.Controls.Add(this.GB6_textBox_数据日志);
            this.F1_groupBox6_数据日志.Font = new System.Drawing.Font("宋体", 11F);
            this.F1_groupBox6_数据日志.Location = new System.Drawing.Point(1627, 447);
            this.F1_groupBox6_数据日志.Margin = new System.Windows.Forms.Padding(4);
            this.F1_groupBox6_数据日志.Name = "F1_groupBox6_数据日志";
            this.F1_groupBox6_数据日志.Padding = new System.Windows.Forms.Padding(4);
            this.F1_groupBox6_数据日志.Size = new System.Drawing.Size(285, 595);
            this.F1_groupBox6_数据日志.TabIndex = 12;
            this.F1_groupBox6_数据日志.TabStop = false;
            this.F1_groupBox6_数据日志.Text = "数据日志";
            // 
            // GB6_textBox_数据日志
            // 
            this.GB6_textBox_数据日志.BackColor = System.Drawing.SystemColors.Menu;
            this.GB6_textBox_数据日志.Font = new System.Drawing.Font("宋体", 10F);
            this.GB6_textBox_数据日志.Location = new System.Drawing.Point(8, 26);
            this.GB6_textBox_数据日志.Margin = new System.Windows.Forms.Padding(4);
            this.GB6_textBox_数据日志.Multiline = true;
            this.GB6_textBox_数据日志.Name = "GB6_textBox_数据日志";
            this.GB6_textBox_数据日志.ReadOnly = true;
            this.GB6_textBox_数据日志.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GB6_textBox_数据日志.Size = new System.Drawing.Size(269, 558);
            this.GB6_textBox_数据日志.TabIndex = 0;
            this.GB6_textBox_数据日志.Tag = "1";
            // 
            // F1_label_注意
            // 
            this.F1_label_注意.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.F1_label_注意.Location = new System.Drawing.Point(941, 100);
            this.F1_label_注意.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.F1_label_注意.Name = "F1_label_注意";
            this.F1_label_注意.Size = new System.Drawing.Size(415, 37);
            this.F1_label_注意.TabIndex = 6;
            this.F1_label_注意.Text = "注意：点击“恢复出厂设置”后需要重新校准。";
            this.F1_label_注意.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // F1_label_提示
            // 
            this.F1_label_提示.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.F1_label_提示.Location = new System.Drawing.Point(1376, 100);
            this.F1_label_提示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.F1_label_提示.Name = "F1_label_提示";
            this.F1_label_提示.Size = new System.Drawing.Size(365, 38);
            this.F1_label_提示.TabIndex = 7;
            this.F1_label_提示.Text = "提示：鼠标停留在按键上可获取功能码（Code），可在说明书内获取更详细的说明。";
            this.F1_label_提示.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tipTip
            // 
            this.tipTip.AutoPopDelay = 5000;
            this.tipTip.InitialDelay = 0;
            this.tipTip.ReshowDelay = 0;
            this.tipTip.ToolTipTitle = "Tip:";
            // 
            // rangeTip
            // 
            this.rangeTip.AutoPopDelay = 5000;
            this.rangeTip.InitialDelay = 0;
            this.rangeTip.ReshowDelay = 0;
            this.rangeTip.ToolTipTitle = "Range:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.F1_menuStrip_语言切换菜单);
            this.Controls.Add(this.F1_pictureBox_图片1);
            this.Controls.Add(this.F1_pictureBox_图片2);
            this.Controls.Add(this.F1_pictureBox_图片3);
            this.Controls.Add(this.F1_textBox_图片背景);
            this.Controls.Add(this.F1_button_恢复出厂配置);
            this.Controls.Add(this.F1_button_复位重启电机);
            this.Controls.Add(this.F1_label_注意);
            this.Controls.Add(this.F1_label_提示);
            this.Controls.Add(this.F1_groupBox1_连接设置);
            this.Controls.Add(this.F1_groupBox2_读取参数);
            this.Controls.Add(this.F1_groupBox3_设置系统参数);
            this.Controls.Add(this.F1_groupBox4_电机控制);
            this.Controls.Add(this.F1_groupBox5_设置限位参数);
            this.Controls.Add(this.F1_groupBox6_数据日志);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.F1_menuStrip_语言切换菜单;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MKS ServoD Control V1.0.6.2";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.F1_groupBox1_连接设置.ResumeLayout(false);
            this.F1_groupBox1_连接设置.PerformLayout();
            this.F1_groupBox2_读取参数.ResumeLayout(false);
            this.F1_groupBox2_读取参数.PerformLayout();
            this.GB2_panel_十六or十进制.ResumeLayout(false);
            this.GB2_panel_十六or十进制.PerformLayout();
            this.F1_groupBox3_设置系统参数.ResumeLayout(false);
            this.F1_groupBox3_设置系统参数.PerformLayout();
            this.F1_groupBox4_电机控制.ResumeLayout(false);
            this.GB4_groupBox1_加速度参数.ResumeLayout(false);
            this.GB4_groupBox1_加速度参数.PerformLayout();
            this.GB4_groupBox2_电机状态监控.ResumeLayout(false);
            this.GB4_groupBox2_电机状态监控.PerformLayout();
            this.GB4_groupBox3_电机速度控制模式.ResumeLayout(false);
            this.GB4_groupBox3_电机速度控制模式.PerformLayout();
            this.GB4_3_panel_正转or反转.ResumeLayout(false);
            this.GB4_3_panel_正转or反转.PerformLayout();
            this.GB4_groupBox4_电机位置控制模式.ResumeLayout(false);
            this.GB4_groupBox4_电机位置控制模式.PerformLayout();
            this.GB4_4_panel_正转or反转.ResumeLayout(false);
            this.GB4_4_panel_正转or反转.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1_pictureBox_图片3)).EndInit();
            this.F1_menuStrip_语言切换菜单.ResumeLayout(false);
            this.F1_menuStrip_语言切换菜单.PerformLayout();
            this.F1_groupBox5_设置限位参数.ResumeLayout(false);
            this.F1_groupBox5_设置限位参数.PerformLayout();
            this.F1_groupBox6_数据日志.ResumeLayout(false);
            this.F1_groupBox6_数据日志.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolTip codeTip;
        private System.Windows.Forms.ToolTip rangeTip;
        private System.Windows.Forms.ToolTip tipTip;
        private System.Windows.Forms.TextBox F1_textBox_图片背景;
        private System.Windows.Forms.PictureBox F1_pictureBox_图片1;
        private System.Windows.Forms.PictureBox F1_pictureBox_图片2;
        private System.Windows.Forms.PictureBox F1_pictureBox_图片3;
        private System.Windows.Forms.MenuStrip F1_menuStrip_语言切换菜单;
        private System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label F1_label_注意;
        private System.Windows.Forms.Label F1_label_提示;
        private System.Windows.Forms.Button F1_button_恢复出厂配置;
        private System.Windows.Forms.Button F1_button_复位重启电机;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox1_连接设置;

        private System.Windows.Forms.Label GB1_label_串口;
        private System.Windows.Forms.Label GB1_label_波特率;
        private System.Windows.Forms.Label GB1_label_通讯地址;

        private System.Windows.Forms.Button GB1_button_扫描;
        private System.Windows.Forms.Button GB1_button_连接主板;
        private System.Windows.Forms.Button GB1_button_断开连接;

        private System.Windows.Forms.ComboBox GB1_comboBox_串口;
        private System.Windows.Forms.ComboBox GB1_comboBox_波特率;
        private System.Windows.Forms.ComboBox GB1_comboBox_通讯地址;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox2_读取参数;

        private System.Windows.Forms.Panel GB2_panel_十六or十进制;
        private System.Windows.Forms.RadioButton GB2_radioButton_十进制;
        private System.Windows.Forms.RadioButton GB2_radioButton_十六进制;

        private System.Windows.Forms.TextBox GB2_textBox_堵转状态;
        private System.Windows.Forms.TextBox GB2_textBox_回零状态;
        private System.Windows.Forms.TextBox GB2_textBox_使能状态;
        private System.Windows.Forms.TextBox GB2_textBox_误差值;
        private System.Windows.Forms.TextBox GB2_textBox_脉冲数值;
        private System.Windows.Forms.TextBox GB2_textBox_当前转速;
        private System.Windows.Forms.TextBox GB2_textBox_编码器值;

        private System.Windows.Forms.Button GB2_button_解除堵转;
        private System.Windows.Forms.Button GB2_button_堵转标志位;
        private System.Windows.Forms.Button GB2_button_回零状态;
        private System.Windows.Forms.Button GB2_button_使能状态;
        private System.Windows.Forms.Button GB2_button_位置角度误差;
        private System.Windows.Forms.Button GB2_button_累计脉冲数;
        private System.Windows.Forms.Button GB2_button_电机当前转速;
        private System.Windows.Forms.Button GB2_button_读编码值;
        private System.Windows.Forms.Button GB2_button_进位编码值;
        private System.Windows.Forms.Button GB2_button_版本信息;
        private System.Windows.Forms.Button GB2_button_读取所有参数;

        private System.Windows.Forms.ComboBox GB2_comboBox_读编码值;

        private System.Windows.Forms.CheckBox GB2_checkbox_跟踪模式;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox3_设置系统参数;

        private System.Windows.Forms.Label GB3_label_细分设置;
        private System.Windows.Forms.Label GB3_label_工作模式;
        private System.Windows.Forms.Label GB3_label_电流值;
        private System.Windows.Forms.Label GB3_label_通讯地址;
        private System.Windows.Forms.Label GB3_label_串口波特率;
        private System.Windows.Forms.Label GB3_label_细分插补;
        private System.Windows.Forms.Label GB3_label_堵转保护;
        private System.Windows.Forms.Label GB3_label_自动熄屏;
        private System.Windows.Forms.Label GB3_label_电机方向;
        private System.Windows.Forms.Label GB3_label_使能设置;
        private System.Windows.Forms.Label GB3_label_从机分组;
        private System.Windows.Forms.Label GB3_label_从机应答;
        private System.Windows.Forms.Label GB3_label_保持电流;
        private System.Windows.Forms.Label GB3_label_按键锁定;

        private System.Windows.Forms.ComboBox GB3_comboBox_细分设置;
        private System.Windows.Forms.ComboBox GB3_comboBox_工作模式;
        private System.Windows.Forms.ComboBox GB3_comboBox_电流值;
        private System.Windows.Forms.ComboBox GB3_comboBox_通讯地址;
        private System.Windows.Forms.ComboBox GB3_comboBox_串口波特率;
        private System.Windows.Forms.ComboBox GB3_comboBox_细分插补;
        private System.Windows.Forms.ComboBox GB3_comboBox_堵转保护;
        private System.Windows.Forms.ComboBox GB3_comboBox_自动熄屏;
        private System.Windows.Forms.ComboBox GB3_comboBox_电机方向;
        private System.Windows.Forms.ComboBox GB3_comboBox_使能设置;
        private System.Windows.Forms.ComboBox GB3_comboBox_从机应答;
        private System.Windows.Forms.ComboBox GB3_comboBox_从机分组;
        private System.Windows.Forms.ComboBox GB3_comboBox_保持电流;
        private System.Windows.Forms.ComboBox GB3_comboBox_按键锁定;

        private System.Windows.Forms.Button GB3_button_校准编码器;
        private System.Windows.Forms.Button GB3_button_通讯地址;
        private System.Windows.Forms.Button GB3_button_串口波特率;
        private System.Windows.Forms.Button GB3_button_细分插补;
        private System.Windows.Forms.Button GB3_button_堵转保护;
        private System.Windows.Forms.Button GB3_button_自动熄屏;
        private System.Windows.Forms.Button GB3_button_电机方向;
        private System.Windows.Forms.Button GB3_button_使能设置;
        private System.Windows.Forms.Button GB3_button_电流值;
        private System.Windows.Forms.Button GB3_button_工作模式;
        private System.Windows.Forms.Button GB3_button_细分设置;
        private System.Windows.Forms.Button GB3_button_从机应答;
        private System.Windows.Forms.Button GB3_button_从机分组;
        private System.Windows.Forms.Button GB3_button_保持电流;
        private System.Windows.Forms.Button GB3_button_按键锁定;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox4_电机控制;

        private System.Windows.Forms.Button GB4_button_使能驱动板;
        private System.Windows.Forms.Button GB4_button_关闭驱动板;
        private System.Windows.Forms.Button GB4_button_紧急停止;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox GB4_groupBox1_加速度参数;

        private System.Windows.Forms.Label GB4_1_label_启动加速度;
        private System.Windows.Forms.Label GB4_1_label_停止加速度;
        private System.Windows.Forms.Label GB4_1_label_注意;

        private System.Windows.Forms.ComboBox GB4_1_comboBox_启动加速度;
        private System.Windows.Forms.ComboBox GB4_1_comboBox_停止加速度;

        private System.Windows.Forms.Button GB4_1_button_启动加速度;
        private System.Windows.Forms.Button GB4_1_button_停止加速度;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox GB4_groupBox2_电机状态监控;

        private System.Windows.Forms.Label GB4_2_label_目标方向;
        private System.Windows.Forms.Label GB4_2_label_目标速度;
        private System.Windows.Forms.Label GB4_2_label_目标加速度;
        private System.Windows.Forms.Label GB4_2_label_电机状态;

        private System.Windows.Forms.TextBox GB4_2_textBox_目标方向;
        private System.Windows.Forms.TextBox GB4_2_textBox_目标速度;
        private System.Windows.Forms.TextBox GB4_2_textBox_目标加速度;
        private System.Windows.Forms.TextBox GB4_2_textBox_电机状态;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox GB4_groupBox3_电机速度控制模式;

        private System.Windows.Forms.Panel GB4_3_panel_正转or反转;
        private System.Windows.Forms.RadioButton GB4_3_radioButton_正转;
        private System.Windows.Forms.RadioButton GB4_3_radioButton_反转;

        private System.Windows.Forms.Label GB4_3_label_提示;
        private System.Windows.Forms.Label GB4_3_label_速度档位;

        private System.Windows.Forms.Button GB4_3_button_停止;
        private System.Windows.Forms.Button GB4_3_button_开始;
        private System.Windows.Forms.Button GB4_3_button_开启上电自动运行;
        private System.Windows.Forms.Button GB4_3_button_关闭上电自动运行;

        private System.Windows.Forms.ComboBox GB4_3_comboBox_速度档位;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox GB4_groupBox4_电机位置控制模式;

        private System.Windows.Forms.Panel GB4_4_panel_正转or反转;
        private System.Windows.Forms.RadioButton GB4_4_radioButton_反转;
        private System.Windows.Forms.RadioButton GB4_4_radioButton_正转;

        private System.Windows.Forms.Label GB4_4_label_提示;
        private System.Windows.Forms.Label GB4_4_label_脉冲数;
        private System.Windows.Forms.Label GB4_4_label_速度档位;

        private System.Windows.Forms.ComboBox GB4_4_comboBox_速度档位;
        private System.Windows.Forms.ComboBox GB4_4_comboBox_模式切换;
        private System.Windows.Forms.TextBox GB4_4_textBox_脉冲数;

        private System.Windows.Forms.Button GB4_4_button_停止;
        private System.Windows.Forms.Button GB4_4_button_开始;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox5_设置限位参数;

        private System.Windows.Forms.Label GB5_label_单圈回零;
        private System.Windows.Forms.Label GB5_label_限位回零;
        private System.Windows.Forms.Label GB5_label_IN1;
        private System.Windows.Forms.Label GB5_label_IN2;
        private System.Windows.Forms.Label GB5_label_OUT1;
        private System.Windows.Forms.Label GB5_label_OUT2;
        private System.Windows.Forms.Label GB5_label_回零模式;
        private System.Windows.Forms.Label GB5_label_设置零点;
        private System.Windows.Forms.Label GB5_label_回零速度;
        private System.Windows.Forms.Label GB5_label_回零方向;
        private System.Windows.Forms.Label GB5_label_触发电平;
        private System.Windows.Forms.Label GB5_label_归零方向;
        private System.Windows.Forms.Label GB5_label_归零速度;
        private System.Windows.Forms.Label GB5_label_归零使能;
        private System.Windows.Forms.Label GB5_label_无限位回零;
        private System.Windows.Forms.Label GB5_label_无限位返回距离;
        private System.Windows.Forms.Label GB5_label_无限位回零模式;
        private System.Windows.Forms.Label GB5_label_无限位回零电流;
        private System.Windows.Forms.Label GB5_label_限位重映射;
        private System.Windows.Forms.Label GB5_label_EN回零与位置保护;
        private System.Windows.Forms.Label GB5_label_EN回零;
        private System.Windows.Forms.Label GB5_label_位置保护;
        private System.Windows.Forms.Label GB5_label_触发时间;
        private System.Windows.Forms.Label GB5_label_触发距离;
        private System.Windows.Forms.Label GB5_label_OUT2写入;
        private System.Windows.Forms.Label GB5_label_OUT1写入;

        private System.Windows.Forms.TextBox GB5_textBox_IN1;
        private System.Windows.Forms.TextBox GB5_textBox_IN2;
        private System.Windows.Forms.TextBox GB5_textBox_OUT1;
        private System.Windows.Forms.TextBox GB5_textBox_OUT2;

        private System.Windows.Forms.ComboBox GB5_comboBox_回零模式;
        private System.Windows.Forms.ComboBox GB5_comboBox_设置零点;
        private System.Windows.Forms.ComboBox GB5_comboBox_回零速度;
        private System.Windows.Forms.ComboBox GB5_comboBox_回零方向;
        private System.Windows.Forms.ComboBox GB5_comboBox_触发电平;
        private System.Windows.Forms.ComboBox GB5_comboBox_归零方向;
        private System.Windows.Forms.ComboBox GB5_comboBox_归零速度;
        private System.Windows.Forms.ComboBox GB5_comboBox_归零使能;
        private System.Windows.Forms.ComboBox GB5_comboBox_无限位返回距离;
        private System.Windows.Forms.ComboBox GB5_comboBox_无限位回零模式;
        private System.Windows.Forms.ComboBox GB5_comboBox_无限位回零电流;
        private System.Windows.Forms.ComboBox GB5_comboBox_限位重映射;
        private System.Windows.Forms.ComboBox GB5_comboBox_EN回零;
        private System.Windows.Forms.ComboBox GB5_comboBox_位置保护;
        private System.Windows.Forms.ComboBox GB5_comboBox_触发时间;
        private System.Windows.Forms.ComboBox GB5_comboBox_触发距离;
        private System.Windows.Forms.ComboBox GB5_comboBox_OUT2写入;
        private System.Windows.Forms.ComboBox GB5_comboBox_OUT1写入;
        private System.Windows.Forms.ComboBox GB5_comboBox_OUT2写入值;
        private System.Windows.Forms.ComboBox GB5_comboBox_OUT1写入值;

        private System.Windows.Forms.Button GB5_button_单圈回零;
        private System.Windows.Forms.Button GB5_button_限位参数;
        private System.Windows.Forms.Button GB5_button_读取IO端口;
        private System.Windows.Forms.Button GB5_button_限位归零;
        private System.Windows.Forms.Button GB5_button_直接归零;
        private System.Windows.Forms.Button GB5_button_无限位回零;
        private System.Windows.Forms.Button GB5_button_限位重映射;
        private System.Windows.Forms.Button GB5_button_EN回零与位置保护;
        private System.Windows.Forms.Button GB5_button_写IO端口;

        //----------------------------------------------------------//
        private System.Windows.Forms.GroupBox F1_groupBox6_数据日志;

        private System.Windows.Forms.TextBox GB6_textBox_数据日志;

        //----------------------------------------------------------//
        private System.Windows.Forms.Timer buttonColdDown;
        private System.Windows.Forms.Timer trackingMode;
    }
}

