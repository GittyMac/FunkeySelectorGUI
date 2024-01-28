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
            ) _ = MessageBox.Show("The U.B. Funkeys game was not found! Did you put FunkeySelectorGUI in the RadicaGame folder?"); //MB Mode runs it in RadicaGame so the location doesn't matter.

            if (
                Properties.Settings.Default.disableModCheck == false &&
                File.Exists("Main.swf")
            )
            {
                string mainSWFMD5 = CalculateMD5("Main.swf");

                if (
                    mainSWFMD5 == "93261ce3dc332fdee5d4335eab0a8e63" &&
                    !File.Exists("OpenFK.exe")
                ) _ = MessageBox.Show("You are using UBFunkeys.exe with the Funkeys Selection Mod. Please replace 'U.B. Funkeys/MegaByte.exe' with FunkeySelectorGUI and remove the mod for a better experience.");

                else if (
                    mainSWFMD5 == "93261ce3dc332fdee5d4335eab0a8e63" &&
                    File.Exists("OpenFK.exe")
                ) _ = MessageBox.Show("You are using OpenFK with the Funkeys Selection Mod. Please use the original Main.swf with OpenFK's customF mode for a better experience.");
            }
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