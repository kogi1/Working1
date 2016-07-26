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
    public partial class Kalender_Add : MetroFramework.Forms.MetroForm
    {
        public Kalender_Add()
        {
            InitializeComponent();
        }
        int zahl = 1;
        

        private void Kalender_Add_Load(object sender, EventArgs e)
        {
            string lKdNr = "";
            System.Net.WebClient w = new System.Net.WebClient();
            lKdNr = w.DownloadString("http://178.33.211.91:1337/abfrage_nrt.php");
            int nr;
            try
            {
                
                Console.WriteLine(lKdNr);
                nr = Convert.ToInt32(lKdNr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return;
            }
            nr = nr + zahl;
            txtTerminNr.Text = nr.ToString();
        }

        private void Kalender_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            txtTerminDat.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Kalender_Main dsad = new Kalender_Main();
            dsad.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if(TerminArt.Text == string.Empty || txtTerminDat.Text == string.Empty || hour.Text == string.Empty || minute.Text == string.Empty || txtTerminBes.Text == string.Empty)
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt sein!");
                return;
            }
            string TermNr = txtTerminNr.Text;
            string TermArt = TerminArt.Text;
            string TermDat = txtTerminDat.Text;
            string TermZeit = hour + ":" + minute;
            string TermPart = txtTerminPart.Text;
            string TermBes = txtTerminBes.Text;
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            //MessageBox.Show("http://178.33.211.91:1337/eintrag_term.php?1=" + TermNr + "&2=" + TerminArt.Text + "&3=" + TermDat + "&4=" + hour.Text + ":" + minute.Text + "&5=" + TermPart + "&6=" + TermBes + "&7=" + "0");
            MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/eintrag_term.php?1=" + TermNr + "&2=" + TerminArt.Text + "&3=" + TermDat + "&4=" + hour.Text + ":" + minute.Text + "&5=" + TermPart + "&6=" + TermBes + "&7=" + "0"));
            Kalender_Main dsad = new Kalender_Main();
            dsad.Show();
            this.Hide();
        }
    }
}
