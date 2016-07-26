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
    public partial class Vorschläge : MetroFramework.Forms.MetroForm
    {
        public Vorschläge()
        {
            InitializeComponent();
        }
        private void Vorschläge_Load(object sender, EventArgs e)
        {
            metroButton1.Hide();
            metroButton2.Hide();
            string hw = Main.hwid;
            string hw1 = Vars.hwid1;
            string hw2 = Vars.hwid2;
            string hw3 = Vars.hwid3;
            string hw4 = Vars.hwid4;
            string hw5 = Vars.hwid5;
            if (hw == hw1)
            {
                metroButton2.Show();
                metroButton1.Show();
            }
            else if (hw == hw2)
            {
                metroButton2.Show();
                metroButton1.Show();
            }
            else if (hw == hw3)
            {
                metroButton2.Show();
                metroButton1.Show();
            }
            else if (hw == hw4)
            {
                metroButton2.Show();
                metroButton1.Show();
            }
            else if (hw == hw5)
            {
                metroButton2.Show();
                metroButton1.Show();
            }

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Main.hwid);
            MessageBox.Show("HWID Copied to Clipboard!");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            VorschlägeControll amk = new VorschlägeControll();
            amk.Show();
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string Name = metroTextBox1.Text;
            string Vorschlag = metroTextBox2.Text;

            if (Name == string.Empty || Vorschlag == string.Empty)
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt sein!");
                return;
            }
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/new_vorschlag.php?1=" + Name + "&2=" + Vorschlag));
            this.Close();
        }
    }
}
