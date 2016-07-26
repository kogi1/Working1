using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidShot_Tool
{
    public partial class VorschlägeControll : MetroFramework.Forms.MetroForm
    {
        public VorschlägeControll()
        {
            InitializeComponent();
        }
        private void VorschlägeControll_Load(object sender, EventArgs e)
        {
            auf();
        }
        private void auf()
        {
            string string_to_parse = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_vorschlag.php");
            int i = 0;
            while (i < string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None).Length)
            {
                string[] lol = string_to_parse.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (lol[i] != "")
                {
                    string[] lel = lol[i].Split(new string[] { "~1337~" }, StringSplitOptions.None);
                    listBox1.Items.Add("Name: " + lel[1] + "  |  " + "ID: " + lel[0]);
                }
                i++;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string select = listBox1.SelectedItem.ToString();
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/abfrage_vor_fin.php?s=" + select.Split(new string[] { "  |  ID:" }, StringSplitOptions.None)[1]));
                listBox1.Items.Clear();
                auf();
            }
        }

        
        private void aufgaben()
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string select = listBox1.SelectedItem.ToString();
               
                string vor = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_vor.php?s=" + select.Split(new string[] { "  |  ID:" }, StringSplitOptions.None)[1]);
                metroTextBox1.Text = vor;
            }
        }
    }
}
