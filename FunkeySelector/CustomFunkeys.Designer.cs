namespace FunkeySelector
{
    partial class CustomFunkeys
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFunkeys));
            this.CustomFunkeysLabel = new System.Windows.Forms.Label();
            this.backButton = new UserControls.ChangeFormButton();
            this.helpButton = new System.Windows.Forms.Button();
            this.Imagelist = new System.Windows.Forms.ImageList(this.components);
            this.CustomFunkeysListBox = new System.Windows.Forms.ListBox();
            this.minimizeButton = new FunkeySelector.UserControls.MinimizeButton();
            this.closeButton = new FunkeySelector.UserControls.CloseButton();
            this.SuspendLayout();
            // 
            // CustomFunkeysLabel
            // 
            this.CustomFunkeysLabel.AutoSize = true;
            this.CustomFunkeysLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomFunkeysLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFunkeysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomFunkeysLabel.Location = new System.Drawing.Point(241, 31);
            this.CustomFunkeysLabel.Name = "CustomFunkeysLabel";
            this.CustomFunkeysLabel.Size = new System.Drawing.Size(371, 52);
            this.CustomFunkeysLabel.TabIndex = 58;
            this.CustomFunkeysLabel.Text = "CUSTOM FUNKEYS";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 48);
            this.backButton.TabIndex = 59;
            this.backButton.Text = "BACK";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpButton.Location = new System.Drawing.Point(119, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(101, 48);
            this.helpButton.TabIndex = 60;
            this.helpButton.Text = "HELP";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.Help_Click);
            // 
            // Imagelist
            // 
            this.Imagelist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Imagelist.ImageSize = new System.Drawing.Size(128, 128);
            this.Imagelist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CustomFunkeysListBox
            // 
            this.CustomFunkeysListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomFunkeysListBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFunkeysListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.CustomFunkeysListBox.FormattingEnabled = true;
            this.CustomFunkeysListBox.ItemHeight = 29;
            this.CustomFunkeysListBox.Location = new System.Drawing.Point(31, 104);
            this.CustomFunkeysListBox.Name = "CustomFunkeysListBox";
            this.CustomFunkeysListBox.Size = new System.Drawing.Size(667, 410);
            this.CustomFunkeysListBox.TabIndex = 61;
            this.CustomFunkeysListBox.SelectedIndexChanged += new System.EventHandler(this.CustomFunkeysListBox_SelectedIndexChanged);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Location = new System.Drawing.Point(642, 15);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(26, 22);
            this.minimizeButton.TabIndex = 106;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(681, 17);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 20);
            this.closeButton.TabIndex = 107;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FunkeySelector.Properties.Resources._2432;
            this.ClientSize = new System.Drawing.Size(726, 566);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.CustomFunkeysListBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CustomFunkeysLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.Text = "FunkeySelectorGUI";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.Load += new System.EventHandler(this.CustomFunkeys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomFunkeysLabel;
        private UserControls.ChangeFormButton backButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ImageList Imagelist;
        private System.Windows.Forms.ListBox CustomFunkeysListBox;
        private UserControls.MinimizeButton minimizeButton;
        private UserControls.CloseButton closeButton;
    }
}