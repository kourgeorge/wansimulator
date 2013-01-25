using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetEmulator
{
    public partial class Stopper : Form
    {
        private TimeSpan EllapsedTime = TimeSpan.Zero;
        public Stopper()
        {
            InitializeComponent();
        }

        private void Stopper_Load(object sender, EventArgs e)
        {

            StopperTB.Text = EllapsedTime.ToString();

        }

        private void StartStopper_Click(object sender, EventArgs e)
        {
            if (Stoppertimer.Enabled == false)
            {
                Stoppertimer.Enabled = true;
                StopperButton.Text = "Stop";
            }
            else
            {
                Stoppertimer.Enabled = false;
                StopperButton.Text = "Start";
            }

        }

        private void Stoppertimer_Tick(object sender, EventArgs e)
        {
            EllapsedTime=EllapsedTime.Add(new TimeSpan(0, 0, 0, 1));
            StopperTB.Text = EllapsedTime.ToString();
        }

        private void StopStopper_Click(object sender, EventArgs e)
        {
            Stoppertimer.Enabled = false;
        }

        private void ResetStopper_Click(object sender, EventArgs e)
        {
            EllapsedTime = TimeSpan.Zero;
            StopperTB.Text = EllapsedTime.ToString();
        }

    }
}
