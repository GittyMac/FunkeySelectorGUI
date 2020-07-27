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
        CustomFManager customF = new CustomFManager();
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000035");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000039");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003A");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003B");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003C");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003D");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003E");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000003F");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000040");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000044");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000045");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000046");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
