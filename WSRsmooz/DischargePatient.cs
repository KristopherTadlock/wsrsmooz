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
        String[] stepDescriptions = { "Step 1: Complete all forms necessary for discharge.",
                                      "Step 2: Complete patient discharge now?"
                                    };
        Button[] stepButtons;

        dbConnect database = new dbConnect();
        private String query;
        private DataTable clients, form;
        private FormItem openForm;

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
            ClientNameLabel.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];
            ClientListComboBox.Parent = wizardTabs.TabPages[wizardTabs.SelectedIndex];

            if (wizardTabs.SelectedIndex > 0)
                ClientListComboBox.Enabled = false;
            else
                ClientListComboBox.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex > 0)
                wizardTabs.SelectedIndex--;
        }

        private void nextTab()
        {
            if (wizardTabs.SelectedIndex < wizardTabs.TabCount - 1)
                wizardTabs.SelectedIndex++;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (NextButton.Text != "Complete")
            {
                nextTab();
            }
            else
            {
                query = "update ClientInfo set ExitDate=\"" + dischargeDate.Value.ToString("yyyy-MM-dd") + "\", Success=";
                if (Successful.Checked)
                    query += "1";
                else
                    query += "0";
                query += " where ClientID=" + ((ClientItem) ClientListComboBox.SelectedItem).id;

                if (database.Query(query))
                {
                    MessageBox.Show(((ClientItem) ClientListComboBox.SelectedItem).clientName +
                                    " was successfully discharged.");

                    string temp = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                    temp += "completed discharge for " + ((ClientItem)ClientListComboBox.SelectedItem).clientName;
                    temp += ".\")";
                    database.Query(temp);

                    Successful.Checked = false;
                    wizardTabs.SelectedIndex = 0;
                    UpdateClientBox();
                }
                else
                {
                    MessageBox.Show("Could not discharge " + ((ClientItem) ClientListComboBox.SelectedItem).clientName + ".");
                }
            }
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

        private void UpdateClientBox()
        {
            ClientListComboBox.Items.Clear();
            foreach (DataRow row in clients.Rows)
            {
                ClientItem item = new ClientItem();
                item.id = row["ClientID"].ToString();
                item.clientName = row["ClientName"].ToString();
                ClientListComboBox.Items.Add(item);
            }
        }

        private void DischargePatient_Load(object sender, EventArgs e)
        {
            dischargeDate.Value = DateTime.Today;
            query = "select ClientID, ClientName from ClientInfo where IntakeDate not like '0001-01-01%' and ExitDate like '0001-01-01%'";
            clients = database.GetTable(query);
            UpdateClientBox();

            if (ClientListComboBox.Items.Count > 0)
                ClientListComboBox.SelectedIndex = 0;
        }

        private void ClientListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ClientListComboBox.SelectedItem.ToString().Equals(""))
            {
                foreach (Control button in wizardTabs.TabPages[0].Controls.OfType<Button>())
                    button.Enabled = true;
            }
        }

        public void blastOff(FormItem form, ClientItem client)
        {
            switch (form.id)
            {
                case "4": // Exit Bookkeeping
                    ((Form_ExitBookkeeping)form.form).client = client.id;
                    break;
                case "7": // Discharge Summary
                    ((Form_DischargeSummary)form.form).client = client.id;
                    break;
                case "25": // ASAM
                    ((Form_LinenAgreement)form.form).client = client.id;
                    break;
                case "26": // ASAM
                    ((Form_ASAM)form.form).client = client.id;
                    break;
                default:
                    return;
            }
            form.form.ShowDialog();
        }

        private void blastForm(string formid)
        {
            query = "select * from forms where FormID=" + formid;
            form = database.GetTable(query);

            openForm = new FormItem();
            openForm.id = form.Rows[0]["FormID"].ToString();
            openForm.name = form.Rows[0]["FormName"].ToString();
            openForm.panel = form.Rows[0]["Panel"].ToString();
            openForm.path = "/templates/" + form.Rows[0]["Path"].ToString() + ".pdf";

            switch (formid)
            {
                case "4":
                    openForm.form = new Form_ExitBookkeeping();
                    break;
                case "7":
                    openForm.form = new Form_DischargeSummary();
                    break;
                case "25":
                    openForm.form = new Form_LinenAgreement();
                    break;
                case "26":
                    openForm.form = new Form_ASAM();
                    break;
                default:
                    return;
            }

            blastOff(openForm, ((ClientItem)ClientListComboBox.SelectedItem));
        }

        private void dischargeBookkeeping_Click(object sender, EventArgs e)
        {
            blastForm("4");
        }

        private void dischargeASAM_Click(object sender, EventArgs e)
        {
            blastForm("26");
        }

        private void dischargeSummary_Click(object sender, EventArgs e)
        {
            blastForm("7");
        }

        private void clientSelfEvaluation_Click(object sender, EventArgs e)
        {
            blastForm("22");
        }

        private void safeKeepingAgreement_Click(object sender, EventArgs e)
        {
            blastForm("24");
        }

        private void linensAgreement_Click(object sender, EventArgs e)
        {
            blastForm("25");
        }
    }
}
