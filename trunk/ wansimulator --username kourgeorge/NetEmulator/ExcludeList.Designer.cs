namespace NetEmulator
{
    partial class ExcludeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcludeList));
            this.AddIP = new System.Windows.Forms.Button();
            this.RemoveList = new System.Windows.Forms.Button();
            this.IPlistBox = new System.Windows.Forms.ListBox();
            this.OKList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExcludeRB = new System.Windows.Forms.RadioButton();
            this.IncludeRB = new System.Windows.Forms.RadioButton();
            this.Editbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IPTextBox = new iptb.IPTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddIP
            // 
            this.AddIP.Location = new System.Drawing.Point(130, 16);
            this.AddIP.Name = "AddIP";
            this.AddIP.Size = new System.Drawing.Size(75, 23);
            this.AddIP.TabIndex = 1;
            this.AddIP.Text = "Add";
            this.AddIP.UseVisualStyleBackColor = true;
            this.AddIP.Click += new System.EventHandler(this.AddIP_Click);
            // 
            // RemoveList
            // 
            this.RemoveList.Location = new System.Drawing.Point(130, 19);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(75, 23);
            this.RemoveList.TabIndex = 0;
            this.RemoveList.Text = "Remove";
            this.RemoveList.UseVisualStyleBackColor = true;
            this.RemoveList.Click += new System.EventHandler(this.RemoveList_Click);
            // 
            // IPlistBox
            // 
            this.IPlistBox.FormattingEnabled = true;
            this.IPlistBox.Location = new System.Drawing.Point(6, 17);
            this.IPlistBox.Name = "IPlistBox";
            this.IPlistBox.Size = new System.Drawing.Size(116, 160);
            this.IPlistBox.TabIndex = 0;
            // 
            // OKList
            // 
            this.OKList.Location = new System.Drawing.Point(130, 159);
            this.OKList.Name = "OKList";
            this.OKList.Size = new System.Drawing.Size(75, 23);
            this.OKList.TabIndex = 2;
            this.OKList.Text = "OK";
            this.OKList.UseVisualStyleBackColor = true;
            this.OKList.Click += new System.EventHandler(this.OKList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Editbutton);
            this.groupBox1.Controls.Add(this.OKList);
            this.groupBox1.Controls.Add(this.IPlistBox);
            this.groupBox1.Controls.Add(this.RemoveList);
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered IP List";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExcludeRB);
            this.groupBox3.Controls.Add(this.IncludeRB);
            this.groupBox3.Location = new System.Drawing.Point(130, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(77, 74);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Policy";
            // 
            // ExcludeRB
            // 
            this.ExcludeRB.AutoSize = true;
            this.ExcludeRB.Location = new System.Drawing.Point(10, 46);
            this.ExcludeRB.Name = "ExcludeRB";
            this.ExcludeRB.Size = new System.Drawing.Size(63, 17);
            this.ExcludeRB.TabIndex = 1;
            this.ExcludeRB.TabStop = true;
            this.ExcludeRB.Text = "Exclude";
            this.ExcludeRB.UseVisualStyleBackColor = true;
            // 
            // IncludeRB
            // 
            this.IncludeRB.AutoSize = true;
            this.IncludeRB.Location = new System.Drawing.Point(10, 23);
            this.IncludeRB.Name = "IncludeRB";
            this.IncludeRB.Size = new System.Drawing.Size(60, 17);
            this.IncludeRB.TabIndex = 0;
            this.IncludeRB.TabStop = true;
            this.IncludeRB.Text = "Include";
            this.IncludeRB.UseVisualStyleBackColor = true;
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(130, 48);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 1;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IPTextBox);
            this.groupBox2.Controls.Add(this.AddIP);
            this.groupBox2.Location = new System.Drawing.Point(4, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 43);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter IP Address";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(6, 16);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(116, 23);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.ToolTipText = "";
            // 
            // ExcludeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExcludeList";
            this.ShowInTaskbar = false;
            this.Text = "Filter Definition";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExcludeList_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExcludeList_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddIP;
        private System.Windows.Forms.Button RemoveList;
        private System.Windows.Forms.Button OKList;
        public System.Windows.Forms.ListBox IPlistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ExcludeRB;
        private System.Windows.Forms.RadioButton IncludeRB;
        private iptb.IPTextBox IPTextBox;
    }
}