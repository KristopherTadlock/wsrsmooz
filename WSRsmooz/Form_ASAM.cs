using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace WSRsmooz
{
    public partial class Form_ASAM : Form
    {
        // 'global' variables
        public string client { get; set; }
        dbConnect database = new dbConnect();
        DataTable clientInfo;
        Random rng = new Random();

        // just pdf-y things
        PdfReader pdfReader;
        PdfStamper pdfStamper;
        AcroFields pdfFormFields;
        Dictionary<string, string> asamChanges;
        string templatePDF = "templates/2-ASAM.pdf";
        string newFile;

        public Form_ASAM()
        {
            InitializeComponent();
        }

        public void performReplacements()
        {
            Dictionary<string, string> changes = new Dictionary<string, string>();


            //
            //
            //
            //
            // PERFORM NAME SWAPS HERE!!!!!!!!!!!!!!!!!!!!!
            //
            // Both names must exist.
            // Template:
            //        changes.Add(DATABASE_NAME, PDF_EQUIVALENT);
            //
            //changes.Add("IntakeDate", "ADate");
            // changes.Add("SecPhone", "ClientWCM");
            //
            //
            //
            //
            //
            //
            //
            //



            foreach (KeyValuePair<string, string> change in changes)
            {
                clientInfo.Columns[change.Key].ColumnName = change.Value;
            }
        }

        private void completeForm()
        {
            asamChanges = new Dictionary<string, string>();

            //
            //
            //
            // Changes below.
            //
            //
            //


            asamChanges.Add("IntDate", InterviewDate.Value.ToString("mm/dd/YY"));

            asamChanges.Add("PhInt", cbString(PhoneIntBox));
            asamChanges.Add("Admit", cbString(AdmitBox));
            asamChanges.Add("DuringTX", cbString(DuringTXBox));
            asamChanges.Add("ASAMExit", cbString(ExitBox));

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
                    asamChanges.Add("1", "X");
                    A++;
                    asamChanges.Add("47", "X");
                    F++;
                    asamChanges.Add("59", "X");
                    G++;
                    asamChanges.Add("71", "X");
                    H++;
                    asamChanges.Add("82", "X");
                    I++;
                    asamChanges.Add("93", "X");
                    J++;
                    asamChanges.Add("103", "X");
                    K++;
                    asamChanges.Add("112", "X");
                    L++;
                    asamChanges.Add("122", "X");
                    M++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionOneM", "Moderate");
                    asamChanges.Add("2", "X");
                    A++;
                    asamChanges.Add("12", "X");
                    B++;
                    asamChanges.Add("24", "X");
                    C++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionOneL", "Low");
                    asamChanges.Add("13", "X");
                    B++;
                    asamChanges.Add("25", "X");
                    C++;
                    asamChanges.Add("33", "X");
                    D++;
                    asamChanges.Add("43", "X");
                    E++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_2.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionTwoH", "High");
                    asamChanges.Add("3", "X");
                    A++;
                    asamChanges.Add("48", "X");
                    F++;
                    asamChanges.Add("60", "X");
                    G++;
                    asamChanges.Add("72", "X");
                    H++;
                    asamChanges.Add("83", "X");
                    I++;
                    asamChanges.Add("94", "X");
                    J++;
                    asamChanges.Add("104", "X");
                    K++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionTwoM", "Moderate");
                    asamChanges.Add("4", "X");
                    A++;
                    asamChanges.Add("14", "X");
                    B++;
                    asamChanges.Add("26", "X");
                    C++;
                    asamChanges.Add("34", "X");
                    D++;
                    asamChanges.Add("49", "X");
                    F++;
                    asamChanges.Add("61", "X");
                    G++;
                    asamChanges.Add("73", "X");
                    H++;
                    asamChanges.Add("84", "X");
                    I++;
                    asamChanges.Add("95", "X");
                    J++;
                    asamChanges.Add("105", "X");
                    K++;
                    asamChanges.Add("113", "X");
                    L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionTwoL", "Low");
                    asamChanges.Add("15", "X");
                    B++;
                    asamChanges.Add("35", "X");
                    D++;
                    asamChanges.Add("44", "X");
                    E++;
                    asamChanges.Add("114", "X");
                    L++;
                    asamChanges.Add("123", "X");
                    M++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_3.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionThreeH", "High");
                    asamChanges.Add("5", "X");
                    A++;
                    asamChanges.Add("50", "X");
                    F++;
                    asamChanges.Add("62", "X");
                    G++;
                    asamChanges.Add("74", "X");
                    H++;
                    asamChanges.Add("96", "X");
                    J++;
                    asamChanges.Add("106", "X");
                    K++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionThreeM", "Moderate");
                    asamChanges.Add("6", "X");
                    A++;
                    asamChanges.Add("16", "X");
                    B++;
                    asamChanges.Add("27", "X");
                    C++;
                    asamChanges.Add("36", "X");
                    D++;
                    asamChanges.Add("45", "X");
                    E++;
                    asamChanges.Add("51", "X");
                    F++;
                    asamChanges.Add("63", "X");
                    G++;
                    asamChanges.Add("75", "X");
                    H++;
                    asamChanges.Add("86", "X");
                    I++;
                    asamChanges.Add("97", "X");
                    J++;
                    asamChanges.Add("107", "X");
                    K++;
                    asamChanges.Add("115", "X");
                    L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionThreeL", "Low");
                    asamChanges.Add("17", "X");
                    B++;
                    asamChanges.Add("37", "X");
                    D++;
                    asamChanges.Add("46", "X");
                    E++;
                    asamChanges.Add("116", "X");
                    L++;
                    asamChanges.Add("124", "X");
                    M++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_4.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionFourH", "High");
                    asamChanges.Add("7", "X");
                    A++;
                    asamChanges.Add("52", "X");
                    F++;
                    asamChanges.Add("64", "X");
                    G++;
                    asamChanges.Add("76", "X");
                    H++;
                    asamChanges.Add("87", "X");
                    I++;
                    asamChanges.Add("98", "X");
                    J++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionFourM", "Moderate");
                    asamChanges.Add("8", "X");
                    A++;
                    asamChanges.Add("18", "X");
                    B++;
                    asamChanges.Add("28", "X");
                    C++;
                    asamChanges.Add("38", "X");
                    D++;
                    asamChanges.Add("53", "X");
                    F++;
                    asamChanges.Add("65", "X");
                    G++;
                    asamChanges.Add("77", "X");
                    H++;
                    asamChanges.Add("88", "X");
                    I++;
                    asamChanges.Add("99", "X");
                    J++;
                    asamChanges.Add("108", "X");
                    K++;
                    asamChanges.Add("117", "X");
                    L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionFourL", "Low");
                    asamChanges.Add("19", "X");
                    B++;
                    asamChanges.Add("29", "X");
                    C++;
                    asamChanges.Add("39", "X");
                    D++;
                    asamChanges.Add("54", "X");
                    F++;
                    asamChanges.Add("66", "X");
                    G++;
                    asamChanges.Add("109", "X");
                    K++;
                    asamChanges.Add("118", "X");
                    L++;
                    break;
                default:
                    break;
            }

            switch (newPatientIntakeWizard_tab11_combobox_5.Text)
            {
                case "High":
                    asamChanges.Add("levelFunctionFiveH", "High");
                    asamChanges.Add("9", "X");
                    A++;
                    asamChanges.Add("20", "X");
                    B++;
                    asamChanges.Add("55", "X");
                    F++;
                    asamChanges.Add("67", "X");
                    G++;
                    asamChanges.Add("100", "X");
                    J++;
                    break;
                case "Moderate":
                    asamChanges.Add("levelFunctionFiveM", "Moderate");
                    asamChanges.Add("21", "X");
                    B++;
                    asamChanges.Add("30", "X");
                    C++;
                    asamChanges.Add("40", "X");
                    D++;
                    asamChanges.Add("56", "X");
                    F++;
                    asamChanges.Add("68", "X");
                    G++;
                    asamChanges.Add("78", "X");
                    H++;
                    asamChanges.Add("89", "X");
                    I++;
                    asamChanges.Add("101", "X");
                    J++;
                    asamChanges.Add("119", "X");
                    L++;
                    break;
                case "Low":
                    asamChanges.Add("levelFunctionFiveL", "Low");
                    asamChanges.Add("31", "X");
                    C++;
                    asamChanges.Add("41", "X");
                    D++;
                    asamChanges.Add("79", "X");
                    H++;
                    asamChanges.Add("90", "X");
                    I++;
                    asamChanges.Add("110", "X");
                    K++;
                    asamChanges.Add("120", "X");
                    L++;
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
            asamChanges.Add("ClientNum1", client);
            asamChanges.Add("ClientNum2", client);
        }

        private void stampASAM()
        {
            if (!File.Exists(newFile))
            {
                pdfReader = new PdfReader(templatePDF);
            }
            else
            {
                MessageBox.Show("Error creating file.");
                return;
            }

            pdfStamper = new PdfStamper(pdfReader, new FileStream(templatePDF, FileMode.Create));
            pdfFormFields = pdfStamper.AcroFields;

            foreach (KeyValuePair<string, string> pair in asamChanges)
            {
                pdfFormFields.SetField(pair.Key, pair.Value);
            }

            pdfStamper.Close();
            pdfReader.Close();
        }

        public void printPdf()
        {
            if (File.Exists(newFile))
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "printpdf.exe";
                proc.StartInfo.Arguments = "-print-dialog -exit-on-print \"" + newFile + "\"";
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
                proc.WaitForExit();
                File.Delete(newFile);
            }
        }

        private bool cbBool(CheckBox checkbox)
        {
            if (checkbox.Checked)
                return true;
            return false;
        }

        private string cbString(CheckBox checkbox)
        {
            if (checkbox.Checked)
                return "X";
            return "";
        }

        public void stampPdf()
        {
            // Fill from database.
            foreach (var field in pdfFormFields.Fields)
            {
                if (clientInfo.Columns.Contains(field.Key))
                {
                    pdfFormFields.SetField(field.Key, clientInfo.Rows[0][field.Key].ToString());
                }
            }

            // Traverse anything not in a group box.
            foreach (Control k in this.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    pdfFormFields.SetField(k.Name, k.Text);
                }
                else if (k is DateTimePicker)
                {
                    pdfFormFields.SetField(k.Name, ((DateTimePicker)k).Value.Date.ToString("MM/dd/yyyy"));
                }
                else if (k is CheckBox)
                {
                    // Depends on "checked" value of PDF.
                    // Can modify later if anyone actually used a checkbox Acrofield.
                    if (((CheckBox)k).Checked)
                        pdfFormFields.SetField(k.Name, "X");
                }
            }

            // Traverse everything inside groupboxes.
            foreach (Control i in this.Controls.OfType<GroupBox>())
            {
                foreach (Control j in i.Controls)
                {
                    if (j is TextBox || j is ComboBox)
                    {
                        pdfFormFields.SetField(j.Name, j.Text);
                    }
                    else if (j is DateTimePicker)
                    {
                        pdfFormFields.SetField(j.Name, ((DateTimePicker)j).Value.Date.ToString("MM/dd/yyyy"));
                    }
                    else if (j is CheckBox)
                    {
                        // Depends on "checked" value of PDF.
                        // Can modify later if anyone actually used a checkbox Acrofield.
                        if (((CheckBox)j).Checked)
                            pdfFormFields.SetField(j.Name, "X");
                    }
                }
            }
        }

        private void Form_ASAM_Load(object sender, EventArgs e)
        {
            // create an obfuscated pdf
            newFile = Convert.ToString(rng.Next(int.MaxValue)) + ".pdf";

            string query = "select * from ClientInfo where ClientID=" + client;

            clientInfo = database.GetTable(query);
            performReplacements();
            InterviewDate.Value = DateTime.Today;

            foreach (ComboBox c in Controls.OfType<ComboBox>())
            {
                if (c.Items.Count > 1)
                    c.SelectedIndex = 1;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            String message = ("Are you sure you want to cancel? All unsaved progress will be lost");
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(newFile))
            {
                pdfReader = new PdfReader(templatePDF);
            }
            else
            {
                MessageBox.Show("Error creating file.");
                return;
            }

            pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            pdfFormFields = pdfStamper.AcroFields;

            stampPdf();
            pdfStamper.Close();
            pdfReader.Close();
            printPdf();
        }

    }
}
