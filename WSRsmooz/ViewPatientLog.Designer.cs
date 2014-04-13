namespace WSRsmooz
{
    partial class ViewPatientLog
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
            this.clientList = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listForms = new System.Windows.Forms.ListView();
            this.AdmissionForm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewPatientLog_label_patientName = new System.Windows.Forms.Label();
            this.ViewPatientLog_button_newForm = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.ViewPatientLog_label_formName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientList.FormattingEnabled = true;
            this.clientList.ItemHeight = 20;
            this.clientList.Location = new System.Drawing.Point(13, 33);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(193, 584);
            this.clientList.TabIndex = 0;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Include Inactive Clients";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listForms
            // 
            this.listForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdmissionForm});
            this.listForms.Enabled = false;
            this.listForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listForms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listForms.Location = new System.Drawing.Point(212, 33);
            this.listForms.MultiSelect = false;
            this.listForms.Name = "listForms";
            this.listForms.Size = new System.Drawing.Size(190, 584);
            this.listForms.TabIndex = 2;
            this.listForms.UseCompatibleStateImageBehavior = false;
            this.listForms.View = System.Windows.Forms.View.Details;
            this.listForms.SelectedIndexChanged += new System.EventHandler(this.listForms_SelectedIndexChanged);
            // 
            // AdmissionForm
            // 
            this.AdmissionForm.Text = "Name";
            this.AdmissionForm.Width = 185;
            // 
            // ViewPatientLog_label_patientName
            // 
            this.ViewPatientLog_label_patientName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewPatientLog_label_patientName.AutoSize = true;
            this.ViewPatientLog_label_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientLog_label_patientName.Location = new System.Drawing.Point(591, 72);
            this.ViewPatientLog_label_patientName.Name = "ViewPatientLog_label_patientName";
            this.ViewPatientLog_label_patientName.Size = new System.Drawing.Size(158, 29);
            this.ViewPatientLog_label_patientName.TabIndex = 3;
            this.ViewPatientLog_label_patientName.Text = "Patient Name";
            this.ViewPatientLog_label_patientName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewPatientLog_label_patientName.Visible = false;
            // 
            // ViewPatientLog_button_newForm
            // 
            this.ViewPatientLog_button_newForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientLog_button_newForm.Location = new System.Drawing.Point(484, 116);
            this.ViewPatientLog_button_newForm.Name = "ViewPatientLog_button_newForm";
            this.ViewPatientLog_button_newForm.Size = new System.Drawing.Size(32, 29);
            this.ViewPatientLog_button_newForm.TabIndex = 4;
            this.ViewPatientLog_button_newForm.Text = "+";
            this.ViewPatientLog_button_newForm.UseVisualStyleBackColor = true;
            this.ViewPatientLog_button_newForm.Visible = false;
            // 
            // fileListBox
            // 
            this.fileListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 16;
            this.fileListBox.Location = new System.Drawing.Point(484, 151);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(419, 116);
            this.fileListBox.TabIndex = 5;
            this.fileListBox.Visible = false;
            // 
            // ViewPatientLog_label_formName
            // 
            this.ViewPatientLog_label_formName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewPatientLog_label_formName.AutoSize = true;
            this.ViewPatientLog_label_formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientLog_label_formName.Location = new System.Drawing.Point(522, 124);
            this.ViewPatientLog_label_formName.Name = "ViewPatientLog_label_formName";
            this.ViewPatientLog_label_formName.Size = new System.Drawing.Size(79, 16);
            this.ViewPatientLog_label_formName.TabIndex = 6;
            this.ViewPatientLog_label_formName.Text = "Form Name";
            this.ViewPatientLog_label_formName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewPatientLog_label_formName.Visible = false;
            // 
            // ViewPatientLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.ViewPatientLog_label_formName);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.ViewPatientLog_button_newForm);
            this.Controls.Add(this.ViewPatientLog_label_patientName);
            this.Controls.Add(this.listForms);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatientLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewPatientLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listForms;
        private System.Windows.Forms.ColumnHeader AdmissionForm;
        private System.Windows.Forms.Label ViewPatientLog_label_patientName;
        private System.Windows.Forms.Button ViewPatientLog_button_newForm;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Label ViewPatientLog_label_formName;
    }
}