using System;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class LabelEditor : Form
    {
        public String labelText
        {
            get;
            set;
        }

        public LabelEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelText = textBox1.Text;
            this.DialogResult = DialogResult.Yes;
        }

        private void LabelEditor_Load(object sender, EventArgs e)
        {
            textBox1.Text = labelText;
        }


    }
}
