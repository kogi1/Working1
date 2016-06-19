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
    public partial class loading : MetroFramework.Forms.MetroForm
    {
        public loading()
        {
            InitializeComponent();
        }
       
        private async void loading_Load(object sender, EventArgs e)
        {
            metroProgressBar1.Visible = true;
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Maximum = 8;
            metroProgressBar1.Value = 0;
            metroProgressBar1.Step = 1;
            metroLabel2.Text = "Loading...";
            await Task.Delay(2000);
            for (int i = 0; i < 3; i++)
            {
                metroLabel2.Text = "Lade Tasks " + i.ToString() + "/3";
                metroProgressBar1.PerformStep();
                await Task.Delay(1000);
            }

            for (int i = 0; i < 4; i++)
            {
                metroLabel2.Text = "Lade Oberflächen " + i.ToString() + "/3";
                metroProgressBar1.PerformStep();
                await Task.Delay(2000);
            }
            metroProgressBar1.PerformStep();
            metroLabel2.Text = "Öffne Programm...";
            await Task.Delay(2700);

            Main beta = new Main();
            this.Hide();
            beta.Show();
        }
    }
}
