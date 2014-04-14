namespace WSRsmooz
{
    partial class Login
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
            this.Login_textbox_employee = new System.Windows.Forms.TextBox();
            this.Login_textbox_password = new System.Windows.Forms.TextBox();
            this.Login_button_login = new System.Windows.Forms.Button();
            this.Login_label_employee = new System.Windows.Forms.Label();
            this.Login_label_password = new System.Windows.Forms.Label();
            this.Login_picturebox_logo = new System.Windows.Forms.PictureBox();
            this.Login_label_welcome = new System.Windows.Forms.Label();
            this.Login_label_currentUser = new System.Windows.Forms.Label();
            this.ShowPWCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_picturebox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_textbox_employee
            // 
            this.Login_textbox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_textbox_employee.Location = new System.Drawing.Point(465, 258);
            this.Login_textbox_employee.Name = "Login_textbox_employee";
            this.Login_textbox_employee.Size = new System.Drawing.Size(133, 22);
            this.Login_textbox_employee.TabIndex = 1;
            // 
            // Login_textbox_password
            // 
            this.Login_textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_textbox_password.Location = new System.Drawing.Point(465, 290);
            this.Login_textbox_password.Name = "Login_textbox_password";
            this.Login_textbox_password.PasswordChar = '*';
            this.Login_textbox_password.Size = new System.Drawing.Size(133, 22);
            this.Login_textbox_password.TabIndex = 2;
            // 
            // Login_button_login
            // 
            this.Login_button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button_login.Location = new System.Drawing.Point(456, 318);
            this.Login_button_login.Name = "Login_button_login";
            this.Login_button_login.Size = new System.Drawing.Size(75, 28);
            this.Login_button_login.TabIndex = 3;
            this.Login_button_login.Text = "Login";
            this.Login_button_login.UseVisualStyleBackColor = true;
            this.Login_button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_label_employee
            // 
            this.Login_label_employee.AutoSize = true;
            this.Login_label_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label_employee.Location = new System.Drawing.Point(389, 261);
            this.Login_label_employee.Name = "Login_label_employee";
            this.Login_label_employee.Size = new System.Drawing.Size(73, 16);
            this.Login_label_employee.TabIndex = 4;
            this.Login_label_employee.Text = "Employee:";
            this.Login_label_employee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login_label_password
            // 
            this.Login_label_password.AutoSize = true;
            this.Login_label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label_password.Location = new System.Drawing.Point(391, 293);
            this.Login_label_password.Name = "Login_label_password";
            this.Login_label_password.Size = new System.Drawing.Size(71, 16);
            this.Login_label_password.TabIndex = 5;
            this.Login_label_password.Text = "Password:";
            this.Login_label_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login_picturebox_logo
            // 
            this.Login_picturebox_logo.Image = global::WSRsmooz.Properties.Resources.wsrlogo;
            this.Login_picturebox_logo.Location = new System.Drawing.Point(345, 72);
            this.Login_picturebox_logo.Name = "Login_picturebox_logo";
            this.Login_picturebox_logo.Size = new System.Drawing.Size(297, 182);
            this.Login_picturebox_logo.TabIndex = 6;
            this.Login_picturebox_logo.TabStop = false;
            // 
            // Login_label_welcome
            // 
            this.Login_label_welcome.Location = new System.Drawing.Point(187, 258);
            this.Login_label_welcome.Name = "Login_label_welcome";
            this.Login_label_welcome.Size = new System.Drawing.Size(617, 13);
            this.Login_label_welcome.TabIndex = 7;
            this.Login_label_welcome.Text = "You have successfully logged in as";
            this.Login_label_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login_label_welcome.Visible = false;
            // 
            // Login_label_currentUser
            // 
            this.Login_label_currentUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_label_currentUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label_currentUser.Location = new System.Drawing.Point(182, 274);
            this.Login_label_currentUser.Name = "Login_label_currentUser";
            this.Login_label_currentUser.Size = new System.Drawing.Size(622, 35);
            this.Login_label_currentUser.TabIndex = 8;
            this.Login_label_currentUser.Text = "Darryl Nixon";
            this.Login_label_currentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_label_currentUser.Visible = false;
            // 
            // ShowPWCheckbox
            // 
            this.ShowPWCheckbox.AutoSize = true;
            this.ShowPWCheckbox.Location = new System.Drawing.Point(605, 293);
            this.ShowPWCheckbox.Name = "ShowPWCheckbox";
            this.ShowPWCheckbox.Size = new System.Drawing.Size(102, 17);
            this.ShowPWCheckbox.TabIndex = 9;
            this.ShowPWCheckbox.Text = "Show Password";
            this.ShowPWCheckbox.UseVisualStyleBackColor = true;
            this.ShowPWCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 657);
            this.Controls.Add(this.ShowPWCheckbox);
            this.Controls.Add(this.Login_picturebox_logo);
            this.Controls.Add(this.Login_label_password);
            this.Controls.Add(this.Login_label_employee);
            this.Controls.Add(this.Login_button_login);
            this.Controls.Add(this.Login_textbox_password);
            this.Controls.Add(this.Login_textbox_employee);
            this.Controls.Add(this.Login_label_currentUser);
            this.Controls.Add(this.Login_label_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_picturebox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textbox_employee;
        private System.Windows.Forms.TextBox Login_textbox_password;
        private System.Windows.Forms.Button Login_button_login;
        private System.Windows.Forms.Label Login_label_employee;
        private System.Windows.Forms.Label Login_label_password;
        private System.Windows.Forms.PictureBox Login_picturebox_logo;
        private System.Windows.Forms.Label Login_label_welcome;
        private System.Windows.Forms.Label Login_label_currentUser;
        private System.Windows.Forms.CheckBox ShowPWCheckbox;
    }
}