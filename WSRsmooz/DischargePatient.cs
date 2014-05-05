using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;

namespace WSRsmooz
{
    public partial class DischargePatient : Form
    {
        String[] stepDescriptions = { "Step 1: Discharge shit.",
                                      "Step 2: More of it."
                                    };
        Button[] stepButtons;

        public DischargePatient()
        {
            InitializeComponent();

            stepButtons = new Button[] { checklist_button1,
                                         checklist_button2
                                       };

            changeConstantsToTab(wizardTabs, null);
            //fillInactiveClientList();
        }

        private void changeConstantsToTab(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex == 0)
                BackButton.Visible = false;
            else
                BackButton.Visible = true;

            if (wizardTabs.SelectedIndex == wizardTabs.TabCount - 1)
            {
                NextButton.Text = "Complete";
            }
            else
                NextButton.Text = "Next";

            for (int i = 0; i <= wizardTabs.TabCount - 1; i++)
                if (wizardTabs.SelectedIndex > i)
                    stepButtons[i].BackColor = SystemColors.ActiveCaption;
                else if (wizardTabs.SelectedIndex == i)
                    stepButtons[i].BackColor = SystemColors.Highlight;
                else
                    stepButtons[i].BackColor = SystemColors.Control;

            instructions.Text = stepDescriptions[wizardTabs.SelectedIndex];
            instructions.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            BackButton.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            NextButton.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            CancelButton.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            wizardPicture.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            titleLabel.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex > 0)
                wizardTabs.SelectedIndex--;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex < wizardTabs.TabCount - 1)
                wizardTabs.SelectedIndex++;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // do closey things
            if (MessageBox.Show("Are you sure you want to cancel this intake? Your changes will not be saved.", "Cancel Patient Intake?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((Launcher)MdiParent).currentWindow = "";
                this.Close();
            }
        }
    }
}
