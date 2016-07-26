using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SolidShot_Tool
{
    public partial class Aufgaben : MetroFramework.Forms.MetroForm
    {
        
        public Aufgaben()
        {
            InitializeComponent();
            
        }

        private void Aufgaben_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string beauf = "";
            string auftrag = "";
            string text = "";

            if (txtAufgabe.Text == string.Empty || txtAufgabenstellung.Text == string.Empty || txtAuftragender.Text == string.Empty)
            {
                return;
            }else
            {
                beauf = txtAuftragender.Text;
                auftrag = txtAufgabe.Text;
                text = txtAufgabenstellung.Text;

                auftrag = beauf + ": " + auftrag;
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/aufgaben_eintrag.php?1=" + auftrag + "&2=" + text));
                Main beta = new Main();
                beta.Show();
                this.Hide();

            }

        }

        private void Aufgaben_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Aufgaben_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
