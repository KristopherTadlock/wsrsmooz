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
            this.PanelGroupBox = new System.Windows.Forms.GroupBox();
            this.FormGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelChoiceBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelGroupBox.SuspendLayout();
            this.FormGroupBox.SuspendLayout();
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
            this.FormBox.Location = new System.Drawing.Point(47, 38);
            this.FormBox.Name = "FormBox";
            this.FormBox.Size = new System.Drawing.Size(228, 116);
            this.FormBox.TabIndex = 19;
            this.FormBox.SelectedIndexChanged += new System.EventHandler(this.FormClicked);
            // 
            // PanelBox
            // 
            this.PanelBox.FormattingEnabled = true;
            this.PanelBox.ItemHeight = 16;
            this.PanelBox.Location = new System.Drawing.Point(50, 38);
            this.PanelBox.Name = "PanelBox";
            this.PanelBox.Size = new System.Drawing.Size(228, 116);
            this.PanelBox.TabIndex = 20;
            this.PanelBox.SelectedIndexChanged += new System.EventHandler(this.panelClicked);
            // 
            // PanelName
            // 
            this.PanelName.Location = new System.Drawing.Point(127, 160);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(151, 22);
            this.PanelName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Panel Name:";
            // 
            // SavePanel
            // 
            this.SavePanel.Location = new System.Drawing.Point(203, 188);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(75, 25);
            this.SavePanel.TabIndex = 24;
            this.SavePanel.Text = "Save";
            this.SavePanel.UseVisualStyleBackColor = true;
            this.SavePanel.Click += new System.EventHandler(this.SavePanel_Click);
            // 
            // Panel_MoveUp
            // 
            this.Panel_MoveUp.Location = new System.Drawing.Point(290, 38);
            this.Panel_MoveUp.Name = "Panel_MoveUp";
            this.Panel_MoveUp.Size = new System.Drawing.Size(87, 27);
            this.Panel_MoveUp.TabIndex = 25;
            this.Panel_MoveUp.Text = "Move Up";
            this.Panel_MoveUp.UseVisualStyleBackColor = true;
            this.Panel_MoveUp.Click += new System.EventHandler(this.Panel_MoveUp_Click);
            // 
            // Panel_MoveDown
            // 
            this.Panel_MoveDown.Location = new System.Drawing.Point(290, 73);
            this.Panel_MoveDown.Name = "Panel_MoveDown";
            this.Panel_MoveDown.Size = new System.Drawing.Size(87, 27);
            this.Panel_MoveDown.TabIndex = 26;
            this.Panel_MoveDown.Text = "Move Down";
            this.Panel_MoveDown.UseVisualStyleBackColor = true;
            this.Panel_MoveDown.Click += new System.EventHandler(this.Panel_MoveDown_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Enabled = false;
            this.RemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployee.Location = new System.Drawing.Point(21, 76);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(23, 33);
            this.RemoveEmployee.TabIndex = 28;
            this.RemoveEmployee.Text = "-";
            this.RemoveEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Enabled = false;
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(21, 38);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(23, 33);
            this.AddEmployee.TabIndex = 27;
            this.AddEmployee.Text = "+";
            this.AddEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "-";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(18, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 33);
            this.button5.TabIndex = 29;
            this.button5.Text = "+";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_MoveDown
            // 
            this.Form_MoveDown.Location = new System.Drawing.Point(292, 71);
            this.Form_MoveDown.Name = "Form_MoveDown";
            this.Form_MoveDown.Size = new System.Drawing.Size(87, 27);
            this.Form_MoveDown.TabIndex = 32;
            this.Form_MoveDown.Text = "Move Down";
            this.Form_MoveDown.UseVisualStyleBackColor = true;
            this.Form_MoveDown.Click += new System.EventHandler(this.Form_MoveDown_Click);
            // 
            // Form_MoveUp
            // 
            this.Form_MoveUp.Location = new System.Drawing.Point(292, 38);
            this.Form_MoveUp.Name = "Form_MoveUp";
            this.Form_MoveUp.Size = new System.Drawing.Size(87, 27);
            this.Form_MoveUp.TabIndex = 31;
            this.Form_MoveUp.Text = "Move Up";
            this.Form_MoveUp.UseVisualStyleBackColor = true;
            this.Form_MoveUp.Click += new System.EventHandler(this.Form_MoveUp_Click);
            // 
            // SaveForm
            // 
            this.SaveForm.Location = new System.Drawing.Point(292, 187);
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
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Form Name:";
            // 
            // FormName
            // 
            this.FormName.Location = new System.Drawing.Point(124, 160);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(151, 22);
            this.FormName.TabIndex = 33;
            // 
            // PanelGroupBox
            // 
            this.PanelGroupBox.Controls.Add(this.PanelBox);
            this.PanelGroupBox.Controls.Add(this.Panel_MoveUp);
            this.PanelGroupBox.Controls.Add(this.Panel_MoveDown);
            this.PanelGroupBox.Controls.Add(this.AddEmployee);
            this.PanelGroupBox.Controls.Add(this.RemoveEmployee);
            this.PanelGroupBox.Controls.Add(this.PanelName);
            this.PanelGroupBox.Controls.Add(this.label1);
            this.PanelGroupBox.Controls.Add(this.SavePanel);
            this.PanelGroupBox.Location = new System.Drawing.Point(83, 61);
            this.PanelGroupBox.Name = "PanelGroupBox";
            this.PanelGroupBox.Size = new System.Drawing.Size(397, 227);
            this.PanelGroupBox.TabIndex = 36;
            this.PanelGroupBox.TabStop = false;
            this.PanelGroupBox.Text = "Panel Organization";
            // 
            // FormGroupBox
            // 
            this.FormGroupBox.Controls.Add(this.label4);
            this.FormGroupBox.Controls.Add(this.PanelChoiceBox);
            this.FormGroupBox.Controls.Add(this.Form_MoveUp);
            this.FormGroupBox.Controls.Add(this.FormBox);
            this.FormGroupBox.Controls.Add(this.SaveForm);
            this.FormGroupBox.Controls.Add(this.button5);
            this.FormGroupBox.Controls.Add(this.label2);
            this.FormGroupBox.Controls.Add(this.button4);
            this.FormGroupBox.Controls.Add(this.FormName);
            this.FormGroupBox.Controls.Add(this.Form_MoveDown);
            this.FormGroupBox.Location = new System.Drawing.Point(496, 61);
            this.FormGroupBox.Name = "FormGroupBox";
            this.FormGroupBox.Size = new System.Drawing.Size(397, 227);
            this.FormGroupBox.TabIndex = 37;
            this.FormGroupBox.TabStop = false;
            this.FormGroupBox.Text = "Form Organization";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(239, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Choose a panel on the left in order to modify forms within that panel.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelChoiceBox
            // 
            this.PanelChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PanelChoiceBox.FormattingEnabled = true;
            this.PanelChoiceBox.Location = new System.Drawing.Point(124, 188);
            this.PanelChoiceBox.Name = "PanelChoiceBox";
            this.PanelChoiceBox.Size = new System.Drawing.Size(151, 24);
            this.PanelChoiceBox.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Panel:";
            // 
            // FormOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormGroupBox);
            this.Controls.Add(this.PanelGroupBox);
            this.Controls.Add(this.FormOrganizationTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormOrganization";
            this.PanelGroupBox.ResumeLayout(false);
            this.PanelGroupBox.PerformLayout();
            this.FormGroupBox.ResumeLayout(false);
            this.FormGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox PanelGroupBox;
        private System.Windows.Forms.GroupBox FormGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PanelChoiceBox;
    }
}