using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace SolidShot_Tool
{
    public partial class DatenÄndern : MetroFramework.Forms.MetroForm
    {
        string KdNr = "";
        public DatenÄndern()
        {
            InitializeComponent();
        }
        public string kahba;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Main beta = new Main();
            beta.Show();
            this.Hide();
            
        }
        private void GetInfos()
        {
            //DB Part
            /*
                Select * From Kunden
            */
        }

        private void Daten_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }
        /*
        txtKdNr
        txtUnte
        txtAnsp
        txtBran
        txtMail
        txtTele
        txtWeb

        */
        private void Daten_Load(object sender, EventArgs e)
        {
            string[] d = kahba.Split(new string[] { "_~_" }, StringSplitOptions.None);
            KdNr = d[0];
            txtKdNr.Text = KdNr;
            string sin = d[1];
            txtUnte.Text = d[2];
            txtAnsp.Text = d[3];
            txtBran.Text = d[4];
            txtMail.Text = d[5];
            txtTele.Text = d[6];
            txtWeb.Text = d[7];


          // MessageBox.Show((new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/get_auftrag.php?s=" + KdNr));
           
           

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Php File plus in und output 
        }
    }
}
