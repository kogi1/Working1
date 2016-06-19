using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            MessageBox.Show((new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/eintrag.php?1=" + KdNr + "&2=" + Pass + "&3=" + Unter + "&4=" + Ansp + "&5=" + Bran + "&6=" + Mail + "&7=" + Tele + "&8=" + Webs));
            
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


    }
}
