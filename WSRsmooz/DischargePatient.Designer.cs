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
            this.instructions = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.wizardPicture = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.wizardTabs.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Screening";
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
            this.checklist_button1.Text = "Basic I";
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
            this.checklist_button2.Text = "Basic I";
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
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(356, 83);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(224, 16);
            this.instructions.TabIndex = 15;
            this.instructions.Text = "Step 1: Enter basic client information.";
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
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(824, 631);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "2";
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
            this.wizardTabs.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPicture)).EndInit();
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

    }
}