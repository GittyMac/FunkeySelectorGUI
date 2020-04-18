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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This shows all of the custom Funkeys in the CustomFunkeys folder in the RadicaGame folder. Put the custom Funkey's txt inside the folder, it'll show up here. Click on the custom Funkey you want, and it'll show up in game!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles("./CustomFunkeys");

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.IO.File.Copy(listBox1.SelectedItem.ToString(), "customF.txt", true);
            Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow();
        }
    }
}
