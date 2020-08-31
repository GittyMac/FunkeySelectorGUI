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

namespace FunkeySelector
{
    public partial class Form13 : Form
    {
        //
        //Initial setup
        //

        public Form13()
        {
            InitializeComponent();
            this.TransparencyKey = System.Drawing.Color.Gold; //Removes the gold sections to allow the UI to be rounded.
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

        //Initializes the listbox with customfunkeys.
        private void Form13_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles("./CustomFunkeys");

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        //
        //End of initial startup
        //

        //
        //Button Clicks
        //

        //Help
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This shows all of the custom Funkeys in the CustomFunkeys folder in the RadicaGame folder. Put the custom Funkey's txt inside the folder, it'll show up here. Click on the custom Funkey you want, and it'll show up in game!");
        }

        //Back
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        //Will select Funkey when listbox item is selected.
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.IO.File.Copy(listBox1.SelectedItem.ToString(), "customF.txt", true); //This does not use CustomFManager as it uses a different method.
            if (Properties.Settings.Default.wineCompat == false)
            {
                Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
            }
        }

        //Close
        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize
        private void button22_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        //End of Button Clicks
        //

        //
        //Button Images
        //

        //Minimize
        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources._150;
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources._154;
        }
        private void button22_MouseDown(object sender, MouseEventArgs e)
        {
            button22.BackgroundImage = Properties.Resources._157;
        }

        //Close
        private void button23_MouseLeave(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources._246;
        }

        private void button23_MouseEnter(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources._248;
        }
        private void button23_MouseDown(object sender, MouseEventArgs e)
        {
            button23.BackgroundImage = Properties.Resources._250;
        }

        //
        // End of Button Images
        //
    }
}
