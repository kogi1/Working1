using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            MessageBox.Show((new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/update.php?1=" + ArtUP + "&2=" + InfUP + "&3=" + PreiUP + "&4=" + EndeUP + "&5=" + StatusUP + "&AufNr=" + txtAufNr.Text + "&6=" + abg));
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
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
