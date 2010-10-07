using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace NetEmulator
{
    public partial class DNSResolver : Form
    {
        ExcludeList father;
        public delegate void EventHandler(String IPText);
        public EventHandler UpdateEvent;


        public DNSResolver(ExcludeList father)
        {
            InitializeComponent();
            this.father = father;
            UpdateEvent = new EventHandler(UpdateUI);
            CopytoClipbutton.Enabled = false;
            CopytoFilterbutton.Enabled = false;
        }

        private void Resolvebutton_Click(object sender, EventArgs e)
        {
            iPTextBox.Text = "";
            if (HostTextBox.Text != "")
            {
                Resolvebutton.Enabled = false;
                Resolvebutton.Text = "Resolving...";
                CopytoClipbutton.Enabled = false;
                CopytoFilterbutton.Enabled = false;
                HostTextBox.Enabled = false;
                Refresh();
                new Thread(Resolve).Start();

            }
        }

        public void Resolve()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(HostTextBox.Text);
                
                for (int i=0; i<ipHost.AddressList.Length ; ++i)
                {
                    if (ipHost.AddressList[i].AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
                    {
                        string IPText = ipHost.AddressList[i].ToString();
                        UpdateEvent(IPText);
                        return;

                    }
                }
                throw new Exception("No IPv4 Address Found.");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                UpdateEvent("Exeption");
            }

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            father.IPTextBox.Text = iPTextBox.Text;
            
        }

        public void UpdateUI(string IPText)
        {

            if (iPTextBox.InvokeRequired)
            {
                // this is worker thread
                EventHandler del = new EventHandler(UpdateUI);
                iPTextBox.Invoke(del, new object[] { IPText });
            }
            else
            {
                if (IPText == "Exeption") { /* do nothing*/ }
                else
                {
                    iPTextBox.Text = IPText;
                }
                Resolvebutton.Enabled = true;
                Resolvebutton.Text = "Resolve";
                CopytoFilterbutton.Enabled = true;
                CopytoClipbutton.Enabled = true;
                HostTextBox.Enabled = true;

            }
        }

        private void CopytoClipbutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(iPTextBox.Text);
        }
    }
}
