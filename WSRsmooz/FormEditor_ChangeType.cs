using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class FormEditor_ChangeType : Form
    {
        public string result;

        public FormEditor_ChangeType()
        {
            InitializeComponent();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            result = "Textbox";
            this.DialogResult = DialogResult.Yes;
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            result = "BigTextbox";
            this.DialogResult = DialogResult.Yes;
        }

        private void ComboButton_Click(object sender, EventArgs e)
        {
            result = "Combobox";
            this.DialogResult = DialogResult.Yes;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            result = "Checkbox";
            this.DialogResult = DialogResult.Yes;
        }
    }
}
