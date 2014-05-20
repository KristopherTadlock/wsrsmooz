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
                                      "Step 8: Participants are required to be clean and sober for 72 hours.",
                                      "Step 9: ASAM. Enter basic information to analyze need.",
                                      "Step 10: ASAM. Continue entering information.",
                                      "Step 11: ASAM. Level of function analysis.",
                                      "Step 12: Enter client's current prescriptions.",
                                      "Step 13: Provide an intake date or leave blank to wait!"
                                    };
        Button[] stepButtons;

        // mandatory variables
        Dictionary<string, string> screeningChanges;
        Dictionary<string, string> asamChanges;
        dbConnect database = new dbConnect();
        DataTable inactiveClients = new DataTable();

        // just pdf-y things
        PdfReader pdfReader;
        PdfStamper pdfStamper;
        AcroFields pdfFormFields;
        string screeningPDF = "templates/1-Screening & Client Information.pdf";
        string asamPDF = "templates/2-ASAM.pdf";
        string newScreening, newASAM;
        Random rng = new Random();

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
                                         NewPatientIntake_checklist_button_tab8,
                                         NewPatientIntake_checklist_button_tab9,
                                         NewPatientIntake_checklist_button_tab10,
                                         NewPatientIntake_checklist_button_tab11,
                                         NewPatientIntake_checklist_button_tab12,
                                         NewPatientIntake_checklist_button_tab13
                                       };
            changeConstantsToTab(newPatientIntakeWizard, null);

            int rand = rng.Next(int.MaxValue);
            newScreening = Convert.ToString(rand) + ".pdf";
            newASAM = Convert.ToString(rng.Next(rand)) + ".pdf";
            fillInactiveClientList();
        }

        private void fillInactiveClientList()
        {
            newPatientIntakeWizard_tab1_listbox_inactiveclients.Items.Clear();

            String query = "select ClientNum, ClientName from ClientInfo where IntakeDate LIKE '0001-01-01%' and ExitDate like '0001-01-01%'";
            inactiveClients = database.GetTable(query);

            foreach (DataRow row in inactiveClients.Rows)
            {
                ClientItem item = new ClientItem();
                item.id = row["ClientNum"].ToString();
                item.clientName = row["ClientName"].ToString();
                newPatientIntakeWizard_tab1_listbox_inactiveclients.Items.Add(item);
            }
            if (newPatientIntakeWizard_tab1_listbox_inactiveclients.Items.Count > 0)
                newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedIndex = 0;
        }

        private void newPatientIntakeWizard_tab1_button_removeclient_Click(object sender, EventArgs e)
        {
            if (newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItems.Count > 0)
            {
                String query = "delete from ClientInfo where ClientNum=";
                query += ((ClientItem)newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItem).id;

                if (database.Query(query))
                    fillInactiveClientList();
            }
        }

        private void newPatientIntakeWizard_tab1_button_giveintakedate_Click(object sender, EventArgs e)
        {
            if (newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItems.Count > 0)
            {
                String query = "update ClientInfo set IntakeDate=\"";
                query += newPatientIntakeWizard_tab1_datetimepicker_intakedate.Value.ToString("yyyy-MM-dd");
                query += "\" where ClientNum=";
                query += ((ClientItem)newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItem).id;
                String mbox = ((ClientItem)newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItem).clientName;

                if (database.Query(query))
                {
                    mbox += "'s intake is now complete. Client will appear in the patient log.";
                    string temp = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                    temp += "finished intake for " + ((ClientItem)newPatientIntakeWizard_tab1_listbox_inactiveclients.SelectedItem).clientName;
                    temp += ".\")";
                    database.Query(temp);
                }
                else
                    mbox += "'s intake could not be added to the database.";
                MessageBox.Show(mbox);

                fillInactiveClientList();
            }
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
            if (newPatientIntakeWizard_button_next.Text != "Complete")
            {
                nextTab();
            }
            else
            {
                completeForm();
                stampASAM();
                stampScreening();
                printPdfs();
            }
        }

        public void printPdfs()
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "printpdf.exe";
            proc.StartInfo.Arguments = "-print-dialog -exit-on-print \"" + newScreening + "\"";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            proc.WaitForExit();
            proc.StartInfo.Arguments = "-print-dialog -exit-on-print \"" + newASAM + "\"";
            proc.Start();
            proc.WaitForExit();

            if (File.Exists(newScreening))
                File.Delete(newScreening);
            if (File.Exists(newASAM))
                File.Delete(newASAM);
        }

        private void stampScreening()
        {
            if (!File.Exists(newScreening))
            {
                pdfReader = new PdfReader(screeningPDF);
            }
            else
            {
                MessageBox.Show("Error creating file.");
                return;
            }

            pdfStamper = new PdfStamper(pdfReader, new FileStream(newScreening, FileMode.Create));
            pdfFormFields = pdfStamper.AcroFields;

            foreach (KeyValuePair<string, string> pair in screeningChanges)
            {
                pdfFormFields.SetField(pair.Key, pair.Value);
            }

            pdfStamper.Close();
            pdfReader.Close();
        }

        private void stampASAM()
        {
            if (!File.Exists(newASAM))
            {
                pdfReader = new PdfReader(asamPDF);
            }
            else
            {
                MessageBox.Show("Error creating file.");
                return;
            }

            pdfStamper = new PdfStamper(pdfReader, new FileStream(newASAM, FileMode.Create));
            pdfFormFields = pdfStamper.AcroFields;

            foreach (KeyValuePair<string, string> pair in asamChanges)
            {
                pdfFormFields.SetField(pair.Key, pair.Value);
            }

            pdfStamper.Close();
            pdfReader.Close();
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
            if (newPatientIntakeWizard.SelectedIndex == 7)
            {
                if (newPatientIntakeWizard_tab8_checkbox_arson.Checked || newPatientIntakeWizard_tab8_checkbox_sexualCrime.Checked)
                {
                    newPatientIntakeWizard_tab8_label_stop.Visible = true;
                    newPatientIntakeWizard_tab8_label_stop2.Visible = true;
                    newPatientIntakeWizard_button_next.Enabled = false;
                }
                else
                {
                    newPatientIntakeWizard_tab8_label_stop.Visible = false;
                    newPatientIntakeWizard_tab8_label_stop2.Visible = false;
                    newPatientIntakeWizard_button_next.Enabled = true;
                }
            }
            else if (newPatientIntakeWizard.SelectedIndex == 8)
            {
                if ((newPatientIntakeWizard_tab9_checkbox_1a.Checked && newPatientIntakeWizard_tab9_checkbox_1b.Checked)
                    || newPatientIntakeWizard_tab9_checkbox_2.Checked || newPatientIntakeWizard_tab9_checkbox_3.Checked)
                {
                    newPatientIntakeWizard_tab9_label_emergency.Visible = true;
                }
                else
                {
                    newPatientIntakeWizard_tab9_label_emergency.Visible = false;
                }
            }
            else if (newPatientIntakeWizard.SelectedIndex == 9)
            {
                if (newPatientIntakeWizard_tab10_checkbox_4a.Checked || newPatientIntakeWizard_tab10_checkbox_4b.Checked)
                {
                    newPatientIntakeWizard_tab10_label_emergency.Visible = true;
                }
                else
                {
                    newPatientIntakeWizard_tab10_label_emergency.Visible = false;
                }

                if (newPatientIntakeWizard_tab10_checkbox_5a.Checked)
                {
                    newPatientIntakeWizard_tab10_label_emergency2.Visible = true;
                }
                else
                {
                    newPatientIntakeWizard_tab10_label_emergency2.Visible = false;
                }

                if (newPatientIntakeWizard_tab10_checkbox_6.Checked || newPatientIntakeWizard_tab10_checkbox_5b.Checked)
                {
                    newPatientIntakeWizard_tab10_label_emergency3.Visible = true;
                }
                else
                {
                    newPatientIntakeWizard_tab10_label_emergency3.Visible = false;
                }
            }
        }

        private string cbString(CheckBox checkbox)
        {
            if (checkbox.Checked)
                return "X";
            return "";
        }

        private bool cbBool(CheckBox checkbox)
        {
            if (checkbox.Checked)
                return true;
            return false;
        }

        private void completeForm()
        {
            screeningChanges = new Dictionary<string, string>();
            asamChanges = new Dictionary<string, string>();

            //
            //
            //
            // Changes below.
            //
            //
            //

            // tab 1
            int age = DateTime.Today.Year - newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Value.Year;
            if (newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Value > DateTime.Today.AddYears(-age)) age--;

            screeningChanges.Add("ClientNameFirst", newPatientIntakeWizard_tab1_textbox_firstName.Text);
            screeningChanges.Add("ClientNameLast", newPatientIntakeWizard_tab1_textbox_lastName.Text);
            screeningChanges.Add("DoB", newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Value.ToString("mm/dd/YY"));
            screeningChanges.Add("Age", age.ToString());
            screeningChanges.Add("ClientAddr", newPatientIntakeWizard_tab1_textbox_streetAddress.Text);
            screeningChanges.Add("ClientCity", newPatientIntakeWizard_tab1_textbox_city.Text);
            screeningChanges.Add("ClientState", newPatientIntakeWizard_tab1_combobox_state.Text);
            screeningChanges.Add("ClientZip", newPatientIntakeWizard_tab1_textbox_zip.Text);
            screeningChanges.Add("County", newPatientIntakeWizard_tab1_textbox_county.Text);
            screeningChanges.Add("numYears", newPatientIntakeWizard_tab1_textbox_yearsResided.Text);

            asamChanges.Add("ClientName", newPatientIntakeWizard_tab1_textbox_firstName.Text + " " + newPatientIntakeWizard_tab1_textbox_lastName.Text);
            asamChanges.Add("IntDate", DateTime.Today.ToString("mm/dd/YY"));

            // tab 2
            screeningChanges.Add("Vet", cbString(newPatientIntakeWizard_tab2_checkbox_veteran));
            screeningChanges.Add("SSN", newPatientIntakeWizard_tab2_textbox_ssn.Text);
            screeningChanges.Add("DL", newPatientIntakeWizard_tab2_textbox_dlnumber.Text);
            screeningChanges.Add("DLS", newPatientIntakeWizard_tab2_combobox_dlstate.Text);
            screeningChanges.Add("MAR", newPatientIntakeWizard_tab2_textbox_maritalStatus.Text);
            screeningChanges.Add("Partner", newPatientIntakeWizard_tab2_textbox_partnersName.Text);
            screeningChanges.Add("ClientPhone", newPatientIntakeWizard_tab2_textbox_primaryPhone.Text);
            screeningChanges.Add("ClientWCM", newPatientIntakeWizard_tab2_textbox_secondPhone.Text);

            // tab 3
            screeningChanges.Add("EName", newPatientIntakeWizard_tab3_textbox_emergencyContactName.Text);
            screeningChanges.Add("ERel", newPatientIntakeWizard_tab3_textbox_emergencyRelationship.Text);
            screeningChanges.Add("EPhone", newPatientIntakeWizard_tab3_textbox_emergencyPrimaryPhone.Text);
            screeningChanges.Add("Eaddr", newPatientIntakeWizard_tab3_textbox_emergencyAddress.Text);
            screeningChanges.Add("ECity", newPatientIntakeWizard_tab3_textbox_emergencyCity.Text);
            screeningChanges.Add("EState", newPatientIntakeWizard_tab3_textbox_emergencyState.Text);
            screeningChanges.Add("EZip", newPatientIntakeWizard_tab3_textbox_emergencyZip.Text);
            screeningChanges.Add("ECWPhone", newPatientIntakeWizard_tab3_textbox_emergencySecondPhone.Text);

            // tab 4
            screeningChanges.Add("AName", newPatientIntakeWizard_tab4_textbox_agencyName.Text);
            screeningChanges.Add("ACPName", newPatientIntakeWizard_tab4_textbox_agencyContactName.Text);
            screeningChanges.Add("ACounty", newPatientIntakeWizard_tab4_textbox_agencyCounty.Text);
            screeningChanges.Add("ACPnumber", newPatientIntakeWizard_tab4_textbox_agencyPrimaryPhone.Text);
            screeningChanges.Add("AAddr", newPatientIntakeWizard_tab4_textbox_agencyAddress.Text);
            screeningChanges.Add("ACity", newPatientIntakeWizard_tab4_textbox_agencyCity.Text);
            screeningChanges.Add("AState", newPatientIntakeWizard_tab4_combobox_agencyState.Text);
            screeningChanges.Add("AZIP", newPatientIntakeWizard_tab4_textbox_agencyZip.Text);
            screeningChanges.Add("ACnumber", newPatientIntakeWizard_tab4_textbox_agencySecondPhone.Text);

            // tab 5
            screeningChanges.Add("Pris", cbString(newPatientIntakeWizard_tab5_checkbox_paroleProbation));
            screeningChanges.Add("Par", cbString(newPatientIntakeWizard_tab5_checkbox_jailPrison));
            screeningChanges.Add("PStatmt", newPatientIntakeWizard_tab5_textbox_paroleReason.Text);
            screeningChanges.Add("POName", newPatientIntakeWizard_tab5_textbox_paroleOfficerName.Text);
            screeningChanges.Add("POAddr", newPatientIntakeWizard_tab5_textbox_paroleOfficerAddress.Text);
            screeningChanges.Add("POCphone", newPatientIntakeWizard_tab5_textbox_paroleOfficerPhone.Text);

            // tab 6
            screeningChanges.Add("PHDdays", cbString(newPatientIntakeWizard_tab6_checkbox_physicalHospitalization));
            screeningChanges.Add("PHwhy", newPatientIntakeWizard_tab6_textbox_physicalHospitalizationReason.Text);
            screeningChanges.Add("MHdays", cbString(newPatientIntakeWizard_tab6_checkbox_mentalHospitalization));
            screeningChanges.Add("MHwhy", newPatientIntakeWizard_tab6_textbox_mentalHospitalizationReason.Text);
            screeningChanges.Add("IVU", cbString(newPatientIntakeWizard_tab6_checkbox_ivUsed));
            screeningChanges.Add("PT", cbString(newPatientIntakeWizard_tab6_checkbox_priorTreatment));
            screeningChanges.Add("HMT", newPatientIntakeWizard_tab6_textbox_priorTreatmentAmount.Text);
            screeningChanges.Add("WWTreat", newPatientIntakeWizard_tab6_textbox_priorTreatmentWhereWhen.Text);

            // tab 7
            screeningChanges.Add("Substance1", newPatientIntakeWizard_tab7_textbox_substance1name.Text);
            screeningChanges.Add("Substance2", newPatientIntakeWizard_tab7_textbox_substance2name.Text);
            screeningChanges.Add("Substance3", newPatientIntakeWizard_tab7_textbox_substance3name.Text);
            screeningChanges.Add("DLU1", newPatientIntakeWizard_tab7_datetimepicker_substance1lastuse.Value.ToString("mm/dd/YY"));
            screeningChanges.Add("DLU2", newPatientIntakeWizard_tab7_datetimepicker_substance2lastuse.Value.ToString("mm/dd/YY"));
            screeningChanges.Add("DLU3", newPatientIntakeWizard_tab7_datetimepicker_substance3lastuse.Value.ToString("mm/dd/YY"));
            screeningChanges.Add("Freq1", newPatientIntakeWizard_tab7_textbox_substance1frequency.Text);
            screeningChanges.Add("Freq2", newPatientIntakeWizard_tab7_textbox_substance2frequency.Text);
            screeningChanges.Add("Freq3", newPatientIntakeWizard_tab7_textbox_substance3frequency.Text);
            screeningChanges.Add("Amount1", newPatientIntakeWizard_tab7_textbox_substance1amount.Text);
            screeningChanges.Add("Amount2", newPatientIntakeWizard_tab7_textbox_substance2amount.Text);
            screeningChanges.Add("Amount3", newPatientIntakeWizard_tab7_textbox_substance3amount.Text);
            screeningChanges.Add("Method1", newPatientIntakeWizard_tab7_textbox_substance1method.Text);
            screeningChanges.Add("Method2", newPatientIntakeWizard_tab7_textbox_substance2method.Text);
            screeningChanges.Add("Method3", newPatientIntakeWizard_tab7_textbox_substance3method.Text);

            // tab 8
            screeningChanges.Add("CrimeS", cbString(newPatientIntakeWizard_tab8_checkbox_sexualCrime));
            screeningChanges.Add("CrimeA", cbString(newPatientIntakeWizard_tab8_checkbox_arson));
            screeningChanges.Add("Referrals", newPatientIntakeWizard_tab8_textbox_referrals.Text);

            // ASAM
            // tab 9
            asamChanges.Add("PhInt", cbString(newPatientIntakeWizard_tab9_checkbox_phoneInterview));
            asamChanges.Add("Admit", cbString(newPatientIntakeWizard_tab9_checkbox_admit));
            asamChanges.Add("DuringTX", cbString(newPatientIntakeWizard_tab9_checkbox_duringtx));

            if (cbBool(newPatientIntakeWizard_tab9_checkbox_1a))
                asamChanges.Add("immTriageOneAyes", "X");
            else
                asamChanges.Add("immTriageOneAno", "X");

            if (cbBool(newPatientIntakeWizard_tab9_checkbox_1b))
                asamChanges.Add("immTriageOneByes", "X");
            else
                asamChanges.Add("immTriageOneBno", "X");

            if (cbBool(newPatientIntakeWizard_tab9_checkbox_2))
                asamChanges.Add("immTriageTwoyes", "X");
            else
                asamChanges.Add("immTriageTwono", "X");

            if (cbBool(newPatientIntakeWizard_tab9_checkbox_3))
                asamChanges.Add("immTriageThreeyes", "X");
            else
                asamChanges.Add("immTriageThreeno", "X");

            // tab 10
            if (cbBool(newPatientIntakeWizard_tab10_checkbox_4a))
                asamChanges.Add("immTriageFourAyes", "X");
            else
                asamChanges.Add("immTriageFourAno", "X");

            if (cbBool(newPatientIntakeWizard_tab10_checkbox_4b))
                asamChanges.Add("immTriageFourByes", "X");
            else
                asamChanges.Add("immTriageFourBno", "X");

            if (cbBool(newPatientIntakeWizard_tab10_checkbox_5a))
                asamChanges.Add("immTriageFiveAyes", "X");
            else
                asamChanges.Add("immTriageFiveAno", "X");

            if (cbBool(newPatientIntakeWizard_tab10_checkbox_5b))
                asamChanges.Add("immTriageFiveByes", "X");
            else
                asamChanges.Add("immTriageFiveBno", "X");

            if (cbBool(newPatientIntakeWizard_tab10_checkbox_6))
                asamChanges.Add("immTriageSixyes", "X");
            else
                asamChanges.Add("immTriageSixno", "X");

            // tab 11
            // ASAM table
            int A, B, C, D, E, F, G, H, I, J, K, L, M;
            A = B = C = D = E = F = G = H = I = J = K = L = M = 0;

            switch (newPatientIntakeWizard_tab11_combobox_1.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionOneH", "High");
                    asamChanges.Add("1", "X"); A++;
                    asamChanges.Add("47", "X"); F++;
                    asamChanges.Add("59", "X"); G++;
                    asamChanges.Add("71", "X"); H++;
                    asamChanges.Add("82", "X"); I++;
                    asamChanges.Add("93", "X"); J++;
                    asamChanges.Add("103", "X"); K++;
                    asamChanges.Add("112", "X"); L++;
                    asamChanges.Add("122", "X"); M++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionOneM", "Moderate");
                    asamChanges.Add("2", "X"); A++;
                    asamChanges.Add("12", "X"); B++;
                    asamChanges.Add("24", "X"); C++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionOneL", "Low");
                    asamChanges.Add("13", "X"); B++;
                    asamChanges.Add("25", "X"); C++;
                    asamChanges.Add("33", "X"); D++;
                    asamChanges.Add("43", "X"); E++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_2.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionTwoH", "High");
                    asamChanges.Add("3", "X"); A++;
                    asamChanges.Add("48", "X"); F++;
                    asamChanges.Add("60", "X"); G++;
                    asamChanges.Add("72", "X"); H++;
                    asamChanges.Add("83", "X"); I++;
                    asamChanges.Add("94", "X"); J++;
                    asamChanges.Add("104", "X"); K++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionTwoM", "Moderate");
                    asamChanges.Add("4", "X"); A++;
                    asamChanges.Add("14", "X"); B++;
                    asamChanges.Add("26", "X"); C++;
                    asamChanges.Add("34", "X"); D++;
                    asamChanges.Add("49", "X"); F++;
                    asamChanges.Add("61", "X"); G++;
                    asamChanges.Add("73", "X"); H++;
                    asamChanges.Add("84", "X"); I++;
                    asamChanges.Add("95", "X"); J++;
                    asamChanges.Add("105", "X"); K++;
                    asamChanges.Add("113", "X"); L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionTwoL", "Low");
                    asamChanges.Add("15", "X"); B++;
                    asamChanges.Add("35", "X"); D++;
                    asamChanges.Add("44", "X"); E++;
                    asamChanges.Add("114", "X"); L++;
                    asamChanges.Add("123", "X"); M++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_3.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionThreeH", "High");
                    asamChanges.Add("5", "X"); A++;
                    asamChanges.Add("50", "X"); F++;
                    asamChanges.Add("62", "X"); G++;
                    asamChanges.Add("74", "X"); H++;
                    asamChanges.Add("96", "X"); J++;
                    asamChanges.Add("106", "X"); K++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionThreeM", "Moderate");
                    asamChanges.Add("6", "X"); A++;
                    asamChanges.Add("16", "X"); B++;
                    asamChanges.Add("27", "X"); C++;
                    asamChanges.Add("36", "X"); D++;
                    asamChanges.Add("45", "X"); E++;
                    asamChanges.Add("51", "X"); F++;
                    asamChanges.Add("63", "X"); G++;
                    asamChanges.Add("75", "X"); H++;
                    asamChanges.Add("86", "X"); I++;
                    asamChanges.Add("97", "X"); J++;
                    asamChanges.Add("107", "X"); K++;
                    asamChanges.Add("115", "X"); L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionThreeL", "Low");
                    asamChanges.Add("17", "X"); B++;
                    asamChanges.Add("37", "X"); D++;
                    asamChanges.Add("46", "X"); E++;
                    asamChanges.Add("116", "X"); L++;
                    asamChanges.Add("124", "X"); M++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_4.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionFourH", "High");
                    asamChanges.Add("7", "X"); A++;
                    asamChanges.Add("52", "X"); F++;
                    asamChanges.Add("64", "X"); G++;
                    asamChanges.Add("76", "X"); H++;
                    asamChanges.Add("87", "X"); I++;
                    asamChanges.Add("98", "X"); J++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionFourM", "Moderate");
                    asamChanges.Add("8", "X"); A++;
                    asamChanges.Add("18", "X"); B++;
                    asamChanges.Add("28", "X"); C++;
                    asamChanges.Add("38", "X"); D++;
                    asamChanges.Add("53", "X"); F++;
                    asamChanges.Add("65", "X"); G++;
                    asamChanges.Add("77", "X"); H++;
                    asamChanges.Add("88", "X"); I++;
                    asamChanges.Add("99", "X"); J++;
                    asamChanges.Add("108", "X"); K++;
                    asamChanges.Add("117", "X"); L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionFourL", "Low");
                    asamChanges.Add("19", "X"); B++;
                    asamChanges.Add("29", "X"); C++;
                    asamChanges.Add("39", "X"); D++;
                    asamChanges.Add("54", "X"); F++;
                    asamChanges.Add("66", "X"); G++;
                    asamChanges.Add("109", "X"); K++;
                    asamChanges.Add("118", "X"); L++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_5.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionFiveH", "High");
                    asamChanges.Add("9", "X"); A++;
                    asamChanges.Add("20", "X"); B++;
                    asamChanges.Add("55", "X"); F++;
                    asamChanges.Add("67", "X"); G++;
                    asamChanges.Add("100", "X"); J++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionFiveM", "Moderate");
                    asamChanges.Add("21", "X"); B++;
                    asamChanges.Add("30", "X"); C++;
                    asamChanges.Add("40", "X"); D++;
                    asamChanges.Add("56", "X"); F++;
                    asamChanges.Add("68", "X"); G++;
                    asamChanges.Add("78", "X"); H++;
                    asamChanges.Add("89", "X"); I++;
                    asamChanges.Add("101", "X"); J++;
                    asamChanges.Add("119", "X"); L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionFiveL", "Low");
                    asamChanges.Add("31", "X"); C++;
                    asamChanges.Add("41", "X"); D++;
                    asamChanges.Add("79", "X"); H++;
                    asamChanges.Add("90", "X"); I++;
                    asamChanges.Add("110", "X"); K++;
                    asamChanges.Add("120", "X"); L++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_6.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionSixH", "High");
                    asamChanges.Add("10", "X"); A++;
                    asamChanges.Add("22", "X"); B++;
                    asamChanges.Add("57", "X"); F++;
                    asamChanges.Add("69", "X"); G++;
                    asamChanges.Add("80", "X"); H++;
                    asamChanges.Add("91", "X"); I++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionSixM", "Moderate");
                    asamChanges.Add("11", "X"); A++;
                    asamChanges.Add("23", "X"); B++;
                    asamChanges.Add("58", "X"); F++;
                    asamChanges.Add("70", "X"); G++;
                    asamChanges.Add("81", "X"); H++;
                    asamChanges.Add("92", "X"); I++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionSixL", "Low");
                    asamChanges.Add("32", "X"); C++;
                    asamChanges.Add("42", "X"); D++;
                    asamChanges.Add("102", "X"); J++;
                    asamChanges.Add("111", "X"); K++;
                    asamChanges.Add("121", "X"); L++;
                    break;
                default:
                    break;
            }
                asamChanges.Add("A", A.ToString());
                asamChanges.Add("B", B.ToString());
                asamChanges.Add("C", C.ToString());
                asamChanges.Add("D", D.ToString());
                asamChanges.Add("E", E.ToString());
                asamChanges.Add("F", F.ToString());
                asamChanges.Add("G", G.ToString());
                asamChanges.Add("H", H.ToString());
                asamChanges.Add("I", I.ToString());
                asamChanges.Add("J", J.ToString());
                asamChanges.Add("K", K.ToString());
                asamChanges.Add("L", L.ToString());
                asamChanges.Add("M", M.ToString());

            // Screening!
            // tab 12
            screeningChanges.Add("ASAMLim", cbString(newPatientIntakeWizard_tab12_checkbox_physicalLimitations));
            screeningChanges.Add("ASAMlimEx", newPatientIntakeWizard_tab12_textbox_describeLimits.Text);
            screeningChanges.Add("Meds1", newPatientIntakeWizard_tab12_textbox_medication1.Text);
            screeningChanges.Add("Meds2", newPatientIntakeWizard_tab12_textbox_medication2.Text);
            screeningChanges.Add("Meds3", newPatientIntakeWizard_tab12_textbox_medication3.Text);
            screeningChanges.Add("Dos1", newPatientIntakeWizard_tab12_textbox_dosage1.Text);
            screeningChanges.Add("Dos2", newPatientIntakeWizard_tab12_textbox_dosage2.Text);
            screeningChanges.Add("Dos3", newPatientIntakeWizard_tab12_textbox_dosage3.Text);
            screeningChanges.Add("Diag1", newPatientIntakeWizard_tab12_textbox_diagnosis1.Text);
            screeningChanges.Add("Diag2", newPatientIntakeWizard_tab12_textbox_diagnosis2.Text);
            screeningChanges.Add("Diag3", newPatientIntakeWizard_tab12_textbox_diagnosis3.Text);
            
            // Finally, database shit.
            String query = "insert into ClientInfo (";

            if (newPatientIntakeWizard_tab13_checkbox_intakeornot.Checked)
                query += "ClientNum, ";

            query += "IntakeDate, ClientName, DoB, Age, County, ClientCity, ClientAddr, ClientState, ClientZip, ";
            query += "ClientPhone, SecPhone, AName, AAddr, ACPName, ACPNumber, Funder, Gender, Race, Ethinicity) values(\"";
            string temp = "";
            if (newPatientIntakeWizard_tab13_checkbox_intakeornot.Checked)
            {
                String getClientNum = database.SelectString("select max(ClientNum) from ClientInfo");
                int intClientNum = Convert.ToInt32(getClientNum) + 1;

                query += intClientNum.ToString() + "\", \"";
                query += newPatientIntakeWizard_tab13_datetimepicker_intakeDate.Value.ToString("yyyy-MM-dd") + "\", \"";

                temp = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                temp += "admitted client " + newPatientIntakeWizard_tab1_textbox_firstName.Text + " " + newPatientIntakeWizard_tab1_textbox_lastName.Text;
                temp += ".\")";
                database.Query(temp);
            }
            else
            {
                query += "0001-01-01\", \"";

                temp = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                temp += "partially intook " + newPatientIntakeWizard_tab1_textbox_firstName.Text + " " + newPatientIntakeWizard_tab1_textbox_lastName.Text;
                temp += ".\")";
                database.Query(temp);
            }

            query += newPatientIntakeWizard_tab1_textbox_firstName.Text + " " + newPatientIntakeWizard_tab1_textbox_lastName.Text + "\",\"";
            query += newPatientIntakeWizard_tab1_datetimepicker_dateOfBirth.Value.ToString("yyyy-MM-dd") + "\",";
            query += age.ToString() + ",";
            query += "\"" + newPatientIntakeWizard_tab1_textbox_county.Text;
            query += "\", \"" + newPatientIntakeWizard_tab1_textbox_city.Text;
            query += "\", \"" + newPatientIntakeWizard_tab1_textbox_streetAddress.Text;
            query += "\", \"" + newPatientIntakeWizard_tab1_combobox_state.Text;
            query += "\", \"" + newPatientIntakeWizard_tab1_textbox_zip.Text;
            query += "\", \"" + newPatientIntakeWizard_tab2_textbox_primaryPhone.Text;
            query += "\", \"" + newPatientIntakeWizard_tab2_textbox_secondPhone.Text;
            query += "\", \"" + newPatientIntakeWizard_tab4_textbox_agencyName.Text;
            query += "\", \"" + newPatientIntakeWizard_tab4_textbox_agencyAddress.Text;
            query += "\", \"" + newPatientIntakeWizard_tab4_textbox_agencyContactName.Text;
            query += "\", \"" + newPatientIntakeWizard_tab4_textbox_agencyPrimaryPhone.Text;
            query += "\", \"" + newPatientIntakeWizard_tab13_textbox_funder.Text;
            query += "\", \"" + newPatientIntakeWizard_tab13_combobox_gender.Text;
            query += "\", \"" + newPatientIntakeWizard_tab13_textbox_race.Text;
            query += "\", \"" + newPatientIntakeWizard_tab13_combobox_ethnicity.Text + "\")";
            database.Query(query);
            fillInactiveClientList();
            
            // how do i get clientnumz
            query = "select ClientNum from ClientInfo where ClientName=\"";
            query += newPatientIntakeWizard_tab1_textbox_firstName.Text + " " + newPatientIntakeWizard_tab1_textbox_lastName.Text + "\" and ";
            query += "ClientAddr=\"" + newPatientIntakeWizard_tab1_textbox_streetAddress.Text + "\"";
            String newClientNum = database.SelectString(query);

            screeningChanges.Add("ClientNum1", newClientNum);
            screeningChanges.Add("ClientNum2", newClientNum);
            asamChanges.Add("ClientNum1", newClientNum);
            asamChanges.Add("ClientNum2", newClientNum);
        }

        private void newPatientIntakeWizard_tab13_checkbox_intakeornot_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                newPatientIntakeWizard_tab13_datetimepicker_intakeDate.Value = DateTime.Today;
                newPatientIntakeWizard_tab13_datetimepicker_intakeDate.Visible = true;
                newPatientIntakeWizard_tab13_label_intakeDate.Visible = true;
            }
            else
            {
                newPatientIntakeWizard_tab13_datetimepicker_intakeDate.Visible = false;
                newPatientIntakeWizard_tab13_label_intakeDate.Visible = false;
            }
        }
    }
}
