
namespace FunkeySelector.UserControls
{
    partial class MinimizeButton
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
            this.minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = global::FunkeySelector.Properties.Resources._150;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimize.Location = new System.Drawing.Point(0, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 22);
            this.minimize.TabIndex = 80;
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseDown);
            this.minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minimize);
            this.Name = "MinimizeButton";
            this.Size = new System.Drawing.Size(26, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minimize;
    }
}
