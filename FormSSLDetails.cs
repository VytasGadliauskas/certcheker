﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sslcheker
{
    public partial class FormSSLDetails : Form
    {
        public string hostname { set; get; }
        public int port { set; get; }

        public FormSSLDetails()
        {
            InitializeComponent();
        }

        private void FormSSLDetails_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            try
            {
                X509Certificate2 cert = null;
                var client = new TcpClient(hostname, port);
                var certValidation = new RemoteCertificateValidationCallback(delegate (object snd, X509Certificate certificate,
                            X509Chain chainLocal, SslPolicyErrors sslPolicyErrors)
                {
                    return true; //Accept every certificate, even if it's invalid
                });

                // Create an SSL stream and takeover client's stream
                using (var sslStream = new SslStream(client.GetStream(), true, certValidation))
                {
                    sslStream.AuthenticateAsClient(hostname);
                    var serverCertificate = sslStream.RemoteCertificate;
                    cert = new X509Certificate2(serverCertificate);
                    richTextBox1.AppendText("HOSTNAME : "+hostname+":"+port+"\r\n\n");

                    richTextBox1.AppendText("Issued To:\r\n");
                    richTextBox1.AppendText("      CN : " + cert.GetNameInfo(X509NameType.SimpleName, false)+"\r");
                    richTextBox1.AppendText("      Url : " + cert.GetNameInfo(X509NameType.UrlName, false) + "\r");
                    richTextBox1.AppendText("      Email : " + cert.GetNameInfo(X509NameType.EmailName, false) + "\r");
                    richTextBox1.AppendText("      DNS : " + cert.GetNameInfo(X509NameType.DnsName, false) + "\r\n");

                    richTextBox1.AppendText("Issued By: \r\n");
                    richTextBox1.AppendText("      CN : " + cert.Issuer + "\r\n");

                    richTextBox1.AppendText("Valid period:\r\n");
                    richTextBox1.AppendText("      Issued on : "+ cert.NotBefore+"\r");
                    richTextBox1.AppendText("      Expires on : " + cert.NotAfter + "\r");
                    richTextBox1.AppendText("      Days to expire : " + (cert.NotAfter - localDate).Days + "\r\n");

                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }
    }
}
