using System.Windows.Forms;
namespace WSRsmooz
{
    partial class EditableCombobox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combobox = new WSRsmooz.CustomTransparentComboBox();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.Location = new System.Drawing.Point(0, 0);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(94, 24);
            this.combobox.TabIndex = 0;
            this.combobox.SizeChanged += new System.EventHandler(this.SizeWasChanged);
            // 
            // EditableCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.combobox);
            this.Name = "EditableCombobox";
            this.Size = new System.Drawing.Size(94, 28);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.triggerEntry);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightClick);
            this.ResumeLayout(false);

        }

        #endregion

        public CustomTransparentComboBox combobox;

    }
}
