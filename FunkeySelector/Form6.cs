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
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000050");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000051");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000052");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000053");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000054");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000055");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000056");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000005A");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000005B");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000005C");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000005D");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000005E");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000F2");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000F6");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000F1");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000CC");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }
    }
}
