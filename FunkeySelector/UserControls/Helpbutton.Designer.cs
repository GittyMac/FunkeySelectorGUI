
namespace FunkeySelector.UserControls
{
    partial class Helpbutton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.BackgroundImage = global::FunkeySelector.Properties.Resources._542;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.help.Location = new System.Drawing.Point(0, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(23, 23);
            this.help.TabIndex = 61;
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.Help_Click);
            this.help.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_MouseDown);
            this.help.MouseEnter += new System.EventHandler(this.Help_MouseEnter);
            this.help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            // 
            // Helpbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.help);
            this.Name = "Helpbutton";
            this.Size = new System.Drawing.Size(23, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button help;
    }
}
