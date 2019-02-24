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
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000102");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000106");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000010D");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000103");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000107");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000010E");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000104");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000108");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000010F");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000105");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000010C");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000110");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000011A");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=0000011E");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=00000125");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }
    }
}
