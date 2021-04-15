
namespace System_Info
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.pnlWhite2 = new System.Windows.Forms.Panel();
            this.btnRAM = new System.Windows.Forms.Button();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlCPU = new System.Windows.Forms.Panel();
            this.txtClockSpeed = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.Label();
            this.txtCores = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.Label();
            this.txtCPUTemp = new System.Windows.Forms.Label();
            this.txtCPUsage = new System.Windows.Forms.Label();
            this.progCPU = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.perCPU = new System.Diagnostics.PerformanceCounter();
            this.tmrSysInfo = new System.Windows.Forms.Timer(this.components);
            this.tran = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlRAM = new System.Windows.Forms.Panel();
            this.txtRAMSpeed = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.Label();
            this.txtRAMSlots = new System.Windows.Forms.Label();
            this.txtRAMUse = new System.Windows.Forms.Label();
            this.progRAM = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.cmsNI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.tglLightMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtLightMode = new System.Windows.Forms.Label();
            this.tglstartup = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtME = new System.Windows.Forms.Label();
            this.txtStartUp = new System.Windows.Forms.Label();
            this.bgwCPUInfo = new System.ComponentModel.BackgroundWorker();
            this.perRAM = new System.Diagnostics.PerformanceCounter();
            this.niThis = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlWhite3 = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perCPU)).BeginInit();
            this.pnlRAM.SuspendLayout();
            this.cmsNI.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnCPU);
            this.pnlSidebar.Controls.Add(this.pnlWhite2);
            this.pnlSidebar.Controls.Add(this.btnRAM);
            this.pnlSidebar.Controls.Add(this.pnlWhite);
            this.pnlSidebar.Controls.Add(this.pnlWhite3);
            this.tran.SetDecoration(this.pnlSidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(65, 377);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.tran.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::System_Info.Properties.Resources.settings_24px1;
            this.btnSettings.Location = new System.Drawing.Point(0, 221);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(65, 41);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.AutoSize = true;
            this.tran.SetDecoration(this.btnCPU, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Image = global::System_Info.Properties.Resources.processor_24pxWhite;
            this.btnCPU.Location = new System.Drawing.Point(0, 7);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(65, 41);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // pnlWhite2
            // 
            this.pnlWhite2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tran.SetDecoration(this.pnlWhite2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlWhite2.Location = new System.Drawing.Point(0, 12);
            this.pnlWhite2.Name = "pnlWhite2";
            this.pnlWhite2.Size = new System.Drawing.Size(4, 30);
            this.pnlWhite2.TabIndex = 3;
            // 
            // btnRAM
            // 
            this.btnRAM.AutoSize = true;
            this.tran.SetDecoration(this.btnRAM, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRAM.FlatAppearance.BorderSize = 0;
            this.btnRAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRAM.Image = global::System_Info.Properties.Resources.memory_slot_24pxWhite;
            this.btnRAM.Location = new System.Drawing.Point(0, 67);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(65, 41);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tran.SetDecoration(this.pnlWhite, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlWhite.Location = new System.Drawing.Point(0, 72);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(4, 30);
            this.pnlWhite.TabIndex = 2;
            // 
            // pnlCPU
            // 
            this.pnlCPU.Controls.Add(this.txtClockSpeed);
            this.pnlCPU.Controls.Add(this.txtThreads);
            this.pnlCPU.Controls.Add(this.txtCores);
            this.pnlCPU.Controls.Add(this.txtCPU);
            this.pnlCPU.Controls.Add(this.txtCPUTemp);
            this.pnlCPU.Controls.Add(this.txtCPUsage);
            this.pnlCPU.Controls.Add(this.progCPU);
            this.tran.SetDecoration(this.pnlCPU, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlCPU.Location = new System.Drawing.Point(347, 192);
            this.pnlCPU.Name = "pnlCPU";
            this.pnlCPU.Size = new System.Drawing.Size(382, 277);
            this.pnlCPU.TabIndex = 1;
            this.pnlCPU.Visible = false;
            this.pnlCPU.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCPU_Paint);
            // 
            // txtClockSpeed
            // 
            this.txtClockSpeed.AutoSize = true;
            this.tran.SetDecoration(this.txtClockSpeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtClockSpeed.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClockSpeed.ForeColor = System.Drawing.Color.White;
            this.txtClockSpeed.Location = new System.Drawing.Point(18, 88);
            this.txtClockSpeed.Name = "txtClockSpeed";
            this.txtClockSpeed.Size = new System.Drawing.Size(99, 19);
            this.txtClockSpeed.TabIndex = 6;
            this.txtClockSpeed.Text = "Base Speed:";
            // 
            // txtThreads
            // 
            this.txtThreads.AutoSize = true;
            this.tran.SetDecoration(this.txtThreads, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtThreads.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.ForeColor = System.Drawing.Color.White;
            this.txtThreads.Location = new System.Drawing.Point(92, 53);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(85, 19);
            this.txtThreads.TabIndex = 5;
            this.txtThreads.Text = "Threads: 4";
            // 
            // txtCores
            // 
            this.txtCores.AutoSize = true;
            this.tran.SetDecoration(this.txtCores, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCores.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCores.ForeColor = System.Drawing.Color.White;
            this.txtCores.Location = new System.Drawing.Point(18, 53);
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(68, 19);
            this.txtCores.TabIndex = 4;
            this.txtCores.Text = "Cores: 2";
            // 
            // txtCPU
            // 
            this.txtCPU.AutoSize = true;
            this.tran.SetDecoration(this.txtCPU, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCPU.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPU.ForeColor = System.Drawing.Color.White;
            this.txtCPU.Location = new System.Drawing.Point(18, 18);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(170, 19);
            this.txtCPU.TabIndex = 3;
            this.txtCPU.Text = "Insert CPU Name here";
            // 
            // txtCPUTemp
            // 
            this.txtCPUTemp.AutoSize = true;
            this.tran.SetDecoration(this.txtCPUTemp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCPUTemp.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUTemp.ForeColor = System.Drawing.Color.White;
            this.txtCPUTemp.Location = new System.Drawing.Point(18, 125);
            this.txtCPUTemp.Name = "txtCPUTemp";
            this.txtCPUTemp.Size = new System.Drawing.Size(181, 19);
            this.txtCPUTemp.TabIndex = 2;
            this.txtCPUTemp.Text = "CPU Temperature: 43℃ ";
            // 
            // txtCPUsage
            // 
            this.txtCPUsage.AutoSize = true;
            this.tran.SetDecoration(this.txtCPUsage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCPUsage.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUsage.ForeColor = System.Drawing.Color.White;
            this.txtCPUsage.Location = new System.Drawing.Point(319, 234);
            this.txtCPUsage.Name = "txtCPUsage";
            this.txtCPUsage.Size = new System.Drawing.Size(45, 25);
            this.txtCPUsage.TabIndex = 1;
            this.txtCPUsage.Text = "18%";
            this.txtCPUsage.Click += new System.EventHandler(this.txtCPU_Click);
            // 
            // progCPU
            // 
            this.progCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.progCPU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tran.SetDecoration(this.progCPU, Guna.UI2.AnimatorNS.DecorationType.None);
            this.progCPU.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.progCPU.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progCPU.Location = new System.Drawing.Point(22, 232);
            this.progCPU.Name = "progCPU";
            this.progCPU.ProgressColor = System.Drawing.Color.DarkViolet;
            this.progCPU.ProgressColor2 = System.Drawing.Color.MediumBlue;
            this.progCPU.ShadowDecoration.Parent = this.progCPU;
            this.progCPU.Size = new System.Drawing.Size(291, 30);
            this.progCPU.TabIndex = 0;
            this.progCPU.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progCPU.ValueChanged += new System.EventHandler(this.progCPU_ValueChanged);
            // 
            // perCPU
            // 
            this.perCPU.CategoryName = "Processor";
            this.perCPU.CounterName = "% Processor Time";
            this.perCPU.InstanceName = "_Total";
            // 
            // tmrSysInfo
            // 
            this.tmrSysInfo.Enabled = true;
            this.tmrSysInfo.Interval = 500;
            this.tmrSysInfo.Tick += new System.EventHandler(this.tmrSys_Tick);
            // 
            // tran
            // 
            this.tran.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.tran.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.tran.DefaultAnimation = animation1;
            this.tran.Interval = 5;
            // 
            // pnlRAM
            // 
            this.pnlRAM.Controls.Add(this.txtRAMSpeed);
            this.pnlRAM.Controls.Add(this.txtAvailable);
            this.pnlRAM.Controls.Add(this.txtRAM);
            this.pnlRAM.Controls.Add(this.txtRAMSlots);
            this.pnlRAM.Controls.Add(this.txtRAMUse);
            this.pnlRAM.Controls.Add(this.progRAM);
            this.tran.SetDecoration(this.pnlRAM, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlRAM.Location = new System.Drawing.Point(393, 152);
            this.pnlRAM.Name = "pnlRAM";
            this.pnlRAM.Size = new System.Drawing.Size(382, 277);
            this.pnlRAM.TabIndex = 7;
            // 
            // txtRAMSpeed
            // 
            this.txtRAMSpeed.AutoSize = true;
            this.tran.SetDecoration(this.txtRAMSpeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRAMSpeed.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAMSpeed.ForeColor = System.Drawing.Color.White;
            this.txtRAMSpeed.Location = new System.Drawing.Point(18, 53);
            this.txtRAMSpeed.Name = "txtRAMSpeed";
            this.txtRAMSpeed.Size = new System.Drawing.Size(95, 19);
            this.txtRAMSpeed.TabIndex = 6;
            this.txtRAMSpeed.Text = "RAM Speed:";
            // 
            // txtAvailable
            // 
            this.txtAvailable.AutoSize = true;
            this.tran.SetDecoration(this.txtAvailable, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAvailable.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailable.ForeColor = System.Drawing.Color.White;
            this.txtAvailable.Location = new System.Drawing.Point(18, 125);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(117, 19);
            this.txtAvailable.TabIndex = 4;
            this.txtAvailable.Text = "Available RAM:";
            this.txtAvailable.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRAM
            // 
            this.txtRAM.AutoSize = true;
            this.tran.SetDecoration(this.txtRAM, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRAM.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAM.ForeColor = System.Drawing.Color.White;
            this.txtRAM.Location = new System.Drawing.Point(18, 18);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(172, 19);
            this.txtRAM.TabIndex = 3;
            this.txtRAM.Text = "Insert RAM Name here";
            // 
            // txtRAMSlots
            // 
            this.txtRAMSlots.AutoSize = true;
            this.tran.SetDecoration(this.txtRAMSlots, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRAMSlots.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAMSlots.ForeColor = System.Drawing.Color.White;
            this.txtRAMSlots.Location = new System.Drawing.Point(18, 88);
            this.txtRAMSlots.Name = "txtRAMSlots";
            this.txtRAMSlots.Size = new System.Drawing.Size(95, 19);
            this.txtRAMSlots.TabIndex = 2;
            this.txtRAMSlots.Text = "RAM Slots: 1";
            // 
            // txtRAMUse
            // 
            this.txtRAMUse.AutoSize = true;
            this.tran.SetDecoration(this.txtRAMUse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRAMUse.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAMUse.ForeColor = System.Drawing.Color.White;
            this.txtRAMUse.Location = new System.Drawing.Point(319, 234);
            this.txtRAMUse.Name = "txtRAMUse";
            this.txtRAMUse.Size = new System.Drawing.Size(45, 25);
            this.txtRAMUse.TabIndex = 1;
            this.txtRAMUse.Text = "18%";
            // 
            // progRAM
            // 
            this.progRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.progRAM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tran.SetDecoration(this.progRAM, Guna.UI2.AnimatorNS.DecorationType.None);
            this.progRAM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.progRAM.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progRAM.Location = new System.Drawing.Point(22, 232);
            this.progRAM.Name = "progRAM";
            this.progRAM.ProgressColor = System.Drawing.Color.DarkViolet;
            this.progRAM.ProgressColor2 = System.Drawing.Color.MediumBlue;
            this.progRAM.ShadowDecoration.Parent = this.progRAM;
            this.progRAM.Size = new System.Drawing.Size(291, 30);
            this.progRAM.TabIndex = 0;
            this.progRAM.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cmsNI
            // 
            this.tran.SetDecoration(this.cmsNI, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmsNI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiShow,
            this.tmiExit});
            this.cmsNI.Name = "cmsNI";
            this.cmsNI.Size = new System.Drawing.Size(104, 48);
            this.cmsNI.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsNI_ItemClicked);
            this.cmsNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmsNI_MouseClick);
            // 
            // tmiShow
            // 
            this.tmiShow.Name = "tmiShow";
            this.tmiShow.Size = new System.Drawing.Size(103, 22);
            this.tmiShow.Text = "Show";
            // 
            // tmiExit
            // 
            this.tmiExit.Name = "tmiExit";
            this.tmiExit.Size = new System.Drawing.Size(103, 22);
            this.tmiExit.Text = "Exit";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.tglLightMode);
            this.pnlSettings.Controls.Add(this.txtLightMode);
            this.pnlSettings.Controls.Add(this.tglstartup);
            this.pnlSettings.Controls.Add(this.txtME);
            this.pnlSettings.Controls.Add(this.txtStartUp);
            this.tran.SetDecoration(this.pnlSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSettings.Location = new System.Drawing.Point(235, 243);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(382, 277);
            this.pnlSettings.TabIndex = 8;
            // 
            // tglLightMode
            // 
            this.tglLightMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(208)))));
            this.tglLightMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(208)))));
            this.tglLightMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglLightMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglLightMode.CheckedState.Parent = this.tglLightMode;
            this.tran.SetDecoration(this.tglLightMode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglLightMode.Location = new System.Drawing.Point(112, 54);
            this.tglLightMode.Name = "tglLightMode";
            this.tglLightMode.ShadowDecoration.Parent = this.tglLightMode;
            this.tglLightMode.Size = new System.Drawing.Size(35, 20);
            this.tglLightMode.TabIndex = 9;
            this.tglLightMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglLightMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglLightMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglLightMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglLightMode.UncheckedState.Parent = this.tglLightMode;
            this.tglLightMode.CheckedChanged += new System.EventHandler(this.tglLightMode_CheckedChanged);
            // 
            // txtLightMode
            // 
            this.txtLightMode.AutoSize = true;
            this.tran.SetDecoration(this.txtLightMode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLightMode.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLightMode.ForeColor = System.Drawing.Color.White;
            this.txtLightMode.Location = new System.Drawing.Point(18, 53);
            this.txtLightMode.Name = "txtLightMode";
            this.txtLightMode.Size = new System.Drawing.Size(88, 19);
            this.txtLightMode.TabIndex = 8;
            this.txtLightMode.Text = "Light Mode";
            // 
            // tglstartup
            // 
            this.tglstartup.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(208)))));
            this.tglstartup.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(208)))));
            this.tglstartup.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglstartup.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglstartup.CheckedState.Parent = this.tglstartup;
            this.tran.SetDecoration(this.tglstartup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglstartup.Location = new System.Drawing.Point(230, 17);
            this.tglstartup.Name = "tglstartup";
            this.tglstartup.ShadowDecoration.Parent = this.tglstartup;
            this.tglstartup.Size = new System.Drawing.Size(35, 20);
            this.tglstartup.TabIndex = 7;
            this.tglstartup.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglstartup.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglstartup.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglstartup.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglstartup.UncheckedState.Parent = this.tglstartup;
            this.tglstartup.CheckedChanged += new System.EventHandler(this.tglstartup_CheckedChanged);
            // 
            // txtME
            // 
            this.txtME.AutoSize = true;
            this.tran.SetDecoration(this.txtME, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtME.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtME.ForeColor = System.Drawing.Color.White;
            this.txtME.Location = new System.Drawing.Point(220, 246);
            this.txtME.Name = "txtME";
            this.txtME.Size = new System.Drawing.Size(149, 19);
            this.txtME.TabIndex = 6;
            this.txtME.Text = "Made By Dubhghall";
            // 
            // txtStartUp
            // 
            this.txtStartUp.AutoSize = true;
            this.tran.SetDecoration(this.txtStartUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtStartUp.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartUp.ForeColor = System.Drawing.Color.White;
            this.txtStartUp.Location = new System.Drawing.Point(18, 18);
            this.txtStartUp.Name = "txtStartUp";
            this.txtStartUp.Size = new System.Drawing.Size(196, 19);
            this.txtStartUp.TabIndex = 3;
            this.txtStartUp.Text = "Start At Windows Start Up";
            // 
            // bgwCPUInfo
            // 
            this.bgwCPUInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCPUInfo_DoWork);
            // 
            // perRAM
            // 
            this.perRAM.CategoryName = "Memory";
            this.perRAM.CounterName = "Available MBytes";
            // 
            // niThis
            // 
            this.niThis.ContextMenuStrip = this.cmsNI;
            this.niThis.Icon = ((System.Drawing.Icon)(resources.GetObject("niThis.Icon")));
            this.niThis.Text = "notifyIcon1";
            this.niThis.Click += new System.EventHandler(this.niThis_Click);
            this.niThis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.niThis_MouseDown);
            // 
            // pnlWhite3
            // 
            this.pnlWhite3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tran.SetDecoration(this.pnlWhite3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlWhite3.Location = new System.Drawing.Point(0, 226);
            this.pnlWhite3.Name = "pnlWhite3";
            this.pnlWhite3.Size = new System.Drawing.Size(4, 30);
            this.pnlWhite3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(446, 274);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlRAM);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlCPU);
            this.tran.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Obscure Performance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlCPU.ResumeLayout(false);
            this.pnlCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perCPU)).EndInit();
            this.pnlRAM.ResumeLayout(false);
            this.pnlRAM.PerformLayout();
            this.cmsNI.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCPU;
        private Guna.UI2.WinForms.Guna2ProgressBar progCPU;
        private System.Diagnostics.PerformanceCounter perCPU;
        private System.Windows.Forms.Timer tmrSysInfo;
        private System.Windows.Forms.Label txtCPUsage;
        private System.Windows.Forms.Label txtCPUTemp;
        private System.Windows.Forms.Label txtCPU;
        private System.Windows.Forms.Label txtThreads;
        private System.Windows.Forms.Label txtCores;
        private System.Windows.Forms.Label txtClockSpeed;
        private System.Windows.Forms.Button btnCPU;
        private Guna.UI2.WinForms.Guna2Transition tran;
        private System.Windows.Forms.Button btnRAM;
        private System.ComponentModel.BackgroundWorker bgwCPUInfo;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Panel pnlWhite2;
        private System.Windows.Forms.Panel pnlRAM;
        private System.Windows.Forms.Label txtRAMSpeed;
        private System.Windows.Forms.Label txtAvailable;
        private System.Windows.Forms.Label txtRAM;
        private System.Windows.Forms.Label txtRAMSlots;
        private System.Windows.Forms.Label txtRAMUse;
        private Guna.UI2.WinForms.Guna2ProgressBar progRAM;
        private System.Diagnostics.PerformanceCounter perRAM;
        private System.Windows.Forms.NotifyIcon niThis;
        private System.Windows.Forms.ContextMenuStrip cmsNI;
        private System.Windows.Forms.ToolStripMenuItem tmiShow;
        private System.Windows.Forms.ToolStripMenuItem tmiExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglstartup;
        private System.Windows.Forms.Label txtME;
        private System.Windows.Forms.Label txtStartUp;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglLightMode;
        private System.Windows.Forms.Label txtLightMode;
        private System.Windows.Forms.Panel pnlWhite3;
    }
}

