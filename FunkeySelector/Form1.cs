using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkeySelector
{
    public partial class Form1 : Form
    {
        CustomFManager customF = new CustomFManager();
        bool firstStart = true;
        public Form1()
        {
            InitializeComponent();
            if (firstStart == true)
            {
                if (Properties.Settings.Default.disableGameCheck == false)
                {
                    if (!File.Exists("UBFunkeys.exe")) //Checks if it's in the RadicaGame folder.
                    {
                        MessageBox.Show("The U.B. Funkeys game was not found! Did you put FunkeySelectorGUI in the RadicaGame folder?");
                    }
                }
                if (Properties.Settings.Default.disableModCheck == false)
                {
                    if (File.Exists("Main.swf")) //Checks if the main.swf is in the directory, to prevent null errors.
                    {
                        if (CalculateMD5("Main.swf") != "93261ce3dc332fdee5d4335eab0a8e63") //Compares the MD5 hash of the local main.swf with the mods main.swf.
                        {
                            MessageBox.Show("Could not detect the Funkeys Selection Mod! Did you install the mod?");
                        }
                    }
                }
                if (Properties.Settings.Default.disableWineCheck == false)
                {
                    if (Properties.Settings.Default.wineCompat == false)
                    {
                        if (checkMachineType() == true)
                        {
                            if (MessageBox.Show("FunkeySelectorGUI has detected it is running from Wine. If you want to enable Wine compatibility tweaks, which fixes the selection of Funkeys, click yes.", "Wine detected!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Properties.Settings.Default.wineCompat = true;
                            }
                        }
                    }
                }
                firstStart = false;
            }
        }

        public static bool checkMachineType()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Wine\"); //Checks if Wine is detected.
            if (key == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static string CalculateMD5(string filename) //Generates the MD5 hash of the main.swf.
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 funktown = new Form2();
            this.Hide();
            funktown.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 kelp = new Form3();
            this.Hide();
            kelp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 magma = new Form4();
            this.Hide();
            magma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 laput = new Form5();
            this.Hide();
            laput.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 funkiki = new Form6();
            this.Hide();
            funkiki.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 rrc = new Form7();
            this.Hide();
            rrc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 nightmare = new Form8();
            this.Hide();
            nightmare.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 daydream = new Form9();
            this.Hide();
            daydream.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 hrf = new Form10();
            this.Hide();
            hrf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form11 paradox = new Form11();
            this.Hide();
            paradox.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("FFFFFFF0");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Form12 unused = new Form12();
            this.Hide();
            unused.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form13 customf = new Form13();
            this.Hide();
            customf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            Form14 options = new Form14();
            options.Show();
        }
    }
}
