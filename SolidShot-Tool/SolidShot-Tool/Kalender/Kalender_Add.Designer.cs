namespace SolidShot_Tool
{
    partial class Kalender_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalender_Add));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminNr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminDat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminPart = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTerminBes = new MetroFramework.Controls.MetroTextBox();
            this.TerminArt = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.hour = new MetroFramework.Controls.MetroComboBox();
            this.minute = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(326, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(408, 401);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(96, 37);
            this.metroButton5.TabIndex = 18;
            this.metroButton5.Text = "Zurück";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Termin Nr.:";
            // 
            // txtTerminNr
            // 
            this.txtTerminNr.Location = new System.Drawing.Point(128, 58);
            this.txtTerminNr.Name = "txtTerminNr";
            this.txtTerminNr.ReadOnly = true;
            this.txtTerminNr.Size = new System.Drawing.Size(189, 23);
            this.txtTerminNr.TabIndex = 20;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Termin Art:";
            // 
            // txtTerminDat
            // 
            this.txtTerminDat.Location = new System.Drawing.Point(128, 121);
            this.txtTerminDat.Name = "txtTerminDat";
            this.txtTerminDat.ReadOnly = true;
            this.txtTerminDat.Size = new System.Drawing.Size(189, 23);
            this.txtTerminDat.TabIndex = 24;
            this.txtTerminDat.Text = "Bitte rechts wählen";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Termin Datum:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 149);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Termin Zeit:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 179);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Termin Partner:";
            // 
            // txtTerminPart
            // 
            this.txtTerminPart.Location = new System.Drawing.Point(128, 184);
            this.txtTerminPart.Name = "txtTerminPart";
            this.txtTerminPart.Size = new System.Drawing.Size(189, 23);
            this.txtTerminPart.TabIndex = 28;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 211);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Termin Beschreibung:";
            // 
            // txtTerminBes
            // 
            this.txtTerminBes.Location = new System.Drawing.Point(128, 233);
            this.txtTerminBes.Multiline = true;
            this.txtTerminBes.Name = "txtTerminBes";
            this.txtTerminBes.Size = new System.Drawing.Size(376, 103);
            this.txtTerminBes.TabIndex = 30;
            // 
            // TerminArt
            // 
            this.TerminArt.FormattingEnabled = true;
            this.TerminArt.ItemHeight = 23;
            this.TerminArt.Items.AddRange(new object[] {
            "Geschäftstermin",
            "Meeting",
            "Working",
            "Privat",
            "Filmen",
            "Postproduction",
            "Finanzen"});
            this.TerminArt.Location = new System.Drawing.Point(128, 86);
            this.TerminArt.Name = "TerminArt";
            this.TerminArt.Size = new System.Drawing.Size(189, 29);
            this.TerminArt.TabIndex = 31;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(193, 353);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 43);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "Abensenden";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // hour
            // 
            this.hour.FormattingEnabled = true;
            this.hour.ItemHeight = 23;
            this.hour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.hour.Location = new System.Drawing.Point(128, 149);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(85, 29);
            this.hour.TabIndex = 33;
            // 
            // minute
            // 
            this.minute.FormattingEnabled = true;
            this.minute.ItemHeight = 23;
            this.minute.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.minute.Location = new System.Drawing.Point(232, 149);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(85, 29);
            this.minute.TabIndex = 34;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(217, 155);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = ":";
            // 
            // Kalender_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 448);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TerminArt);
            this.Controls.Add(this.txtTerminBes);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtTerminPart);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtTerminDat);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTerminNr);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kalender_Add";
            this.Resizable = false;
            this.Text = "Termin hinzufügen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kalender_Add_FormClosing);
            this.Load += new System.EventHandler(this.Kalender_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox txtTerminDat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTerminNr;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox TerminArt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTerminPart;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTerminBes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox minute;
        private MetroFramework.Controls.MetroComboBox hour;
    }
}