using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetEmulator
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
           clocklabel.Text = DateTime.Now.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.TimeOfDay.ToString().Length < 10)
                clocklabel.Text = DateTime.Now.TimeOfDay.ToString();
            else
                clocklabel.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 10);
        }

    }
}
