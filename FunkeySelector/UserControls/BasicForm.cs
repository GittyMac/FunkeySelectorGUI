using System;
using System.Windows.Forms;

namespace FunkeySelector.UserControls
{
    public class BasicForm : Form
    {
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            // Allows the window to be dragged.
            if (message.Msg == 0x84 && (int)message.Result == 0x1)
            {
                message.Result = (IntPtr)0x2;
            }
        }
    }
}
