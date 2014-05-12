using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class EditableLabel : UserControl
    {
        public Boolean locked = false;

        public EditableLabel()
        {
            InitializeComponent();
            label.Size = this.Size;
            this.Draggable(true);
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return label.Text;
            }

            set
            {
                label.Text = value;
            }
        }

        private void label_SizeChanged(object sender, EventArgs e)
        {
            this.Size = label.Size;
        }

        public void triggerEntry(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                using (LabelEditor form = new LabelEditor())
                {
                    if (!label.Text.Equals("label"))
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
