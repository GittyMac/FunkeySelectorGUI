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
using FunkeySelector.UserControls;

namespace FunkeySelector
{
    public partial class Form1 : BasicForm
    {
        static bool firstStart = true;

        public Form1()
        {
            InitializeComponent();
            if (firstStart == false) return;
            firstStart = false;

            if (
                Properties.Settings.Default.disableGameCheck == false &&
                !File.Exists("UBFunkeys.exe") && !File.Exists("OpenFK.exe")
            ) _ = MessageBox.Show("The U.B. Funkeys game was not found! Did you put FunkeySelectorGUI in the RadicaGame folder?");

            if (
                Properties.Settings.Default.disableModCheck == false &&
                File.Exists("Main.swf")
            )
            {
                string mainSWFMD5 = CalculateMD5("Main.swf");

                if (
                    mainSWFMD5 != "93261ce3dc332fdee5d4335eab0a8e63" &&
                    !File.Exists("OpenFK.exe")
                ) _ = MessageBox.Show("Could not detect the Funkeys Selection Mod! Did you install the mod?");

                else if (
                    mainSWFMD5 == "93261ce3dc332fdee5d4335eab0a8e63" &&
                    File.Exists("OpenFK.exe")
                ) _ = MessageBox.Show("You are using OpenFK with the Funkeys Selection Mod. Please use the original Main.swf with OpenFK's customF mode for a better experience.");
            }

            // Asks user to enable wine tweaks
            if (
                Properties.Settings.Default.disableWineCheck == false &&
                Properties.Settings.Default.wineCompat == false &&
                IsWine() &&
                MessageBox.Show(
                    "FunkeySelectorGUI has detected it is running from Wine. If you want to enable Wine compatibility tweaks, which fixes the selection of Funkeys, click yes.",
                    "Wine detected!",
                    MessageBoxButtons.YesNo
                ) == DialogResult.Yes
            ) Properties.Settings.Default.wineCompat = true;
        }

        public static bool IsWine()
        {
            // This registry key is usually only present when running from Wine
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Wine\"); 
            return key != null;
        }

        static string CalculateMD5(string filename)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename);
            var hash = md5.ComputeHash(stream); // Converts the hash to a readable string to compare.
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        private void InsertCustomID_Click(object sender, EventArgs e)
        {
            CustomF.SetFunkey(CustomIDTextBox.Text);
        }
    }
}