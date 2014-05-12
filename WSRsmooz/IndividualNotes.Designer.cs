namespace WSRsmooz
{
    partial class IndividualNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualNotes));
            this.label1 = new System.Windows.Forms.Label();
            this.DoW = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ListBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.D4 = new System.Windows.Forms.DateTimePicker();
            this.D7 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.DateTimePicker();
            this.T2 = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label432 = new System.Windows.Forms.Label();
            this.NOTE = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(374, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // DoW
            // 
            this.DoW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoW.Location = new System.Drawing.Point(252, 9);
            this.DoW.Name = "DoW";
            this.DoW.Size = new System.Drawing.Size(688, 30);
            this.DoW.TabIndex = 2;
            this.DoW.Text = "Individual Notes";
            this.DoW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientList
            // 
            this.clientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientList.FormattingEnabled = true;
            this.clientList.ItemHeight = 20;
            this.clientList.Location = new System.Drawing.Point(26, 9);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(193, 584);
            this.clientList.TabIndex = 14;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(252, 185);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(688, 24);
            this.ClientNameLabel.TabIndex = 15;
            this.ClientNameLabel.Text = "-----";
            this.ClientNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Week Of:";
            // 
            // D1
            // 
            this.D1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.D1.Location = new System.Drawing.Point(394, 228);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(106, 22);
            this.D1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Thru:";
            // 
            // D4
            // 
            this.D4.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.D4.Location = new System.Drawing.Point(559, 228);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(106, 22);
            this.D4.TabIndex = 20;
            // 
            // D7
            // 
            this.D7.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D7.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.D7.Location = new System.Drawing.Point(725, 228);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(106, 22);
            this.D7.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date:";
            // 
            // T1
            // 
            this.T1.CustomFormat = "hh:mm";
            this.T1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.T1.Location = new System.Drawing.Point(535, 258);
            this.T1.Name = "T1";
            this.T1.ShowUpDown = true;
            this.T1.Size = new System.Drawing.Size(64, 22);
            this.T1.TabIndex = 23;
            this.T1.Value = new System.DateTime(2014, 4, 12, 20, 0, 0, 0);
            // 
            // T2
            // 
            this.T2.CustomFormat = "hh:mm";
            this.T2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.T2.Location = new System.Drawing.Point(652, 258);
            this.T2.Name = "T2";
            this.T2.ShowUpDown = true;
            this.T2.Size = new System.Drawing.Size(64, 22);
            this.T2.TabIndex = 24;
            this.T2.Value = new System.DateTime(2014, 4, 12, 20, 0, 0, 0);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(487, 261);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 16);
            this.label.TabIndex = 25;
            this.label.Text = "Time:";
            // 
            // label432
            // 
            this.label432.AutoSize = true;
            this.label432.Location = new System.Drawing.Point(618, 261);
            this.label432.Name = "label432";
            this.label432.Size = new System.Drawing.Size(28, 16);
            this.label432.TabIndex = 26;
            this.label432.Text = "To:";
            // 
            // NOTE
            // 
            this.NOTE.Location = new System.Drawing.Point(294, 305);
            this.NOTE.Multiline = true;
            this.NOTE.Name = "NOTE";
            this.NOTE.Size = new System.Drawing.Size(635, 193);
            this.NOTE.TabIndex = 27;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(545, 504);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(130, 31);
            this.PrintButton.TabIndex = 28;
            this.PrintButton.Text = "Print Notes";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // IndividualNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NOTE);
            this.Controls.Add(this.label432);
            this.Controls.Add(this.label);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.D7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.DoW);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndividualNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IndividualNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DoW;
        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker D1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker D4;
        private System.Windows.Forms.DateTimePicker D7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker T1;
        private System.Windows.Forms.DateTimePicker T2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label432;
        private System.Windows.Forms.TextBox NOTE;
        private System.Windows.Forms.Button PrintButton;

    }
}