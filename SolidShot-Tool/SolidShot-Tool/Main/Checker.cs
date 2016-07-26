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
    public partial class Checker : MetroFramework.Forms.MetroForm
    {
        public Checker()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Sie müssen einen Security Token eingeben!");
                return;
            }
            if(metroTextBox1.Text == Vars.tok1)
            {
                string lines = Vars.tok1;
                System.IO.File.WriteAllText("datalib.dll", lines);
                Main beta = new Main();
                this.Hide();
                beta.Show();
            } else if(metroTextBox1.Text == Vars.tok2)
            {
                string lines = Vars.tok2;
                System.IO.File.WriteAllText("datalib.dll", lines);
                Main beta = new Main();
                this.Hide();
                beta.Show();
            } else
            {
                MessageBox.Show("Ungültiger Security Token");
                return;
            }
        }

        private void Checker_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
