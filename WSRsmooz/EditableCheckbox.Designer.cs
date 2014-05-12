using System.Windows.Forms;
namespace WSRsmooz
{
    partial class EditableCheckbox
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
            this.checkbox = new WSRsmooz.CustomTransparentCheckBox();
            this.SuspendLayout();
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox.Location = new System.Drawing.Point(4, 0);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(85, 20);
            this.checkbox.TabIndex = 0;
            this.checkbox.Text = "checkbox";
            this.checkbox.SizeChanged += new System.EventHandler(this.label_SizeChanged);
            // 
            // EditableCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.checkbox);
            this.Name = "EditableCheckbox";
            this.Size = new System.Drawing.Size(45, 16);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.triggerEntry);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomTransparentCheckBox checkbox;

    }
}
