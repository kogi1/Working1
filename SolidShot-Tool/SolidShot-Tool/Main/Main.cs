using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Net;

namespace SolidShot_Tool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        string test = "";
        public static string hwid = Value();
        private static string _fingerPrint = string.Empty;
        private static string Value()
        {
            //You don't need to generate the HWID again if it has already been generated. This is better for performance
            //Also, your HWID generally doesn't change when your computer is turned on but it cgnfhan happen.
            //It's up to you if you want to keep generating a HWID or not if the function is called.
            if (string.IsNullOrEmpty(_fingerPrint))
            {
                _fingerPrint = GetHash("CPU >> " + CpuId() + "\nBIOS >> " + BiosId() + "\nBASE >> " + BaseId() + "\nDISK >> " + DiskId() + "\nVIDEO >> " + VideoId() + "\nMAC >> " + MacId());
            }
            return _fingerPrint;
        }
        private static string GetHash(string s)
        {
            //Initialize a new MD5 Crypto Service Provider in order to generate a hash
            MD5 sec = new MD5CryptoServiceProvider();
            //Grab the bytes of the variable 's'
            byte[] bt = Encoding.ASCII.GetBytes(s);
            //Grab the Hexadecimal value of the MD5 hash
            return GetHexString(sec.ComputeHash(bt));
        }

        private static string GetHexString(IList<byte> bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Count; i++)
            {
                byte b = bt[i];
                int n = b;
                int n1 = n & 15;
                int n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n2.ToString(CultureInfo.InvariantCulture);
                if (n1 > 9)
                    s += ((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n1.ToString(CultureInfo.InvariantCulture);
                if ((i + 1) != bt.Count && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }

        //Return a hardware identifier
        private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() != "True") continue;
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }
        //Return a hardware identifier
        private static string Identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }
        private static string CpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don't get all identifiers, as it is very time consuming
            string retVal = Identifier("Win32_Processor", "UniqueId");
            if (retVal != "") return retVal;
            retVal = Identifier("Win32_Processor", "ProcessorId");
            if (retVal != "") return retVal;
            retVal = Identifier("Win32_Processor", "Name");
            if (retVal == "") //If no Name, use Manufacturer
            {
                retVal = Identifier("Win32_Processor", "Manufacturer");
            }
            //Add clock speed for extra security
            retVal += Identifier("Win32_Processor", "MaxClockSpeed");
            return retVal;
        }
        //BIOS Identifier
        private static string BiosId()
        {
            return Identifier("Win32_BIOS", "Manufacturer") + Identifier("Win32_BIOS", "SMBIOSBIOSVersion") + Identifier("Win32_BIOS", "IdentificationCode") + Identifier("Win32_BIOS", "SerialNumber") + Identifier("Win32_BIOS", "ReleaseDate") + Identifier("Win32_BIOS", "Version");
        }
        //Main physical hard drive ID
        private static string DiskId()
        {
            return Identifier("Win32_DiskDrive", "Model") + Identifier("Win32_DiskDrive", "Manufacturer") + Identifier("Win32_DiskDrive", "Signature") + Identifier("Win32_DiskDrive", "TotalHeads");
        }
        //Motherboard ID
        private static string BaseId()
        {
            return Identifier("Win32_BaseBoard", "Model") + Identifier("Win32_BaseBoard", "Manufacturer") + Identifier("Win32_BaseBoard", "Name") + Identifier("Win32_BaseBoard", "SerialNumber");
        }
        //Primary video controller ID
        private static string VideoId()
        {
            return Identifier("Win32_VideoController", "DriverVersion") + Identifier("Win32_VideoController", "Name");
        }
        //First enabled network card ID
        private static string MacId()
        {
            return Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }
        public void kahba ()
        {
            listBox1.Items.Clear();
            aufgaben();
        }  

        private void Main_Load(object sender, EventArgs e)
        {
            aufgaben();
            kundenlast();
            sachenmachen();
            
        }
        private void aufgaben ()
        {
            string string_to_parse = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_aufgaben.php");
            int i = 0;
            while (i < string_to_parse.Split(new string[] { "~1337~" }, StringSplitOptions.None).Length)
            {
                string[] lol = string_to_parse.Split(new string[] { "~1337~" }, StringSplitOptions.None);
                if (lol[i] != "")
                {

                    string[] lel = lol[i].Split(new string[] { "~1337~" }, StringSplitOptions.None);

                    listBox1.Items.Add(lel[0]);
                }
                i++;
            }
        }
        private void kundenlast()
        {
            string myLongString = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/new_kunden.php");
            myLongString = myLongString.Replace("~-~", "" + System.Environment.NewLine);
            richTextBox5.Text = myLongString;
        }
        private void sachenmachen()
        {
            string counter = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/count_kunden.php");
            richTextBox4.Text = counter;

            string counter1 = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/count_auftrag1.php");
            richTextBox1.Text = counter1;

            string counter2 = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/count_auftrag2.php");
            richTextBox2.Text = counter2;

            string counter3 = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/count_auftrag3.php");
            richTextBox3.Text = counter3;
        }
        public string[][] parse_players_string(string str)
        {
            string[][] StringArrayArray = null;
            List<string[]> StringArrayList = new List<string[]>();
            foreach (string dfdsfd in str.Split(new string[] { "\n" }, StringSplitOptions.None))
            {
                if (!(dfdsfd == ""))
                {
                    string[] StringArray = dfdsfd.Split(new string[] { "_~_" }, StringSplitOptions.None);
                    StringArrayList.Add(StringArray);
                }
            }
            StringArrayArray = StringArrayList.ToArray();
            return StringArrayArray;
        }

        private void btnNewKun_Click(object sender, EventArgs e)
        {
            NewKun beta = new NewKun();
            this.Hide();
            beta.Show();
        }

        private void btnNewAuf_Click(object sender, EventArgs e)
        {
            NewAuf beta = new NewAuf();
            this.Hide();
            beta.Show();
        }

        private void btnDaten_Click(object sender, EventArgs e)
        {
            DatenSelect beta = new DatenSelect();
            this.Hide();
            beta.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
           
            StatusSelect beta = new StatusSelect();
         
            this.Hide();
            beta.Show();
        
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process p;
            p = System.Diagnostics.Process.GetCurrentProcess();
            p.Kill();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() != string.Empty) {

                }
            }
            catch (Exception)
            {

                return;
            }
            if (listBox1.SelectedItem.ToString() != string.Empty)
            {
                string allah = listBox1.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Sind Sie sicher das Sie die Aufgabe abschließen möchten?", "Aufgabe Abschließen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WebClient wc = new WebClient();
                    wc.Encoding = Encoding.UTF8;
                    MessageBox.Show(wc.DownloadString("http://178.33.211.91:1337/update1.php?auf=" + allah));
                    listBox1.Items.Clear();
                    aufgaben();
                }
            }
            else
            {
                return;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string select = listBox1.SelectedItem.ToString();
                string textaufgabe = (new System.Net.WebClient()).DownloadString("http://178.33.211.91:1337/abfrage_aufgaben_text.php?text=" + select);
                string message = "Aufgabe: '" + select + "'" + Environment.NewLine 
                    +"" + Environment.NewLine
                    +"Aufgabenstellung: " + textaufgabe;
                string cap = "Aufgabenstellung";
                MessageBox.Show(message, cap);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Aufgaben abc = new Aufgaben();
            abc.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
 
                Vorschläge alph = new Vorschläge();
                alph.Show();

        }

        private void metroButton1_Click(object sender, EventArgs e)//Kundendatenändern
        {
            SelÄndern abc = new SelÄndern();
            abc.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)//Mailcenter
        {
            checkMail abc = new checkMail();
            abc.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FTP_Main asf = new FTP_Main();
            asf.Show();
            this.Hide();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Kalender_Main dsad = new Kalender_Main();
            dsad.Show();
            this.Hide();
        }
    }
}
