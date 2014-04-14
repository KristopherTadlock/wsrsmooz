namespace WSRsmooz
{
    partial class EditEmployees
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
            this.EmpName_Label = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.employeeList = new System.Windows.Forms.ListBox();
            this.EmployeeInformation_GroupBox = new System.Windows.Forms.GroupBox();
            this.EmpCommit = new System.Windows.Forms.Button();
            this.EmpPrompt = new System.Windows.Forms.CheckBox();
            this.EmpPassword = new System.Windows.Forms.TextBox();
            this.EmpPassword_Label = new System.Windows.Forms.Label();
            this.EmpAdmin = new System.Windows.Forms.CheckBox();
            this.EditEmployeeTitle = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.AcceptButton = EmpCommit;
            this.EmployeeInformation_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpName_Label
            // 
            this.EmpName_Label.AutoSize = true;
            this.EmpName_Label.Location = new System.Drawing.Point(15, 30);
            this.EmpName_Label.Name = "EmpName_Label";
            this.EmpName_Label.Size = new System.Drawing.Size(113, 16);
            this.EmpName_Label.TabIndex = 0;
            this.EmpName_Label.Text = "Employee Name:";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(134, 27);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(148, 22);
            this.EmpName.TabIndex = 1;
            // 
            // employeeList
            // 
            this.employeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 20;
            this.employeeList.Location = new System.Drawing.Point(166, 67);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(177, 284);
            this.employeeList.TabIndex = 14;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeList_SelectedIndexChanged);
            // 
            // EmployeeInformation_GroupBox
            // 
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpCommit);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpPrompt);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpPassword);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpPassword_Label);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpAdmin);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpName);
            this.EmployeeInformation_GroupBox.Controls.Add(this.EmpName_Label);
            this.EmployeeInformation_GroupBox.Location = new System.Drawing.Point(349, 67);
            this.EmployeeInformation_GroupBox.Name = "EmployeeInformation_GroupBox";
            this.EmployeeInformation_GroupBox.Size = new System.Drawing.Size(460, 144);
            this.EmployeeInformation_GroupBox.TabIndex = 15;
            this.EmployeeInformation_GroupBox.TabStop = false;
            this.EmployeeInformation_GroupBox.Text = "Employee Information";
            // 
            // EmpCommit
            // 
            this.EmpCommit.Location = new System.Drawing.Point(326, 35);
            this.EmpCommit.Name = "EmpCommit";
            this.EmpCommit.Size = new System.Drawing.Size(75, 42);
            this.EmpCommit.TabIndex = 16;
            this.EmpCommit.Text = "Commit";
            this.EmpCommit.UseVisualStyleBackColor = true;
            this.EmpCommit.Click += new System.EventHandler(this.EmpCommit_Click);
            // 
            // EmpPrompt
            // 
            this.EmpPrompt.AutoSize = true;
            this.EmpPrompt.Location = new System.Drawing.Point(134, 88);
            this.EmpPrompt.Name = "EmpPrompt";
            this.EmpPrompt.Size = new System.Drawing.Size(210, 20);
            this.EmpPrompt.TabIndex = 5;
            this.EmpPrompt.Text = "Reset Password on Next Login";
            this.EmpPrompt.UseVisualStyleBackColor = true;
            // 
            // EmpPassword
            // 
            this.EmpPassword.Location = new System.Drawing.Point(134, 55);
            this.EmpPassword.Name = "EmpPassword";
            this.EmpPassword.PasswordChar = '*';
            this.EmpPassword.Size = new System.Drawing.Size(148, 22);
            this.EmpPassword.TabIndex = 4;
            // 
            // EmpPassword_Label
            // 
            this.EmpPassword_Label.AutoSize = true;
            this.EmpPassword_Label.Location = new System.Drawing.Point(7, 58);
            this.EmpPassword_Label.Name = "EmpPassword_Label";
            this.EmpPassword_Label.Size = new System.Drawing.Size(121, 16);
            this.EmpPassword_Label.TabIndex = 3;
            this.EmpPassword_Label.Text = "Change Password:";
            // 
            // EmpAdmin
            // 
            this.EmpAdmin.AutoSize = true;
            this.EmpAdmin.Location = new System.Drawing.Point(134, 114);
            this.EmpAdmin.Name = "EmpAdmin";
            this.EmpAdmin.Size = new System.Drawing.Size(153, 20);
            this.EmpAdmin.TabIndex = 2;
            this.EmpAdmin.Text = "Administrator Access";
            this.EmpAdmin.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeTitle
            // 
            this.EditEmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployeeTitle.Location = new System.Drawing.Point(156, 23);
            this.EditEmployeeTitle.Name = "EditEmployeeTitle";
            this.EditEmployeeTitle.Size = new System.Drawing.Size(648, 33);
            this.EditEmployeeTitle.TabIndex = 16;
            this.EditEmployeeTitle.Text = "Edit Employees";
            this.EditEmployeeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(137, 67);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(23, 33);
            this.AddEmployee.TabIndex = 18;
            this.AddEmployee.Text = "+";
            this.AddEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployee.Location = new System.Drawing.Point(137, 105);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(23, 33);
            this.RemoveEmployee.TabIndex = 19;
            this.RemoveEmployee.Text = "-";
            this.RemoveEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // EditEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.EditEmployeeTitle);
            this.Controls.Add(this.EmployeeInformation_GroupBox);
            this.Controls.Add(this.employeeList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditEmployees";
            this.EmployeeInformation_GroupBox.ResumeLayout(false);
            this.EmployeeInformation_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmpName_Label;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.GroupBox EmployeeInformation_GroupBox;
        private System.Windows.Forms.TextBox EmpPassword;
        private System.Windows.Forms.Label EmpPassword_Label;
        private System.Windows.Forms.CheckBox EmpAdmin;
        private System.Windows.Forms.CheckBox EmpPrompt;
        private System.Windows.Forms.Button EmpCommit;
        private System.Windows.Forms.Label EditEmployeeTitle;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button RemoveEmployee;
    }
}