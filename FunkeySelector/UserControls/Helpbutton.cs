using System;
using System.ComponentModel;
using System.Windows.Forms;
using FunkeySelector.Properties;

namespace FunkeySelector.UserControls
{
    public partial class Helpbutton : UserControl
    {
        [
            Category("Behavior"),
            Description("The text to show in the popup shown when clicked.")
        ]
        public string HelpText { get; set; } = "Help text here.";

        public Helpbutton()
        {
            InitializeComponent();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelpText, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            help.BackgroundImage = Resources._544;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            help.BackgroundImage = Resources._542;
        }

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            help.BackgroundImage = Resources._546;
        }
    }
}
