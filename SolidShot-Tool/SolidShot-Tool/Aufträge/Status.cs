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
namespace SolidShot_Tool
{
    public partial class Status : MetroFramework.Forms.MetroForm
    {
        public Status()
        {
            InitializeComponent();
        }

        public string kappa;
        string mail = "";

        private void Status_Load(object sender, EventArgs e)
        {
            string[] d = kappa.Split(new string[] { "_~_" }, StringSplitOptions.None);
            txtAufNr.Text = d[0];
            txtKdNr.Text = d[1];
            txtArt.Text = d[2];
            txtInf.Text = d[3];
            txtPrei.Text = d[4];
            txtBegi.Text = d[5];
            txtEnde.Text = d[6];
            txtStat.Text = d[7];

            string KDNR = txtKdNr.Text;
            string KD = "\"" + KDNR + "\"";
            mail = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/getmail.php?s=" + KD);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Main beta = new Main();
            this.Hide();
            beta.Show();
        }

        private void Status_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string ArtUP;string InfUP;string PreiUP;string EndeUP; string StatusUP; string abg;

            if (ComStat.Text == String.Empty)
            {
                MessageBox.Show("Kein Update ohne gültigen Status");
                return;
            }
            if(txtArtN.Text == "")
            {
                ArtUP = txtArt.Text;
            } else
            {
                ArtUP = txtArtN.Text;
            }

            if (txtInfN.Text == "")
            {
                InfUP = txtInf.Text;
            }
            else
            {
                InfUP = txtInfN.Text;
            }

            if (txtPreiN.Text == "")
            {
                PreiUP = txtPrei.Text;
            }
            else
            {
                PreiUP = txtPreiN.Text;
            }

            if (txtEndeN.Text == "")
            {
                EndeUP = txtEnde.Text;
            }
            else
            {
                EndeUP = txtEndeN.Text;
            }

            if(metroCheckBox1.Checked)
            {
                abg = "1";
            }
            else
            {
                abg = "0";
            }
            StatusUP = ComStat.Text;

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/update.php?1=" + ArtUP + "&2=" + InfUP + "&3=" + PreiUP + "&4=" + EndeUP + "&5=" + StatusUP + "&AufNr=" + txtAufNr.Text + "&6=" + abg));

            DialogResult dialogResult = MessageBox.Show("Soll der Kunde eine Benachrichtigung erhalten?", "Benachrichtigung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
           /*
                string msg = "";
                MailMessage mail = new MailMessage("noreply@solidshot.at", mail);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("noreply@solidshot.at", "Kogikogi1q2w3e");
                client.Host = "smtp.solidshot.at";
                mail.Subject = "Auftragsstautus wurde geändert";
                mail.Body = msg;
                client.Send(mail);
*/
                string msg = "Guten Tag," + Environment.NewLine +
                Environment.NewLine + 
                "der Status Ihres Auftrgs wurder geändert." + Environment.NewLine +
                Environment.NewLine +
                "Neuer Status: " + ComStat.Text + Environment.NewLine +
                Environment.NewLine +
                "Weitere Details finden Sie im Kundeninterface unter:" + Environment.NewLine +
                "- Website: https://login.solidshot.at" + Environment.NewLine +
                "- Kundenkennung: " + txtKdNr.Text + Environment.NewLine +
                "- Passwort: Das von uns zugeteilte Passwort oder Ihr im Kundeninterface personalisierte Passwort" + Environment.NewLine +
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
                objeto_mail.To.Add(new MailAddress(mail));
                objeto_mail.Subject = "Auftragsstautus wurde geändert";
                objeto_mail.Body = msg;
                client.Send(objeto_mail);
            }
            

            Main beta = new Main();
            this.Hide();
            beta.Show();
        }
        /*
        txtAufNr
        txtKdNr
        txtArt
        txtArtN
        txtInf
        txtInfN
        txtPrei
        txtPreiN
        txtBegi
        txtEnde
        txtEndeN
        txtStat
        ComStat
        */
        

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
