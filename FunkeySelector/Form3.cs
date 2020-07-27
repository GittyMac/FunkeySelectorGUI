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
    public partial class Form3 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form3()
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
            customF.setFunkey("00000014");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000018");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000019");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001A");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001B");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001C");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001D");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001E");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000001F");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000023");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000024");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000025");
        }
    }
}
