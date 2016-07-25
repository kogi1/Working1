using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace SolidShot_Tool
{
    public partial class FTP_Backup : MetroFramework.Forms.MetroForm
    {
        public FTP_Backup()
        {
            InitializeComponent();
        }
        string fullPath = "";
        string fileName = "";
        string path = "";
        string host = "ftp://178.33.211.91";
        string user = "solidshot1";
        string pass = "Kogikogi1q2w3e";
        string localFile = "";

        private void FTP_Backup_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var ftpWebRequest = (FtpWebRequest)WebRequest.Create(host + "/" + fileName);
            ftpWebRequest.Credentials = new NetworkCredential(user, pass);
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            using (var inputStream = File.OpenRead(localFile))
            using (var outputStream = ftpWebRequest.GetRequestStream())
            {
                var buffer = new byte[1024 * 1024];
                int totalReadBytesCount = 0;
                int readBytesCount;
                while ((readBytesCount = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, readBytesCount);
                    totalReadBytesCount += readBytesCount;
                    var progress = totalReadBytesCount * 100.0 / inputStream.Length;
                    backgroundWorker1.ReportProgress((int)progress);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (localFile == string.Empty)
            {
                MessageBox.Show("Bitte wählen Sie eine Datei!");
                return;
            }
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                fullPath = openFileDialog1.FileName;
                fileName = openFileDialog1.SafeFileName;
                path = fullPath.Replace(fileName, "");



                //MessageBox.Show(fullPath + " Voller Pfad");
                // MessageBox.Show(fileName + " Filename");
                // MessageBox.Show(path + " Pfad");
                txtFile.Text = fullPath;
                localFile = fullPath;
            }
        }

        private void FTP_Backup_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            MessageBox.Show("Finished");
            metroProgressBar1.Value = 0;
        }
    }
}
