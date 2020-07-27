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
    public partial class Form11 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form11()
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
            customF.setFunkey("00000117");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000011B");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000122");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000118");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000011C");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000123");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000119");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000011D");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000124");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000126");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000127");
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
