using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FunkeySelector.UserControls
{
    class FunkeyChangerButton : Button
    {
        [
            Category("Behavior"),
            Description("The ID of the funkey to change into when clicked.")
        ]
        public string FunkeyID { get; set; } = "FFFFFFF0";

        public FunkeyChangerButton()
        {
            this.Click += new EventHandler(this.ChangeFunkey);
        }

        public void ChangeFunkey(object sender, EventArgs e)
        {
            CustomF.SetFunkey(FunkeyID);
        }
    }
}
