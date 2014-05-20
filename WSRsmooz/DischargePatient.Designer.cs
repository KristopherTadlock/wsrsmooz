namespace WSRsmooz
{
    partial class DischargePatient
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
            this.label2 = new System.Windows.Forms.Label();
            this.checklist_button1 = new System.Windows.Forms.Button();
            this.checklist_button2 = new System.Windows.Forms.Button();
            this.wizardTabs = new WSRsmooz.WizardTabs();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.linensAgreement = new System.Windows.Forms.Button();
            this.safeKeepingAgreement = new System.Windows.Forms.Button();
            this.clientSelfEvaluation = new System.Windows.Forms.Button();
            this.dischargeSummary = new System.Windows.Forms.Button();
            this.dischargeASAM = new System.Windows.Forms.Button();
            this.dischargeBookkeeping = new System.Windows.Forms.Button();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientListComboBox = new System.Windows.Forms.ComboBox();
            this.instructions = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.wizardPicture = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.newPatientIntakeWizard_tab13_label_intakeDate = new System.Windows.Forms.Label();
            this.dischargeDate = new System.Windows.Forms.DateTimePicker();
            this.Successful = new System.Windows.Forms.CheckBox();
            this.wizardTabs.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPicture)).BeginInit();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Process";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checklist_button1
            // 
            this.checklist_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checklist_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklist_button1.Location = new System.Drawing.Point(12, 36);
            this.checklist_button1.Name = "checklist_button1";
            this.checklist_button1.Size = new System.Drawing.Size(130, 32);
            this.checklist_button1.TabIndex = 14;
            this.checklist_button1.TabStop = false;
            this.checklist_button1.Text = "Forms";
            this.checklist_button1.UseVisualStyleBackColor = true;
            // 
            // checklist_button2
            // 
            this.checklist_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checklist_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklist_button2.Location = new System.Drawing.Point(12, 74);
            this.checklist_button2.Name = "checklist_button2";
            this.checklist_button2.Size = new System.Drawing.Size(130, 32);
            this.checklist_button2.TabIndex = 16;
            this.checklist_button2.TabStop = false;
            this.checklist_button2.Text = "Discharge";
            this.checklist_button2.UseVisualStyleBackColor = true;
            // 
            // wizardTabs
            // 
            this.wizardTabs.Controls.Add(this.tab1);
            this.wizardTabs.Controls.Add(this.tab2);
            this.wizardTabs.Dock = System.Windows.Forms.DockStyle.Right;
            this.wizardTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardTabs.Location = new System.Drawing.Point(154, 0);
            this.wizardTabs.Name = "wizardTabs";
            this.wizardTabs.SelectedIndex = 0;
            this.wizardTabs.Size = new System.Drawing.Size(832, 657);
            this.wizardTabs.TabIndex = 0;
            this.wizardTabs.SelectedIndexChanged += new System.EventHandler(this.changeConstantsToTab);
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.SystemColors.Control;
            this.tab1.Controls.Add(this.linensAgreement);
            this.tab1.Controls.Add(this.safeKeepingAgreement);
            this.tab1.Controls.Add(this.clientSelfEvaluation);
            this.tab1.Controls.Add(this.dischargeSummary);
            this.tab1.Controls.Add(this.dischargeASAM);
            this.tab1.Controls.Add(this.dischargeBookkeeping);
            this.tab1.Controls.Add(this.ClientNameLabel);
            this.tab1.Controls.Add(this.ClientListComboBox);
            this.tab1.Controls.Add(this.instructions);
            this.tab1.Controls.Add(this.BackButton);
            this.tab1.Controls.Add(this.CancelButton);
            this.tab1.Controls.Add(this.NextButton);
            this.tab1.Controls.Add(this.titleLabel);
            this.tab1.Controls.Add(this.wizardPicture);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(824, 631);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "1";
            // 
            // linensAgreement
            // 
            this.linensAgreement.Enabled = false;
            this.linensAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linensAgreement.Location = new System.Drawing.Point(380, 319);
            this.linensAgreement.Name = "linensAgreement";
            this.linensAgreement.Size = new System.Drawing.Size(317, 26);
            this.linensAgreement.TabIndex = 23;
            this.linensAgreement.Text = "Linens Agreement";
            this.linensAgreement.UseVisualStyleBackColor = true;
            this.linensAgreement.Click += new System.EventHandler(this.linensAgreement_Click);
            // 
            // safeKeepingAgreement
            // 
            this.safeKeepingAgreement.Enabled = false;
            this.safeKeepingAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeKeepingAgreement.Location = new System.Drawing.Point(380, 287);
            this.safeKeepingAgreement.Name = "safeKeepingAgreement";
            this.safeKeepingAgreement.Size = new System.Drawing.Size(317, 26);
            this.safeKeepingAgreement.TabIndex = 22;
            this.safeKeepingAgreement.Text = "Safe Keeping Agreement";
            this.safeKeepingAgreement.UseVisualStyleBackColor = true;
            this.safeKeepingAgreement.Click += new System.EventHandler(this.safeKeepingAgreement_Click);
            // 
            // clientSelfEvaluation
            // 
            this.clientSelfEvaluation.Enabled = false;
            this.clientSelfEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSelfEvaluation.Location = new System.Drawing.Point(380, 255);
            this.clientSelfEvaluation.Name = "clientSelfEvaluation";
            this.clientSelfEvaluation.Size = new System.Drawing.Size(317, 26);
            this.clientSelfEvaluation.TabIndex = 21;
            this.clientSelfEvaluation.Text = "Client Self Evaluation";
            this.clientSelfEvaluation.UseVisualStyleBackColor = true;
            this.clientSelfEvaluation.Click += new System.EventHandler(this.clientSelfEvaluation_Click);
            // 
            // dischargeSummary
            // 
            this.dischargeSummary.Enabled = false;
            this.dischargeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeSummary.Location = new System.Drawing.Point(380, 223);
            this.dischargeSummary.Name = "dischargeSummary";
            this.dischargeSummary.Size = new System.Drawing.Size(317, 26);
            this.dischargeSummary.TabIndex = 20;
            this.dischargeSummary.Text = "Discharge Summary";
            this.dischargeSummary.UseVisualStyleBackColor = true;
            this.dischargeSummary.Click += new System.EventHandler(this.dischargeSummary_Click);
            // 
            // dischargeASAM
            // 
            this.dischargeASAM.Enabled = false;
            this.dischargeASAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeASAM.Location = new System.Drawing.Point(380, 191);
            this.dischargeASAM.Name = "dischargeASAM";
            this.dischargeASAM.Size = new System.Drawing.Size(317, 26);
            this.dischargeASAM.TabIndex = 19;
            this.dischargeASAM.Text = "Discharge ASAM";
            this.dischargeASAM.UseVisualStyleBackColor = true;
            this.dischargeASAM.Click += new System.EventHandler(this.dischargeASAM_Click);
            // 
            // dischargeBookkeeping
            // 
            this.dischargeBookkeeping.Enabled = false;
            this.dischargeBookkeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeBookkeeping.Location = new System.Drawing.Point(380, 159);
            this.dischargeBookkeeping.Name = "dischargeBookkeeping";
            this.dischargeBookkeeping.Size = new System.Drawing.Size(317, 26);
            this.dischargeBookkeeping.TabIndex = 18;
            this.dischargeBookkeeping.Text = "Discharge Bookkeeping";
            this.dischargeBookkeeping.UseVisualStyleBackColor = true;
            this.dischargeBookkeeping.Click += new System.EventHandler(this.dischargeBookkeeping_Click);
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(377, 121);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(84, 16);
            this.ClientNameLabel.TabIndex = 17;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ClientListComboBox
            // 
            this.ClientListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientListComboBox.FormattingEnabled = true;
            this.ClientListComboBox.Location = new System.Drawing.Point(467, 115);
            this.ClientListComboBox.Name = "ClientListComboBox";
            this.ClientListComboBox.Size = new System.Drawing.Size(230, 28);
            this.ClientListComboBox.TabIndex = 16;
            this.ClientListComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientListComboBox_SelectedIndexChanged);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(356, 83);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(313, 16);
            this.instructions.TabIndex = 15;
            this.instructions.Text = "Step 1: Complete all forms necessary for discharge.";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(416, 394);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(599, 394);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(497, 394);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(353, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(344, 33);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Patient Discharge Wizard";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wizardPicture
            // 
            this.wizardPicture.Image = global::WSRsmooz.Properties.Resources.wizard_icon;
            this.wizardPicture.Location = new System.Drawing.Point(114, 83);
            this.wizardPicture.Name = "wizardPicture";
            this.wizardPicture.Size = new System.Drawing.Size(229, 276);
            this.wizardPicture.TabIndex = 2;
            this.wizardPicture.TabStop = false;
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.SystemColors.Control;
            this.tab2.Controls.Add(this.newPatientIntakeWizard_tab13_label_intakeDate);
            this.tab2.Controls.Add(this.dischargeDate);
            this.tab2.Controls.Add(this.Successful);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(824, 631);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "2";
            // 
            // newPatientIntakeWizard_tab13_label_intakeDate
            // 
            this.newPatientIntakeWizard_tab13_label_intakeDate.AutoSize = true;
            this.newPatientIntakeWizard_tab13_label_intakeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab13_label_intakeDate.Location = new System.Drawing.Point(445, 211);
            this.newPatientIntakeWizard_tab13_label_intakeDate.Name = "newPatientIntakeWizard_tab13_label_intakeDate";
            this.newPatientIntakeWizard_tab13_label_intakeDate.Size = new System.Drawing.Size(105, 16);
            this.newPatientIntakeWizard_tab13_label_intakeDate.TabIndex = 86;
            this.newPatientIntakeWizard_tab13_label_intakeDate.Text = "Discharge Date:";
            // 
            // dischargeDate
            // 
            this.dischargeDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dischargeDate.Location = new System.Drawing.Point(556, 206);
            this.dischargeDate.Name = "dischargeDate";
            this.dischargeDate.Size = new System.Drawing.Size(106, 22);
            this.dischargeDate.TabIndex = 85;
            // 
            // Successful
            // 
            this.Successful.AutoSize = true;
            this.Successful.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Successful.Location = new System.Drawing.Point(501, 180);
            this.Successful.Name = "Successful";
            this.Successful.Size = new System.Drawing.Size(99, 20);
            this.Successful.TabIndex = 0;
            this.Successful.Text = "Successful?";
            this.Successful.UseVisualStyleBackColor = true;
            // 
            // DischargePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 657);
            this.Controls.Add(this.checklist_button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checklist_button1);
            this.Controls.Add(this.wizardTabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DischargePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DischargePatient";
            this.Load += new System.EventHandler(this.DischargePatient_Load);
            this.wizardTabs.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPicture)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardTabs wizardTabs;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checklist_button1;
        private System.Windows.Forms.PictureBox wizardPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button checklist_button2;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.ComboBox ClientListComboBox;
        private System.Windows.Forms.Button dischargeBookkeeping;
        private System.Windows.Forms.Button dischargeASAM;
        private System.Windows.Forms.Button dischargeSummary;
        private System.Windows.Forms.Button clientSelfEvaluation;
        private System.Windows.Forms.Button linensAgreement;
        private System.Windows.Forms.Button safeKeepingAgreement;
        private System.Windows.Forms.CheckBox Successful;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab13_label_intakeDate;
        private System.Windows.Forms.DateTimePicker dischargeDate;

    }
}