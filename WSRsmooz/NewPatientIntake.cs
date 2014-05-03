using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WSRsmooz
{
    public partial class NewPatientIntake : Form
    {
        // optional variables
        Color textBoxErrorColor = Color.PaleVioletRed;
        String[] stepDescriptions = { "Step 1: Enter basic client information.",
                                      "Step 2: Continue entering basic client information.",
                                      "Step 3: Enter client emergency contact information.",
                                      "Step 4: Enter agency/referral information.",
                                      "Step 5: Enter client legal information.",
                                      "Step 6: Enter client health information.",
                                      "Step 7: Continue entering client health information.",
                                      "Step 8: Participants are required to be clean and sober for 72 hours."
                                    };

        Button[] stepButtons;

        // mandatory variables
        Boolean tab1_valid = false;

        public NewPatientIntake()
        {
            InitializeComponent();
            stepButtons = new Button[] { NewPatientIntake_checklist_button_tab1,
                                         NewPatientIntake_checklist_button_tab2,
                                         NewPatientIntake_checklist_button_tab3,
                                         NewPatientIntake_checklist_button_tab4,
                                         NewPatientIntake_checklist_button_tab5,
                                         NewPatientIntake_checklist_button_tab6,
                                         NewPatientIntake_checklist_button_tab7,
                                         NewPatientIntake_checklist_button_tab8
                                       };
            changeConstantsToTab(newPatientIntakeWizard, null);
        }

        public void cancelNewPatientIntake(object sender, EventArgs e)
        {
            // do closey things
            if (MessageBox.Show("Are you sure you want to cancel this intake? Your changes will not be saved.", "Cancel Patient Intake?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((Launcher)MdiParent).currentWindow = "";
                this.Close();
            }
            
        }

        public void validateTextBox(object sender, short type)
        {
            Regex regex;
            switch(type)
            {
                case 1:
                    // letters with space only, upper or lower ok
                    //regex = new Regex(@"^[a-zA-Z ]*$");
                    regex = new Regex(@"^([a-zA-Z]+\s)*[a-zA-Z]+$");
                    break;
                case 2:
                    // letters only, upper only
                    regex = new Regex(@"^[A-Z]*$");
                    break;
                case 3:
                    // numbers only
                    regex = new Regex(@"^[0-9]*$");
                    break;
                case 4:
                    // letters or numbers with space, upper or lower ok
                    regex = new Regex(@"^([\w.]+\s)*[\w.]+$");
                    break;
                case 5:
                    // phone numbers
                    regex = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
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

        public void backTab(object sender, EventArgs e)
        {
            if (newPatientIntakeWizard.SelectedIndex > 0)
                newPatientIntakeWizard.SelectedIndex--;
        }

        public void nextTab()
        {
            if (newPatientIntakeWizard.SelectedIndex < newPatientIntakeWizard.TabCount - 1)
                newPatientIntakeWizard.SelectedIndex++;
        }

        private void changeConstantsToTab(object sender, EventArgs e)
        {
            if (newPatientIntakeWizard.SelectedIndex == 0)
                newPatientIntakeWizard_button_back.Visible = false;
            else
                newPatientIntakeWizard_button_back.Visible = true;

            if (newPatientIntakeWizard.SelectedIndex == newPatientIntakeWizard.TabCount - 1)
            {
                newPatientIntakeWizard_button_next.Text = "Complete";
            }
            else
                newPatientIntakeWizard_button_next.Text = "Next";

            for (int i = 0; i <= newPatientIntakeWizard.TabCount - 1; i++)
                if (newPatientIntakeWizard.SelectedIndex > i)
                    stepButtons[i].BackColor = SystemColors.ActiveCaption;
                else if (newPatientIntakeWizard.SelectedIndex == i)
                    stepButtons[i].BackColor = SystemColors.Highlight;
                else
                    stepButtons[i].BackColor = SystemColors.Control;

            newPatientIntakeWizard_label_instructions.Text = stepDescriptions[newPatientIntakeWizard.SelectedIndex];

            newPatientIntakeWizard_label_instructions.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
            newPatientIntakeWizard_button_back.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
            newPatientIntakeWizard_button_next.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
            newPatientIntakeWizard_button_cancel.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
            newPatientIntakeWizard_picturebox_wizard.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
            newPatientIntakeWizard_label_title.Parent = newPatientIntakeWizard.TabPages[newPatientIntakeWizard.SelectedIndex];
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

        private void validateLettersNumbers(object sender, EventArgs e)
        {
            validateTextBox(sender, 4);
        }

        private void validateNumbers(object sender, EventArgs e)
        {
            validateTextBox(sender, 3);
        }

        private void validateLettersUpper(object sender, EventArgs e)
        {
            validateTextBox(sender, 2);
        }

        private void validateLettersWithSpaces(object sender, EventArgs e)
        {
            validateTextBox(sender, 1);
        }

        private void validatePhoneNumber(object sender, EventArgs e)
        {
            validateTextBox(sender, 5);
        }

        private void stopIntake(object sender, EventArgs e)
        {
            if (newPatientIntakeWizard_tab8_checkbox_arson.Checked || newPatientIntakeWizard_tab8_checkbox_sexualCrime.Checked)
            {
                newPatientIntakeWizard_tab8_label_stop.Visible = true;
                newPatientIntakeWizard_tab8_label_stop2.Visible = true;
                newPatientIntakeWizard_button_next.Enabled = false;
            } else
            {
                newPatientIntakeWizard_tab8_label_stop.Visible = false;
                newPatientIntakeWizard_tab8_label_stop2.Visible = false;
                newPatientIntakeWizard_button_next.Enabled = true;
            }
        }

    }
}
