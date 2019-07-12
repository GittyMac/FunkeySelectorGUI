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
    public partial class Form1 : Form
    {
        private object frmBorderless;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 funktown = new Form2();
            this.Hide();
            funktown.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 kelp = new Form3();
            this.Hide();
            kelp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 magma = new Form4();
            this.Hide();
            magma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 laput = new Form5();
            this.Hide();
            laput.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 funkiki = new Form6();
            this.Hide();
            funkiki.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 rrc = new Form7();
            this.Hide();
            rrc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 nightmare = new Form8();
            this.Hide();
            nightmare.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 daydream = new Form9();
            this.Hide();
            daydream.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 hrf = new Form10();
            this.Hide();
            hrf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form11 paradox = new Form11();
            this.Hide();
            paradox.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=FFFFFFF0");
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Form12 unused = new Form12();
            this.Hide();
            unused.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=" + textBox1.Text);
            }
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }
    }
}
