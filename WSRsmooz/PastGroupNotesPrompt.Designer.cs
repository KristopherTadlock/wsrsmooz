namespace WSRsmooz
{
    partial class PastGroupNotesPrompt
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
            this.PastNotes = new System.Windows.Forms.ListBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PastNotes
            // 
            this.PastNotes.FormattingEnabled = true;
            this.PastNotes.ItemHeight = 16;
            this.PastNotes.Location = new System.Drawing.Point(12, 12);
            this.PastNotes.Name = "PastNotes";
            this.PastNotes.Size = new System.Drawing.Size(120, 132);
            this.PastNotes.TabIndex = 0;
            // 
            // MainLabel
            // 
            this.MainLabel.Location = new System.Drawing.Point(138, 21);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(237, 20);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Past Group Notes for";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientName
            // 
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(138, 41);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(237, 25);
            this.ClientName.TabIndex = 2;
            this.ClientName.Text = "Client";
            this.ClientName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(189, 69);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(134, 42);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(139, 120);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(236, 16);
            this.Note.TabIndex = 4;
            this.Note.Text = "Notes are destroyed after 30 days.";
            this.Note.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PastGroupNotesPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 154);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.PastNotes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PastGroupNotesPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Past Group Notes";
            this.Load += new System.EventHandler(this.PastGroupNotesPrompt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PastNotes;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label Note;
    }
}