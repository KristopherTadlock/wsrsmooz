namespace WSRsmooz
{
    partial class GroupNotes
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
            this.KickTopic = new System.Windows.Forms.TextBox();
            this.DoW = new System.Windows.Forms.Label();
            this.DaySelection = new System.Windows.Forms.ComboBox();
            this.KickText = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.AMText = new System.Windows.Forms.TextBox();
            this.AMTopic = new System.Windows.Forms.TextBox();
            this.PMText = new System.Windows.Forms.TextBox();
            this.PMTopic = new System.Windows.Forms.TextBox();
            this.SignKick = new System.Windows.Forms.Button();
            this.KickStart_Label = new System.Windows.Forms.Label();
            this.Kick_GroupBox = new System.Windows.Forms.GroupBox();
            this.AM_GroupBox = new System.Windows.Forms.GroupBox();
            this.PM_GroupBox = new System.Windows.Forms.GroupBox();
            this.KickStart = new System.Windows.Forms.DateTimePicker();
            this.KickEnd = new System.Windows.Forms.DateTimePicker();
            this.KickEnd_Label = new System.Windows.Forms.Label();
            this.KickStart_Label_AM = new System.Windows.Forms.Label();
            this.KickEnd_Label_AM = new System.Windows.Forms.Label();
            this.KickTopic_Label = new System.Windows.Forms.Label();
            this.AMTopic_Label = new System.Windows.Forms.Label();
            this.PMTopic_Label = new System.Windows.Forms.Label();
            this.SignAM = new System.Windows.Forms.Button();
            this.SignPM = new System.Windows.Forms.Button();
            this.SignKick_Label = new System.Windows.Forms.Label();
            this.SignAM_Label = new System.Windows.Forms.Label();
            this.SignPM_Label = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ListBox();
            this.WeekOf_Label = new System.Windows.Forms.Label();
            this.DateOfWeek = new System.Windows.Forms.Label();
            this.Kick_GroupBox.SuspendLayout();
            this.AM_GroupBox.SuspendLayout();
            this.PM_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // KickTopic
            // 
            this.KickTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickTopic.Location = new System.Drawing.Point(61, 59);
            this.KickTopic.Name = "KickTopic";
            this.KickTopic.Size = new System.Drawing.Size(376, 22);
            this.KickTopic.TabIndex = 0;
            // 
            // DoW
            // 
            this.DoW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoW.Location = new System.Drawing.Point(287, 12);
            this.DoW.Name = "DoW";
            this.DoW.Size = new System.Drawing.Size(580, 30);
            this.DoW.TabIndex = 1;
            this.DoW.Text = "Change to Current Day of Week";
            this.DoW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DaySelection
            // 
            this.DaySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaySelection.FormattingEnabled = true;
            this.DaySelection.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            "Additional"});
            this.DaySelection.Location = new System.Drawing.Point(511, 85);
            this.DaySelection.Name = "DaySelection";
            this.DaySelection.Size = new System.Drawing.Size(133, 24);
            this.DaySelection.TabIndex = 9;
            this.DaySelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KickText
            // 
            this.KickText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickText.Location = new System.Drawing.Point(12, 87);
            this.KickText.Multiline = true;
            this.KickText.Name = "KickText";
            this.KickText.Size = new System.Drawing.Size(425, 52);
            this.KickText.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(482, 553);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(191, 28);
            this.Save.TabIndex = 8;
            this.Save.Text = "Preserve Without Signing";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AMText
            // 
            this.AMText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMText.Location = new System.Drawing.Point(14, 51);
            this.AMText.Multiline = true;
            this.AMText.Name = "AMText";
            this.AMText.Size = new System.Drawing.Size(420, 52);
            this.AMText.TabIndex = 5;
            // 
            // AMTopic
            // 
            this.AMTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMTopic.Location = new System.Drawing.Point(61, 23);
            this.AMTopic.Name = "AMTopic";
            this.AMTopic.Size = new System.Drawing.Size(376, 22);
            this.AMTopic.TabIndex = 4;
            // 
            // PMText
            // 
            this.PMText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMText.Location = new System.Drawing.Point(14, 55);
            this.PMText.Multiline = true;
            this.PMText.Name = "PMText";
            this.PMText.Size = new System.Drawing.Size(420, 52);
            this.PMText.TabIndex = 7;
            // 
            // PMTopic
            // 
            this.PMTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMTopic.Location = new System.Drawing.Point(61, 27);
            this.PMTopic.Name = "PMTopic";
            this.PMTopic.Size = new System.Drawing.Size(376, 22);
            this.PMTopic.TabIndex = 6;
            // 
            // SignKick
            // 
            this.SignKick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignKick.Location = new System.Drawing.Point(443, 87);
            this.SignKick.Name = "SignKick";
            this.SignKick.Size = new System.Drawing.Size(132, 52);
            this.SignKick.TabIndex = 10;
            this.SignKick.Text = "Sign";
            this.SignKick.UseVisualStyleBackColor = true;
            this.SignKick.Click += new System.EventHandler(this.SignKick_Click);
            // 
            // KickStart_Label
            // 
            this.KickStart_Label.AutoSize = true;
            this.KickStart_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickStart_Label.Location = new System.Drawing.Point(17, 33);
            this.KickStart_Label.Name = "KickStart_Label";
            this.KickStart_Label.Size = new System.Drawing.Size(38, 16);
            this.KickStart_Label.TabIndex = 12;
            this.KickStart_Label.Text = "Start:";
            // 
            // Kick_GroupBox
            // 
            this.Kick_GroupBox.Controls.Add(this.SignKick_Label);
            this.Kick_GroupBox.Controls.Add(this.KickTopic_Label);
            this.Kick_GroupBox.Controls.Add(this.KickEnd_Label_AM);
            this.Kick_GroupBox.Controls.Add(this.KickStart_Label_AM);
            this.Kick_GroupBox.Controls.Add(this.KickEnd);
            this.Kick_GroupBox.Controls.Add(this.KickEnd_Label);
            this.Kick_GroupBox.Controls.Add(this.KickStart);
            this.Kick_GroupBox.Controls.Add(this.KickStart_Label);
            this.Kick_GroupBox.Controls.Add(this.SignKick);
            this.Kick_GroupBox.Controls.Add(this.KickTopic);
            this.Kick_GroupBox.Controls.Add(this.KickText);
            this.Kick_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kick_GroupBox.Location = new System.Drawing.Point(292, 109);
            this.Kick_GroupBox.Name = "Kick_GroupBox";
            this.Kick_GroupBox.Size = new System.Drawing.Size(581, 150);
            this.Kick_GroupBox.TabIndex = 13;
            this.Kick_GroupBox.TabStop = false;
            this.Kick_GroupBox.Text = "Kick-Off";
            // 
            // AM_GroupBox
            // 
            this.AM_GroupBox.Controls.Add(this.SignAM_Label);
            this.AM_GroupBox.Controls.Add(this.SignAM);
            this.AM_GroupBox.Controls.Add(this.AMTopic_Label);
            this.AM_GroupBox.Controls.Add(this.AMText);
            this.AM_GroupBox.Controls.Add(this.AMTopic);
            this.AM_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AM_GroupBox.Location = new System.Drawing.Point(292, 274);
            this.AM_GroupBox.Name = "AM_GroupBox";
            this.AM_GroupBox.Size = new System.Drawing.Size(581, 128);
            this.AM_GroupBox.TabIndex = 14;
            this.AM_GroupBox.TabStop = false;
            this.AM_GroupBox.Text = "AM Notes";
            // 
            // PM_GroupBox
            // 
            this.PM_GroupBox.Controls.Add(this.SignPM_Label);
            this.PM_GroupBox.Controls.Add(this.SignPM);
            this.PM_GroupBox.Controls.Add(this.PMTopic_Label);
            this.PM_GroupBox.Controls.Add(this.PMText);
            this.PM_GroupBox.Controls.Add(this.PMTopic);
            this.PM_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM_GroupBox.Location = new System.Drawing.Point(292, 410);
            this.PM_GroupBox.Name = "PM_GroupBox";
            this.PM_GroupBox.Size = new System.Drawing.Size(581, 128);
            this.PM_GroupBox.TabIndex = 15;
            this.PM_GroupBox.TabStop = false;
            this.PM_GroupBox.Text = "PM Notes";
            // 
            // KickStart
            // 
            this.KickStart.CustomFormat = "hh:mm";
            this.KickStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KickStart.Location = new System.Drawing.Point(61, 30);
            this.KickStart.Name = "KickStart";
            this.KickStart.ShowUpDown = true;
            this.KickStart.Size = new System.Drawing.Size(64, 22);
            this.KickStart.TabIndex = 2;
            this.KickStart.Value = new System.DateTime(2014, 4, 12, 20, 0, 0, 0);
            // 
            // KickEnd
            // 
            this.KickEnd.CustomFormat = "hh:mm";
            this.KickEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KickEnd.Location = new System.Drawing.Point(210, 30);
            this.KickEnd.Name = "KickEnd";
            this.KickEnd.ShowUpDown = true;
            this.KickEnd.Size = new System.Drawing.Size(64, 22);
            this.KickEnd.TabIndex = 3;
            this.KickEnd.Value = new System.DateTime(2014, 4, 12, 21, 0, 0, 0);
            // 
            // KickEnd_Label
            // 
            this.KickEnd_Label.AutoSize = true;
            this.KickEnd_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickEnd_Label.Location = new System.Drawing.Point(169, 33);
            this.KickEnd_Label.Name = "KickEnd_Label";
            this.KickEnd_Label.Size = new System.Drawing.Size(35, 16);
            this.KickEnd_Label.TabIndex = 14;
            this.KickEnd_Label.Text = "End:";
            // 
            // KickStart_Label_AM
            // 
            this.KickStart_Label_AM.AutoSize = true;
            this.KickStart_Label_AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickStart_Label_AM.Location = new System.Drawing.Point(131, 33);
            this.KickStart_Label_AM.Name = "KickStart_Label_AM";
            this.KickStart_Label_AM.Size = new System.Drawing.Size(28, 16);
            this.KickStart_Label_AM.TabIndex = 16;
            this.KickStart_Label_AM.Text = "AM";
            // 
            // KickEnd_Label_AM
            // 
            this.KickEnd_Label_AM.AutoSize = true;
            this.KickEnd_Label_AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickEnd_Label_AM.Location = new System.Drawing.Point(280, 33);
            this.KickEnd_Label_AM.Name = "KickEnd_Label_AM";
            this.KickEnd_Label_AM.Size = new System.Drawing.Size(28, 16);
            this.KickEnd_Label_AM.TabIndex = 17;
            this.KickEnd_Label_AM.Text = "AM";
            // 
            // KickTopic_Label
            // 
            this.KickTopic_Label.AutoSize = true;
            this.KickTopic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickTopic_Label.Location = new System.Drawing.Point(9, 62);
            this.KickTopic_Label.Name = "KickTopic_Label";
            this.KickTopic_Label.Size = new System.Drawing.Size(46, 16);
            this.KickTopic_Label.TabIndex = 18;
            this.KickTopic_Label.Text = "Topic:";
            // 
            // AMTopic_Label
            // 
            this.AMTopic_Label.AutoSize = true;
            this.AMTopic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMTopic_Label.Location = new System.Drawing.Point(9, 26);
            this.AMTopic_Label.Name = "AMTopic_Label";
            this.AMTopic_Label.Size = new System.Drawing.Size(46, 16);
            this.AMTopic_Label.TabIndex = 19;
            this.AMTopic_Label.Text = "Topic:";
            // 
            // PMTopic_Label
            // 
            this.PMTopic_Label.AutoSize = true;
            this.PMTopic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMTopic_Label.Location = new System.Drawing.Point(9, 30);
            this.PMTopic_Label.Name = "PMTopic_Label";
            this.PMTopic_Label.Size = new System.Drawing.Size(46, 16);
            this.PMTopic_Label.TabIndex = 20;
            this.PMTopic_Label.Text = "Topic:";
            // 
            // SignAM
            // 
            this.SignAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignAM.Location = new System.Drawing.Point(443, 51);
            this.SignAM.Name = "SignAM";
            this.SignAM.Size = new System.Drawing.Size(132, 52);
            this.SignAM.TabIndex = 11;
            this.SignAM.Text = "Sign";
            this.SignAM.UseVisualStyleBackColor = true;
            this.SignAM.Click += new System.EventHandler(this.SignAM_Click);
            // 
            // SignPM
            // 
            this.SignPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignPM.Location = new System.Drawing.Point(443, 55);
            this.SignPM.Name = "SignPM";
            this.SignPM.Size = new System.Drawing.Size(132, 52);
            this.SignPM.TabIndex = 12;
            this.SignPM.Text = "Sign";
            this.SignPM.UseVisualStyleBackColor = true;
            this.SignPM.Click += new System.EventHandler(this.SignPM_Click);
            // 
            // SignKick_Label
            // 
            this.SignKick_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.SignKick_Label.Location = new System.Drawing.Point(443, 65);
            this.SignKick_Label.Name = "SignKick_Label";
            this.SignKick_Label.Size = new System.Drawing.Size(132, 19);
            this.SignKick_Label.TabIndex = 19;
            this.SignKick_Label.Text = "Unsigned";
            this.SignKick_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignAM_Label
            // 
            this.SignAM_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.SignAM_Label.Location = new System.Drawing.Point(443, 29);
            this.SignAM_Label.Name = "SignAM_Label";
            this.SignAM_Label.Size = new System.Drawing.Size(132, 19);
            this.SignAM_Label.TabIndex = 20;
            this.SignAM_Label.Text = "Unsigned";
            this.SignAM_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignPM_Label
            // 
            this.SignPM_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.SignPM_Label.Location = new System.Drawing.Point(443, 33);
            this.SignPM_Label.Name = "SignPM_Label";
            this.SignPM_Label.Size = new System.Drawing.Size(132, 19);
            this.SignPM_Label.TabIndex = 21;
            this.SignPM_Label.Text = "Unsigned";
            this.SignPM_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientList
            // 
            this.clientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientList.FormattingEnabled = true;
            this.clientList.ItemHeight = 20;
            this.clientList.Location = new System.Drawing.Point(32, 12);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(193, 584);
            this.clientList.TabIndex = 13;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // WeekOf_Label
            // 
            this.WeekOf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekOf_Label.Location = new System.Drawing.Point(287, 37);
            this.WeekOf_Label.Name = "WeekOf_Label";
            this.WeekOf_Label.Size = new System.Drawing.Size(580, 24);
            this.WeekOf_Label.TabIndex = 17;
            this.WeekOf_Label.Text = "Change to Current Week";
            this.WeekOf_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateOfWeek
            // 
            this.DateOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfWeek.Location = new System.Drawing.Point(287, 58);
            this.DateOfWeek.Name = "DateOfWeek";
            this.DateOfWeek.Size = new System.Drawing.Size(580, 24);
            this.DateOfWeek.TabIndex = 18;
            this.DateOfWeek.Text = "Change to Current Day";
            this.DateOfWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.DateOfWeek);
            this.Controls.Add(this.WeekOf_Label);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.PM_GroupBox);
            this.Controls.Add(this.AM_GroupBox);
            this.Controls.Add(this.Kick_GroupBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DaySelection);
            this.Controls.Add(this.DoW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GroupNotes";
            this.Kick_GroupBox.ResumeLayout(false);
            this.Kick_GroupBox.PerformLayout();
            this.AM_GroupBox.ResumeLayout(false);
            this.AM_GroupBox.PerformLayout();
            this.PM_GroupBox.ResumeLayout(false);
            this.PM_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox KickTopic;
        private System.Windows.Forms.Label DoW;
        private System.Windows.Forms.ComboBox DaySelection;
        private System.Windows.Forms.TextBox KickText;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox AMText;
        private System.Windows.Forms.TextBox AMTopic;
        private System.Windows.Forms.TextBox PMText;
        private System.Windows.Forms.TextBox PMTopic;
        private System.Windows.Forms.Button SignKick;
        private System.Windows.Forms.Label KickStart_Label;
        private System.Windows.Forms.GroupBox Kick_GroupBox;
        private System.Windows.Forms.DateTimePicker KickStart;
        private System.Windows.Forms.GroupBox AM_GroupBox;
        private System.Windows.Forms.GroupBox PM_GroupBox;
        private System.Windows.Forms.DateTimePicker KickEnd;
        private System.Windows.Forms.Label KickEnd_Label;
        private System.Windows.Forms.Label KickEnd_Label_AM;
        private System.Windows.Forms.Label KickStart_Label_AM;
        private System.Windows.Forms.Label KickTopic_Label;
        private System.Windows.Forms.Label AMTopic_Label;
        private System.Windows.Forms.Label PMTopic_Label;
        private System.Windows.Forms.Button SignAM;
        private System.Windows.Forms.Button SignPM;
        private System.Windows.Forms.Label SignKick_Label;
        private System.Windows.Forms.Label SignAM_Label;
        private System.Windows.Forms.Label SignPM_Label;
        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Label WeekOf_Label;
        private System.Windows.Forms.Label DateOfWeek;
    }
}