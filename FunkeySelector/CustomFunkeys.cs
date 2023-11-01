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
using FunkeySelector.Properties;

namespace FunkeySelector
{
    public partial class CustomFunkeys : BasicForm
    {
        private Dictionary<string, string> FunkeyPaths;

        public CustomFunkeys()
        {
            InitializeComponent();
        }

        //Initializes the listbox with customfunkeys.
        private void CustomFunkeys_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            CustomFunkeysListBox.Items.Clear();
            FunkeyPaths.Clear();

            if (!Directory.Exists("./CustomFunkeys"))
            {
                Directory.CreateDirectory("./CustomFunkeys"); // Remember, you wouldn't download a file named con, just like you wouldn't download a car!
                File.WriteAllText("./CustomFunkeys/Car Dealer.txt", "funkeyCodeNum=S0000001"); // You would download pizza instead.
            }

            string[] files = Directory.GetFiles("./CustomFunkeys");

            foreach (string file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                CustomFunkeysListBox.Items.Add(name);
                FunkeyPaths.Add(name, file);
            }
        }

        // Will change into funkey when listbox item is selected.
        private void CustomFunkeysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = CustomFunkeysListBox.SelectedItem.ToString();
            string file = FunkeyPaths[name];

            try
            {
                CustomF.SetFunkeyFromFile(file);
            }
            catch (Exception exception) when (exception is DirectoryNotFoundException or FileNotFoundException)
            {
                bool isDirectoryError = exception is DirectoryNotFoundException;

                string text = isDirectoryError ?
                    "The CustomFunkeys directory no longer exists. Do you want to retry? Pressing no will recreate the Customfunkeys directory. Press cancel to ignore."
                    : $"{Path.GetFileName(file)} no longer exists. Do you want to retry? Pressing no will refresh the list. Press cancel to ignore.";

                string caption = $"{(isDirectoryError ? "Directory" : "File")} not found";

                DialogResult result = MessageBox.Show(
                    text,
                    caption,
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );

                if (result == DialogResult.Yes)
                {
                    CustomFunkeysListBox_SelectedIndexChanged(sender, e);
                    return;
                }
                if (result == DialogResult.No) RefreshItems();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }
    }
}
