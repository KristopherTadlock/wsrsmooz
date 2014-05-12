using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class CustomTextboxLabel : UserControl
    {
        private Boolean skip = false;
        public Boolean locked = false;
        public string pdfAttribute { get; set; }

        public CustomTextboxLabel()
        {
            InitializeComponent();
            this.AutoSize = false;
            resetSize();
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return textBox.Text;
            }

            set
            {
                textBox.Text = value;
                resetSize();
            }
        }

        public void resetSize()
        {
            this.Width = label.Width + textBox.Width;
            this.Height = textBox.Height - 4;
        }

        public String attrName()
        {
            return label.Text;
        }

        public void attrName(String newName)
        {
            label.Text = newName;
            resetSize();
        }

        private void Transform(object sender, MouseEventArgs e)
        {
            if (!locked && e.Button == MouseButtons.Right)
            {
                using (FormEditor_ChangeType form = new FormEditor_ChangeType())
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                    {
                        switch (form.result)
                        {
                            case "Textbox":
                                if (textBox.Multiline)
                                {
                                    textBox.Multiline = false;
                                    textBox.Size = new System.Drawing.Size(textBox.Width, 22);
                                    this.Width = label.Width + textBox.Width;
                                    this.Height = textBox.Height;
                                }
                                break;
                            case "BigTextbox":
                                if (!textBox.Multiline)
                                {
                                    textBox.Multiline = true;
                                    this.Height = 78;
                                    textBox.Size = new System.Drawing.Size(textBox.Width, 78);
                                    this.Width = label.Width + textBox.Width;
                                }
                                break;
                            case "Combobox":
                                EditableCombobox combobox = new EditableCombobox();
                                combobox.Text = label.Text;
                                combobox.Parent = this.Parent;
                                combobox.Draggable(true);
                                combobox.rememberName = label.Text;
                                combobox.pdfAttribute = this.pdfAttribute;
                                combobox.combobox.Items.Add(label.Text);
                                combobox.combobox.SelectedIndex = 0;
                                Parent.Controls.Add(combobox);
                                combobox.Location = this.Location;
                                Parent.Controls.Remove(this);
                                break;
                            case "Checkbox":
                                EditableCheckbox checkbox = new EditableCheckbox();
                                checkbox.Text = label.Text;
                                checkbox.Parent = this.Parent;
                                checkbox.pdfAttribute = this.pdfAttribute;
                                checkbox.Draggable(true);
                                Parent.Controls.Add(checkbox);
                                checkbox.Location = this.Location;
                                Parent.Controls.Remove(this);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void DoubleClick(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                using (LabelEditor form = new LabelEditor())
                {
                    form.labelText = label.Text;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        label.Text = form.labelText;
                }
            }
        }
    }
}
