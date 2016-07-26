using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

/*
Vars:
lblKdNr = letzte Kundennummer

txtKdNr
txtPass
txtUnter
txtAnsp
txtBran
txtMail
txtTele
txtWebs

*/



namespace SolidShot_Tool
{
    public partial class NewKun : MetroFramework.Forms.MetroForm
    {
        string KdNr; string Pass; string Unter; string Ansp; string Bran; string Mail; string Tele; string Webs;
        public NewKun()
        {
            InitializeComponent();
        }
        private void NewKun_Load(object sender, EventArgs e)
        {
            //Funktion für Abrufen der letzten KdNr
            string lKdNr = "";
            System.Net.WebClient w = new System.Net.WebClient();
            lKdNr = w.DownloadString("http://178.33.211.91:1337/abfrage_nr.php");
            lblKdNr.Text = lKdNr.ToString();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Main beta = new Main();
            this.Hide();
            beta.Show();
        }
        private void DatenAnDB()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/eintrag.php?1=" + KdNr + "&2=" + Pass + "&3=" + Unter + "&4=" + Ansp + "&5=" + Bran + "&6=" + Mail + "&7=" + Tele + "&8=" + Webs));
            
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            KdNr = txtKdNr.Text; Pass = txtPass.Text;
            Unter = txtUnter.Text; Ansp = txtAnsp.Text;
            Bran = txtBran.Text; Mail = txtMail.Text;
            Tele = txtTele.Text; Webs = txtWebs.Text;

            if(KdNr == string.Empty || Pass == string.Empty || Unter == string.Empty || Ansp == string.Empty || Bran == string.Empty || Mail == string.Empty || Tele == string.Empty || Webs == string.Empty)
            {
                MessageBox.Show("Es wurde nicht jedes Feld ausgefüllt!");
                return;
            }
            const string message = "Sind Sie sicher das die Eingaben korrekt sind?";
            const string caption = "Check";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            { 
                if(metroCheckBox1.Checked == true)
                {
                string msg = "Guten Tag," + Environment.NewLine +
                Environment.NewLine +
                "Ihr Kundenkonto wurde soeben angelegt." + Environment.NewLine +
                Environment.NewLine +
                "Sie können sich nun jederzeit im Kundeninterface einloggen:" + Environment.NewLine +
                "- Website: https://login.solidshot.at" + Environment.NewLine +
                "- Kundenkennung: " + txtKdNr.Text + Environment.NewLine +
                "- Passwort: " + txtPass.Text  + Environment.NewLine +
                Environment.NewLine +
                "Bitte ändern Sie Ihr Passwort nach dem ersten Login!" + Environment.NewLine +
                Environment.NewLine +
                "Haben Sie weitere Frage können Sie uns jederzeit ein Ticket im Kundeninterface zukommen lassen" + Environment.NewLine +
                "oder Sie setzten sich Telefonisch mit uns in Verbindung." + Environment.NewLine +
                Environment.NewLine +
                "Mit freundlichen Grüßen" + Environment.NewLine +
                Environment.NewLine +
                "Ihr SolidShot Team" + Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Telefon: +43 664 4610920" + Environment.NewLine +
                "E-Mail: office@solidshot.at" + Environment.NewLine +
                "Web: https://solidshot.at" + Environment.NewLine +
                Environment.NewLine +
                "------------------------------" + Environment.NewLine +
                "SolidShot GmbH, Reichenhallerstraße 6-8, 5020 Salzburg" + Environment.NewLine +
                "Sitz: Salzburg, Geschäftsführer: Daniel Ronacher";
                    MailMessage objeto_mail = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.Host = "smtp.solidshot.at";
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("noreply@solidshot.at", "Kogikogi1q2w3e");
                    objeto_mail.From = new MailAddress("noreply@solidshot.at");
                    objeto_mail.To.Add(new MailAddress(txtMail.Text));
                    objeto_mail.Subject = "Kundenkonto wurde angelegt";
                    objeto_mail.Body = msg;
                    client.Send(objeto_mail);
                }
                

                WebRequest request = WebRequest.Create("ftp://178.33.211.91/" + txtKdNr.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential("solidshot2", "Kogikogi1q2w3e");
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine(resp.StatusCode);
                }
                string[] lines = {
                    "Kundennummer: " + txtKdNr.Text,
                    "Unternehmen: " + txtUnter.Text,
                    "Ansprech Person: " + txtAnsp.Text,
                    "Branche: " + txtBran.Text,
                    "E-Mail: " + txtMail.Text,
                    "Tel: " + txtTele.Text,
                    "Web: " + txtWebs.Text
                };
                System.IO.File.WriteAllLines(txtKdNr.Text + ".txt", lines);
                 
                FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create("ftp://178.33.211.91/" + txtKdNr.Text + "/" + txtKdNr.Text + ".txt");
                ftpClient.Credentials = new System.Net.NetworkCredential("solidshot2", "Kogikogi1q2w3e");
                ftpClient.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                ftpClient.UseBinary = true;
                ftpClient.KeepAlive = true;
                System.IO.FileInfo fi = new System.IO.FileInfo(txtKdNr.Text + ".txt");
                ftpClient.ContentLength = fi.Length;
                byte[] buffer = new byte[4097];
                int bytes = 0;
                int total_bytes = (int)fi.Length;
                System.IO.FileStream fs = fi.OpenRead();
                System.IO.Stream rs = ftpClient.GetRequestStream();
                while (total_bytes > 0)
                {
                    bytes = fs.Read(buffer, 0, buffer.Length);
                    rs.Write(buffer, 0, bytes);
                    total_bytes = total_bytes - bytes;
                }
                //fs.Flush();
                fs.Close();
                rs.Close();
                System.IO.File.Delete(txtKdNr.Text + ".txt");
                

                DatenAnDB();
                Main beta = new Main();
                this.Hide();
                beta.Show();
            }
        }

        private void NewKun_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!(/)=?&/%*~";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string key = "";
            key = new String(stringChars);
            txtPass.Text = key;
        }
    }
}
