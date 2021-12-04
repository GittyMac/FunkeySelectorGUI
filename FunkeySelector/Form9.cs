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
    public partial class Form9 : Form
    {
        //
        //Initial setup
        //

        CustomFManager customF = new CustomFManager(); //Sets up CustomFManager.
        public Form9()
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

        //Dyer
        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A1");
        }

        //Dyer R
        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AE");
        }

        //Dyer VR
        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000BE");
        }

        //Lucky
        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A2");
        }

        //Lucky R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AF");
        }

        //Lucky VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000BF");
        }

        //Tank
        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A3");
        }

        //Tank R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B3");
        }

        //Tank VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C0");
        }

        //Berger
        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A9");
        }

        //Berger R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B6");
        }

        //Berger VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C3");
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
