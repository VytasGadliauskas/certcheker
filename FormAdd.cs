using sslcheker.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sslcheker
{

    public partial class FormAdd : Form
    {
        public string hostname { get; set; }
        public int port { get; set;} 

        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxHostname.Text.Length > 0)
            {
                if (checkBoxResolve.Checked)
                {
                    try
                    {
                        IPAddress address = IPAddress.Parse(textBoxHostname.Text);
                        IPHostEntry host = Dns.GetHostEntry(address);
                        hostname = host.HostName;
                        port = (int)numericUpDownPort.Value;
                        Close();
                    } 
                    catch 
                    {
                        hostname = textBoxHostname.Text;
                        port = (int)numericUpDownPort.Value;
                        Close();
                    }
                }
                else 
                { 
                    hostname = textBoxHostname.Text;
                    port = (int)numericUpDownPort.Value;
                    Close();
                }
            }
            else {
                textBoxHostname.BackColor = Color.Red;
            }
        }

        private void textBoxHostname_Click(object sender, EventArgs e)
        {
            textBoxHostname.BackColor = Color.White;
        }
    }
}
