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
        CustomFManager customF = new CustomFManager();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000047");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000048");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000049");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004A");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004B");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000004F");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AA");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B7");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AB");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C5");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000FC");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000FD");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000101");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CD");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CB");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CF");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F7");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F8");
        }
    }
}
