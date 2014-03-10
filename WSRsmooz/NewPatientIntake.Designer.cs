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
            this.NewPatientIntake_checklist_button_tab1 = new System.Windows.Forms.Button();
            this.NewPatientIntake_checklist_button_tab2 = new System.Windows.Forms.Button();
            this.newPatientIntakeWizard = new WSRsmooz.WizardTabs();
            this.newPatientIntakeWizard_tab1 = new System.Windows.Forms.TabPage();
            this.newPatientIntakeWizard_button_back = new System.Windows.Forms.Button();
            this.newPatientIntakeWizard_tab1_label_zip = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_zip = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_tab1_combobox_state = new System.Windows.Forms.ComboBox();
            this.newPatientIntakeWizard_tab1_label_state = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_label_city = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_city = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_tab1_label_streetAddress = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_streetAddress = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_tab1_label_dateOfBirth = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.newPatientIntakeWizard_button_cancel = new System.Windows.Forms.Button();
            this.newPatientIntakeWizard_button_next = new System.Windows.Forms.Button();
            this.newPatientIntakeWizard_tab1_label_middleInitial = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_middleInitial = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_tab1_label_lastName = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_lastName = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_label_instructions = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_label_firstName = new System.Windows.Forms.Label();
            this.newPatientIntakeWizard_tab1_textbox_firstName = new System.Windows.Forms.TextBox();
            this.newPatientIntakeWizard_picturebox_wizard = new System.Windows.Forms.PictureBox();
            this.newPatientIntakeWizard_label_title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newPatientIntakeWizard.SuspendLayout();
            this.newPatientIntakeWizard_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPatientIntakeWizard_picturebox_wizard)).BeginInit();
            this.SuspendLayout();
            // 
            // NewPatientIntake_checklist_button_tab1
            // 
            this.NewPatientIntake_checklist_button_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPatientIntake_checklist_button_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatientIntake_checklist_button_tab1.Location = new System.Drawing.Point(12, 12);
            this.NewPatientIntake_checklist_button_tab1.Name = "NewPatientIntake_checklist_button_tab1";
            this.NewPatientIntake_checklist_button_tab1.Size = new System.Drawing.Size(130, 32);
            this.NewPatientIntake_checklist_button_tab1.TabIndex = 1;
            this.NewPatientIntake_checklist_button_tab1.Text = "Basic Information";
            this.NewPatientIntake_checklist_button_tab1.UseVisualStyleBackColor = true;
            // 
            // NewPatientIntake_checklist_button_tab2
            // 
            this.NewPatientIntake_checklist_button_tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPatientIntake_checklist_button_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatientIntake_checklist_button_tab2.Location = new System.Drawing.Point(12, 50);
            this.NewPatientIntake_checklist_button_tab2.Name = "NewPatientIntake_checklist_button_tab2";
            this.NewPatientIntake_checklist_button_tab2.Size = new System.Drawing.Size(130, 32);
            this.NewPatientIntake_checklist_button_tab2.TabIndex = 2;
            this.NewPatientIntake_checklist_button_tab2.Text = "Basic Bullshit";
            this.NewPatientIntake_checklist_button_tab2.UseVisualStyleBackColor = true;
            // 
            // newPatientIntakeWizard
            // 
            this.newPatientIntakeWizard.Controls.Add(this.newPatientIntakeWizard_tab1);
            this.newPatientIntakeWizard.Controls.Add(this.tabPage2);
            this.newPatientIntakeWizard.Dock = System.Windows.Forms.DockStyle.Right;
            this.newPatientIntakeWizard.Location = new System.Drawing.Point(154, 0);
            this.newPatientIntakeWizard.Name = "newPatientIntakeWizard";
            this.newPatientIntakeWizard.SelectedIndex = 0;
            this.newPatientIntakeWizard.Size = new System.Drawing.Size(832, 657);
            this.newPatientIntakeWizard.TabIndex = 0;
            this.newPatientIntakeWizard.SelectedIndexChanged += new System.EventHandler(this.changeConstantsToTab);
            // 
            // newPatientIntakeWizard_tab1
            // 
            this.newPatientIntakeWizard_tab1.BackColor = System.Drawing.SystemColors.Control;
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_button_back);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_zip);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_zip);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_combobox_state);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_state);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_city);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_city);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_streetAddress);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_streetAddress);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_dateOfBirth);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_button_cancel);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_button_next);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_middleInitial);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_middleInitial);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_lastName);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_lastName);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_label_instructions);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_label_firstName);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_tab1_textbox_firstName);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_picturebox_wizard);
            this.newPatientIntakeWizard_tab1.Controls.Add(this.newPatientIntakeWizard_label_title);
            this.newPatientIntakeWizard_tab1.Location = new System.Drawing.Point(4, 22);
            this.newPatientIntakeWizard_tab1.Name = "newPatientIntakeWizard_tab1";
            this.newPatientIntakeWizard_tab1.Padding = new System.Windows.Forms.Padding(3);
            this.newPatientIntakeWizard_tab1.Size = new System.Drawing.Size(824, 631);
            this.newPatientIntakeWizard_tab1.TabIndex = 0;
            this.newPatientIntakeWizard_tab1.Text = "tabPage1";
            // 
            // newPatientIntakeWizard_button_back
            // 
            this.newPatientIntakeWizard_button_back.Location = new System.Drawing.Point(416, 336);
            this.newPatientIntakeWizard_button_back.Name = "newPatientIntakeWizard_button_back";
            this.newPatientIntakeWizard_button_back.Size = new System.Drawing.Size(75, 23);
            this.newPatientIntakeWizard_button_back.TabIndex = 23;
            this.newPatientIntakeWizard_button_back.Text = "Back";
            this.newPatientIntakeWizard_button_back.UseVisualStyleBackColor = true;
            this.newPatientIntakeWizard_button_back.Click += new System.EventHandler(this.newPatientIntakeWizard_button_back_Click);
            // 
            // newPatientIntakeWizard_tab1_label_zip
            // 
            this.newPatientIntakeWizard_tab1_label_zip.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_zip.Location = new System.Drawing.Point(382, 284);
            this.newPatientIntakeWizard_tab1_label_zip.Name = "newPatientIntakeWizard_tab1_label_zip";
            this.newPatientIntakeWizard_tab1_label_zip.Size = new System.Drawing.Size(66, 16);
            this.newPatientIntakeWizard_tab1_label_zip.TabIndex = 22;
            this.newPatientIntakeWizard_tab1_label_zip.Text = "Zip Code:";
            // 
            // newPatientIntakeWizard_tab1_textbox_zip
            // 
            this.newPatientIntakeWizard_tab1_textbox_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_zip.Location = new System.Drawing.Point(454, 281);
            this.newPatientIntakeWizard_tab1_textbox_zip.MaxLength = 5;
            this.newPatientIntakeWizard_tab1_textbox_zip.Name = "newPatientIntakeWizard_tab1_textbox_zip";
            this.newPatientIntakeWizard_tab1_textbox_zip.Size = new System.Drawing.Size(106, 22);
            this.newPatientIntakeWizard_tab1_textbox_zip.TabIndex = 21;
            this.newPatientIntakeWizard_tab1_textbox_zip.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_zip_TextChanged);
            // 
            // newPatientIntakeWizard_tab1_combobox_state
            // 
            this.newPatientIntakeWizard_tab1_combobox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_combobox_state.FormattingEnabled = true;
            this.newPatientIntakeWizard_tab1_combobox_state.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY",
            "AS",
            "DC",
            "FM",
            "GU",
            "MH",
            "MP",
            "PW",
            "PR",
            "VI"});
            this.newPatientIntakeWizard_tab1_combobox_state.Location = new System.Drawing.Point(615, 253);
            this.newPatientIntakeWizard_tab1_combobox_state.Name = "newPatientIntakeWizard_tab1_combobox_state";
            this.newPatientIntakeWizard_tab1_combobox_state.Size = new System.Drawing.Size(59, 24);
            this.newPatientIntakeWizard_tab1_combobox_state.TabIndex = 20;
            this.newPatientIntakeWizard_tab1_combobox_state.Text = "CA";
            // 
            // newPatientIntakeWizard_tab1_label_state
            // 
            this.newPatientIntakeWizard_tab1_label_state.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_state.Location = new System.Drawing.Point(571, 256);
            this.newPatientIntakeWizard_tab1_label_state.Name = "newPatientIntakeWizard_tab1_label_state";
            this.newPatientIntakeWizard_tab1_label_state.Size = new System.Drawing.Size(42, 16);
            this.newPatientIntakeWizard_tab1_label_state.TabIndex = 18;
            this.newPatientIntakeWizard_tab1_label_state.Text = "State:";
            // 
            // newPatientIntakeWizard_tab1_label_city
            // 
            this.newPatientIntakeWizard_tab1_label_city.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_city.Location = new System.Drawing.Point(415, 256);
            this.newPatientIntakeWizard_tab1_label_city.Name = "newPatientIntakeWizard_tab1_label_city";
            this.newPatientIntakeWizard_tab1_label_city.Size = new System.Drawing.Size(33, 16);
            this.newPatientIntakeWizard_tab1_label_city.TabIndex = 17;
            this.newPatientIntakeWizard_tab1_label_city.Text = "City:";
            // 
            // newPatientIntakeWizard_tab1_textbox_city
            // 
            this.newPatientIntakeWizard_tab1_textbox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_city.Location = new System.Drawing.Point(454, 253);
            this.newPatientIntakeWizard_tab1_textbox_city.MaxLength = 30;
            this.newPatientIntakeWizard_tab1_textbox_city.Name = "newPatientIntakeWizard_tab1_textbox_city";
            this.newPatientIntakeWizard_tab1_textbox_city.Size = new System.Drawing.Size(106, 22);
            this.newPatientIntakeWizard_tab1_textbox_city.TabIndex = 16;
            this.newPatientIntakeWizard_tab1_textbox_city.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_city_TextChanged);
            // 
            // newPatientIntakeWizard_tab1_label_streetAddress
            // 
            this.newPatientIntakeWizard_tab1_label_streetAddress.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_streetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_streetAddress.Location = new System.Drawing.Point(348, 228);
            this.newPatientIntakeWizard_tab1_label_streetAddress.Name = "newPatientIntakeWizard_tab1_label_streetAddress";
            this.newPatientIntakeWizard_tab1_label_streetAddress.Size = new System.Drawing.Size(100, 16);
            this.newPatientIntakeWizard_tab1_label_streetAddress.TabIndex = 15;
            this.newPatientIntakeWizard_tab1_label_streetAddress.Text = "Street Address:";
            // 
            // newPatientIntakeWizard_tab1_textbox_streetAddress
            // 
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.Location = new System.Drawing.Point(454, 225);
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.MaxLength = 50;
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.Name = "newPatientIntakeWizard_tab1_textbox_streetAddress";
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.Size = new System.Drawing.Size(220, 22);
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.TabIndex = 14;
            this.newPatientIntakeWizard_tab1_textbox_streetAddress.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_streetAddress_TextChanged);
            // 
            // newPatientIntakeWizard_tab1_label_dateOfBirth
            // 
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.Location = new System.Drawing.Point(365, 202);
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.Name = "newPatientIntakeWizard_tab1_label_dateOfBirth";
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.Size = new System.Drawing.Size(83, 16);
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.TabIndex = 13;
            this.newPatientIntakeWizard_tab1_label_dateOfBirth.Text = "Date of Birth:";
            // 
            // newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth
            // 
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Location = new System.Drawing.Point(454, 197);
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Name = "newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth";
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Size = new System.Drawing.Size(106, 22);
            this.newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.TabIndex = 12;
            // 
            // newPatientIntakeWizard_button_cancel
            // 
            this.newPatientIntakeWizard_button_cancel.Location = new System.Drawing.Point(599, 336);
            this.newPatientIntakeWizard_button_cancel.Name = "newPatientIntakeWizard_button_cancel";
            this.newPatientIntakeWizard_button_cancel.Size = new System.Drawing.Size(75, 23);
            this.newPatientIntakeWizard_button_cancel.TabIndex = 11;
            this.newPatientIntakeWizard_button_cancel.Text = "Cancel";
            this.newPatientIntakeWizard_button_cancel.UseVisualStyleBackColor = true;
            this.newPatientIntakeWizard_button_cancel.Click += new System.EventHandler(this.newPatientIntakeWizard_tab1_button_cancel_Click);
            // 
            // newPatientIntakeWizard_button_next
            // 
            this.newPatientIntakeWizard_button_next.Location = new System.Drawing.Point(497, 336);
            this.newPatientIntakeWizard_button_next.Name = "newPatientIntakeWizard_button_next";
            this.newPatientIntakeWizard_button_next.Size = new System.Drawing.Size(75, 23);
            this.newPatientIntakeWizard_button_next.TabIndex = 10;
            this.newPatientIntakeWizard_button_next.Text = "Next";
            this.newPatientIntakeWizard_button_next.UseVisualStyleBackColor = true;
            this.newPatientIntakeWizard_button_next.Click += new System.EventHandler(this.newPatientIntakeWizard_tab1_button_next_Click);
            // 
            // newPatientIntakeWizard_tab1_label_middleInitial
            // 
            this.newPatientIntakeWizard_tab1_label_middleInitial.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_middleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_middleInitial.Location = new System.Drawing.Point(363, 172);
            this.newPatientIntakeWizard_tab1_label_middleInitial.Name = "newPatientIntakeWizard_tab1_label_middleInitial";
            this.newPatientIntakeWizard_tab1_label_middleInitial.Size = new System.Drawing.Size(85, 16);
            this.newPatientIntakeWizard_tab1_label_middleInitial.TabIndex = 8;
            this.newPatientIntakeWizard_tab1_label_middleInitial.Text = "Middle Initial:";
            // 
            // newPatientIntakeWizard_tab1_textbox_middleInitial
            // 
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.Location = new System.Drawing.Point(454, 169);
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.MaxLength = 1;
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.Name = "newPatientIntakeWizard_tab1_textbox_middleInitial";
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.Size = new System.Drawing.Size(40, 22);
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.TabIndex = 7;
            this.newPatientIntakeWizard_tab1_textbox_middleInitial.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_middleInitial_TextChanged);
            // 
            // newPatientIntakeWizard_tab1_label_lastName
            // 
            this.newPatientIntakeWizard_tab1_label_lastName.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_lastName.Location = new System.Drawing.Point(372, 144);
            this.newPatientIntakeWizard_tab1_label_lastName.Name = "newPatientIntakeWizard_tab1_label_lastName";
            this.newPatientIntakeWizard_tab1_label_lastName.Size = new System.Drawing.Size(76, 16);
            this.newPatientIntakeWizard_tab1_label_lastName.TabIndex = 6;
            this.newPatientIntakeWizard_tab1_label_lastName.Text = "Last Name:";
            // 
            // newPatientIntakeWizard_tab1_textbox_lastName
            // 
            this.newPatientIntakeWizard_tab1_textbox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_lastName.Location = new System.Drawing.Point(454, 141);
            this.newPatientIntakeWizard_tab1_textbox_lastName.MaxLength = 26;
            this.newPatientIntakeWizard_tab1_textbox_lastName.Name = "newPatientIntakeWizard_tab1_textbox_lastName";
            this.newPatientIntakeWizard_tab1_textbox_lastName.Size = new System.Drawing.Size(150, 22);
            this.newPatientIntakeWizard_tab1_textbox_lastName.TabIndex = 5;
            this.newPatientIntakeWizard_tab1_textbox_lastName.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_lastName_TextChanged);
            // 
            // newPatientIntakeWizard_label_instructions
            // 
            this.newPatientIntakeWizard_label_instructions.AutoSize = true;
            this.newPatientIntakeWizard_label_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_label_instructions.Location = new System.Drawing.Point(356, 83);
            this.newPatientIntakeWizard_label_instructions.Name = "newPatientIntakeWizard_label_instructions";
            this.newPatientIntakeWizard_label_instructions.Size = new System.Drawing.Size(224, 16);
            this.newPatientIntakeWizard_label_instructions.TabIndex = 4;
            this.newPatientIntakeWizard_label_instructions.Text = "Step 1: Enter basic client information.";
            // 
            // newPatientIntakeWizard_tab1_label_firstName
            // 
            this.newPatientIntakeWizard_tab1_label_firstName.AutoSize = true;
            this.newPatientIntakeWizard_tab1_label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_label_firstName.Location = new System.Drawing.Point(372, 116);
            this.newPatientIntakeWizard_tab1_label_firstName.Name = "newPatientIntakeWizard_tab1_label_firstName";
            this.newPatientIntakeWizard_tab1_label_firstName.Size = new System.Drawing.Size(76, 16);
            this.newPatientIntakeWizard_tab1_label_firstName.TabIndex = 3;
            this.newPatientIntakeWizard_tab1_label_firstName.Text = "First Name:";
            // 
            // newPatientIntakeWizard_tab1_textbox_firstName
            // 
            this.newPatientIntakeWizard_tab1_textbox_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_tab1_textbox_firstName.Location = new System.Drawing.Point(454, 113);
            this.newPatientIntakeWizard_tab1_textbox_firstName.MaxLength = 26;
            this.newPatientIntakeWizard_tab1_textbox_firstName.Name = "newPatientIntakeWizard_tab1_textbox_firstName";
            this.newPatientIntakeWizard_tab1_textbox_firstName.Size = new System.Drawing.Size(150, 22);
            this.newPatientIntakeWizard_tab1_textbox_firstName.TabIndex = 2;
            this.newPatientIntakeWizard_tab1_textbox_firstName.TextChanged += new System.EventHandler(this.newPatientIntakeWizard_tab1_textbox_firstName_TextChanged);
            // 
            // newPatientIntakeWizard_picturebox_wizard
            // 
            this.newPatientIntakeWizard_picturebox_wizard.Image = global::WSRsmooz.Properties.Resources.wizard_icon;
            this.newPatientIntakeWizard_picturebox_wizard.Location = new System.Drawing.Point(114, 83);
            this.newPatientIntakeWizard_picturebox_wizard.Name = "newPatientIntakeWizard_picturebox_wizard";
            this.newPatientIntakeWizard_picturebox_wizard.Size = new System.Drawing.Size(229, 276);
            this.newPatientIntakeWizard_picturebox_wizard.TabIndex = 1;
            this.newPatientIntakeWizard_picturebox_wizard.TabStop = false;
            // 
            // newPatientIntakeWizard_label_title
            // 
            this.newPatientIntakeWizard_label_title.AutoSize = true;
            this.newPatientIntakeWizard_label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientIntakeWizard_label_title.Location = new System.Drawing.Point(353, 38);
            this.newPatientIntakeWizard_label_title.Name = "newPatientIntakeWizard_label_title";
            this.newPatientIntakeWizard_label_title.Size = new System.Drawing.Size(357, 33);
            this.newPatientIntakeWizard_label_title.TabIndex = 0;
            this.newPatientIntakeWizard_label_title.Text = "New Patient Intake Wizard";
            this.newPatientIntakeWizard_label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // NewPatientIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 657);
            this.Controls.Add(this.NewPatientIntake_checklist_button_tab2);
            this.Controls.Add(this.NewPatientIntake_checklist_button_tab1);
            this.Controls.Add(this.newPatientIntakeWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPatientIntake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewPatientIntake";
            this.newPatientIntakeWizard.ResumeLayout(false);
            this.newPatientIntakeWizard_tab1.ResumeLayout(false);
            this.newPatientIntakeWizard_tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPatientIntakeWizard_picturebox_wizard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardTabs newPatientIntakeWizard;
        private System.Windows.Forms.TabPage newPatientIntakeWizard_tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox newPatientIntakeWizard_picturebox_wizard;
        private System.Windows.Forms.Label newPatientIntakeWizard_label_title;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_firstName;
        private System.Windows.Forms.Label newPatientIntakeWizard_label_instructions;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_firstName;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_lastName;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_lastName;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_middleInitial;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_middleInitial;
        private System.Windows.Forms.Button newPatientIntakeWizard_button_cancel;
        private System.Windows.Forms.Button newPatientIntakeWizard_button_next;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_dateOfBirth;
        private System.Windows.Forms.DateTimePicker newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_streetAddress;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_streetAddress;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_state;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_city;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_city;
        private System.Windows.Forms.ComboBox newPatientIntakeWizard_tab1_combobox_state;
        private System.Windows.Forms.Label newPatientIntakeWizard_tab1_label_zip;
        private System.Windows.Forms.TextBox newPatientIntakeWizard_tab1_textbox_zip;
        private System.Windows.Forms.Button NewPatientIntake_checklist_button_tab1;
        private System.Windows.Forms.Button NewPatientIntake_checklist_button_tab2;
        private System.Windows.Forms.Button newPatientIntakeWizard_button_back;

    }
}