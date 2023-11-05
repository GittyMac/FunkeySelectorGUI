using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FunkeySelector.UserControls
{
    public partial class OKButton : UserControl
    {
        [
            Category("Behavior"),
            Description("Whether to close the form this control is in when clicked.")
        ]
        public bool CloseForm { get; set; } = true;

        public OKButton()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            button.BackgroundImage = Properties.Resources._232;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            button.BackgroundImage = Properties.Resources._230;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            button.BackgroundImage = Properties.Resources._234;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!CloseForm) return;
            ParentForm.Close();
        }
    }
}
