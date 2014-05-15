using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class IndividualNotes : Form
    {
        dbConnect database = new dbConnect();
        DataTable clients;
        DataTable clientInfo;

        int loadClientID;
        String ClientName;

        PdfReader pdfReader;
        PdfStamper pdfStamper;
        AcroFields pdfFormFields;

        Random rng = new Random();

        string templatePDF = "templates/2- 1on1 notes 2.pdf";
        DateTime firstDayOfWeek;
        DateTime sevenLater;
        string newFile;

        public IndividualNotes()
        {
            InitializeComponent();
            firstDayOfWeek = DateTime.Today.StartOfWeek(DayOfWeek.Monday);
            sevenLater = firstDayOfWeek.AddDays(7);
            D1.Value = firstDayOfWeek;
            D4.Value = sevenLater;
            D7.Value = DateTime.Today;
        }

        public void performReplacements()
        {
            Dictionary<string, string> changes = new Dictionary<string, string>();
            changes.Add("ClientName", "CLIENT NAME");
            changes.Add("ClientNum", "CLIENT LOG");

            foreach (KeyValuePair<string, string> change in changes)
            {
                clientInfo.Columns[change.Key].ColumnName = change.Value;
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItem != null)
            {
                loadClient((ClientItem)clientList.SelectedItem);
                newFile = Convert.ToString(rng.Next(int.MaxValue)) + ".pdf";
                ClientNameLabel.Text = "1-on-1 with " + ClientName;
            }
        }

        public void loadClient(ClientItem client)
        {
            String query = "select ClientName, ClientNum from ClientInfo where `ClientID`=\"" + client.id + "\"";
            clientInfo = database.GetTable(query);
            performReplacements();
            loadClientID = Convert.ToInt32(client.id);
            ClientName = client.clientName;
        }

        public void updateClientList()
        {
            foreach (DataRow row in clients.Rows)
            {
                ClientItem item = new ClientItem();
                item.id = row["ClientID"].ToString();
                item.clientName = row["ClientName"].ToString();
                clientList.Items.Add(item);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count > 0)
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
            else
            {
                MessageBox.Show("You must select a client before printing.");
            }
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
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    pdfFormFields.SetField(k.Name, k.Text);
                }
                else if (k is DateTimePicker)
                {
                    if (k.Name.Equals("T1") || k.Name.Equals("T3"))
                        pdfFormFields.SetField(k.Name, k.Text);
                    else
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
        }

        private void IndividualNotes_Load(object sender, EventArgs e)
        {
            string query = "select ClientName, ClientID from ClientInfo";
            clients = database.GetTable(query);

            updateClientList();
        }
    }
}
