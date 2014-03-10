using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WSRsmooz
{
    public partial class NewPatientIntake : Form
    {
        // option variables
        Color textBoxErrorColor = Color.PaleVioletRed;

        // mandatory variables
        Boolean tab1_valid = false;

        public NewPatientIntake()
        {
            InitializeComponent();
        }

        public void cancelNewPatientIntake()
        {
            // do closey things
            if (MessageBox.Show("Are you sure you want to cancel this intake? Your changes will not be saved.", "Cancel Patient Intake?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((Launcher)MdiParent).currentWindow = "";
                this.Close();
            }
            
        }

        private void newPatientIntakeWizard_tab1_button_cancel_Click(object sender, EventArgs e)
        {
            cancelNewPatientIntake();
        }

        public void validateTextBox(object sender, short type)
        {
            Regex regex;
            switch(type)
            {
                case 1:
                    // letters with space only, upper or lower ok
                    //regex = new Regex(@"^[a-zA-Z ]*$");
                    regex = new Regex(@"^([\w]+\s)*[\w]+$");
                    break;
                case 2:
                    // letters only, upper only
                    regex = new Regex(@"^[A-Z]*$");
                    break;
                case 3:
                    // numbers only
                    regex = new Regex(@"^[0-9]*$");
                    break;
                default:
                    regex = new Regex(@"*$");
                    break;
            }

            if (!regex.Match(((TextBox)sender).Text).Success)
                ((TextBox)sender).BackColor = textBoxErrorColor;
            else
                ((TextBox)sender).BackColor = Color.White;
        }

        public void backTab()
        {
            if (newPatientIntakeWizard.SelectedIndex > 0)
                newPatientIntakeWizard.SelectedIndex--;
        }

        public void nextTab()
        {
            if (newPatientIntakeWizard.SelectedIndex < newPatientIntakeWizard.TabCount - 1)
                newPatientIntakeWizard.SelectedIndex++;
        }

        private void newPatientIntakeWizard_tab1_textbox_firstName_TextChanged(object sender, EventArgs e)
        {
            validateTextBox(sender, 1);
        }

        private void newPatientIntakeWizard_tab1_textbox_lastName_TextChanged(object sender, EventArgs e)
        {
            validateTextBox(sender, 1);
        }

        private void newPatientIntakeWizard_tab1_textbox_middleInitial_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            validateTextBox(sender, 2);
        }

        private void newPatientIntakeWizard_tab1_textbox_city_TextChanged(object sender, EventArgs e)
        {
            validateTextBox(sender, 1);
        }

        private void newPatientIntakeWizard_tab1_textbox_zip_TextChanged(object sender, EventArgs e)
        {
            validateTextBox(sender, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backTab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextTab();
        }

        private void newPatientIntakeWizard_tab1_button_next_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in newPatientIntakeWizard.SelectedTab.Controls.OfType<TextBox>())
            {
                if (t.BackColor == textBoxErrorColor)
                {
                    MessageBox.Show("One or more fields contain invalid characters.");
                    return;
                }
            }
            nextTab();
        }

    }
}
