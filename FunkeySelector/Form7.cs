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
    public partial class Form7 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000005F");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000083");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000088");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customF.setFunkey("0000008C");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000093");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000095");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000096");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("00000094");
        }
    }
}
