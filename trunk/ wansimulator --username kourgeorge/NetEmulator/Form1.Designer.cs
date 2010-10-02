namespace NetEmulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DelayTB = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PLTB = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PLLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BWTB = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.kbps = new System.Windows.Forms.Label();
            this.BWLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.StartStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadConfigurationToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdittoolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.excludeListStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.clockStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stopperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.netMonitorStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Notifytimer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.Monitorbutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Stopperbutton = new System.Windows.Forms.Button();
            this.Clockbutton = new System.Windows.Forms.Button();
            this.Listbutton = new System.Windows.Forms.Button();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.LoadButton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.ConfigurationgroupBox = new System.Windows.Forms.GroupBox();
            this.Form1toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BWTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.NotifyContextMenuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ConfigurationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(270, 379);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 33);
            this.startB.TabIndex = 1;
            this.startB.Text = "Start";
            this.Form1toolTip.SetToolTip(this.startB, "Start Simulation");
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.start_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(356, 379);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(75, 33);
            this.stopB.TabIndex = 2;
            this.stopB.Text = "Stop";
            this.Form1toolTip.SetToolTip(this.stopB, "Stop Simulation");
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(49, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(303, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Based On DummyNet";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.groupBox3);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Location = new System.Drawing.Point(5, 96);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(431, 265);
            this.MainPanel.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delay";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.DelayTB);
            this.panel3.Location = new System.Drawing.Point(70, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 46);
            this.panel3.TabIndex = 18;
            // 
            // DelayTB
            // 
            this.DelayTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelayTB.LargeChange = 1;
            this.DelayTB.Location = new System.Drawing.Point(0, 0);
            this.DelayTB.Name = "DelayTB";
            this.DelayTB.Size = new System.Drawing.Size(244, 42);
            this.DelayTB.TabIndex = 0;
            this.DelayTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.DelayTB.ValueChanged += new System.EventHandler(this.DelayTB_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.DelayLabel);
            this.panel5.Location = new System.Drawing.Point(327, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 36);
            this.panel5.TabIndex = 0;
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.DelayLabel.Location = new System.Drawing.Point(26, 10);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(13, 13);
            this.DelayLabel.TabIndex = 15;
            this.DelayLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packet Loss";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PLTB);
            this.panel1.Location = new System.Drawing.Point(68, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 46);
            this.panel1.TabIndex = 19;
            // 
            // PLTB
            // 
            this.PLTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLTB.LargeChange = 1;
            this.PLTB.Location = new System.Drawing.Point(0, 0);
            this.PLTB.Maximum = 5;
            this.PLTB.Name = "PLTB";
            this.PLTB.Size = new System.Drawing.Size(244, 42);
            this.PLTB.TabIndex = 0;
            this.PLTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PLTB.ValueChanged += new System.EventHandler(this.PLTB_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.PLLabel);
            this.panel7.Location = new System.Drawing.Point(327, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(81, 36);
            this.panel7.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(49, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "%";
            // 
            // PLLabel
            // 
            this.PLLabel.AutoSize = true;
            this.PLLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.PLLabel.Location = new System.Drawing.Point(26, 10);
            this.PLLabel.Name = "PLLabel";
            this.PLLabel.Size = new System.Drawing.Size(13, 13);
            this.PLLabel.TabIndex = 15;
            this.PLLabel.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Band Width";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BWTB);
            this.panel2.Location = new System.Drawing.Point(70, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 49);
            this.panel2.TabIndex = 20;
            // 
            // BWTB
            // 
            this.BWTB.LargeChange = 1;
            this.BWTB.Location = new System.Drawing.Point(0, -1);
            this.BWTB.Maximum = 5;
            this.BWTB.Name = "BWTB";
            this.BWTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BWTB.Size = new System.Drawing.Size(244, 50);
            this.BWTB.TabIndex = 0;
            this.BWTB.Tag = "";
            this.BWTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BWTB.ValueChanged += new System.EventHandler(this.BWTB_Scroll);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.kbps);
            this.panel6.Controls.Add(this.BWLabel);
            this.panel6.Location = new System.Drawing.Point(327, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(81, 36);
            this.panel6.TabIndex = 17;
            // 
            // kbps
            // 
            this.kbps.AutoSize = true;
            this.kbps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbps.ForeColor = System.Drawing.Color.MediumBlue;
            this.kbps.Location = new System.Drawing.Point(42, 8);
            this.kbps.Name = "kbps";
            this.kbps.Size = new System.Drawing.Size(40, 16);
            this.kbps.TabIndex = 4;
            this.kbps.Text = "kbit/s";
            this.kbps.Visible = false;
            // 
            // BWLabel
            // 
            this.BWLabel.AutoSize = true;
            this.BWLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.BWLabel.Location = new System.Drawing.Point(16, 10);
            this.BWLabel.Name = "BWLabel";
            this.BWLabel.Size = new System.Drawing.Size(64, 13);
            this.BWLabel.TabIndex = 15;
            this.BWLabel.Text = "Unrestricted";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStrip,
            this.EdittoolStrip,
            this.ToolsStrip,
            this.HelpStrip,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(446, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileStrip
            // 
            this.FileStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartStrip,
            this.StopStrip,
            this.toolStripSeparator1,
            this.loadConfigurationToolStrip,
            this.saveConfigurationToolStrip,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.FileStrip.Image = ((System.Drawing.Image)(resources.GetObject("FileStrip.Image")));
            this.FileStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.ShowDropDownArrow = false;
            this.FileStrip.Size = new System.Drawing.Size(32, 22);
            this.FileStrip.Text = "File";
            // 
            // StartStrip
            // 
            this.StartStrip.Name = "StartStrip";
            this.StartStrip.Size = new System.Drawing.Size(184, 22);
            this.StartStrip.Text = "Start";
            this.StartStrip.Click += new System.EventHandler(this.start_Click);
            // 
            // StopStrip
            // 
            this.StopStrip.Name = "StopStrip";
            this.StopStrip.Size = new System.Drawing.Size(184, 22);
            this.StopStrip.Text = "Stop";
            this.StopStrip.Click += new System.EventHandler(this.stopB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // loadConfigurationToolStrip
            // 
            this.loadConfigurationToolStrip.Name = "loadConfigurationToolStrip";
            this.loadConfigurationToolStrip.Size = new System.Drawing.Size(184, 22);
            this.loadConfigurationToolStrip.Text = "Load Configuration";
            this.loadConfigurationToolStrip.Click += new System.EventHandler(this.loadConfigurationToolStripMenuItem_Click);
            // 
            // saveConfigurationToolStrip
            // 
            this.saveConfigurationToolStrip.Name = "saveConfigurationToolStrip";
            this.saveConfigurationToolStrip.Size = new System.Drawing.Size(184, 22);
            this.saveConfigurationToolStrip.Text = "Save Configuration";
            this.saveConfigurationToolStrip.Click += new System.EventHandler(this.saveConfigurationStrip_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EdittoolStrip
            // 
            this.EdittoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EdittoolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excludeListStrip});
            this.EdittoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("EdittoolStrip.Image")));
            this.EdittoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EdittoolStrip.Name = "EdittoolStrip";
            this.EdittoolStrip.ShowDropDownArrow = false;
            this.EdittoolStrip.Size = new System.Drawing.Size(33, 22);
            this.EdittoolStrip.Text = "Edit";
            // 
            // excludeListStrip
            // 
            this.excludeListStrip.Name = "excludeListStrip";
            this.excludeListStrip.Size = new System.Drawing.Size(162, 22);
            this.excludeListStrip.Text = "Filter Definition";
            this.excludeListStrip.Click += new System.EventHandler(this.excludeListToolStripMenuItem_Click);
            // 
            // ToolsStrip
            // 
            this.ToolsStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockStrip,
            this.stopperToolStripMenuItem1,
            this.toolStripSeparator3,
            this.netMonitorStrip});
            this.ToolsStrip.Image = ((System.Drawing.Image)(resources.GetObject("ToolsStrip.Image")));
            this.ToolsStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolsStrip.Name = "ToolsStrip";
            this.ToolsStrip.ShowDropDownArrow = false;
            this.ToolsStrip.Size = new System.Drawing.Size(43, 22);
            this.ToolsStrip.Text = "Tools";
            // 
            // clockStrip
            // 
            this.clockStrip.Name = "clockStrip";
            this.clockStrip.Size = new System.Drawing.Size(142, 22);
            this.clockStrip.Text = "Clock";
            this.clockStrip.Click += new System.EventHandler(this.clockToolStripMenuItem_Click);
            // 
            // stopperToolStripMenuItem1
            // 
            this.stopperToolStripMenuItem1.Name = "stopperToolStripMenuItem1";
            this.stopperToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.stopperToolStripMenuItem1.Text = "Stopper";
            this.stopperToolStripMenuItem1.Click += new System.EventHandler(this.stopperToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // netMonitorStrip
            // 
            this.netMonitorStrip.Name = "netMonitorStrip";
            this.netMonitorStrip.Size = new System.Drawing.Size(142, 22);
            this.netMonitorStrip.Text = "Net Monitor";
            this.netMonitorStrip.Click += new System.EventHandler(this.netMonitorToolStripMenuItem_Click);
            // 
            // HelpStrip
            // 
            this.HelpStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStrip});
            this.HelpStrip.Image = ((System.Drawing.Image)(resources.GetObject("HelpStrip.Image")));
            this.HelpStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpStrip.Name = "HelpStrip";
            this.HelpStrip.ShowDropDownArrow = false;
            this.HelpStrip.Size = new System.Drawing.Size(37, 22);
            this.HelpStrip.Text = "Help";
            // 
            // aboutStrip
            // 
            this.aboutStrip.Name = "aboutStrip";
            this.aboutStrip.Size = new System.Drawing.Size(109, 22);
            this.aboutStrip.Text = "About";
            this.aboutStrip.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Escape And Clear All";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MainNotifyIcon.ContextMenuStrip = this.NotifyContextMenuStrip;
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "WANSim\r\nStatus: Ready";
            this.MainNotifyIcon.Visible = true;
            this.MainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseDoubleClick);
            // 
            // NotifyContextMenuStrip
            // 
            this.NotifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem1});
            this.NotifyContextMenuStrip.Name = "NotifyContextMenuStrip";
            this.NotifyContextMenuStrip.Size = new System.Drawing.Size(105, 76);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.start_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopB_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(101, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Notifytimer
            // 
            this.Notifytimer.Interval = 1000;
            this.Notifytimer.Tick += new System.EventHandler(this.Notifytimer_Tick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Monitorbutton);
            this.panel4.Controls.Add(this.Helpbutton);
            this.panel4.Controls.Add(this.Stopperbutton);
            this.panel4.Controls.Add(this.Clockbutton);
            this.panel4.Controls.Add(this.Listbutton);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(20, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 61);
            this.panel4.TabIndex = 11;
            // 
            // Monitorbutton
            // 
            this.Monitorbutton.Image = ((System.Drawing.Image)(resources.GetObject("Monitorbutton.Image")));
            this.Monitorbutton.Location = new System.Drawing.Point(248, 7);
            this.Monitorbutton.Name = "Monitorbutton";
            this.Monitorbutton.Size = new System.Drawing.Size(62, 47);
            this.Monitorbutton.TabIndex = 3;
            this.Form1toolTip.SetToolTip(this.Monitorbutton, "NetMon Helps you to monitor Host for ping Round Trip Time");
            this.Monitorbutton.UseVisualStyleBackColor = true;
            this.Monitorbutton.Click += new System.EventHandler(this.netMonitorToolStripMenuItem_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.Image = ((System.Drawing.Image)(resources.GetObject("Helpbutton.Image")));
            this.Helpbutton.Location = new System.Drawing.Point(328, 7);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(62, 47);
            this.Helpbutton.TabIndex = 4;
            this.Form1toolTip.SetToolTip(this.Helpbutton, "About and Help");
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Stopperbutton
            // 
            this.Stopperbutton.Image = ((System.Drawing.Image)(resources.GetObject("Stopperbutton.Image")));
            this.Stopperbutton.Location = new System.Drawing.Point(168, 7);
            this.Stopperbutton.Name = "Stopperbutton";
            this.Stopperbutton.Size = new System.Drawing.Size(62, 47);
            this.Stopperbutton.TabIndex = 2;
            this.Form1toolTip.SetToolTip(this.Stopperbutton, "Stopper");
            this.Stopperbutton.UseVisualStyleBackColor = true;
            this.Stopperbutton.Click += new System.EventHandler(this.stopperToolStripMenuItem1_Click);
            // 
            // Clockbutton
            // 
            this.Clockbutton.Image = ((System.Drawing.Image)(resources.GetObject("Clockbutton.Image")));
            this.Clockbutton.Location = new System.Drawing.Point(88, 7);
            this.Clockbutton.Name = "Clockbutton";
            this.Clockbutton.Size = new System.Drawing.Size(62, 47);
            this.Clockbutton.TabIndex = 1;
            this.Form1toolTip.SetToolTip(this.Clockbutton, "Clock");
            this.Clockbutton.UseVisualStyleBackColor = true;
            this.Clockbutton.Click += new System.EventHandler(this.clockToolStripMenuItem_Click);
            // 
            // Listbutton
            // 
            this.Listbutton.Image = ((System.Drawing.Image)(resources.GetObject("Listbutton.Image")));
            this.Listbutton.Location = new System.Drawing.Point(8, 7);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(62, 47);
            this.Listbutton.TabIndex = 0;
            this.Form1toolTip.SetToolTip(this.Listbutton, "Enter to the ExcludeList the IPs you want to exclude from the simulation");
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.excludeListToolStripMenuItem_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            this.LoadButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadButton.Image")));
            this.LoadButton.Location = new System.Drawing.Point(4, 17);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(39, 28);
            this.LoadButton.TabIndex = 12;
            this.Form1toolTip.SetToolTip(this.LoadButton, "Load Configuration");
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.loadConfigurationToolStripMenuItem_Click);
            // 
            // savebutton
            // 
            this.savebutton.Image = ((System.Drawing.Image)(resources.GetObject("savebutton.Image")));
            this.savebutton.Location = new System.Drawing.Point(49, 17);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(39, 28);
            this.savebutton.TabIndex = 13;
            this.Form1toolTip.SetToolTip(this.savebutton, "Save Configuration");
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.saveConfigurationStrip_Click);
            // 
            // ConfigurationgroupBox
            // 
            this.ConfigurationgroupBox.Controls.Add(this.LoadButton);
            this.ConfigurationgroupBox.Controls.Add(this.savebutton);
            this.ConfigurationgroupBox.Location = new System.Drawing.Point(16, 366);
            this.ConfigurationgroupBox.Name = "ConfigurationgroupBox";
            this.ConfigurationgroupBox.Size = new System.Drawing.Size(91, 52);
            this.ConfigurationgroupBox.TabIndex = 15;
            this.ConfigurationgroupBox.TabStop = false;
            this.ConfigurationgroupBox.Text = "Configuration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 422);
            this.Controls.Add(this.ConfigurationgroupBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.startB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " WANSim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MainPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BWTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.NotifyContextMenuStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ConfigurationgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PLLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label kbps;
        private System.Windows.Forms.Label BWLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar DelayTB;
        private System.Windows.Forms.TrackBar PLTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar BWTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileStrip;
        private System.Windows.Forms.ToolStripMenuItem StartStrip;
        private System.Windows.Forms.ToolStripMenuItem StopStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton ToolsStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton HelpStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem netMonitorStrip;
        private System.Windows.Forms.ToolStripMenuItem clockStrip;
        public System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.Timer Notifytimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Monitorbutton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStrip;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.ContextMenuStrip NotifyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button Stopperbutton;
        private System.Windows.Forms.Button Clockbutton;
        private System.Windows.Forms.ToolStripDropDownButton EdittoolStrip;
        private System.Windows.Forms.ToolStripMenuItem excludeListStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.GroupBox ConfigurationgroupBox;
        private System.Windows.Forms.ToolTip Form1toolTip;
    }
}

