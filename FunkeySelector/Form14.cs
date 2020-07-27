using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunkeySelector
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            checkBox1.Checked = Properties.Settings.Default.disableModCheck;
            checkBox2.Checked = Properties.Settings.Default.disableGameCheck;
            checkBox3.Checked = Properties.Settings.Default.wineCompat;
            checkBox4.Checked = Properties.Settings.Default.disableWineCheck;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.disableModCheck = true;
            }
            else
                Properties.Settings.Default.disableModCheck = false;
            Properties.Settings.Default.Save();


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.disableGameCheck = true;
            }
            else
                Properties.Settings.Default.disableGameCheck = false;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Properties.Settings.Default.wineCompat = true;
            }
            else
                Properties.Settings.Default.wineCompat = false;
            Properties.Settings.Default.Save();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Properties.Settings.Default.disableWineCheck = true;
            }
            else
                Properties.Settings.Default.disableWineCheck = false;
            Properties.Settings.Default.Save();
        }
    }
}
