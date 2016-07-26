using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidShot_Tool
{
    public partial class FTP_Browser_Kunden : MetroFramework.Forms.MetroForm
    {
        public FTP_Browser_Kunden()
        {
            InitializeComponent();
        }
        string[] kdnr;
        string fullPath;
        bool download = false;
        string downpath = "";
        


        private void FTP_Browser_Kunden_Load(object sender, EventArgs e)
        {
            string fasfasf = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/KdNr.php");
            int i = 0;
            while (i < fasfasf.Split(new string[] { "\n" }, StringSplitOptions.None).Length)
            {
                string[] lol = fasfasf.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (lol[i] != "")
                {
                    string[] lel = lol[i].Split(new string[] { "_~_" }, StringSplitOptions.None);
                    metroComboBox1.Items.Add("Unternehmen:" + lel[1] + " |" + lel[0]);
                }
                i++;
            }
            try
            {
                downpath = System.IO.File.ReadAllText("asclib.dll");
                metroLabel3.Text = "Download Directory festgelegt: Ja";
                download = true;

            }
            catch (Exception)
            {
                metroLabel3.Text = "Download Directory festgelegt: Nein";
                download = false;
                return;
            }
            
        }





        private void FTP_Browser_Kunden_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FTP_Main abc = new FTP_Main();
            abc.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == string.Empty)
            {
                MessageBox.Show("Bitte wählen Sie einen Kunden aus!");
                return;
            }
            else {
                getdata();
            }
        }

        private void getdata()
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://178.33.211.91/" + kdnr[1]);
            ftpRequest.Credentials = new NetworkCredential("solidshot2", "Kogikogi1q2w3e");
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            List<string> directories = new List<string>();

            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                directories.Add(line);
                line = streamReader.ReadLine();
            }

            streamReader.Close();
            listBox1.DataSource = directories;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kdnr = metroComboBox1.Text.Split(new string[] { "|" }, StringSplitOptions.None);
            Console.WriteLine(kdnr[1]);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox1.Text = listBox1.SelectedItem.ToString();
        }
        private void DownloadFile(string ftpSourceFilePath)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[2048];

            FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create("ftp://178.33.211.91/" + ftpSourceFilePath);
            ftpClient.Credentials = new System.Net.NetworkCredential("solidshot2", "Kogikogi1q2w3e");
            ftpClient.Method = WebRequestMethods.Ftp.DownloadFile;

            Stream reader = ftpClient.GetResponse().GetResponseStream();
            //File.SetAttributes("", FileAttributes.Normal);
            string[] datei = metroTextBox1.Text.Split(new string[] { "/" }, StringSplitOptions.None);
            FileStream fileStream = new FileStream(datei[1], FileMode.Create);

            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;

                fileStream.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();
            string sad = System.IO.Directory.GetCurrentDirectory();
            string output = datei[1].Substring(datei[1].IndexOf('K'));
            string path = downpath.Substring(0, downpath.LastIndexOf(@"\") + 1);
            string test = path + output;
            
            
            System.IO.File.Copy(datei[1], test, true);
            System.IO.File.Delete(datei[1]);
            MessageBox.Show("Download abgeschlossen!");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (download == true)
            {
                DownloadFile(metroTextBox1.Text);
            }else
            {
                MessageBox.Show("Sie müssen einen Downloadpfad festlegen!");
                return;
            }
            Console.WriteLine("Finished!0");
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            if (metroLabel3.Text == "Download Directory festgelegt: Ja")
            {
                MessageBox.Show("Downloadpfad wurde schon festgelegt!");
                return;
            }
            MessageBox.Show("Bitte den Ordner auswählen! z.B. Desktop. Es wird ein Unterordner names SolidShot_Downloads erstellt!");
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                fullPath = folderBrowserDialog1.SelectedPath;
                

            }
            System.IO.Directory.CreateDirectory(fullPath + "/SolidShot_Downloads");
            string[] lines = {
                    fullPath + @"\SolidShot_Downloads\"
                };
            System.IO.File.WriteAllLines("asclib.dll", lines);
            metroLabel3.Text = "Download Directory festgelegt: Ja";
            downpath = System.IO.File.ReadAllText("asclib.dll");
            download = true;

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie die Datei: " + metroTextBox1.Text + " wirklich löschen?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://178.33.211.91/" + metroTextBox1.Text);

                //If you need to use network credentials
                request.Credentials = new NetworkCredential("solidshot2", "Kogikogi1q2w3e");
                //additionally, if you want to use the current user's network credentials, just use:
                //System.Net.CredentialCache.DefaultNetworkCredentials

                request.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Delete status: {0}", response.StatusDescription);
                response.Close();
                getdata();
            }
            
        }
    }
}
