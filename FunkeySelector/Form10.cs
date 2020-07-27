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
    public partial class Form10 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form10()
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
            customF.setFunkey("00000102");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000106");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000010D");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000103");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000107");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000010E");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000104");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000108");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000010F");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000105");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000010C");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000110");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000011A");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000011E");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000125");
        }
    }
}
