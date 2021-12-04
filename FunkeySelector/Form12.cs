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
    public partial class Form12 : Form
    {
        //
        //Initial setup
        //

        CustomFManager customF = new CustomFManager(); //Sets up CustomFManager.
        public Form12()
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

        //Con
        private void Button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("S0000001");
        }

        //TachB
        private void Button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000001");
        }

        //TachY
        private void Button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000002");
        }

        //TachR
        private void Button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000003");
        }

        //HenchmanP
        private void Button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000001");
        }

        //HenchmanG
        private void Button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000003");
        }

        //HenchmanB
        private void Button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000003");
        }

        //Dali
        private void Button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000007");
        }

        //Goya
        private void Button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000006");
        }

        //Back
        private void Button1_Click(object sender, EventArgs e)
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
