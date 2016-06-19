using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
txtKdNr
txtArt
txtInfo
txtPrei
txtBegi
txtEnde
*/
namespace SolidShot_Tool
{
    public partial class NewAuf : MetroFramework.Forms.MetroForm
    {
        string KdNr; string Art; string Info; string Prei; string Begi; string Ende;
        public NewAuf()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Main beta = new Main();
            this.Hide();
            beta.Show();
        }

        private void NewAuf_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DatenSelect beta = new DatenSelect();
            beta.Show();
        }

        private void DatenAnDB()
        {
           
            
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            string KdNr; string Art; string Info; string Prei; string Begi; string Ende;
            KdNr = txtKdNr.Text; Art = txtArt.Text;
            Info = txtInfo.Text; Prei = txtPrei.Text;
            Begi = txtBegi.Text; Ende = txtEnde.Text;

            if (KdNr == string.Empty || Art == string.Empty || Info == string.Empty || Prei == string.Empty || Begi == string.Empty || Ende == string.Empty)
            {
                MessageBox.Show("Es wurde nicht jedes Feld ausgefüllt!");
                return;
            }
            const string message = "Sind Sie sicher das die Eingaben korrekt sind?";
            const string caption = "Check";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show((new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/eintrag_auftag.php?1=" + KdNr + "&2=" + Art + "&3=" + Info + "&4=" + Prei + "&5=" + Begi + "&6=" + Ende));
                Main beta = new Main();
                this.Hide();
                beta.Show();
            }
        }
    }
}
