using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace FunkeySelector
{
    public partial class Form2 : Form
    {
        //
        // Initial Setups
        //

        CustomFManager customF = new CustomFManager(); //Assigns CustomFManager to customF.
        public Form2()
        {
            InitializeComponent();
            this.TransparencyKey = System.Drawing.Color.Gold; //Cuts out gold parts to be rounded.
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
        // End of Initial Setups
        //

        //
        // Button Clicks
        // Most of these call CustomFManager to set the customF code. 
        //

        //Back
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        //Scratch
        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000047");
        }

        //Scratch R
        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000048");
        }

        //Scratch VR
        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000049");
        }

        //Lotus
        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004A");
        }

        //Lotus R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004B");
        }

        //Lotus VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004F");
        }

        //Drift
        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AA");
        }

        //Drift R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B7");
        }

        //Drift VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C4");
        }

        //Waggs
        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AB");
        }

        //Waggs R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B8");
        }

        //Waggs VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C5");
        }

        //Dot
        private void button16_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000FC");
        }

        //Dot R
        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000FD");
        }

        //Dot VR
        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000101");
        }

        //Holler
        private void button20_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CD");
        }

        //Gabby
        private void button21_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CB");
        }

        //Henchman
        private void button18_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CF");
        }

        //Master Lox
        private void button17_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F7");
        }

        //Mayor Sayso
        private void button19_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F8");
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

        //Exit
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

        //
        // End of Button Images
        //

    }
}
