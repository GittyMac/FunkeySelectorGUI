using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;

namespace FunkeySelector.UserControls
{
    class ChangeFormButton : Button
    {
        [
            Category("Behavior"),
            Description("The form to open when clicked.")
        ]
        public string FormToOpen { get; set; } = "Form1";

        [
            Category("Behavior"),
            Description("Whether to keep this form opened.")
        ]
        public bool KeepCurrentForm { get; set; } = false;

        public ChangeFormButton()
        {
            this.Click += new EventHandler(OnClick);
        }

        private void OnClick(object sender, EventArgs e)
        {
            ChangeForm();
        }

        public void ChangeForm()
        {
            Form currentForm = this.FindForm();
            Form parentForm = currentForm.Owner;

            // Flex Seal™️
            if (FormToOpen == "Form1" && parentForm.Name == "Form1")
            {
                parentForm.Show();
                parentForm.Location = currentForm.Location;
                currentForm.Close();
                return;
            }

            Form zoneForm = GetClassInstance<Form>(FormToOpen);
            if (!KeepCurrentForm) currentForm.Hide();
            zoneForm.StartPosition = FormStartPosition.CenterParent;
            zoneForm.ShowDialog(this);
        }

        static private T GetClassInstance<T>(string name)
        {
            ConstructorInfo[] constructorInfos =
               Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Namespace == "FunkeySelector" && type.Name == name)
                .Select(type => type.GetConstructor(Type.EmptyTypes))
                .Where(constructorInfo => constructorInfo != null)
                .ToArray();

            if (constructorInfos.Length < 1) throw new Exception($"Could not find constructor for class {name}.");

            T instance = (T)constructorInfos[0].Invoke(new object[] { });
            return instance;
        }
    }
}