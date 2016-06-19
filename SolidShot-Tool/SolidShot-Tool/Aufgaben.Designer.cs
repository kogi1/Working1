namespace SolidShot_Tool
{
    partial class Aufgaben
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aufgaben));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtAuftragender = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAufgabe = new MetroFramework.Controls.MetroTextBox();
            this.txtAufgabenstellung = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Beauftragte:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(149, 305);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 37);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Absenden";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtAuftragender
            // 
            this.txtAuftragender.Location = new System.Drawing.Point(149, 76);
            this.txtAuftragender.Name = "txtAuftragender";
            this.txtAuftragender.Size = new System.Drawing.Size(244, 23);
            this.txtAuftragender.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Aufgabe:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Aufgabenstellung:";
            // 
            // txtAufgabe
            // 
            this.txtAufgabe.Location = new System.Drawing.Point(149, 109);
            this.txtAufgabe.Name = "txtAufgabe";
            this.txtAufgabe.Size = new System.Drawing.Size(244, 23);
            this.txtAufgabe.TabIndex = 5;
            // 
            // txtAufgabenstellung
            // 
            this.txtAufgabenstellung.Location = new System.Drawing.Point(149, 139);
            this.txtAufgabenstellung.Multiline = true;
            this.txtAufgabenstellung.Name = "txtAufgabenstellung";
            this.txtAufgabenstellung.Size = new System.Drawing.Size(244, 149);
            this.txtAufgabenstellung.TabIndex = 6;
            // 
            // Aufgaben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 375);
            this.Controls.Add(this.txtAufgabenstellung);
            this.Controls.Add(this.txtAufgabe);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtAuftragender);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Aufgaben";
            this.Resizable = false;
            this.Text = "Aufgabe hinzufügen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aufgaben_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Aufgaben_FormClosed);
            this.Load += new System.EventHandler(this.Aufgaben_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox txtAufgabenstellung;
        private MetroFramework.Controls.MetroTextBox txtAufgabe;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAuftragender;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}