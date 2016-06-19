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
    public partial class Daten : MetroFramework.Forms.MetroForm
    {
        string KdNr = "";
        public Daten()
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
            string string_to_parse = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/get_auftrag.php?s=" + KdNr);

            int i = 0;
            while (i < string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None).Length)
            {
                string[] lol = string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (lol[i] != "")
                {
                    string[] lel = lol[i].Split(new string[] { "_~_" }, StringSplitOptions.None);
                    listBox1.Items.Add("AufNr:" + lel[0] + "  |  " + "Art:" + lel[1]);
                }
                i++;
            }
            //Erstelle V-Card & Plante QR-Code
            string alz = txtAnsp.Text;
            string n1 = "";
            string n2 = "";


            //string[] name = alz.Split(new string[] { " " }, StringSplitOptions.None);
            //  n1 = name[0];
            // n1 = name[1];
            // FileIOPermission fileIOPerm = new FileIOPermission(FileIOPermissionAccess.Write, @"C:\Users\r11pl\Desktop");

            // fileIOPerm.Demand();

            //// MessageBox.Show(test);

            //  string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.Directory.CreateDirectory("Data");

            string path1 = "Data/" + txtKdNr.Text + ".vcf";
            string[] lines = {
                "BEGIN:VCARD",
                "VERSION:3.0",
                "FN:" + txtAnsp.Text,
                "N:" + n2 + ";" + n1,
                "ORG:" + txtUnte.Text,
                "TEL;TYPE=WORK,VOICE:" + txtTele.Text,
                "EMAIL;TYPE=INTERNET:" + txtMail.Text,
                "URL:" + txtWeb.Text,
                "END:VCARD" };
           System.IO.File.WriteAllLines(path1, lines);

            string contacts = File.ReadAllText("Data/" + txtKdNr.Text + ".vcf");
            BarcodeWriter bcWriter = new BarcodeWriter();
            var encOptions = new ZXing.Common.EncodingOptions() { Width = 200, Height = 200, Margin = 0 };
            bcWriter.Options = encOptions;

            ZXing.Rendering.BitmapRenderer renderer = new ZXing.Rendering.BitmapRenderer();

            bcWriter.Renderer = renderer;
            bcWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bm = bcWriter.Write(contacts);

            pictureBox1.Image = bm;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           

        }
    }
}
