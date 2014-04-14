namespace WSRsmooz
{
    partial class AddEmployeePrompt
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
            this.Title = new System.Windows.Forms.Label();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmpCommit = new System.Windows.Forms.Button();
            this.EmpAdmin = new System.Windows.Forms.CheckBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpName_Label = new System.Windows.Forms.Label();
            this.EmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(468, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add Employee";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.EmpCommit);
            this.EmployeeGroupBox.Controls.Add(this.EmpAdmin);
            this.EmployeeGroupBox.Controls.Add(this.EmpName);
            this.EmployeeGroupBox.Controls.Add(this.EmpName_Label);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(12, 34);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(459, 98);
            this.EmployeeGroupBox.TabIndex = 1;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "New Employee";
            // 
            // EmpCommit
            // 
            this.EmpCommit.Location = new System.Drawing.Point(343, 28);
            this.EmpCommit.Name = "EmpCommit";
            this.EmpCommit.Size = new System.Drawing.Size(75, 42);
            this.EmpCommit.TabIndex = 23;
            this.EmpCommit.Text = "Commit";
            this.EmpCommit.UseVisualStyleBackColor = true;
            this.EmpCommit.Click += new System.EventHandler(this.EmpCommit_Click);
            // 
            // EmpAdmin
            // 
            this.EmpAdmin.AutoSize = true;
            this.EmpAdmin.Location = new System.Drawing.Point(153, 62);
            this.EmpAdmin.Name = "EmpAdmin";
            this.EmpAdmin.Size = new System.Drawing.Size(153, 20);
            this.EmpAdmin.TabIndex = 19;
            this.EmpAdmin.Text = "Administrator Access";
            this.EmpAdmin.UseVisualStyleBackColor = true;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(158, 32);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(148, 22);
            this.EmpName.TabIndex = 18;
            // 
            // EmpName_Label
            // 
            this.EmpName_Label.AutoSize = true;
            this.EmpName_Label.Location = new System.Drawing.Point(39, 35);
            this.EmpName_Label.Name = "EmpName_Label";
            this.EmpName_Label.Size = new System.Drawing.Size(113, 16);
            this.EmpName_Label.TabIndex = 17;
            this.EmpName_Label.Text = "Employee Name:";
            // 
            // AddEmployeePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 144);
            this.Controls.Add(this.EmployeeGroupBox);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmployeePrompt";
            this.Text = "Add Employee";
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.Button EmpCommit;
        private System.Windows.Forms.CheckBox EmpAdmin;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label EmpName_Label;
    }
}