namespace WSRsmooz
{
    partial class PatientLog
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clientList = new System.Windows.Forms.ListBox();
            this.PanelList = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Include Inactive Clients";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clientList
            // 
            this.clientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientList.FormattingEnabled = true;
            this.clientList.ItemHeight = 20;
            this.clientList.Location = new System.Drawing.Point(12, 33);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(193, 564);
            this.clientList.TabIndex = 0;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // PanelList
            // 
            this.PanelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PanelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelList.FormattingEnabled = true;
            this.PanelList.Items.AddRange(new object[] {
            "Panel 1"});
            this.PanelList.Location = new System.Drawing.Point(434, 57);
            this.PanelList.Name = "PanelList";
            this.PanelList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelList.Size = new System.Drawing.Size(300, 39);
            this.PanelList.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(211, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(747, 32);
            this.Title.TabIndex = 100;
            this.Title.Text = "Patient Log and Forms";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Window;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(384, 109);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(400, 40);
            this.delete.TabIndex = 3;
            this.delete.Text = "Client Screening Form";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // delete2
            // 
            this.delete2.BackColor = System.Drawing.SystemColors.Window;
            this.delete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete2.Location = new System.Drawing.Point(384, 154);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(400, 40);
            this.delete2.TabIndex = 4;
            this.delete2.Text = "ASAM";
            this.delete2.UseVisualStyleBackColor = false;
            // 
            // PatientLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PanelList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clientList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PatientLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.ComboBox PanelList;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button delete2;
    }
}