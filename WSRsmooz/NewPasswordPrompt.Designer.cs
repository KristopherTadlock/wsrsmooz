namespace WSRsmooz
{
    partial class NewPasswordPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Success = new System.Windows.Forms.Button();
            this.ShowPWCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your password has been reset. Please enter a new one:";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(27, 38);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(213, 22);
            this.NewPasswordTextBox.TabIndex = 0;
            // 
            // Success
            // 
            this.Success.Location = new System.Drawing.Point(258, 28);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(93, 46);
            this.Success.TabIndex = 1;
            this.Success.Text = "Change Password";
            this.Success.UseVisualStyleBackColor = true;
            this.Success.Click += new System.EventHandler(this.Success_Click);
            // 
            // ShowPWCheckbox
            // 
            this.ShowPWCheckbox.AutoSize = true;
            this.ShowPWCheckbox.Location = new System.Drawing.Point(117, 66);
            this.ShowPWCheckbox.Name = "ShowPWCheckbox";
            this.ShowPWCheckbox.Size = new System.Drawing.Size(123, 20);
            this.ShowPWCheckbox.TabIndex = 3;
            this.ShowPWCheckbox.Text = "Show Password";
            this.ShowPWCheckbox.UseVisualStyleBackColor = true;
            this.ShowPWCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 91);
            this.Controls.Add(this.ShowPWCheckbox);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPasswordPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter a New Password!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button Success;
        private System.Windows.Forms.CheckBox ShowPWCheckbox;
    }
}