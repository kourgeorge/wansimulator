using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetEmulator
{
    public partial class ExcludeList : Form
    {
        private Form1 m_parent;
        public ExcludeList(Form1 m_parent1)
        {
            InitializeComponent();
            m_parent = m_parent1;

        }

        private void AddIP_Click(object sender, EventArgs e)
        {
            if (IsValidIP(IPTextBox.Text))
            {
                
                string IP = IPTextBox.Text.Trim();

                if (!IPlistBox.Items.Contains(IP))
                {
                    IPlistBox.Items.Add(IPTextBox.Text);
                    m_parent.FilteredIPLinkedList.AddLast(IPTextBox.Text);
                    IPTextBox.Text = "";
                }
            }
        }

        private void RemoveList_Click(object sender, EventArgs e)
        {
            if (IPlistBox.SelectedItem!=null)
            {
                m_parent.FilteredIPLinkedList.Remove(IPlistBox.SelectedItem.ToString());
                IPlistBox.Items.Remove(IPlistBox.SelectedItem);
            }
        }

        private void OKList_Click(object sender, EventArgs e)
        {
            //Update the policy
            if (IncludeRB.Checked==true) m_parent.IncludePolicy = true;
            else m_parent.IncludePolicy = false;

            this.Close();
            
        }

        private void ExcludeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_parent.Show();
        }
        
        public static bool IsValidIP(string IPstr)
        {
            try
            {
                string[] literals = IPstr.Split('.');
                if (literals.Length != 4) return false;
                foreach (string literal in literals)
                {
                    if (literal == "")
                        return false;
                    else if (Convert.ToInt32(literal) > 255 || Convert.ToInt32(literal) < 0)
                        return false;
                }
                return true;
            }
            catch (Exception exp)
            { return false; }
        }

        private void ExcludeList_Load(object sender, EventArgs e)
        {
            if (m_parent.IncludePolicy == true)
                IncludeRB.Checked = true;
            else ExcludeRB.Checked = true;

            foreach (string item in m_parent.FilteredIPLinkedList)
            {
                IPlistBox.Items.Add(item);
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (IPlistBox.SelectedItem != null)
            {
                IPTextBox.Text = IPlistBox.SelectedItem.ToString();
                RemoveList_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DNSResolver DNSWindow = new DNSResolver(this);
            DNSWindow.ShowDialog();
        }
    }
}
