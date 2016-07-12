using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidShot_Tool
{
    public partial class SelÄndern : MetroFramework.Forms.MetroForm
    {
        public SelÄndern()
        {
            InitializeComponent();
        }

        private void SelÄndern_Load(object sender, EventArgs e)
        {
            string fasfasf = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/KdNr.php");
            int i = 0;
            while (i < fasfasf.Split(new string[] { "\n" }, StringSplitOptions.None).Length)
            {
                string[] lol = fasfasf.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (lol[i] != "")
                {
                    string[] lel = lol[i].Split(new string[] { "_~_" }, StringSplitOptions.None);
                    listBox1.Items.Add("Unternehmen:" + lel[1] + "  |  " + "KdNr:" + lel[0]);
                }
                i++;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != string.Empty)
            {
                string dasdg = listBox1.SelectedItem.ToString();
                DatenÄndern dsa = new DatenÄndern();
                dsa.kahba = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_daten.php?s=" + dasdg.Split(new string[] { "  |  KdNr:" }, StringSplitOptions.None)[1]);

                dsa.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void SelÄndern_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
