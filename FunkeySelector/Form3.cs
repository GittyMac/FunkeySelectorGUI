using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkeySelector
{
    public partial class Form3 : Form
    {
        //
        //Initial Startup
        //

        CustomFManager customF = new CustomFManager(); //Assigns CustomFManager to customF.

        public Form3()
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

        //
        //End of Initial Startup
        //

        //
        //Start of Button Clicks
        //Most of them switches the customF code.
        //

        //Back
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog(this);
        }

        //Glub
        private void button2_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000014");
        }

        //Glub R
        private void button3_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000018");
        }

        //Glub VR
        private void button4_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000019");
        }

        //Sprout
        private void button10_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001A");
        }

        //Sprout R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001B");
        }

        //Sprout VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001C");
        }

        //Twinx
        private void button7_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001D");
        }

        //Twinx R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001E");
        }

        //Twinx VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000001F");
        }

        //Tiki
        private void button13_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000023");
        }

        //Tiki R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000024");
        }

        //Tiki VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000025");
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
