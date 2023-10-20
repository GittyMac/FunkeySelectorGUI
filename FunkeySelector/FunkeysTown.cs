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
    public partial class FunkeysTown : Form
    {
        //
        // Initial Setups
        //

        CustomFManager customF = new CustomFManager(); //Assigns CustomFManager to customF.
        public FunkeysTown()
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
            this.Hide();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog(this);
        }

        private void Scratch_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000047");
        }

        private void ScratchR_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000048");
        }

        private void ScratchVR_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000049");
        }

        //Lotus
        private void button10_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000004A");
        }

        //Lotus R
        private void button9_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000004B");
        }

        //Lotus VR
        private void button8_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("0000004F");
        }

        //Drift
        private void button7_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000AA");
        }

        //Drift R
        private void button6_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000B7");
        }

        //Drift VR
        private void button5_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000C4");
        }

        //Waggs
        private void button13_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000AB");
        }

        //Waggs R
        private void button12_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000B8");
        }

        //Waggs VR
        private void button11_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000C5");
        }

        //Dot
        private void button16_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000FC");
        }

        //Dot R
        private void button15_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000FD");
        }

        //Dot VR
        private void button14_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("00000101");
        }

        //Holler
        private void button20_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000CD");
        }

        //Gabby
        private void button21_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000CB");
        }

        //Henchman
        private void button18_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000CF");
        }

        //Master Lox
        private void button17_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000F7");
        }

        //Mayor Sayso
        private void button19_Click(object sender, EventArgs e)
        {
            customF.SetFunkey("000000F8");
        }

        //
        //End of Button Clicks
        //
    }
}
