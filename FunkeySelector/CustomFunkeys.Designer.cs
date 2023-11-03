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
            this.backButton = new FunkeySelector.UserControls.ChangeFormButton();
            this.Imagelist = new System.Windows.Forms.ImageList(this.components);
            this.CustomFunkeysListBox = new System.Windows.Forms.ListBox();
            this.minimizeButton = new FunkeySelector.UserControls.MinimizeButton();
            this.closeButton = new FunkeySelector.UserControls.CloseButton();
            this.refreshButton = new System.Windows.Forms.Button();
            this.helpbutton = new FunkeySelector.UserControls.Helpbutton();
            this.SuspendLayout();
            // 
            // CustomFunkeysLabel
            // 
            this.CustomFunkeysLabel.AutoSize = true;
            this.CustomFunkeysLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomFunkeysLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFunkeysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomFunkeysLabel.Location = new System.Drawing.Point(227, 27);
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
            this.backButton.FormToOpen = "Form1";
            this.backButton.KeepCurrentForm = false;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 86);
            this.backButton.TabIndex = 59;
            this.backButton.Text = "BACK";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backButton.UseVisualStyleBackColor = false;
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
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshButton.Location = new System.Drawing.Point(119, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(116, 86);
            this.refreshButton.TabIndex = 108;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.helpbutton.HelpText = resources.GetString("helpbutton.HelpText");
            this.helpbutton.Location = new System.Drawing.Point(608, 16);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(23, 23);
            this.helpbutton.TabIndex = 109;
            // 
            // CustomFunkeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FunkeySelector.Properties.Resources._2432;
            this.ClientSize = new System.Drawing.Size(726, 566);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.CustomFunkeysListBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CustomFunkeysLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomFunkeys";
            this.Text = "FunkeySelectorGUI - Custom Funkeys";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.Load += new System.EventHandler(this.CustomFunkeys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomFunkeysLabel;
        private UserControls.ChangeFormButton backButton;
        private System.Windows.Forms.ImageList Imagelist;
        private System.Windows.Forms.ListBox CustomFunkeysListBox;
        private UserControls.MinimizeButton minimizeButton;
        private UserControls.CloseButton closeButton;
        private System.Windows.Forms.Button refreshButton;
        private UserControls.Helpbutton helpbutton;
    }
}