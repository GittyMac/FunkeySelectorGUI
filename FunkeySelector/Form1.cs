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

        CustomFManager customF = new(); //Sets the CustomFManager to customf.
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
                        }else if (CalculateMD5("Main.swf") == "93261ce3dc332fdee5d4335eab0a8e63" && File.Exists("OpenFK.exe"))
                        {
                            MessageBox.Show("You are using OpenFK with the Funkeys Selection Mod. Please use the original Main.swf with OpenFK's customF mode for a better experience.");
                        }
                    }
                }
                if (Properties.Settings.Default.disableWineCheck == false) //Checks if Wine check is allowed.
                {
                    if (Properties.Settings.Default.wineCompat == false) //If wine compatibility is on, it won't check as well, as there's no need to check and prompt for wine compatibility.
                    {
                        if (CheckMachineType() == true) //Calls the Wine checker
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

        public static bool CheckMachineType() //Checks if FSGUI is running from Wine or Windows.
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
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename); //Opens the main.swf.
            var hash = md5.ComputeHash(stream); //Computes the MD5 hash of the swf.
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant(); //Converts the hash to a readable string to compare.
        }

        //
        // End of Initial Setups
        //

        //
        // Button Clicks
        // Most of these just hide this form and shows another one.
        //

        private void FunkeysTown_Click(object sender, EventArgs e)
        {
            FunkeysTown funktown = new FunkeysTown();
            this.Hide();
            funktown.StartPosition = FormStartPosition.CenterParent;
            funktown.ShowDialog(this);
        }

        private void KelpyBasin_Click(object sender, EventArgs e)
        {
            Form3 kelp = new Form3();
            this.Hide();
            kelp.StartPosition = FormStartPosition.CenterParent;
            kelp.ShowDialog(this);
        }

        private void MagmaGorge_Click(object sender, EventArgs e)
        {
            Form4 magma = new Form4();
            this.Hide();
            magma.StartPosition = FormStartPosition.CenterParent;
            magma.ShowDialog(this);
        }

        private void LaputtaStation_Click(object sender, EventArgs e)
        {
            Form5 laput = new Form5();
            this.Hide();
            laput.StartPosition = FormStartPosition.CenterParent;
            laput.ShowDialog(this);
        }

        private void FunkikiIsland_Click(object sender, EventArgs e)
        {
            Form6 funkiki = new Form6();
            this.Hide();
            funkiki.StartPosition = FormStartPosition.CenterParent;
            funkiki.ShowDialog(this);
        }


        private void RoyaltonRacingComplex_Click(object sender, EventArgs e)
        {
            Form7 rrc = new Form7();
            this.Hide();
            rrc.StartPosition = FormStartPosition.CenterParent;
            rrc.ShowDialog(this);
        }

        private void NightmareRift_Click(object sender, EventArgs e)
        {
            Form8 nightmare = new Form8();
            this.Hide();
            nightmare.StartPosition = FormStartPosition.CenterParent;
            nightmare.ShowDialog(this);
        }

        private void DaydreamOasis_Click(object sender, EventArgs e)
        {
            Form9 daydream = new Form9();
            this.Hide();
            daydream.StartPosition = FormStartPosition.CenterParent;
            daydream.ShowDialog(this);
        }

        private void HiddenRealm_Click(object sender, EventArgs e)
        {
            Form10 hrf = new Form10();
            this.Hide();
            hrf.StartPosition = FormStartPosition.CenterParent;
            hrf.ShowDialog(this);
        }

        private void ParadoxGreen_Click(object sender, EventArgs e)
        {
            Form11 paradox = new Form11();
            this.Hide();
            paradox.StartPosition = FormStartPosition.CenterParent;
            paradox.ShowDialog(this);
        }

        private void UB_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("FFFFFFF0");
        }

        private void UnusedFunkeys_Click(object sender, EventArgs e)
        {
            Form12 unused = new Form12();
            this.Hide();
            unused.StartPosition = FormStartPosition.CenterParent;
            unused.ShowDialog(this);
        }

        private void InsertCustomID_Click(object sender, EventArgs e)
        {
            customF.SetFunkey(CustomIDTextBox.Text);
        }

        private void CustomFunkeys_Click(object sender, EventArgs e)
        {
            Form13 customf = new Form13();
            this.Hide();
            customf.StartPosition = FormStartPosition.CenterParent;
            customf.ShowDialog(this);
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Form14 options = new Form14();
            options.StartPosition = FormStartPosition.CenterParent;
            options.ShowDialog();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        //End of Button Clicks
        //

        //Options
        private void OptionsButton_MouseEnter(object sender, EventArgs e)
        {
            OptionsButton.BackgroundImage = Properties.Resources._681;
        }

        private void OptionsButton_MouseLeave(object sender, EventArgs e)
        {
            OptionsButton.BackgroundImage = Properties.Resources._679;
        }

        private void OptionsButton_MouseDown(object sender, MouseEventArgs e)
        {
            OptionsButton.BackgroundImage = Properties.Resources._683;
        }
    }
}