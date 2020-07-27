using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunkeySelector
{
    public partial class Form12 : Form
    {
        CustomFManager customF = new CustomFManager();
        public Form12()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            customF.setFunkey("S0000001");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000001");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000002");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            customF.setFunkey("T0000003");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000001");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000003");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000003");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000007");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            customF.setFunkey("h0000006");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
