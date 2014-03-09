namespace WSRsmooz
{
    partial class NewPatientIntake
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
            this.wizardTabs1 = new WSRsmooz.WizardTabs();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wizardTabs1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardTabs1
            // 
            this.wizardTabs1.Controls.Add(this.tabPage1);
            this.wizardTabs1.Controls.Add(this.tabPage2);
            this.wizardTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardTabs1.Location = new System.Drawing.Point(0, 0);
            this.wizardTabs1.Name = "wizardTabs1";
            this.wizardTabs1.SelectedIndex = 0;
            this.wizardTabs1.Size = new System.Drawing.Size(986, 657);
            this.wizardTabs1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // NewPatientIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 657);
            this.Controls.Add(this.wizardTabs1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPatientIntake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewPatientIntake";
            this.wizardTabs1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WizardTabs wizardTabs1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}