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
        //
        //Initial Setups
        //

        CustomFManager customF = new CustomFManager(); //Sets the CustomFManager to customf.
        bool firstStart = true;

        public Form1() //When the form is opened.
        {
            InitializeComponent();
            this.TransparencyKey = System.Drawing.Color.Gold; //Removes the gold sections to allow the UI to be rounded.
            if (firstStart == true)
            {
                if (Properties.Settings.Default.disableGameCheck == false) //If the game check is allowed.
                {
                    if (!File.Exists("UBFunkeys.exe")) //Checks if it's in the RadicaGame folder.
                    {
                        if (!File.Exists("OpenFK.exe")) //Ensures that OpenFK users won't get warned.
                        {
                            MessageBox.Show("The U.B. Funkeys game was not found! Did you put FunkeySelectorGUI in the RadicaGame folder?");
                        }
                    }
                }
                if (Properties.Settings.Default.disableModCheck == false) // Checks if mod check is allowed.
                {
                    if (File.Exists("Main.swf")) //Checks if the main.swf is in the directory, to prevent null errors.
                    {
                        if (CalculateMD5("Main.swf") != "93261ce3dc332fdee5d4335eab0a8e63") //Compares the MD5 hash of the local main.swf with the mod's main.swf.
                        {
                            if (File.Exists("OpenFK.exe")) //Ensures that OpenFK users won't get warned.
                            {
                                Debug.WriteLine("OpenFK detected! Skipping mod check.");
                            }
                            else MessageBox.Show("Could not detect the Funkeys Selection Mod! Did you install the mod?");
                        }
                    }
                }
                if (Properties.Settings.Default.disableWineCheck == false) //Checks if Wine check is allowed.
                {
                    if (Properties.Settings.Default.wineCompat == false) //If wine compatibility is on, it won't check as well, as there's no need to check and prompt for wine compatibility.
                    {
                        if (checkMachineType() == true) //Calls the Wine checker
                        {
                            if (MessageBox.Show("FunkeySelectorGUI has detected it is running from Wine. If you want to enable Wine compatibility tweaks, which fixes the selection of Funkeys, click yes.", "Wine detected!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Properties.Settings.Default.wineCompat = true;
                            }
                        }
                    }
                }
                firstStart = false; //Prevents the checks from running after first start.
            }
        }

        protected override void WndProc(ref Message m) //Allows the window to be dragged.
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public static bool checkMachineType() //Checks if FSGUI is running from Wine or Windows.
        {
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Wine\"); //Checks if Wine is detected using a registry key that usually is only used on Wine.
            if (key == null)
            {
                return false; //Windows
            }
            else
            {
                return true; //Wine
            }
        }

        static string CalculateMD5(string filename) //Generates the MD5 hash of the main.swf.
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename)) //Opens the main.swf.
                {
                    var hash = md5.ComputeHash(stream); //Computes the MD5 hash of the swf.
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant(); //Converts the hash to a readable string to compare.
                }
            }
        }

        //
        // End of Initial Setups
        //

        //
        // Button Clicks
        // Most of these just hide this form and shows another one.
        //

        //Exit
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Funkeystown
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 funktown = new Form2();
            this.Hide();
            funktown.Show();
        }

        //Kelpy Basin
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 kelp = new Form3();
            this.Hide();
            kelp.Show();
        }

        //Exit (Again)
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Magma Gorge
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 magma = new Form4();
            this.Hide();
            magma.Show();
        }

        //Laputta Station
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 laput = new Form5();
            this.Hide();
            laput.Show();
        }

        //Funkiki Island
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 funkiki = new Form6();
            this.Hide();
            funkiki.Show();
        }


        //Royalton Racing Complex
        private void button6_Click(object sender, EventArgs e)
        {
            Form7 rrc = new Form7();
            this.Hide();
            rrc.Show();
        }

        //Nightmare Rift
        private void button7_Click(object sender, EventArgs e)
        {
            Form8 nightmare = new Form8();
            this.Hide();
            nightmare.Show();
        }

        //Daydream Oasis
        private void button8_Click(object sender, EventArgs e)
        {
            Form9 daydream = new Form9();
            this.Hide();
            daydream.Show();
        }

        //Hidden Realm
        private void button9_Click(object sender, EventArgs e)
        {
            Form10 hrf = new Form10();
            this.Hide();
            hrf.Show();
        }

        //Paradox Green
        private void button10_Click(object sender, EventArgs e)
        {
            Form11 paradox = new Form11();
            this.Hide();
            paradox.Show();
        }

        //U.B.
        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("FFFFFFF0");
        }

        //Unused Funkeys
        private void Button13_Click(object sender, EventArgs e)
        {
            Form12 unused = new Form12();
            this.Hide();
            unused.Show();
        }

        //Insert Custom ID
        private void Button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey(textBox1.Text); //Sets customF to the contents of textBox1.
        }

        //Custom Funkeys
        private void button16_Click(object sender, EventArgs e)
        {
            Form13 customf = new Form13();
            this.Hide();
            customf.Show();
        }

        //Options
        private void button17_Click(object sender, EventArgs e)
        {
            Form14 options = new Form14();
            options.StartPosition = FormStartPosition.CenterParent;
            options.ShowDialog();
        }

        //Minimize
        private void button15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        //End of Button Clicks
        //

        //
        //Button Image Swaps
        //

        //Options
        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources._681;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources._679;
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackgroundImage = Properties.Resources._683;
        }

        //Minimize
        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources._150;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources._154;
        }
        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            button15.BackgroundImage = Properties.Resources._157;
        }

        //Close
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources._246;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources._248;
        }
        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button12.BackgroundImage = Properties.Resources._250;
        }

        //
        // End of Button Images
        //
    }
}