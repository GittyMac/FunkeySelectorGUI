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
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000035");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000039");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003A");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003B");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003C");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003D");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003E");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000003F");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000040");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000044");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000045");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000046");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000CE");
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
