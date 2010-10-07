using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Xml;

namespace NetEmulator
{
    public partial class Form1 : Form
    {
        private string Appdirectory;
        public LinkedList<String> FilteredIPLinkedList = new LinkedList<String>();
        public bool IncludePolicy;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Appdirectory = Directory.GetCurrentDirectory();
            stopB.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            StopStrip.Enabled = false;
            IncludePolicy = false;
            BWcomboBox.SelectedIndex=15;  //select Unrestricted
        }
        private string IncludePolicySimulationString()
        {
            string Configuration;
            if (ModetabControl.SelectedTab.Name == "BasicTab")
                Configuration = SimulationConfiguration();
            else Configuration = AdvancedSimulationConfiguration();

            foreach (string IPString in FilteredIPLinkedList)
            {
                Configuration += "ipfw add 100 pipe 1 src-ip " + IPString + " in\r\n";
                Configuration += "ipfw add 200 pipe 2 dst-ip " + IPString + " out\r\n";
            }
            return Configuration;
        }

        private string ExcludePolicySimulationString()
        {
            string Configuration = "";
            int rulenum = 100;
            foreach (string IPString in FilteredIPLinkedList)
            {
                Configuration += "ipfw add " + rulenum + " skipto 20000 all from " + IPString + " to any\r\n";
                ++rulenum;
                Configuration += "ipfw add " + rulenum + " skipto 20000 all from any to " + IPString + "\r\n";
                ++rulenum;
            }
            //Handle all the other (included in the simulation)
            Configuration += "\r\n";
            if (ModetabControl.SelectedTab.Name == "BasicTab")
                Configuration += SimulationConfiguration();
            else Configuration += AdvancedSimulationConfiguration();

            Configuration += "ipfw add pipe 1 ip from any to any in\r\n";
            Configuration += "ipfw add pipe 2 ip from any to any out\r\n";

            return Configuration;
        }

        private string SimulationConfiguration()
        {
            string configuration = "";
            //define 2 half duplex pipes 
            for (int i = 1; i <= 2; i++)
            {
                configuration += "ipfw pipe " + i + " config ";
                configuration += "delay " + DelayTB.Value * 40 + "ms ";

                if (BWLabel.Text != "Unrestricted")
                {
                    configuration += "bw " + BWLabel.Text + "Kbit/s ";
                }

                if (PLTB.Value != 0)
                {
                    double val = Convert.ToInt32(PLLabel.Text) / 100.0;
                    configuration += "plr " + val;
                }

                configuration += " mask all";
                configuration += "\r\n";
            }
            return configuration;
        }

        private string AdvancedSimulationConfiguration()
        {
            string configuration = "";
            //define 2 half duplex pipes 
            for (int i = 1; i <= 2; i++)
            {
                configuration += "ipfw pipe " + i + " config ";
                configuration += "delay " + DelaytextBox.Text + "ms ";

                if (BWcomboBox.SelectedText != "Unrestricted")
                {
                    configuration += "bw " + BWcomboBox.SelectedText + "Kbit/s ";
                }

                if (PLtextBox.Text != "0")
                {
                    double val = Convert.ToInt32(PLtextBox.Text) / 100.0;
                    configuration += "plr " + val;
                }

                configuration += " mask all";
                configuration += "\r\n";
            }
            return configuration;
        }
        private void start_Click(object sender, EventArgs e)
        {

            try
            {
                //create a batch file
                string batchPath = System.IO.Path.Combine(Appdirectory, "emulation_start.bat");
                FileInfo fi = new FileInfo(batchPath);

                StreamWriter sw = fi.CreateText();
                //The List Of Operations you want to execute.

                sw.WriteLine("@set CYGWIN=nodosfilewarning");
                sw.WriteLine("@ipfw -q flush");
                sw.WriteLine("@ipfw -q pipe flush");

                if (IncludePolicy == true)
                    sw.WriteLine(IncludePolicySimulationString());
                else
                    sw.WriteLine(ExcludePolicySimulationString());

                sw.WriteLine("ipfw pipe show");
                sw.Close();


                // handle and start the process
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo(fi.FullName);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;


                procStartInfo.CreateNoWindow = true;
                procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = procStartInfo;

                procStartInfo.WorkingDirectory = Appdirectory;
                process.Start();


                //get the process output
                StringBuilder sb = new StringBuilder();
                string strLine;

                while ((strLine = process.StandardOutput.ReadLine()) != null)
                {
                    sb.AppendLine(strLine);
                }

                string RunOutput = sb.ToString();
                if (RunOutput.Contains("cannot talk to kernel module"))
                {
                    throw (new Exception("The needed driver is not installed on your Network Device.\nPlease refer the Help for more information"));
                }

                startB.Enabled = false;
                stopB.Enabled = true;
                StartStrip.Enabled = false;
                StopStrip.Enabled = true;
                MainPanel.Enabled = false;
                ModetabControl.Enabled = false;
                Listbutton.Enabled = false;
                excludeListStrip.Enabled = false;
                startToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
                MainNotifyIcon.Text = "WANsim\nStatus: Running";
                MainNotifyIcon.BalloonTipTitle = "WANsim";
                MainNotifyIcon.BalloonTipText = "Network Simulation is Running";
                MainNotifyIcon.ShowBalloonTip(50);
                ConfigurationgroupBox.Enabled = false;
                loadConfigurationToolStrip.Enabled = false;
                saveConfigurationToolStrip.Enabled = false;
                this.Text = "WANsim (Running)";
                MainNotifyIcon.Icon = new Icon("run.ico");

            }
            catch (Exception exp)
            {
                string message = "Error has occured, please contact the author.\r\n\r\n" + "More Information:\r\n" + exp.Message;
                MessageBox.Show(message);
            }
        }




        private void stopB_Click(object sender, EventArgs e)
        {
            try
            {
                //create a batch file
                string batchPath = System.IO.Path.Combine(Appdirectory, "emulation_stop.bat");
                FileInfo fi = new FileInfo(batchPath);

                StreamWriter sw = fi.CreateText();
                //The List Of Operations you want to execute.

                sw.WriteLine("@ipfw -q flush");
                sw.WriteLine("@ipfw -q pipe flush");
                sw.Close();

                //try this
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo(fi.FullName);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;


                procStartInfo.CreateNoWindow = true;
                procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //additional options
                procStartInfo.WorkingDirectory = Appdirectory;


                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = procStartInfo;
                procStartInfo.WorkingDirectory = Appdirectory;
                process.Start();


                //additional options

                StringBuilder sb = new StringBuilder();
                string strLine;

                while ((strLine = process.StandardOutput.ReadLine()) != null)
                {
                    sb.AppendLine(strLine);
                }

                string RunOutput = sb.ToString();
                /* not needed in the stop
                if (RunOutput.Contains("cannot talk to kernel module"))
                {
                    throw (new Exception("The needed driver is not installed on your Network Device.\nPlease refer the Help for more information"));
                }
                */

                if (startB.Enabled == false) // do all this only if the simulation is started.
                {
                    startB.Enabled = true;
                    stopB.Enabled = false;
                    StartStrip.Enabled = true;
                    StopStrip.Enabled = false;
                    MainPanel.Enabled = true;
                    ModetabControl.Enabled = true;
                    Listbutton.Enabled = true;
                    excludeListStrip.Enabled = true;
                    startToolStripMenuItem.Enabled = true;
                    stopToolStripMenuItem.Enabled = false;
                    MainNotifyIcon.Text = "WANsim\nStatus: Ready";
                    MainNotifyIcon.BalloonTipTitle = "WANsim Emulator";
                    MainNotifyIcon.BalloonTipText = "Network Simulation Stopped";
                    MainNotifyIcon.ShowBalloonTip(50);
                    ConfigurationgroupBox.Enabled = true;
                    loadConfigurationToolStrip.Enabled = true;
                    saveConfigurationToolStrip.Enabled = true;
                    this.Text = "WANsim";
                    MainNotifyIcon.Icon = new Icon("state1.ico");
                }
            }
            catch (Exception exp)
            {
                string message = "Error has occured, please contact the author.\r\n\r\n" + "More Information:\r\n" + exp.Message;
                MessageBox.Show(message);
            }
        }


        private void BWTB_Scroll(object sender, EventArgs e)
        {
            switch (BWTB.Value)
            {
                case 0: BWLabel.Text = "Unrestricted"; kbps.Visible = false; break;
                case 1: BWLabel.Text = "1544"; kbps.Visible = true; break;
                case 2: BWLabel.Text = "255"; kbps.Visible = true; break;
                case 3: BWLabel.Text = "64"; kbps.Visible = true; break;
                case 4: BWLabel.Text = "33.6"; kbps.Visible = true; break;
                case 5: BWLabel.Text = "14.4"; kbps.Visible = true; break;
            }
        }

        private void DelayTB_Scroll(object sender, EventArgs e)
        {
            DelayLabel.Text = (DelayTB.Value * 40).ToString();
        }

        private void PLTB_Scroll(object sender, EventArgs e)
        {
            switch (PLTB.Value)
            {
                case 0: PLLabel.Text = "0"; break;
                case 1: PLLabel.Text = "0.2"; break;
                case 2: PLLabel.Text = "1"; break;
                case 3: PLLabel.Text = "2"; break;
                case 4: PLLabel.Text = "5"; break;
                case 5: PLLabel.Text = "15"; break;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stopperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stopper StopperForm = new Stopper();
            StopperForm.Show();
        }

        private void clockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clock ClockForm = new Clock();
            ClockForm.Show();
        }

        private void netMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetMon NetMonForm = new NetMon();
            NetMonForm.Show();
        }


        private void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void excludeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcludeList excludeForm = new ExcludeList(this);
            excludeForm.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
        }

        private void saveConfigurationStrip_Click(object sender, EventArgs e)
        {
            string savedFile = "";
            XmlDocument xmldoc;
            xmldoc = new XmlDocument();

            XmlDeclaration xmlDec;
            xmlDec = xmldoc.CreateXmlDeclaration("1.0", null, null);
            xmlDec.Encoding = "UTF-8";

            XmlElement ConfigurationDescription = xmldoc.CreateElement("", "ConfigurationDescription", "");

            //Delay Description
            XmlElement Delay = xmldoc.CreateElement("", "Delay", "");
            XmlText actual_Delay = xmldoc.CreateTextNode(DelayTB.Value.ToString());
            Delay.AppendChild(actual_Delay);

            //PacketLoss Description
            XmlElement PacketLoss = xmldoc.CreateElement("", "PacketLoss", "");
            XmlText actual_PacketLoss = xmldoc.CreateTextNode(PLTB.Value.ToString());
            PacketLoss.AppendChild(actual_PacketLoss);

            //BandWidth Description
            XmlElement BandWidth = xmldoc.CreateElement("", "BandWidth", "");
            XmlText actual_BandWidth = xmldoc.CreateTextNode(BWTB.Value.ToString());
            BandWidth.AppendChild(actual_BandWidth);

            //Policy Description
            XmlElement Policy = xmldoc.CreateElement("", "Policy", "");
            XmlText actual_Policy;
            if (IncludePolicy == true)
                actual_Policy = xmldoc.CreateTextNode("Include");
            else actual_Policy = xmldoc.CreateTextNode("Exclude");
            Policy.AppendChild(actual_Policy);

            //Filtered IP List Description
            XmlElement XMLFilteredIPList = xmldoc.CreateElement("", "FilteredIPList", "");
            foreach (string item in FilteredIPLinkedList)
            {
                XmlElement IPelement = xmldoc.CreateElement("", "IPelement", "");
                XmlText IP_Item = xmldoc.CreateTextNode(item);
                IPelement.AppendChild(IP_Item);
                XMLFilteredIPList.AppendChild(IPelement);
            }
            //build Up the XML
            ConfigurationDescription.AppendChild(Delay);
            ConfigurationDescription.AppendChild(PacketLoss);
            ConfigurationDescription.AppendChild(BandWidth);
            ConfigurationDescription.AppendChild(Policy);
            ConfigurationDescription.AppendChild(XMLFilteredIPList);


            xmldoc.AppendChild(ConfigurationDescription);
            xmldoc.InsertBefore(xmlDec, ConfigurationDescription);


            // treat the Save File Dialog
            saveFD.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            saveFD.Title = "Save Configuration As";
            saveFD.FileName = "EmulationConf.xml";
            saveFD.Filter = "XML Files|*.xml|All Files|*.*";
            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                savedFile = saveFD.FileName;
                xmldoc.Save(savedFile);
            }
        }

        private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                openFD.Title = "Load Configuration file";
                openFD.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                openFD.FileName = "*.xml";
                openFD.Filter = "XML Files|*.xml|All Files|*.*";
                string Chosen_File = "";
                if (openFD.ShowDialog() != DialogResult.Cancel)
                {

                    Chosen_File = openFD.FileName;
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(Chosen_File);

                    //Delay
                    XmlNodeList DelayNode = xmldoc.GetElementsByTagName("Delay");
                    string actual_Delay = DelayNode[0].InnerText;
                    DelayTB.Value = Convert.ToInt32(actual_Delay);

                    //Packet Loss
                    XmlNodeList PLNode = xmldoc.GetElementsByTagName("PacketLoss");
                    string actual_PL = PLNode[0].InnerText;
                    PLTB.Value = Convert.ToInt32(actual_PL);

                    //BandWidth
                    XmlNodeList BWNode = xmldoc.GetElementsByTagName("BandWidth");
                    string actual_BW = BWNode[0].InnerText;
                    BWTB.Value = Convert.ToInt32(actual_BW);

                    //Policy
                    XmlNodeList PolicyNode = xmldoc.GetElementsByTagName("Policy");
                    if (PolicyNode[0] != null) //backward compitability
                    {
                        string actual_Policy = PolicyNode[0].InnerText;
                        if (actual_Policy == "Include")
                            IncludePolicy = true;
                        else
                            IncludePolicy = false;
                    }
                    //clear the Exclude list
                    FilteredIPLinkedList.Clear();
                    XmlNodeList IPelements = xmldoc.GetElementsByTagName("IPelement");
                    foreach (XmlNode IPElement in IPelements)
                    {
                        if (ExcludeList.IsValidIP(IPElement.InnerText))
                        {
                            FilteredIPLinkedList.AddLast(IPElement.InnerText);
                        }
                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("An error occured while loading the Configuration xml file.\r\nPlease contact the author.\r\n\r\nMore Information:\r\n: " + exp.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopB_Click(sender, e);
            MainNotifyIcon.Dispose();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainNotifyIcon.Visible = false;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DelayTB.Value = PLTB.Value = BWTB.Value = 0;
            IncludePolicy = false;
            FilteredIPLinkedList.Clear();
            stopB_Click(sender, e);
        }

        private void Form1timer_Tick(object sender, EventArgs e)
        {
            if (MainNotifyIcon.Icon == new Icon("run.ico"))
            {
                throw new Exception("working");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DelaytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar == 8)
                    DelaytextBox.Text.Remove(DelaytextBox.Text.Length - 1, 1);
                else if ((Convert.ToInt32((DelaytextBox.Text + e.KeyChar)) > 8000))
                {
                    DelaytextBox.Text = "8000";
                    DelaytextBox.SelectAll();
                    e.Handled = true;
                }

            }
            else
                e.Handled = true;
        }

        private void PLtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar == 8)
                    PLtextBox.Text.Remove(PLtextBox.Text.Length - 1, 1);
                else if ((Convert.ToInt32((PLtextBox.Text + e.KeyChar)) > 90))
                {
                    PLtextBox.Text = "90";
                    PLtextBox.SelectAll();
                    e.Handled = true;
                }

            }
            else
                e.Handled = true;
        }

        private void BWcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar == 8)
                    PLtextBox.Text.Remove(PLtextBox.Text.Length - 1, 1);
                else if ((Convert.ToInt32((PLtextBox.Text + e.KeyChar)) > 10240.0))
                {
                    PLtextBox.Text = "Unrestricted";
                    PLtextBox.SelectAll();
                    e.Handled = true;
                }

            }
            else
                e.Handled = true;
        }
    }

}
