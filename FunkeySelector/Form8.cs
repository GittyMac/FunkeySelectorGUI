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
    public partial class Form8 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form8()
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
            customF.setFunkey("000000A0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000BA");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000A8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000C2");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000AC");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000B9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CA");
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
