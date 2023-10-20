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
    public partial class Form5 : Form
    {
        //
        //Initial setup
        //

        CustomFManager customF = new CustomFManager(); //Sets up CustomFManager.
        public Form5()
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
        //Button clicks
        //

        //Xener
        private void button2_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000035");
        }

        //Xener R
        private void button3_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000039");
        }

        //Xener VR
        private void button4_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003A");
        }

        //Fallout
        private void button10_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003B");
        }

        //Fallout R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003C");
        }

        //Fallout VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003D");
        }

        //Boggle
        private void button7_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003E");
        }

        //Boggle R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000003F");
        }

        //Boggle VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000040");
        }

        //Vroom
        private void button13_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000044");
        }

        //Vroom R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000045");
        }

        //Vroom VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000046");
        }

        //Rom
        private void button14_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000CE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog(this);
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
