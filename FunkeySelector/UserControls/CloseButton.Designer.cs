
namespace FunkeySelector
{
    partial class CloseButton
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
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::FunkeySelector.Properties.Resources._246;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 20);
            this.close.TabIndex = 16;
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // CloseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.close);
            this.Name = "CloseButton";
            this.Size = new System.Drawing.Size(26, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
    }
}
