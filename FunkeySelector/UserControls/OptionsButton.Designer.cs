
namespace FunkeySelector.UserControls
{
    partial class OptionsButton
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
            this.options = new FunkeySelector.UserControls.ChangeFormButton();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.BackgroundImage = global::FunkeySelector.Properties.Resources._679;
            this.options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.options.FlatAppearance.BorderSize = 0;
            this.options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.Transparent;
            this.options.FormToOpen = "Options";
            this.options.KeepCurrentForm = true;
            this.options.Location = new System.Drawing.Point(0, 0);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(39, 44);
            this.options.TabIndex = 79;
            this.options.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.options.UseVisualStyleBackColor = false;
            this.options.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Options_MouseDown);
            this.options.MouseEnter += new System.EventHandler(this.Options_MouseEnter);
            this.options.MouseLeave += new System.EventHandler(this.Options_MouseLeave);
            // 
            // OptionsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.options);
            this.Name = "OptionsButton";
            this.Size = new System.Drawing.Size(39, 44);
            this.ResumeLayout(false);

        }

        #endregion

        private FunkeySelector.UserControls.ChangeFormButton options;
    }
}
