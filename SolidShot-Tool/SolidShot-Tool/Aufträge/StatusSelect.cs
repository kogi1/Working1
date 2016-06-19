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
    public partial class StatusSelect : MetroFramework.Forms.MetroForm
    {
        public StatusSelect()
        {
            InitializeComponent();
        }

        private void StatusSelect_Load(object sender, EventArgs e)
        {
            String string_to_parse = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/AufNr.php");
            int i = 0;
            while (i < string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None).Length)
            {
                string[] lol = string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (lol[i] != "")
                {
                    string[] lel = lol[i].Split(new string[] { "_~_" }, StringSplitOptions.None);
                    listBox1.Items.Add("Unternehmen:" + lel[1] + "  |  " + "AufNr:" + lel[0]);
                }
                i++;
            }
        }

        private void StatusSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != String.Empty)
            {
                String kskjkd = listBox1.SelectedItem.ToString();
                Status theta = new Status();
                theta.kappa = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_status.php?s=" + kskjkd.Split(new string[] { "  |  AufNr:" }, StringSplitOptions.None)[1]);
                theta.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
