using sslcheker.Data;
using sslcheker.Operations;
using sslcheker.Properties;
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
    public partial class FormSeetings : Form
    {

        public FormSeetings()
        {
            InitializeComponent();
        }

        private void FormSeetings_Load(object sender, EventArgs e)
        {
            numericUpDownErrorDays.Value = PConfig.ERROR;
            numericUpDownWarningDays.Value = PConfig.WARNING;
            numericUpDownMinutes.Value = PConfig.PERIODICALTIME;
            checkBoxPeriodicCheck.Checked = PConfig.PERIODICALCHECK==1?true:false;
            checkBoxEnableMail.Checked = PConfig.EMAILENABLE==1?true:false;
            textBoxSmtpHost.Text = PConfig.SMTPHOST;
            numericUpDownSmtpPort.Value = PConfig.SMTPPORT;
            textBoxMailFrom.Text = PConfig.EMAILFROM;
            textBoxMailTo.Text = PConfig.EMAILTO;
            if (checkBoxEnableMail.Checked)
            {
                buttonTestEmail.Enabled = true;
            }
            else {
                buttonTestEmail.Enabled = false;
            }
            textBoxUser.Text = PConfig.SMTPUSER;
            textBoxPassword.Text = PConfig.SMTPPASSWORD;
            checkBoxAutentificate.Checked = PConfig.SMTPAUTENTIFICATE==1?true:false;
            checkBoxEnableSSL.Checked = PConfig.SMTPSSL==1?true:false;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            PConfig.ERROR = Int32.Parse(numericUpDownErrorDays.Value.ToString());
            PConfig.WARNING = Int32.Parse(numericUpDownWarningDays.Value.ToString());
            PConfig.PERIODICALTIME = Int32.Parse(numericUpDownMinutes.Value.ToString()); 
            PConfig.PERIODICALCHECK = checkBoxPeriodicCheck.Checked ? 1 : 0;
            PConfig.EMAILENABLE = checkBoxEnableMail.Checked ? 1 : 0;
            PConfig.SMTPHOST = textBoxSmtpHost.Text;
            PConfig.SMTPPORT = Int32.Parse(numericUpDownSmtpPort.Value.ToString());
            PConfig.EMAILFROM = textBoxMailFrom.Text;
            PConfig.EMAILTO = textBoxMailTo.Text;
            PConfig.SMTPUSER = textBoxUser.Text;
            PConfig.SMTPPASSWORD = textBoxPassword.Text;
            PConfig.SMTPAUTENTIFICATE = checkBoxAutentificate.Checked ? 1 : 0;
            PConfig.SMTPSSL = checkBoxEnableSSL.Checked ? 1 : 0;
            Close();
        }


        private void buttonTestEmail_Click(object sender, EventArgs e)
        {
            Operations2.sendEmai("Test from SSL cheker to "+PConfig.EMAILTO , "Test from SSL cheker");
        }

        private void checkBoxEnableMail_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableMail.Checked)
            {
                buttonTestEmail.Enabled = true;
            }
            else
            {
                buttonTestEmail.Enabled = false;
            }
        }
    }
}
