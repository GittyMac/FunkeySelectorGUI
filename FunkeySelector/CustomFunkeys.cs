using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FunkeySelector.UserControls;

namespace FunkeySelector
{
    public partial class CustomFunkeys : BasicForm
    {
        public CustomFunkeys()
        {
            InitializeComponent();
        }

        //Initializes the listbox with customfunkeys.
        private void CustomFunkeys_Load(object sender, EventArgs e)
        {
            CustomFunkeysListBox.Items.Clear();
            string[] files = Directory.GetFiles("./CustomFunkeys");

            foreach (string file in files)
            {
                CustomFunkeysListBox.Items.Add(file);
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This shows all of the custom Funkeys in the CustomFunkeys folder in the RadicaGame folder. Put the custom Funkey's txt inside the folder, it'll show up here. Click on the custom Funkey you want, and it'll show up in game!");
        }

        //Will select Funkey when listbox item is selected.
        private void CustomFunkeysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.Copy(CustomFunkeysListBox.SelectedItem.ToString(), "customF.txt", true); //This does not use CustomFManager as it uses a different method.
            if (Properties.Settings.Default.wineCompat == false)
            {
                Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
            }
        }
    }
}
