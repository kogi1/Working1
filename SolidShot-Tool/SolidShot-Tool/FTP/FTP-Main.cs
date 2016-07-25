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
    public partial class FTP_Main : MetroFramework.Forms.MetroForm
    {
        public FTP_Main()
        {
            InitializeComponent();
        }

        private void FTP_Main_Load(object sender, EventArgs e)
        {

        }

        private void metrobutton1_Click(object sender, EventArgs e)
        {
            FTP_Backup asf = new FTP_Backup();
            asf.Show();
            this.Hide();
        }

        private void FTP_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
