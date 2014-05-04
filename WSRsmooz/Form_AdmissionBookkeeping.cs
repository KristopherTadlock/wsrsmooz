using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using System.Collections.Generic;


namespace WSRsmooz
{
    public partial class Form_AdmissionBookkeeping : Form
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
        string templatePDF = "templates/1-ADMISSION BOOKKEEPING FORM.pdf";
        string newFile;


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
            changes.Add("IntakeDate", "ADate");
            changes.Add("SecPhone", "ClientWCM");
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

        // form initialization
        public Form_AdmissionBookkeeping()
        {
            InitializeComponent();

            // create an obfuscated pdf
            newFile = Convert.ToString(rng.Next(int.MaxValue)) + ".pdf";

            client = "3";
            string query = "select * from ClientInfo where ClientID=" + client;

            clientInfo = database.GetTable(query);
            performReplacements();
        }

        // reads in pdf template, calls functions to fill new pdf, prints, deletes
        public void processPdfGen(object sender, EventArgs e)
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

            if (File.Exists(newFile))
                File.Delete(newFile);
        }

        // function to call printpdf.exe and wait for processing before deleting
        public void printPdf()
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "printpdf.exe";
            proc.StartInfo.Arguments = "-print-dialog -exit-on-print \"" + newFile + "\"";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            proc.WaitForExit();
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
                if (k is TextBox || k is ComboBox)
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
                        pdfFormFields.SetField(j.Name, "X");
                    }
                }
            }
        }

        private void cancelForm(object sender, EventArgs e)
        {
            String message = ("Are you sure you want to cancel? All unsaved progress will be lost");
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
