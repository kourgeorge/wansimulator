namespace NetEmulator
{
  partial class SpeedTest
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.plotter = new Slepov.WinForms.Plotter();
      this.SaveGraphBtn = new System.Windows.Forms.Button();
      this.SaveLogsToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.TestBtn = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.ProgressUpdate = new System.Windows.Forms.ToolStripProgressBar();
      this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.airSpeedIndicatorInstrumentControl1 = new NetEmulator.AirSpeedIndicatorInstrumentControl();
      this.UpdateUITimer = new System.Windows.Forms.Timer(this.components);
      this.groupBox2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.plotter);
      this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
      this.groupBox2.Location = new System.Drawing.Point(12, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(306, 113);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "RTT History";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(9, 44);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(20, 12);
      this.label11.TabIndex = 12;
      this.label11.Text = "20 -";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(275, 43);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(20, 12);
      this.label12.TabIndex = 11;
      this.label12.Text = "- 20";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(9, 66);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(20, 12);
      this.label8.TabIndex = 10;
      this.label8.Text = "10 -";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(9, 23);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(20, 12);
      this.label9.TabIndex = 9;
      this.label9.Text = "30 -";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
      this.label10.Location = new System.Drawing.Point(14, 87);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(15, 12);
      this.label10.TabIndex = 8;
      this.label10.Text = "0 -";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(275, 65);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(20, 12);
      this.label5.TabIndex = 7;
      this.label5.Text = "- 10";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(275, 19);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(20, 12);
      this.label6.TabIndex = 6;
      this.label6.Text = "- 30";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
      this.label7.Location = new System.Drawing.Point(275, 87);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(15, 12);
      this.label7.TabIndex = 5;
      this.label7.Text = "- 0";
      // 
      // plotter
      // 
      this.plotter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
      this.plotter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
      this.plotter.Location = new System.Drawing.Point(29, 24);
      this.plotter.Max = 30F;
      this.plotter.Min = 0F;
      this.plotter.Name = "plotter";
      this.plotter.Size = new System.Drawing.Size(244, 73);
      this.plotter.TabIndex = 4;
      this.plotter.Text = "RTT History";
      // 
      // SaveGraphBtn
      // 
      this.SaveGraphBtn.Enabled = false;
      this.SaveGraphBtn.Location = new System.Drawing.Point(23, 236);
      this.SaveGraphBtn.Name = "SaveGraphBtn";
      this.SaveGraphBtn.Size = new System.Drawing.Size(76, 29);
      this.SaveGraphBtn.TabIndex = 7;
      this.SaveGraphBtn.Text = "Save Graph";
      this.SaveGraphBtn.UseVisualStyleBackColor = true;
      this.SaveGraphBtn.Click += new System.EventHandler(this.SaveGraphBtn_Click);
      // 
      // SaveLogsToolTip
      // 
      this.SaveLogsToolTip.AutomaticDelay = 200;
      this.SaveLogsToolTip.AutoPopDelay = 5000;
      this.SaveLogsToolTip.InitialDelay = 200;
      this.SaveLogsToolTip.ReshowDelay = 40;
      this.SaveLogsToolTip.ToolTipTitle = "NetMon Logs";
      // 
      // TestBtn
      // 
      this.TestBtn.Location = new System.Drawing.Point(23, 186);
      this.TestBtn.Name = "TestBtn";
      this.TestBtn.Size = new System.Drawing.Size(76, 29);
      this.TestBtn.TabIndex = 9;
      this.TestBtn.Text = "Test";
      this.TestBtn.UseVisualStyleBackColor = true;
      this.TestBtn.Click += new System.EventHandler(this.TestsBtn_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.AutoSize = false;
      this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressUpdate,
            this.StatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 321);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(340, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.Stretch = false;
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // ProgressUpdate
      // 
      this.ProgressUpdate.MarqueeAnimationSpeed = 1;
      this.ProgressUpdate.Name = "ProgressUpdate";
      this.ProgressUpdate.Size = new System.Drawing.Size(150, 16);
      // 
      // StatusLabel
      // 
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(39, 17);
      this.StatusLabel.Text = "Ready";
      // 
      // airSpeedIndicatorInstrumentControl1
      // 
      this.airSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(137, 138);
      this.airSpeedIndicatorInstrumentControl1.Name = "airSpeedIndicatorInstrumentControl1";
      this.airSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 170);
      this.airSpeedIndicatorInstrumentControl1.TabIndex = 10;
      this.airSpeedIndicatorInstrumentControl1.Text = "airSpeedIndicatorInstrumentControl1";
      // 
      // UpdateUITimer
      // 
      this.UpdateUITimer.Interval = 10;
      this.UpdateUITimer.Tick += new System.EventHandler(this.UpdateUITimer_Tick);
      // 
      // SpeedTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(173)))));
      this.ClientSize = new System.Drawing.Size(340, 343);
      this.Controls.Add(this.airSpeedIndicatorInstrumentControl1);
      this.Controls.Add(this.TestBtn);
      this.Controls.Add(this.SaveGraphBtn);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.statusStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "SpeedTest";
      this.ShowInTaskbar = false;
      this.Text = "NetMon";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedTest_FormClosing);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Slepov.WinForms.Plotter plotter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveGraphBtn;
        private System.Windows.Forms.ToolTip SaveLogsToolTip;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar ProgressUpdate;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private AirSpeedIndicatorInstrumentControl airSpeedIndicatorInstrumentControl1;
        private System.Windows.Forms.Timer UpdateUITimer;
    }
}