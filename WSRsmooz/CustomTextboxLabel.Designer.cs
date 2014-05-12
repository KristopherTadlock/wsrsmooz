namespace WSRsmooz
{
    partial class CustomTextboxLabel
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new WSRsmooz.CustomTransparentLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(87, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(130, 22);
            this.textBox.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Label Name";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomTextboxLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Name = "CustomTextboxLabel";
            this.Size = new System.Drawing.Size(217, 25);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Transform);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomTransparentLabel label;
        public System.Windows.Forms.TextBox textBox;
    }
}
