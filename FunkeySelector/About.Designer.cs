namespace FunkeySelector
{
    partial class About
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
            this.AboutFSGUILabel = new System.Windows.Forms.Label();
            this.DevelopedByLabel = new System.Windows.Forms.Label();
            this.MadeForLabel = new System.Windows.Forms.Label();
            this.CreditsToLabel = new System.Windows.Forms.Label();
            this.okButton = new FunkeySelector.UserControls.OKButton();
            this.SuspendLayout();
            // 
            // AboutFSGUILabel
            // 
            this.AboutFSGUILabel.AutoSize = true;
            this.AboutFSGUILabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutFSGUILabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutFSGUILabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutFSGUILabel.Location = new System.Drawing.Point(137, 25);
            this.AboutFSGUILabel.Name = "AboutFSGUILabel";
            this.AboutFSGUILabel.Size = new System.Drawing.Size(297, 26);
            this.AboutFSGUILabel.TabIndex = 3;
            this.AboutFSGUILabel.Text = "ABOUT FUNKEYSELECTORGUI";
            // 
            // DevelopedByLabel
            // 
            this.DevelopedByLabel.AutoSize = true;
            this.DevelopedByLabel.BackColor = System.Drawing.Color.Transparent;
            this.DevelopedByLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedByLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DevelopedByLabel.Location = new System.Drawing.Point(155, 84);
            this.DevelopedByLabel.Name = "DevelopedByLabel";
            this.DevelopedByLabel.Size = new System.Drawing.Size(260, 20);
            this.DevelopedByLabel.TabIndex = 4;
            this.DevelopedByLabel.Text = "DEVELOPED BY GITTYMAC (LAKO)";
            // 
            // MadeForLabel
            // 
            this.MadeForLabel.AutoSize = true;
            this.MadeForLabel.BackColor = System.Drawing.Color.Transparent;
            this.MadeForLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadeForLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MadeForLabel.Location = new System.Drawing.Point(122, 126);
            this.MadeForLabel.Name = "MadeForLabel";
            this.MadeForLabel.Size = new System.Drawing.Size(327, 20);
            this.MadeForLabel.TabIndex = 5;
            this.MadeForLabel.Text = "MADE FOR THE FUNKEYS SELECTION MOD";
            // 
            // CreditsToLabel
            // 
            this.CreditsToLabel.AutoSize = true;
            this.CreditsToLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditsToLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsToLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreditsToLabel.Location = new System.Drawing.Point(90, 168);
            this.CreditsToLabel.Name = "CreditsToLabel";
            this.CreditsToLabel.Size = new System.Drawing.Size(390, 20);
            this.CreditsToLabel.TabIndex = 6;
            this.CreditsToLabel.Text = "CREDITS TO DUALSCAR FOR THE ICONS AND IDEA";
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
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FunkeySelector.Properties.Resources._1841;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(570, 272);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.CreditsToLabel);
            this.Controls.Add(this.MadeForLabel);
            this.Controls.Add(this.DevelopedByLabel);
            this.Controls.Add(this.AboutFSGUILabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "Form15";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutFSGUILabel;
        private System.Windows.Forms.Label DevelopedByLabel;
        private System.Windows.Forms.Label MadeForLabel;
        private System.Windows.Forms.Label CreditsToLabel;
        private UserControls.OKButton okButton;
    }
}