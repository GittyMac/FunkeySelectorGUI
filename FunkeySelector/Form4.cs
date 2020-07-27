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
    public partial class Form4 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000026");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000027");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000028");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000029");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000002A");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000002E");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000002F");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000030");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000031");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000032");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000033");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000034");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
