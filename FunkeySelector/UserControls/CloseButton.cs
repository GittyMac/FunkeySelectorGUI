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
    public partial class CloseButton : UserControl
    {
        public CloseButton()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources._246;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources._248;
        }
        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            close.BackgroundImage = Properties.Resources._250;
        }
    }
}
