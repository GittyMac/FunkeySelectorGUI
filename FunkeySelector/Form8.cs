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
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000A0");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000AD");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000BA");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000A4");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000B4");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000C1");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000A8");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000B5");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000C2");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000AC");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000B9");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=000000CA");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }
    }
}
