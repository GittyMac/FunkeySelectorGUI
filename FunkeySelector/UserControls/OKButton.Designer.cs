
namespace FunkeySelector.UserControls
{
    partial class OKButton
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImage = global::FunkeySelector.Properties.Resources._230;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(86, 23);
            this.button.TabIndex = 1;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.Button_Click);
            this.button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // OKButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button);
            this.Name = "OKButton";
            this.Size = new System.Drawing.Size(86, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
    }
}
