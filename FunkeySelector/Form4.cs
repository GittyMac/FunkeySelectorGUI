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
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000026");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000027");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000028");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000029");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000002A");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000002E");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000002F");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000030");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000031");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000032");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000033");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000034");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
