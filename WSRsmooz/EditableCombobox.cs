using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class EditableCombobox : UserControl
    {
        public string rememberName { get; set; }
        public string pdfAttribute { get; set; }
        public Boolean locked = false;

        public EditableCombobox()
        {
            InitializeComponent();
            combobox.Size = this.Size;
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return combobox.Text;
            }

            set
            {
                combobox.Text = value;
            }
        }

        public void resizeBox()
        {
            int max = 0;
            int temp = 0;

            foreach (String i in combobox.Items)
            {
                temp = TextRenderer.MeasureText(i, combobox.Font).Width;
                if (temp > max)
                    max = temp;
            }

            this.Width = max + 20;
        }

        public void triggerEntry(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                using (LabelEditor form = new LabelEditor())
                {
                    if (combobox.Items.Count > 0)
                    {
                        for (int i = 0; i < combobox.Items.Count; i++)
                        {
                            if (i < combobox.Items.Count - 1)
                                form.labelText += combobox.Items[i] + "\r\n";
                            else
                                form.labelText += combobox.Items[i];
                        }
                    }
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                    {
                        String result = form.labelText;
                        combobox.Items.Clear();
                        foreach (String line in result.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                        {
                            combobox.Items.Add(line);
                        }
                        if (combobox.Items.Count > 0)
                        {
                            rememberName = combobox.Items[0].ToString();
                            combobox.SelectedIndex = 0;
                            resizeBox();
                        }
                    }
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
                                textBox.label.Text = rememberName;
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
                                multitextBox.label.Text = rememberName;
                                multitextBox.Height = 78;
                                multitextBox.Draggable(true);
                                Parent.Controls.Add(multitextBox);
                                multitextBox.Location = this.Location;
                                multitextBox.Width = multitextBox.label.Width + multitextBox.textBox.Width;
                                Parent.Controls.Remove(this);
                                break;
                            case "Combobox":
                                break;
                            case "Checkbox":
                                EditableCheckbox checkbox = new EditableCheckbox();
                                checkbox.Text = rememberName;
                                checkbox.pdfAttribute = this.pdfAttribute;
                                checkbox.Parent = this.Parent;
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

        private void SizeWasChanged(object sender, EventArgs e)
        {
            this.Size = combobox.Size;
        }
    }

    public partial class ComboBoxer : ComboBox
    {
        public string pdfAttribute { get; set; }

        public void resizeBox()
        {
            int max = 0;
            int temp = 0;

            foreach (String i in this.Items)
            {
                temp = TextRenderer.MeasureText(i, this.Font).Width;
                if (temp > max)
                    max = temp;
            }

            this.Width = max + 20;
        }
    }
}
