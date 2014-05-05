namespace WSRsmooz
{
    partial class FormOrganization
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
            this.FormOrganizationTitle = new System.Windows.Forms.Label();
            this.FormBox = new System.Windows.Forms.ListBox();
            this.PanelBox = new System.Windows.Forms.ListBox();
            this.PanelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SavePanel = new System.Windows.Forms.Button();
            this.Panel_MoveUp = new System.Windows.Forms.Button();
            this.Panel_MoveDown = new System.Windows.Forms.Button();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Form_MoveDown = new System.Windows.Forms.Button();
            this.Form_MoveUp = new System.Windows.Forms.Button();
            this.SaveForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FormName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FormOrganizationTitle
            // 
            this.FormOrganizationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormOrganizationTitle.Location = new System.Drawing.Point(156, 18);
            this.FormOrganizationTitle.Name = "FormOrganizationTitle";
            this.FormOrganizationTitle.Size = new System.Drawing.Size(648, 33);
            this.FormOrganizationTitle.TabIndex = 17;
            this.FormOrganizationTitle.Text = "Form Organization";
            this.FormOrganizationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormBox
            // 
            this.FormBox.FormattingEnabled = true;
            this.FormBox.ItemHeight = 16;
            this.FormBox.Location = new System.Drawing.Point(206, 325);
            this.FormBox.Name = "FormBox";
            this.FormBox.Size = new System.Drawing.Size(228, 116);
            this.FormBox.TabIndex = 19;
            this.FormBox.SelectedIndexChanged += new System.EventHandler(this.FormClicked);
            // 
            // PanelBox
            // 
            this.PanelBox.FormattingEnabled = true;
            this.PanelBox.ItemHeight = 16;
            this.PanelBox.Location = new System.Drawing.Point(206, 124);
            this.PanelBox.Name = "PanelBox";
            this.PanelBox.Size = new System.Drawing.Size(228, 116);
            this.PanelBox.TabIndex = 20;
            this.PanelBox.SelectedIndexChanged += new System.EventHandler(this.panelClicked);
            // 
            // PanelName
            // 
            this.PanelName.Location = new System.Drawing.Point(702, 156);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(151, 22);
            this.PanelName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Panel Name:";
            // 
            // SavePanel
            // 
            this.SavePanel.Location = new System.Drawing.Point(738, 184);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(75, 25);
            this.SavePanel.TabIndex = 24;
            this.SavePanel.Text = "Save";
            this.SavePanel.UseVisualStyleBackColor = true;
            this.SavePanel.Click += new System.EventHandler(this.SavePanel_Click);
            // 
            // Panel_MoveUp
            // 
            this.Panel_MoveUp.Location = new System.Drawing.Point(446, 124);
            this.Panel_MoveUp.Name = "Panel_MoveUp";
            this.Panel_MoveUp.Size = new System.Drawing.Size(87, 27);
            this.Panel_MoveUp.TabIndex = 25;
            this.Panel_MoveUp.Text = "Move Up";
            this.Panel_MoveUp.UseVisualStyleBackColor = true;
            this.Panel_MoveUp.Click += new System.EventHandler(this.Panel_MoveUp_Click);
            // 
            // Panel_MoveDown
            // 
            this.Panel_MoveDown.Location = new System.Drawing.Point(446, 159);
            this.Panel_MoveDown.Name = "Panel_MoveDown";
            this.Panel_MoveDown.Size = new System.Drawing.Size(87, 27);
            this.Panel_MoveDown.TabIndex = 26;
            this.Panel_MoveDown.Text = "Move Down";
            this.Panel_MoveDown.UseVisualStyleBackColor = true;
            this.Panel_MoveDown.Click += new System.EventHandler(this.Panel_MoveDown_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployee.Location = new System.Drawing.Point(177, 162);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(23, 33);
            this.RemoveEmployee.TabIndex = 28;
            this.RemoveEmployee.Text = "-";
            this.RemoveEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(177, 124);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(23, 33);
            this.AddEmployee.TabIndex = 27;
            this.AddEmployee.Text = "+";
            this.AddEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(177, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "-";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(177, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 33);
            this.button5.TabIndex = 29;
            this.button5.Text = "+";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_MoveDown
            // 
            this.Form_MoveDown.Location = new System.Drawing.Point(440, 360);
            this.Form_MoveDown.Name = "Form_MoveDown";
            this.Form_MoveDown.Size = new System.Drawing.Size(87, 27);
            this.Form_MoveDown.TabIndex = 32;
            this.Form_MoveDown.Text = "Move Down";
            this.Form_MoveDown.UseVisualStyleBackColor = true;
            this.Form_MoveDown.Click += new System.EventHandler(this.Form_MoveDown_Click);
            // 
            // Form_MoveUp
            // 
            this.Form_MoveUp.Location = new System.Drawing.Point(440, 330);
            this.Form_MoveUp.Name = "Form_MoveUp";
            this.Form_MoveUp.Size = new System.Drawing.Size(87, 27);
            this.Form_MoveUp.TabIndex = 31;
            this.Form_MoveUp.Text = "Move Up";
            this.Form_MoveUp.UseVisualStyleBackColor = true;
            this.Form_MoveUp.Click += new System.EventHandler(this.Form_MoveUp_Click);
            // 
            // SaveForm
            // 
            this.SaveForm.Location = new System.Drawing.Point(738, 364);
            this.SaveForm.Name = "SaveForm";
            this.SaveForm.Size = new System.Drawing.Size(75, 25);
            this.SaveForm.TabIndex = 35;
            this.SaveForm.Text = "Save";
            this.SaveForm.UseVisualStyleBackColor = true;
            this.SaveForm.Click += new System.EventHandler(this.SaveForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Form Name:";
            // 
            // FormName
            // 
            this.FormName.Location = new System.Drawing.Point(702, 336);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(151, 22);
            this.FormName.TabIndex = 33;
            // 
            // FormOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.SaveForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.Form_MoveDown);
            this.Controls.Add(this.Form_MoveUp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.Panel_MoveDown);
            this.Controls.Add(this.Panel_MoveUp);
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelName);
            this.Controls.Add(this.PanelBox);
            this.Controls.Add(this.FormBox);
            this.Controls.Add(this.FormOrganizationTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormOrganization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormOrganizationTitle;
        private System.Windows.Forms.ListBox FormBox;
        private System.Windows.Forms.ListBox PanelBox;
        private System.Windows.Forms.TextBox PanelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavePanel;
        private System.Windows.Forms.Button Panel_MoveUp;
        private System.Windows.Forms.Button Panel_MoveDown;
        private System.Windows.Forms.Button RemoveEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Form_MoveDown;
        private System.Windows.Forms.Button Form_MoveUp;
        private System.Windows.Forms.Button SaveForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FormName;
    }
}