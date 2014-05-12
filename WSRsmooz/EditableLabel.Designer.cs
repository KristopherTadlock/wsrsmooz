namespace WSRsmooz
{
    partial class EditableLabel
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
            this.label = new WSRsmooz.CustomTransparentLabel();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 16);
            this.label.TabIndex = 0;
            this.label.Text = "label";
            this.label.SizeChanged += new System.EventHandler(this.label_SizeChanged);
            // 
            // EditableLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label);
            this.Name = "EditableLabel";
            this.Size = new System.Drawing.Size(45, 16);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.triggerEntry);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomTransparentLabel label;

    }
}
