namespace NetEmulator
{
    partial class DNSResolver
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
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.Resolvebutton = new System.Windows.Forms.Button();
            this.CopytoFilterbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CopytoClipbutton = new System.Windows.Forms.Button();
            this.iPTextBox = new iptb.IPTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(14, 25);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(120, 20);
            this.HostTextBox.TabIndex = 0;
            // 
            // Resolvebutton
            // 
            this.Resolvebutton.Location = new System.Drawing.Point(142, 22);
            this.Resolvebutton.Name = "Resolvebutton";
            this.Resolvebutton.Size = new System.Drawing.Size(81, 26);
            this.Resolvebutton.TabIndex = 1;
            this.Resolvebutton.Text = "Resolve";
            this.Resolvebutton.UseVisualStyleBackColor = true;
            this.Resolvebutton.Click += new System.EventHandler(this.Resolvebutton_Click);
            // 
            // CopytoFilterbutton
            // 
            this.CopytoFilterbutton.Location = new System.Drawing.Point(12, 101);
            this.CopytoFilterbutton.Name = "CopytoFilterbutton";
            this.CopytoFilterbutton.Size = new System.Drawing.Size(105, 26);
            this.CopytoFilterbutton.TabIndex = 2;
            this.CopytoFilterbutton.Text = "Copy to Filter";
            this.CopytoFilterbutton.UseVisualStyleBackColor = true;
            this.CopytoFilterbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Resolvebutton);
            this.groupBox1.Controls.Add(this.HostTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Host Name or IP Address";
            // 
            // CopytoClipbutton
            // 
            this.CopytoClipbutton.Location = new System.Drawing.Point(133, 101);
            this.CopytoClipbutton.Name = "CopytoClipbutton";
            this.CopytoClipbutton.Size = new System.Drawing.Size(105, 26);
            this.CopytoClipbutton.TabIndex = 4;
            this.CopytoClipbutton.Text = "Copy to Clipboard";
            this.CopytoClipbutton.UseVisualStyleBackColor = true;
            this.CopytoClipbutton.Click += new System.EventHandler(this.CopytoClipbutton_Click);
            // 
            // iPTextBox
            // 
            this.iPTextBox.Enabled = false;
            this.iPTextBox.Location = new System.Drawing.Point(64, 72);
            this.iPTextBox.Name = "iPTextBox";
            this.iPTextBox.Size = new System.Drawing.Size(123, 26);
            this.iPTextBox.TabIndex = 0;
            this.iPTextBox.ToolTipText = "";
            // 
            // DNSResolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 134);
            this.Controls.Add(this.CopytoClipbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CopytoFilterbutton);
            this.Controls.Add(this.iPTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DNSResolver";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DNS Resolver";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Button Resolvebutton;
        private iptb.IPTextBox iPTextBox;
        private System.Windows.Forms.Button CopytoFilterbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CopytoClipbutton;
    }
}