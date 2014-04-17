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
    public partial class Form_ClientScreeningForm : Form
    {
        public Form_ClientScreeningForm()
        {
            InitializeComponent();
        }

        private void PrimaryPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            PrimaryPhoneNumber.Text = String.Format("{0:(###) ###-####}", PrimaryPhoneNumber.Text);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
