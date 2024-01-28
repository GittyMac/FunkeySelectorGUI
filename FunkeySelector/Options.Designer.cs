namespace FunkeySelector
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.disableModCheck = new FunkeySelector.UserControls.SettingCheckBox();
            this.disableGameCheck = new FunkeySelector.UserControls.SettingCheckBox();
            this.aboutButton = new FunkeySelector.UserControls.ChangeFormButton();
            this.okButton = new FunkeySelector.UserControls.OKButton();
            this.SuspendLayout();
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OptionsLabel.Location = new System.Drawing.Point(234, 25);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(103, 26);
            this.OptionsLabel.TabIndex = 1;
            this.OptionsLabel.Text = "OPTIONS";
            // 
            // disableModCheck
            // 
            this.disableModCheck.AutoSize = true;
            this.disableModCheck.BackColor = System.Drawing.Color.Transparent;
            this.disableModCheck.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableModCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.disableModCheck.Location = new System.Drawing.Point(111, 104);
            this.disableModCheck.Name = "disableModCheck";
            this.disableModCheck.SettingName = "disableModCheck";
            this.disableModCheck.Size = new System.Drawing.Size(351, 24);
            this.disableModCheck.TabIndex = 2;
            this.disableModCheck.Text = "DISABLE FUNKEYS SELECTION MOD CHECK";
            this.disableModCheck.UseVisualStyleBackColor = false;
            // 
            // disableGameCheck
            // 
            this.disableGameCheck.AutoSize = true;
            this.disableGameCheck.BackColor = System.Drawing.Color.Transparent;
            this.disableGameCheck.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableGameCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.disableGameCheck.Location = new System.Drawing.Point(111, 127);
            this.disableGameCheck.Name = "disableGameCheck";
            this.disableGameCheck.SettingName = "disableGameCheck";
            this.disableGameCheck.Size = new System.Drawing.Size(297, 24);
            this.disableGameCheck.TabIndex = 3;
            this.disableGameCheck.Text = "DISABLE U.B. FUNKEYS GAME CHECK";
            this.disableGameCheck.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutButton.FormToOpen = "About";
            this.aboutButton.KeepCurrentForm = true;
            this.aboutButton.Location = new System.Drawing.Point(146, 187);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(262, 31);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "ABOUT FUNKEYSELECTORGUI";
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.CloseForm = true;
            this.okButton.Location = new System.Drawing.Point(242, 244);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 23);
            this.okButton.TabIndex = 7;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FunkeySelector.Properties.Resources._1841;
            this.ClientSize = new System.Drawing.Size(570, 273);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.disableGameCheck);
            this.Controls.Add(this.disableModCheck);
            this.Controls.Add(this.OptionsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "FunkeySelectorGUI - Options";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OptionsLabel;
        private FunkeySelector.UserControls.SettingCheckBox disableModCheck;
        private FunkeySelector.UserControls.SettingCheckBox disableGameCheck;
        private FunkeySelector.UserControls.ChangeFormButton aboutButton;
        private UserControls.OKButton okButton;
    }
}