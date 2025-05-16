using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sslcheker
{
    public partial class FormEdit : Form
    {
        public string hostname { get; set; }
        public int port { get; set; }

        public FormEdit()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxHostname.Text.Length > 0)
            {
                hostname = textBoxHostname.Text;
                port = (int)numericUpDown1.Value;
                Close();
            }
            else 
            {
                textBoxHostname.BackColor = Color.Red;
            }


        }

        private void textBoxHostname_Click(object sender, EventArgs e)
        {
            textBoxHostname.BackColor = Color.White;
        }
    }
}
