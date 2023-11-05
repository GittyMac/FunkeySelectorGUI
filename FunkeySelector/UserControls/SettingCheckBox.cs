using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using FunkeySelector.Properties;

namespace FunkeySelector.UserControls
{
    public partial class SettingCheckBox : CheckBox
    {
        private string settingName;

        [
            Category("Behavior"),
            Description("The name of the setting this CheckBox is bound to."),
        ]
        public string SettingName
        {   // We use a getter here because Name changes and is not always the same at runtime
            get => settingName != null && settingName != "" ? settingName : Name;
            set => settingName = value;
        }

        public SettingCheckBox()
        {
            this.CheckedChanged += new EventHandler(CheckChange);
            this.ParentChanged += new EventHandler(ParentLoad);
        }

        private void ParentLoad(object sender, EventArgs e)
        {
            this.Checked = (bool)GetSetting().GetValue(Settings.Default, null);
        }

        private void CheckChange(object sender, EventArgs e)
        {
            GetSetting()
                .SetValue(Settings.Default, this.Checked, null);

            Settings.Default.Save();
        }

        private PropertyInfo GetSetting()
        {
            return typeof(Settings)
                .GetProperty(SettingName);
        }
    }
}

