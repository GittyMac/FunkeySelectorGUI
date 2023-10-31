using System;
using System.Windows.Forms;

namespace FunkeySelector.UserControls
{
    public partial class OptionsButton : UserControl
    {
        public OptionsButton()
        {
            InitializeComponent();
        }

        private void Options_MouseEnter(object sender, EventArgs e)
        {
            options.BackgroundImage = Properties.Resources._681;
        }

        private void Options_MouseLeave(object sender, EventArgs e)
        {
            options.BackgroundImage = Properties.Resources._679;
        }

        private void Options_MouseDown(object sender, MouseEventArgs e)
        {
            options.BackgroundImage = Properties.Resources._683;
        }
    }
}
