namespace WSRsmooz
{
    partial class Launcher
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.launcher_button_viewPatientLog = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_newPatientIntake = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_groupClipboard = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_individualNotes = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_dischargePatient = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_login = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_employees = new System.Windows.Forms.ToolStripButton();
            this.launcher_button_forms = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launcher_button_viewPatientLog,
            this.launcher_button_newPatientIntake,
            this.launcher_button_groupClipboard,
            this.launcher_button_individualNotes,
            this.launcher_button_dischargePatient,
            this.launcher_button_login,
            this.launcher_button_employees,
            this.launcher_button_forms});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1008, 72);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // launcher_button_viewPatientLog
            // 
            this.launcher_button_viewPatientLog.AutoSize = false;
            this.launcher_button_viewPatientLog.Enabled = false;
            this.launcher_button_viewPatientLog.Image = global::WSRsmooz.Properties.Resources.viewpatients;
            this.launcher_button_viewPatientLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_viewPatientLog.Name = "launcher_button_viewPatientLog";
            this.launcher_button_viewPatientLog.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_viewPatientLog.Text = "&View Patient Log";
            this.launcher_button_viewPatientLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_viewPatientLog.Click += new System.EventHandler(this.launcher_button_viewPatientLog_Click);
            // 
            // launcher_button_newPatientIntake
            // 
            this.launcher_button_newPatientIntake.AutoSize = false;
            this.launcher_button_newPatientIntake.Enabled = false;
            this.launcher_button_newPatientIntake.Image = global::WSRsmooz.Properties.Resources.newpatientintake;
            this.launcher_button_newPatientIntake.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_newPatientIntake.Name = "launcher_button_newPatientIntake";
            this.launcher_button_newPatientIntake.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_newPatientIntake.Text = "New Patient &Intake";
            this.launcher_button_newPatientIntake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_newPatientIntake.Click += new System.EventHandler(this.launcher_button_newPatientIntake_Click);
            // 
            // launcher_button_groupClipboard
            // 
            this.launcher_button_groupClipboard.AutoSize = false;
            this.launcher_button_groupClipboard.Enabled = false;
            this.launcher_button_groupClipboard.Image = global::WSRsmooz.Properties.Resources.groupclipboard;
            this.launcher_button_groupClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_groupClipboard.Name = "launcher_button_groupClipboard";
            this.launcher_button_groupClipboard.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_groupClipboard.Text = "&Group Clipboard";
            this.launcher_button_groupClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_groupClipboard.Click += new System.EventHandler(this.launcher_button_groupClipboard_Click);
            // 
            // launcher_button_individualNotes
            // 
            this.launcher_button_individualNotes.AutoSize = false;
            this.launcher_button_individualNotes.Enabled = false;
            this.launcher_button_individualNotes.Image = global::WSRsmooz.Properties.Resources.individualnotes;
            this.launcher_button_individualNotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_individualNotes.Name = "launcher_button_individualNotes";
            this.launcher_button_individualNotes.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_individualNotes.Text = "Individual &Notes";
            this.launcher_button_individualNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_individualNotes.Click += new System.EventHandler(this.launcher_button_individualNotes_Click);
            // 
            // launcher_button_dischargePatient
            // 
            this.launcher_button_dischargePatient.AutoSize = false;
            this.launcher_button_dischargePatient.Enabled = false;
            this.launcher_button_dischargePatient.Image = global::WSRsmooz.Properties.Resources.dischargepatient;
            this.launcher_button_dischargePatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_dischargePatient.Name = "launcher_button_dischargePatient";
            this.launcher_button_dischargePatient.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_dischargePatient.Text = "&Discharge Patient";
            this.launcher_button_dischargePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_dischargePatient.Click += new System.EventHandler(this.launcher_button_dischargePatient_Click);
            // 
            // launcher_button_login
            // 
            this.launcher_button_login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.launcher_button_login.AutoSize = false;
            this.launcher_button_login.Image = global::WSRsmooz.Properties.Resources.login;
            this.launcher_button_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_login.Name = "launcher_button_login";
            this.launcher_button_login.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_login.Text = "&Login";
            this.launcher_button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_login.Click += new System.EventHandler(this.launcher_button_login_Click);
            // 
            // launcher_button_employees
            // 
            this.launcher_button_employees.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.launcher_button_employees.AutoSize = false;
            this.launcher_button_employees.Enabled = false;
            this.launcher_button_employees.Image = global::WSRsmooz.Properties.Resources.employees;
            this.launcher_button_employees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_employees.Name = "launcher_button_employees";
            this.launcher_button_employees.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_employees.Text = "&Employees";
            this.launcher_button_employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_employees.Click += new System.EventHandler(this.launcher_button_employees_Click);
            // 
            // launcher_button_forms
            // 
            this.launcher_button_forms.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.launcher_button_forms.AutoSize = false;
            this.launcher_button_forms.Enabled = false;
            this.launcher_button_forms.Image = global::WSRsmooz.Properties.Resources.formoganization;
            this.launcher_button_forms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launcher_button_forms.Name = "launcher_button_forms";
            this.launcher_button_forms.Size = new System.Drawing.Size(105, 69);
            this.launcher_button_forms.Text = "&Forms";
            this.launcher_button_forms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launcher_button_forms.Click += new System.EventHandler(this.launcher_button_forms_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "West Slope Recovery";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton launcher_button_viewPatientLog;
        private System.Windows.Forms.ToolStripButton launcher_button_newPatientIntake;
        private System.Windows.Forms.ToolStripButton launcher_button_groupClipboard;
        private System.Windows.Forms.ToolStripButton launcher_button_individualNotes;
        private System.Windows.Forms.ToolStripButton launcher_button_login;
        private System.Windows.Forms.ToolStripButton launcher_button_dischargePatient;
        private System.Windows.Forms.ToolStripButton launcher_button_employees;
        private System.Windows.Forms.ToolStripButton launcher_button_forms;
    }
}

