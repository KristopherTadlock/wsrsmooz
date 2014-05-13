namespace WSRsmooz
{
    partial class CustomFormEditor
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
            this.IMPORTANTYESLoadPDFButton = new System.Windows.Forms.Button();
            this.IMPORTANTYESSaveFormButton = new System.Windows.Forms.Button();
            this.IMPORTANTYESTitleBox = new System.Windows.Forms.TextBox();
            this.IMPORTANTYESLabel = new System.Windows.Forms.Label();
            this.IMPORTANTYESPanelChoiceBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IMPORTANTYESLoadPDFButton
            // 
            this.IMPORTANTYESLoadPDFButton.Location = new System.Drawing.Point(-1, -1);
            this.IMPORTANTYESLoadPDFButton.Margin = new System.Windows.Forms.Padding(4);
            this.IMPORTANTYESLoadPDFButton.Name = "IMPORTANTYESLoadPDFButton";
            this.IMPORTANTYESLoadPDFButton.Size = new System.Drawing.Size(91, 28);
            this.IMPORTANTYESLoadPDFButton.TabIndex = 0;
            this.IMPORTANTYESLoadPDFButton.Text = "Load PDF";
            this.IMPORTANTYESLoadPDFButton.UseVisualStyleBackColor = true;
            this.IMPORTANTYESLoadPDFButton.Click += new System.EventHandler(this.LoadPDF);
            // 
            // IMPORTANTYESSaveFormButton
            // 
            this.IMPORTANTYESSaveFormButton.Location = new System.Drawing.Point(89, -1);
            this.IMPORTANTYESSaveFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.IMPORTANTYESSaveFormButton.Name = "IMPORTANTYESSaveFormButton";
            this.IMPORTANTYESSaveFormButton.Size = new System.Drawing.Size(91, 28);
            this.IMPORTANTYESSaveFormButton.TabIndex = 1;
            this.IMPORTANTYESSaveFormButton.Text = "Save Form";
            this.IMPORTANTYESSaveFormButton.UseVisualStyleBackColor = true;
            this.IMPORTANTYESSaveFormButton.Click += new System.EventHandler(this.SaveForm);
            // 
            // IMPORTANTYESTitleBox
            // 
            this.IMPORTANTYESTitleBox.Location = new System.Drawing.Point(230, 2);
            this.IMPORTANTYESTitleBox.Name = "IMPORTANTYESTitleBox";
            this.IMPORTANTYESTitleBox.Size = new System.Drawing.Size(304, 22);
            this.IMPORTANTYESTitleBox.TabIndex = 2;
            // 
            // IMPORTANTYESLabel
            // 
            this.IMPORTANTYESLabel.AutoSize = true;
            this.IMPORTANTYESLabel.Location = new System.Drawing.Point(187, 5);
            this.IMPORTANTYESLabel.Name = "IMPORTANTYESLabel";
            this.IMPORTANTYESLabel.Size = new System.Drawing.Size(37, 16);
            this.IMPORTANTYESLabel.TabIndex = 3;
            this.IMPORTANTYESLabel.Text = "Title:";
            // 
            // IMPORTANTYESPanelChoiceBox
            // 
            this.IMPORTANTYESPanelChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IMPORTANTYESPanelChoiceBox.FormattingEnabled = true;
            this.IMPORTANTYESPanelChoiceBox.Location = new System.Drawing.Point(540, 2);
            this.IMPORTANTYESPanelChoiceBox.Name = "IMPORTANTYESPanelChoiceBox";
            this.IMPORTANTYESPanelChoiceBox.Size = new System.Drawing.Size(151, 24);
            this.IMPORTANTYESPanelChoiceBox.TabIndex = 40;
            // 
            // CustomFormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 509);
            this.Controls.Add(this.IMPORTANTYESPanelChoiceBox);
            this.Controls.Add(this.IMPORTANTYESLabel);
            this.Controls.Add(this.IMPORTANTYESTitleBox);
            this.Controls.Add(this.IMPORTANTYESSaveFormButton);
            this.Controls.Add(this.IMPORTANTYESLoadPDFButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomFormEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Editor";
            this.Load += new System.EventHandler(this.CustomFormEditor_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IMPORTANTYESLoadPDFButton;
        private System.Windows.Forms.Button IMPORTANTYESSaveFormButton;
        private System.Windows.Forms.TextBox IMPORTANTYESTitleBox;
        private System.Windows.Forms.Label IMPORTANTYESLabel;
        private System.Windows.Forms.ComboBox IMPORTANTYESPanelChoiceBox;
    }
}