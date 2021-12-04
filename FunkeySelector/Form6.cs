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
    public partial class Form6 : Form
    {
        //
        //Initial setup
        //

        CustomFManager customF = new CustomFManager(); //Sets up CustomFManager.
        public Form6()
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
        //End of initial startup
        //

        //
        //Button Clicks
        //

        //Back
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog(this);
        }

        //Flurry
        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000050");
        }

        //Flurry R
        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000051");
        }

        //Flurry VR
        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000052");
        }

        //Nibble
        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000053");
        }

        //Nibble R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000054");
        }

        //Nibble VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000055");
        }

        //Sol
        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000056");
        }

        //Sol R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005A");
        }

        //Sol VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005B");
        }

        //Webley
        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005C");
        }

        //Webley R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005D");
        }

        //Webley VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005E");
        }

        //Pineapple King
        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F2");
        }

        //Native
        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F6");
        }

        //Jerry
        private void button16_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F1");
        }

        //Rewind
        private void button17_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CC");
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
