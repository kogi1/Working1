using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Net;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidShot_Tool
{
    public partial class checkMail : MetroFramework.Forms.MetroForm
    {
        public checkMail()
        {
            InitializeComponent();
        }

        private void checkMail_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /*
            MailMessage mail = new MailMessage("r.planer@solidshot.at", "raffi@lpgaming.tv");
             SmtpClient client = new SmtpClient();
             client.Port = 25;
             client.DeliveryMethod = SmtpDeliveryMethod.Network;
             client.UseDefaultCredentials = false;
             client.Credentials = new System.Net.NetworkCredential("r.planer@solidshot.at", "Kogikogi1q2w3e");
             client.Host = "smtp.solidshot.at";
             mail.Subject = "this is a test email.";
             mail.Body = "this is my test email body";
             client.Send(mail);
             */
        }
    }
}
