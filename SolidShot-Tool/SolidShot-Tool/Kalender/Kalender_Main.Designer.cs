namespace SolidShot_Tool
{
    partial class Kalender_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalender_Main));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminNr = new MetroFramework.Controls.MetroTextBox();
            this.dsf = new MetroFramework.Controls.MetroLabel();
            this.txtTerminArt = new MetroFramework.Controls.MetroTextBox();
            this.fdf = new MetroFramework.Controls.MetroLabel();
            this.txtTerminDat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminZeit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminPart = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminBesch = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(379, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(182, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Termine abrufen";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(32, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 180);
            this.listBox1.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 261);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Termin Nr.:";
            // 
            // txtTerminNr
            // 
            this.txtTerminNr.Location = new System.Drawing.Point(137, 259);
            this.txtTerminNr.Name = "txtTerminNr";
            this.txtTerminNr.Size = new System.Drawing.Size(162, 23);
            this.txtTerminNr.TabIndex = 3;
            // 
            // dsf
            // 
            this.dsf.AutoSize = true;
            this.dsf.Location = new System.Drawing.Point(32, 292);
            this.dsf.Name = "dsf";
            this.dsf.Size = new System.Drawing.Size(74, 19);
            this.dsf.TabIndex = 4;
            this.dsf.Text = "Termin Art:";
            // 
            // txtTerminArt
            // 
            this.txtTerminArt.Location = new System.Drawing.Point(137, 288);
            this.txtTerminArt.Name = "txtTerminArt";
            this.txtTerminArt.Size = new System.Drawing.Size(162, 23);
            this.txtTerminArt.TabIndex = 5;
            // 
            // fdf
            // 
            this.fdf.AutoSize = true;
            this.fdf.Location = new System.Drawing.Point(32, 321);
            this.fdf.Name = "fdf";
            this.fdf.Size = new System.Drawing.Size(94, 19);
            this.fdf.TabIndex = 6;
            this.fdf.Text = "Termin Datum:";
            // 
            // txtTerminDat
            // 
            this.txtTerminDat.Location = new System.Drawing.Point(137, 317);
            this.txtTerminDat.Name = "txtTerminDat";
            this.txtTerminDat.Size = new System.Drawing.Size(162, 23);
            this.txtTerminDat.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 350);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Termin Zeit:";
            // 
            // txtTerminZeit
            // 
            this.txtTerminZeit.Location = new System.Drawing.Point(137, 346);
            this.txtTerminZeit.Name = "txtTerminZeit";
            this.txtTerminZeit.Size = new System.Drawing.Size(162, 23);
            this.txtTerminZeit.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 378);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Termin Partner:";
            // 
            // txtTerminPart
            // 
            this.txtTerminPart.Location = new System.Drawing.Point(137, 375);
            this.txtTerminPart.Name = "txtTerminPart";
            this.txtTerminPart.Size = new System.Drawing.Size(162, 23);
            this.txtTerminPart.TabIndex = 11;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(317, 259);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(133, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Termin Beschreibung:";
            // 
            // txtTerminBesch
            // 
            this.txtTerminBesch.Location = new System.Drawing.Point(317, 288);
            this.txtTerminBesch.Multiline = true;
            this.txtTerminBesch.Name = "txtTerminBesch";
            this.txtTerminBesch.Size = new System.Drawing.Size(244, 110);
            this.txtTerminBesch.TabIndex = 13;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(379, 103);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(182, 34);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Termine hinzufügen";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(379, 143);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(182, 34);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "Termine editieren";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(379, 183);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(182, 34);
            this.metroButton4.TabIndex = 16;
            this.metroButton4.Text = "Termine abschließen";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(494, 404);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(96, 37);
            this.metroButton5.TabIndex = 17;
            this.metroButton5.Text = "Zurück";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // Kalender_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 454);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtTerminBesch);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtTerminPart);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTerminZeit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTerminDat);
            this.Controls.Add(this.fdf);
            this.Controls.Add(this.txtTerminArt);
            this.Controls.Add(this.dsf);
            this.Controls.Add(this.txtTerminNr);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kalender_Main";
            this.Resizable = false;
            this.Text = "Kalender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kalender_Main_FormClosing);
            this.Load += new System.EventHandler(this.Kalender_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtTerminBesch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTerminPart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTerminZeit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTerminDat;
        private MetroFramework.Controls.MetroLabel fdf;
        private MetroFramework.Controls.MetroTextBox txtTerminArt;
        private MetroFramework.Controls.MetroLabel dsf;
        private MetroFramework.Controls.MetroTextBox txtTerminNr;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}