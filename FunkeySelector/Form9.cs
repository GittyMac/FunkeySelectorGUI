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
        CustomFManager customF = new CustomFManager();
        public Form9()
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
            customF.setFunkey("000000A1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AE");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000BE");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AF");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000BF");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B6");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C3");
        }
    }
}
