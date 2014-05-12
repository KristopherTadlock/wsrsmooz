namespace WSRsmooz
{
    partial class FormEditor_ChangeType
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
            this.SingleButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.ComboButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SingleButton
            // 
            this.SingleButton.Location = new System.Drawing.Point(0, 0);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(75, 22);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.Text = "Single";
            this.SingleButton.UseVisualStyleBackColor = true;
            this.SingleButton.Click += new System.EventHandler(this.SingleButton_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.Location = new System.Drawing.Point(0, 21);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(75, 22);
            this.MultiButton.TabIndex = 1;
            this.MultiButton.Text = "Multi";
            this.MultiButton.UseVisualStyleBackColor = true;
            this.MultiButton.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // ComboButton
            // 
            this.ComboButton.Location = new System.Drawing.Point(0, 42);
            this.ComboButton.Name = "ComboButton";
            this.ComboButton.Size = new System.Drawing.Size(75, 22);
            this.ComboButton.TabIndex = 2;
            this.ComboButton.Text = "Combo";
            this.ComboButton.UseVisualStyleBackColor = true;
            this.ComboButton.Click += new System.EventHandler(this.ComboButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(0, 63);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 22);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // FormEditor_ChangeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(75, 85);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ComboButton);
            this.Controls.Add(this.MultiButton);
            this.Controls.Add(this.SingleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditor_ChangeType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingleButton;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button ComboButton;
        private System.Windows.Forms.Button CheckButton;
    }
}