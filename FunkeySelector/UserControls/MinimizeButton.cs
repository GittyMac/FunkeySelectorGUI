using System;
using System.Windows.Forms;

namespace FunkeySelector.UserControls
{
    public partial class MinimizeButton : UserControl
    {
        public MinimizeButton()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackgroundImage = Properties.Resources._150;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackgroundImage = Properties.Resources._154;
        }
        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            minimize.BackgroundImage = Properties.Resources._157;
        }
    }
}
