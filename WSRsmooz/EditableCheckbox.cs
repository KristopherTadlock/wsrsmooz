using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class EditableCheckbox : UserControl
    {
        public string pdfAttribute { get; set; }
        public Boolean locked = false;

        public EditableCheckbox()
        {
            InitializeComponent();
            checkbox.Size = this.Size;
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return checkbox.Text;
            }

            set
            {
                checkbox.Text = value;
            }
        }

        private void label_SizeChanged(object sender, EventArgs e)
        {
            this.Size = checkbox.Size;
        }

        public void triggerEntry(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                using (LabelEditor form = new LabelEditor())
                {
                    if (!checkbox.Text.Equals("checkbox"))
                        form.labelText = checkbox.Text;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        checkbox.Text = form.labelText;
                }
            }
        }

        private void rightClick(object sender, MouseEventArgs e)
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
                                CustomTextboxLabel textBox = new CustomTextboxLabel();
                                textBox.textBox.Multiline = false;
                                textBox.pdfAttribute = this.pdfAttribute;
                                textBox.label.Text = checkbox.Text;
                                textBox.Size = new System.Drawing.Size(textBox.Width, 22);
                                textBox.resetSize();
                                textBox.Draggable(true);
                                Parent.Controls.Add(textBox);
                                textBox.Location = this.Location;
                                textBox.Width = textBox.label.Width + textBox.textBox.Width;
                                Parent.Controls.Remove(this);
                                break;
                            case "BigTextbox":
                                CustomTextboxLabel multitextBox = new CustomTextboxLabel();
                                multitextBox.textBox.Multiline = true;
                                multitextBox.pdfAttribute = this.pdfAttribute;
                                multitextBox.label.Text = checkbox.Text;
                                multitextBox.Height = 78;
                                multitextBox.Size = new System.Drawing.Size(multitextBox.textBox.Width, 78);
                                multitextBox.Draggable(true);
                                Parent.Controls.Add(multitextBox);
                                multitextBox.Location = this.Location;
                                multitextBox.Width = multitextBox.label.Width + multitextBox.textBox.Width;
                                Parent.Controls.Remove(this);
                                break;
                            case "Combobox":
                                EditableCombobox combobox = new EditableCombobox();
                                combobox.Text = checkbox.Text;
                                combobox.Parent = this.Parent;
                                combobox.pdfAttribute = this.pdfAttribute;
                                combobox.Draggable(true);
                                combobox.rememberName = checkbox.Text;
                                combobox.combobox.Items.Add(checkbox.Text);
                                combobox.combobox.SelectedIndex = 0;
                                Parent.Controls.Add(combobox);
                                combobox.Location = this.Location;
                                Parent.Controls.Remove(this);
                                break;
                            case "Checkbox":
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }

    public partial class CheckBoxer : CheckBox
    {
        public string pdfAttribute { get; set; }
    }
}
