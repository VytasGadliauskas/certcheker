using sslcheker;
using sslcheker.Control;
using sslcheker.Data;
using sslcheker.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sslcheker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///////////////       Operacijos         ///////////////

        private void AddRow(string hostname, int port)
        {
            dataGridView1.Rows.Add("", hostname, port, "", "", "", "", "");
        }

        private void LoadRows()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string fileName = Path.Combine(strWorkPath, "hosts.db");

            if (File.Exists(fileName))
            {
                using (StreamReader inputFile = new StreamReader(Path.Combine(strWorkPath, "hosts.db")))
                {
                    while (!inputFile.EndOfStream)
                    {
                        string[] line = inputFile.ReadLine().Split('|');
                        if (line.Length > 7)
                        {
                            dataGridView1.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7]);
                        }
                    }
                }
            }

            if (Operations2.isPeriodicalCheckEnabled())
            {
                timerPeriodicalCheck.Interval = 3600000 * PConfig.PERIODICALTIME > 0 ? PConfig.PERIODICALTIME : 1;
                timerPeriodicalCheck.Enabled = true;
                toolStripStatusLabelPeriodicalCheck.Text = "Periodical Check enabled: ON";
            }
        }

        private void SaveRows()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(strWorkPath, "hosts.db")))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string line = row.Cells[0].Value.ToString() +
                                  "|" + row.Cells[1].Value.ToString() +
                                  "|" + row.Cells[2].Value.ToString() +
                                  "|" + row.Cells[3].Value.ToString() +
                                  "|" + row.Cells[4].Value.ToString() +
                                  "|" + row.Cells[5].Value.ToString() +
                                  "|" + row.Cells[6].Value.ToString() +
                                  "|" + row.Cells[7].Value.ToString();

                    outputFile.WriteLine(line);
                }
                outputFile.Close();
            }

        }

        private void checkAllHosts() 
        {
            if (dataGridView1.Rows.Count > 0)
            {
                toolStripProgressBar1.Value = 0;

                int pogresStep = 1;

                if (dataGridView1.Rows.Count < 101)
                {
                    pogresStep = 100 / dataGridView1.Rows.Count;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    toolStripProgressBar1.Value += pogresStep;

                    DateTime localDate = DateTime.Now;

                    string host = row.Cells[1].Value.ToString();
                    int port = Int32.Parse(row.Cells[2].Value.ToString());

                    try
                    {
                        X509Certificate2 cert = null;
                        var client = new TcpClient(host, port);
                        var certValidation = new RemoteCertificateValidationCallback(delegate (object snd, X509Certificate certificate,
                                    X509Chain chainLocal, SslPolicyErrors sslPolicyErrors)
                        {
                            return true; //Accept every certificate, even if it's invalid
                        });

                        // Create an SSL stream and takeover client's stream
                        using (var sslStream = new SslStream(client.GetStream(), true, certValidation))
                        {
                            sslStream.AuthenticateAsClient(host);
                            var serverCertificate = sslStream.RemoteCertificate;
                            cert = new X509Certificate2(serverCertificate);

                            row.Cells[0].Value = "OK";
                            row.Cells[3].Value = cert.GetNameInfo(X509NameType.SimpleName, false);
                            row.Cells[4].Value = (cert.NotAfter - localDate).Days;
                            row.Cells[5].Value = cert.NotBefore;
                            row.Cells[6].Value = cert.NotAfter;
                            row.DefaultCellStyle.BackColor = Color.White;
                            if ((int)(cert.NotAfter - localDate).Days < PConfig.ERROR)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                row.Cells[0].Value = "ALERT";
                            }
                            else if ((int)(cert.NotAfter - localDate).Days < PConfig.WARNING)
                            {
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.Cells[0].Value = "WARNING";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        row.Cells[0].Value = ex.Message;
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    row.Cells[7].Value = localDate.ToString();
                }
                toolStripProgressBar1.Value = 100;
            }
        }

        /////////////////////////////////////////////////////

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd())
            {
                formAdd.ShowDialog();
                if (formAdd.port != 0)
                {
                    AddRow(formAdd.hostname, formAdd.port);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRows();
            RegistryOperations.Write();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryOperations.Read();
            LoadRows();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            checkAllHosts();
        }

        private void deleteToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void checkToolStripMenuItemCheck_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string host = row.Cells[1].Value.ToString();
            int port = Int32.Parse(row.Cells[2].Value.ToString());

            DateTime localDate = DateTime.Now;

            try
            {
                X509Certificate2 cert = null;
                var client = new TcpClient(host, port);
                var certValidation = new RemoteCertificateValidationCallback(delegate (object snd, X509Certificate certificate,
                            X509Chain chainLocal, SslPolicyErrors sslPolicyErrors)
                {
                    return true; //Accept every certificate, even if it's invalid
                });

                // Create an SSL stream and takeover client's stream
                using (var sslStream = new SslStream(client.GetStream(), true, certValidation))
                {
                    sslStream.AuthenticateAsClient(host);
                    var serverCertificate = sslStream.RemoteCertificate;
                    cert = new X509Certificate2(serverCertificate);

                    row.Cells[0].Value = "OK";
                    row.Cells[3].Value = cert.GetNameInfo(X509NameType.SimpleName, false);
                    row.Cells[4].Value = (cert.NotAfter - localDate).Days;
                    row.Cells[5].Value = cert.NotBefore;
                    row.Cells[6].Value = cert.NotAfter;
                    row.DefaultCellStyle.BackColor = Color.White;
                    if ((int)(cert.NotAfter - localDate).Days < PConfig.ERROR)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.Cells[0].Value = "ALERT";
                    }
                    else if ((int)(cert.NotAfter - localDate).Days < PConfig.WARNING)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.Cells[0].Value = "WARNING";
                    }
                }
            }
            catch (Exception ex)
            {
                row.Cells[0].Value = ex.Message;
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
            row.Cells[7].Value = localDate.ToString();
        }

        private void editToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            using (FormEdit formEdit = new FormEdit())
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                formEdit.hostname = row.Cells[1].Value.ToString();
                formEdit.port = Int32.Parse(row.Cells[2].Value.ToString());
                formEdit.ShowDialog();
                if (formEdit.port != 0)
                {
                    row.Cells[1].Value = formEdit.hostname;
                    row.Cells[2].Value = formEdit.port;
                }
            }
        }

        private void buttonWebScrab_Click(object sender, EventArgs e)
        {
            using (FormScann formScann = new FormScann())
            {
                formScann.dataGridView = dataGridView1;
                formScann.ShowDialog();
            }
        }

        private void showMoreToolStripMenuItemShowSertificate_Click(object sender, EventArgs e)
        {
            FormSSLDetails formSSLDetails = new FormSSLDetails();
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            formSSLDetails.hostname = row.Cells[1].Value.ToString();
            formSSLDetails.port = Int32.Parse(row.Cells[2].Value.ToString());
            formSSLDetails.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSeetings_Click(object sender, EventArgs e)
        {
            using (FormSeetings formSeetings = new FormSeetings())
            {
                formSeetings.ShowDialog();
                if (formSeetings.DialogResult == DialogResult.OK) 
                {
                    if (Operations2.isPeriodicalCheckEnabled())
                    {
                        timerPeriodicalCheck.Interval = 3600000 * PConfig.PERIODICALTIME > 0 ? PConfig.PERIODICALTIME : 1;
                        timerPeriodicalCheck.Enabled = true;
                        toolStripStatusLabelPeriodicalCheck.Text = "Periodical Check enabled: ON";
                    }
                    else 
                    {
                        timerPeriodicalCheck.Interval = 3600000 * PConfig.PERIODICALTIME > 0 ? PConfig.PERIODICALTIME : 1;
                        timerPeriodicalCheck.Enabled = false;
                        toolStripStatusLabelPeriodicalCheck.Text = "Periodical Check enabled: OFF";
                    }
                }
            }
        }

        private void buttonExportCsv_Click(object sender, EventArgs e)
        {
            string filename = "";

            using (SaveFileDialog saveFileDialogCsv = new SaveFileDialog())
            {
                saveFileDialogCsv.DefaultExt = ".csv";
                saveFileDialogCsv.Title = "Save Csv Files";
                saveFileDialogCsv.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialogCsv.CheckFileExists = true;
                saveFileDialogCsv.CheckPathExists = true;
                if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialogCsv.FileName;
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string line = row.Cells[0].Value.ToString() +
                                          "," + row.Cells[1].Value.ToString() +
                                          "," + row.Cells[2].Value.ToString() +
                                          "," + row.Cells[3].Value.ToString() +
                                          "," + row.Cells[4].Value.ToString() +
                                          "," + row.Cells[5].Value.ToString() +
                                          "," + row.Cells[6].Value.ToString() +
                                          "," + row.Cells[7].Value.ToString();

                            outputFile.WriteLine(line);
                        }
                        outputFile.Close();
                    }

                }

            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void timerPeriodicalCheck_Tick(object sender, EventArgs e)
        {
            
            


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormSSLDetails formSSLDetails = new FormSSLDetails();
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            formSSLDetails.hostname = row.Cells[1].Value.ToString();
            formSSLDetails.port = Int32.Parse(row.Cells[2].Value.ToString());
            formSSLDetails.ShowDialog();
        }
    }
    
}
