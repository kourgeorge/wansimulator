namespace NetEmulator
{
    partial class Stopper
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
            this.StopperButton = new System.Windows.Forms.Button();
            this.ResetStopper = new System.Windows.Forms.Button();
            this.StopperTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stoppertimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StopperButton
            // 
            this.StopperButton.Location = new System.Drawing.Point(15, 40);
            this.StopperButton.Name = "StopperButton";
            this.StopperButton.Size = new System.Drawing.Size(68, 38);
            this.StopperButton.TabIndex = 1;
            this.StopperButton.Text = "Start";
            this.StopperButton.UseVisualStyleBackColor = true;
            this.StopperButton.Click += new System.EventHandler(this.StartStopper_Click);
            // 
            // ResetStopper
            // 
            this.ResetStopper.Location = new System.Drawing.Point(96, 40);
            this.ResetStopper.Name = "ResetStopper";
            this.ResetStopper.Size = new System.Drawing.Size(68, 38);
            this.ResetStopper.TabIndex = 2;
            this.ResetStopper.Text = "Reset";
            this.ResetStopper.UseVisualStyleBackColor = true;
            this.ResetStopper.Click += new System.EventHandler(this.ResetStopper_Click);
            // 
            // StopperTB
            // 
            this.StopperTB.Location = new System.Drawing.Point(84, 12);
            this.StopperTB.Name = "StopperTB";
            this.StopperTB.ReadOnly = true;
            this.StopperTB.Size = new System.Drawing.Size(87, 20);
            this.StopperTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Elapsed";
            // 
            // Stoppertimer
            // 
            this.Stoppertimer.Interval = 1;
            this.Stoppertimer.Tick += new System.EventHandler(this.Stoppertimer_Tick);
            // 
            // Stopper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(184, 84);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopperTB);
            this.Controls.Add(this.ResetStopper);
            this.Controls.Add(this.StopperButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stopper";
            this.ShowInTaskbar = false;
            this.Text = "Stopper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Stopper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopperButton;
        private System.Windows.Forms.Button ResetStopper;
        private System.Windows.Forms.TextBox StopperTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Stoppertimer;
    }
}