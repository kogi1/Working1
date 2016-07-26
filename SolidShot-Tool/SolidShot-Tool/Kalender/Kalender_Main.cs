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
    public partial class Kalender_Main : MetroFramework.Forms.MetroForm
    {
        public Kalender_Main()
        {
            InitializeComponent();
        }
        private void Kalender_Main_Load(object sender, EventArgs e)
        {

        }




        private void Kalender_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void metroButton1_Click(object sender, EventArgs e)//abrufen
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)//hinzufügen
        {
            Kalender_Add dsad = new Kalender_Add();
            dsad.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)//editieren
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)//abschließen
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Main dsad = new Main();
            dsad.Show();
            this.Hide();
        }
    }
}
