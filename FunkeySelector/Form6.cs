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
    public partial class Form6 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form6()
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
            customF.setFunkey("00000050");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000051");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000052");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000053");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000054");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000035");
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000055");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000056");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005A");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005B");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005C");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005D");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005E");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F2");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F6");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000F1");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            customF.setFunkey("000000CC");
        }
    }
}
