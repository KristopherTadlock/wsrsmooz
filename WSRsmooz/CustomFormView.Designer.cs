namespace WSRsmooz
{
    partial class CustomFormView
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
            this.IMPORTANTYESTitleBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IMPORTANTYESTitleBox
            // 
            this.IMPORTANTYESTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMPORTANTYESTitleBox.Location = new System.Drawing.Point(171, 1);
            this.IMPORTANTYESTitleBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IMPORTANTYESTitleBox.Name = "IMPORTANTYESTitleBox";
            this.IMPORTANTYESTitleBox.Size = new System.Drawing.Size(593, 26);
            this.IMPORTANTYESTitleBox.TabIndex = 0;
            this.IMPORTANTYESTitleBox.Text = "Title";
            this.IMPORTANTYESTitleBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 509);
            this.Controls.Add(this.IMPORTANTYESTitleBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomFormView";
            this.Load += new System.EventHandler(this.grabForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IMPORTANTYESTitleBox;
    }
}