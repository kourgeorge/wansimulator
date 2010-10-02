using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace NetEmulator
{
    public partial class NetMon : Form
    {
        public delegate void EventHandler(long pt);
        public EventHandler UpdateEvent;

        public NetMon()
        {
            InitializeComponent();
            UpdateEvent = new EventHandler(UpdateUI);
        }

        private void Monitor_Click(object sender, EventArgs e)
        {

            if (NetMontimer.Enabled == false)
            {

                NetMontimer.Enabled = true;
                Monitor.Text = "Stop";
                Host.Enabled = false;
                new Thread(PingHost).Start();
                PingTime.Text = "Pinging ...";
                PingTime.ForeColor = Color.Black;
                PingGraph.Value = 0;
                mstoolStrip.Visible = false;
            }

            else
            {
                NetMontimer.Enabled = false;
                Monitor.Text = "Monitor";
                Host.Enabled = true;
                PingGraph.Value = 0;
                PingTime.Text = "Ready";
                PingTime.ForeColor = Color.Black;
                mstoolStrip.Visible = false;


            }
        }
        /* Old code
        private void NetMontimer_Tick(object sender, EventArgs e)
        {
            PingHost();
            this.Update();
          
        }
         */
        // new code

        private void NetMontimer_Tick(object sender, EventArgs e)
        {

            new Thread(PingHost).Start();

        }

        public void PingHost()
        {
            try
            {
                Ping ping = new Ping();

                //Ping host (this will block until complete)

                PingReply response = ping.Send(Host.Text);

                //Process ping response

                if (response != null)
                {
                    //RTT = response.RoundtripTime;
                    if (response.Status == IPStatus.Success)
                        UpdateEvent(response.RoundtripTime);
                    else
                        if (NetMontimer.Enabled ==true) //update the UI to unreachable only if the monitor is running
                        UpdateEvent(int.MaxValue); //int.MaxValue simbols unreachable (timeout/wrong host)
                }

            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                if (NetMontimer.Enabled == true) //update the UI to unreachable only if the monitor is running
                    UpdateEvent(int.MaxValue);
            }
        }

       public void UpdateUI(long pingtime)
        {

            if (PingGraph.Control.InvokeRequired)
            {
                // this is worker thread
                EventHandler del = new EventHandler(UpdateUI);
                PingGraph.Control.Invoke(del, new object[] { pingtime });
            }
            else
            {
                // this is UI thread
                if (pingtime == int.MaxValue) //if Unreachable
                {
                    PingTime.Text = "Unreachable";
                    PingTime.ForeColor = Color.Red;
                    mstoolStrip.Visible = false;
                }
                else
                {
                    PingTime.ForeColor = Color.Black;
                    mstoolStrip.Visible = true;
                    if (pingtime < 1) PingTime.Text = "<1";
                    else
                        PingTime.Text = pingtime.ToString();

                    if ((int)pingtime > 900)
                        PingGraph.Value = 900;
                    else
                    {
                        PingGraph.Value = (int)pingtime;
                    }
                    plotter.Add((int)pingtime+10); // the 10 is to be able to see time 0 in the graph.


                }

            }
        }
       public static bool UrlIsValid(string smtpHost)
       {
           bool br = false;
           try
           {
               IPHostEntry ipHost = Dns.Resolve(smtpHost);
               br = true;
           }
           catch (SocketException se)
           {
               br = false;
           }
           return br;
       }
       private void NetMon_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (NetMontimer.Enabled == true)
           {
               NetMontimer.Enabled = false;
           }
       }


    }
}
