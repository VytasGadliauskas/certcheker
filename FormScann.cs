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
    public partial class FormScann : Form
    {
        public FormScann()
        {
            InitializeComponent();
        }

        public DataGridView dataGridView { set; get; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonScann_Click(object sender, EventArgs e)
        {
            buttonScann.Enabled = false;
            try
            {
                if (Int32.Parse(maskedTextBox4.Text) <= Int32.Parse(maskedTextBoxEnd.Text))
                {
                    for (int i = Int32.Parse(maskedTextBox4.Text); i < Int32.Parse(maskedTextBoxEnd.Text)+1; i++)
                    {
                        string IP = maskedTextBox1.Text+"."+maskedTextBox2.Text+"."+maskedTextBox3.Text+"."+i;
                        richTextBoxLog.AppendText(IP + ":" + (int)numericUpDownPort.Value + " - ");
                        if (ScanOperations.IsPortOpen(IP, (int)numericUpDownPort.Value, (int)numericUpDownTimeout.Value))
                        {
                            richTextBoxLog.AppendText("OK\r\n");
                            dataGridView.Rows.Add("", ScanOperations.resolveIp(IP), (int)numericUpDownPort.Value, "", "", "", "", "");
                        }
                        else
                        {
                            richTextBoxLog.AppendText("...\r\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                richTextBoxLog.AppendText(ex.Message+ "\r\n");
            }
            buttonScann.Enabled = true;
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox1.Text))
            {
                maskedTextBox5.Text = maskedTextBox1.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox1.Text))
                {
                    maskedTextBox1.BackColor = Color.Red;
                }
                maskedTextBox2.Focus();
            }
            maskedTextBox1.Text = ScanOperations.removeNotNumbers(maskedTextBox1.Text);
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox2.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox2.Text))
            {
                maskedTextBox6.Text = maskedTextBox2.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox2.Text))
                {
                    maskedTextBox2.BackColor = Color.Red;
                }
                maskedTextBox3.Focus();
            }
            maskedTextBox2.Text = ScanOperations.removeNotNumbers(maskedTextBox2.Text);
        }

        private void maskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox3.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox3.Text))
            {
                maskedTextBox7.Text = maskedTextBox3.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox3.Text))
                {
                    maskedTextBox3.BackColor = Color.Red;
                }
                maskedTextBox4.Focus();
            }
            maskedTextBox3.Text = ScanOperations.removeNotNumbers(maskedTextBox3.Text);
        }

        private void maskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox4.Text))
            {
                if (!ScanOperations.validateIpOctet(maskedTextBox4.Text))
                {
                    maskedTextBox4.BackColor = Color.Red;
                }
                maskedTextBoxEnd.Focus();
            } 
            maskedTextBox4.Text = ScanOperations.removeNotNumbers(maskedTextBox4.Text);
        }

        private void maskedTextBoxEnd_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBoxEnd.Text))
            {
                if (!ScanOperations.validateIpOctet(maskedTextBoxEnd.Text))
                {
                    maskedTextBox4.BackColor = Color.Red;
                }
                buttonScann.Enabled = false;
            }
            maskedTextBoxEnd.Text = ScanOperations.removeNotNumbers(maskedTextBoxEnd.Text);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox5.Text = maskedTextBox1.Text;
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox6.Text = maskedTextBox2.Text;
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox7.Text = maskedTextBox3.Text;
        }

    }
}
