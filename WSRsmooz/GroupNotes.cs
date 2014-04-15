using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using iTextSharp.text.pdf;
using System.Data;
using System.ComponentModel;

namespace WSRsmooz
{
    public partial class GroupNotes : Form
    {
        public Boolean admin { get; set; }
        dbConnection database = new dbConnection();
        DataSet clients = new DataSet();

        int loadClientID;
        String ClientName;

        DateTime editingDay;
        String dayOfWeek;
        DateTime firstDayOfWeek;
        DateTime lastDayOfWeek;

        public PdfReader pdfReader;
        public PdfStamper pdfStamper;
        public AcroFields pdfFormFields;

        string templatePDF = "templates/Group Notes.pdf";
        String templatePathFromOld;
        string newPDFPath;
        string newFile;

        public GroupNotes()
        {
            InitializeComponent();
            admin = false;

            String query = "select * from clients where `Active`=true";
            clients = database.GetTable(query);
            
            editingDay = DateTime.Now;
            lastDayOfWeek = editingDay.Next(DayOfWeek.Sunday);
            firstDayOfWeek = editingDay.StartOfWeek(DayOfWeek.Monday);
            dayOfWeek = editingDay.DayOfWeek.ToString();
            WeekOf_Label.Text = "Week of " + firstDayOfWeek.ToString("MM/dd") + " through " + lastDayOfWeek.ToString("MM/dd");

            updateClientList();
            clientList.SetSelected(0, true);

            newPDFPath = "/clientfiles/groupnotes/" + loadClientID + "/"; // C:\\Users/Darryl/SparkleShare/WestSlopeSecure
            newFile = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + ".pdf";
            templatePathFromOld = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + "-old.pdf";

            // Wipe out shit files.
            if (Directory.Exists(newPDFPath))
            {
                foreach (var file in Directory.EnumerateFiles(newPDFPath, "*-old.pdf", SearchOption.TopDirectoryOnly))
                    File.Delete(file);
            }
         
            processPdfGen();
            DaySelection.SelectedIndex = ((int)(editingDay.DayOfWeek) + 6) % 7;
        }

        public void updateClientList()
        {
            DataTable clientTable = clients.Tables[0];
            foreach (DataRow row in clientTable.Rows)
            {
                ClientItem item = new ClientItem();
                item.id = row["ID"].ToString();
                item.clientName = row["First Name"].ToString() + " " + row["Last Name"].ToString();
                clientList.Items.Add(item);
            }
        }

        public void loadClient(ClientItem client)
        {
            String query = "select * from clients where `ID`=\"" + client + "\"";
            DataTable loadedClient = database.GetTable(query).Tables[0];
            loadClientID = Convert.ToInt32(client.id);
            ClientName = client.clientName;
        }

        public void fillBoxesIfExists(AcroFields pdfFormFields)
        {
            String temp = pdfFormFields.GetField(dayOfWeek + " Kick Starting Time");
            if (temp != "")
                KickStart.Value = DateTime.ParseExact(temp, "hh:mm", CultureInfo.InvariantCulture);
            temp = pdfFormFields.GetField(dayOfWeek + " Kick Ending Time");
            if (temp != "")
            KickEnd.Value = DateTime.ParseExact(temp, "hh:mm", CultureInfo.InvariantCulture);

            KickTopic.Text = pdfFormFields.GetField(dayOfWeek + " Kick Topic");
            KickText.Text = pdfFormFields.GetField(dayOfWeek + " Kick Text");

            togglePermissions(pdfFormFields);

            AMTopic.Text = pdfFormFields.GetField(dayOfWeek + " AM Topic");
            AMText.Text = pdfFormFields.GetField(dayOfWeek + " AM Text");

            PMTopic.Text = pdfFormFields.GetField(dayOfWeek + " PM Topic");
            PMText.Text = pdfFormFields.GetField(dayOfWeek + " PM Text");
        }

        public void togglePermissions(AcroFields pdfFormFields)
        {
            String temp;
            // Check Kick for signature lock.
            temp = pdfFormFields.GetField(dayOfWeek + " Kick Signature");
            if (temp != "")
            {
                KickStart.Enabled = false;
                KickEnd.Enabled = false;
                KickTopic.Enabled = false;
                KickText.Enabled = false;
                SignKick.Enabled = false;
                SignKick_Label.Text = temp;
                SignKick_Label.ForeColor = Color.Red;
            } else
            {
                KickStart.Enabled = true;
                KickEnd.Enabled = true;
                KickTopic.Enabled = true;
                KickText.Enabled = true;
                SignKick.Enabled = true;
                SignKick_Label.Text = "Unsigned";
                SignKick_Label.ForeColor = Color.ForestGreen;
            }

            // Check AM for signature lock.
            temp = pdfFormFields.GetField(dayOfWeek + " AM Signature");
            if (temp != "")
            {
                AMTopic.Enabled = false;
                AMText.Enabled = false;
                SignAM.Enabled = false;
                SignAM_Label.Text = temp;
                SignAM_Label.ForeColor = Color.Red;
            }
            else
            {
                AMTopic.Enabled = true;
                AMText.Enabled = true;
                SignAM.Enabled = true;
                SignAM_Label.Text = "Unsigned";
                SignAM_Label.ForeColor = Color.ForestGreen;
            }

            // Check PM for signature lock.
            temp = pdfFormFields.GetField(dayOfWeek + " PM Signature");
            if (temp != "")
            {
                PMTopic.Enabled = false;
                PMText.Enabled = false;
                SignPM.Enabled = false;
                SignPM_Label.Text = temp;
                SignPM_Label.ForeColor = Color.Red;
            }
            else
            {
                PMTopic.Enabled = true;
                PMText.Enabled = true;
                SignPM.Enabled = true;
                SignPM_Label.Text = "Unsigned";
                SignPM_Label.ForeColor = Color.ForestGreen;
            }
        }

        public void stampBoxes(AcroFields pdfFormFields, int signed)
        {
            pdfFormFields.SetField(dayOfWeek + " Kick Starting Time", KickStart.Text);
            pdfFormFields.SetField(dayOfWeek + " Kick Ending Time", KickEnd.Text);

            pdfFormFields.SetField(dayOfWeek + " Kick Topic", KickTopic.Text);
            pdfFormFields.SetField(dayOfWeek + " Kick Text", KickText.Text);

            pdfFormFields.SetField(dayOfWeek + " AM Topic", AMTopic.Text);
            pdfFormFields.SetField(dayOfWeek + " AM Text", AMText.Text);

            pdfFormFields.SetField(dayOfWeek + " PM Topic", PMTopic.Text);
            pdfFormFields.SetField(dayOfWeek + " PM Text", PMText.Text);

            pdfFormFields.SetField("Week Start", firstDayOfWeek.ToString("MM/dd/yyyy"));
            pdfFormFields.SetField("Week Start 2", firstDayOfWeek.ToString("MM/dd/yyyy"));
            pdfFormFields.SetField("Week End", lastDayOfWeek.ToString("MM/dd/yyyy"));
            pdfFormFields.SetField("Week End 2", lastDayOfWeek.ToString("MM/dd/yyyy"));

            pdfFormFields.SetField("Client Name", ClientName);
            pdfFormFields.SetField("Client Name 2", ClientName);
            pdfFormFields.SetField("Client Log", loadClientID.ToString());
            pdfFormFields.SetField("Client Log 2", loadClientID.ToString());

            switch (signed)
            {
                case 0:
                    pdfFormFields.SetField(dayOfWeek + " Kick Signature", ((Launcher)MdiParent).currentUser);
                    break;
                case 1:
                    pdfFormFields.SetField(dayOfWeek + " AM Signature", ((Launcher)MdiParent).currentUser);
                    break;
                case 2:
                    pdfFormFields.SetField(dayOfWeek + " PM Signature", ((Launcher)MdiParent).currentUser);
                    break;
                default:
                    break;
            }
            togglePermissions(pdfFormFields);
        }

        public void processPdfGen()
        {
            Directory.CreateDirectory(newPDFPath);
            if (!File.Exists(newFile))
            {
                pdfReader = new PdfReader(templatePDF);
            }
            else
            {
                if (File.Exists(templatePathFromOld))
                    File.Delete(templatePathFromOld);
                File.Move(newFile, templatePathFromOld);
                pdfReader = new PdfReader(templatePathFromOld);
            }
            pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            pdfFormFields = pdfStamper.AcroFields;

            fillBoxesIfExists(pdfFormFields);

            pdfStamper.Close();
            pdfReader.Close();
            if (File.Exists(templatePathFromOld))
                File.Delete(templatePathFromOld);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(newPDFPath);
            if (!File.Exists(newFile))
            {
                pdfReader = new PdfReader(templatePDF);
            }
            else
            {
                File.Move(newFile, templatePathFromOld);
                pdfReader = new PdfReader(templatePathFromOld);
            }
            pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            stampBoxes(pdfFormFields, -1);

            pdfStamper.Close();
            pdfReader.Close();
            if (File.Exists(templatePathFromOld))
                File.Delete(templatePathFromOld);
            MessageBox.Show("Form data preserved.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DaySelection.SelectedIndex < 7)
            {
                editingDay = firstDayOfWeek.AddDays(DaySelection.SelectedIndex);
                dayOfWeek = editingDay.DayOfWeek.ToString();
                DateOfWeek.Text = editingDay.ToString("D");
            }
            else
            {
                editingDay = firstDayOfWeek;
                dayOfWeek = "Additional";
                DateOfWeek.Text = editingDay.ToString("D");
            }
            if (clientList.SelectedItem != null)
            {
                loadClient((ClientItem)clientList.SelectedItem);
                newPDFPath = "clientfiles/groupnotes/" + loadClientID + "/";
                newFile = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + ".pdf";
                templatePathFromOld = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + "-old.pdf";
                DoW.Text = ClientName + "'s Group Notes";

                processPdfGen();
            }
        }

        private void SignKick_Click(object sender, EventArgs e)
        {
            SignaturePrompt sigCapture = new SignaturePrompt();
            DialogResult sigResult = sigCapture.ShowDialog();
            if (sigResult == DialogResult.OK)
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MemoryStream sigStream = sigCapture.sigStream;
                System.Drawing.Image img = System.Drawing.Image.FromStream(sigStream);
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Png);

                Directory.CreateDirectory(newPDFPath);
                if (!File.Exists(newFile))
                {
                    pdfReader = new PdfReader(templatePDF);
                }
                else
                {
                    File.Move(newFile, templatePathFromOld);
                    pdfReader = new PdfReader(templatePathFromOld);
                }
                pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                stampBoxes(pdfFormFields, 0);

                PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                if (DaySelection.SelectedIndex > 2) pdfContentByte = pdfStamper.GetOverContent(2);

                IList<AcroFields.FieldPosition> fieldPositions;

                fieldPositions = pdfFormFields.GetFieldPositions(dayOfWeek + " Kick Signature");
                AcroFields.FieldPosition fieldPosition = fieldPositions[0];

                png.ScaleAbsolute(92f, 28f);
                png.SetAbsolutePosition(fieldPosition.position.Left, fieldPosition.position.Bottom);
                
                pdfContentByte.AddImage(png);

                pdfStamper.Close();
                pdfReader.Close();
                if (File.Exists(templatePathFromOld))
                    File.Delete(templatePathFromOld);
            }
            else
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MessageBox.Show("A signature is required to save this to PDF.");
            }
        }

        private void SignAM_Click(object sender, EventArgs e)
        {
            SignaturePrompt sigCapture = new SignaturePrompt();
            DialogResult sigResult = sigCapture.ShowDialog();
            if (sigResult == DialogResult.OK)
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MemoryStream sigStream = sigCapture.sigStream;
                System.Drawing.Image img = System.Drawing.Image.FromStream(sigStream);
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Png);

                Directory.CreateDirectory(newPDFPath);
                if (!File.Exists(newFile))
                {
                    pdfReader = new PdfReader(templatePDF);
                }
                else
                {
                    File.Move(newFile, templatePathFromOld);
                    pdfReader = new PdfReader(templatePathFromOld);
                }
                pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                stampBoxes(pdfFormFields, 1);

                PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                if (DaySelection.SelectedIndex > 2) pdfContentByte = pdfStamper.GetOverContent(2);

                IList<AcroFields.FieldPosition> fieldPositions;

                fieldPositions = pdfFormFields.GetFieldPositions(dayOfWeek + " AM Signature");
                AcroFields.FieldPosition fieldPosition = fieldPositions[0];

                png.ScaleAbsolute(92f, 28f);
                png.SetAbsolutePosition(fieldPosition.position.Left, fieldPosition.position.Bottom);

                pdfContentByte.AddImage(png);

                pdfStamper.Close();
                pdfReader.Close();
                if (File.Exists(templatePathFromOld))
                    File.Delete(templatePathFromOld);
            }
            else
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MessageBox.Show("A signature is required to save this to PDF.");
            }
        }

        private void SignPM_Click(object sender, EventArgs e)
        {
            SignaturePrompt sigCapture = new SignaturePrompt();
            DialogResult sigResult = sigCapture.ShowDialog();
            if (sigResult == DialogResult.OK)
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MemoryStream sigStream = sigCapture.sigStream;
                System.Drawing.Image img = System.Drawing.Image.FromStream(sigStream);
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Png);

                Directory.CreateDirectory(newPDFPath);
                if (!File.Exists(newFile))
                {
                    pdfReader = new PdfReader(templatePDF);
                }
                else
                {
                    File.Move(newFile, templatePathFromOld);
                    pdfReader = new PdfReader(templatePathFromOld);
                }
                pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                stampBoxes(pdfFormFields, 2);

                PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                if (DaySelection.SelectedIndex > 2) pdfContentByte = pdfStamper.GetOverContent(2);

                IList<AcroFields.FieldPosition> fieldPositions;

                fieldPositions = pdfFormFields.GetFieldPositions(dayOfWeek + " PM Signature");
                AcroFields.FieldPosition fieldPosition = fieldPositions[0];

                png.ScaleAbsolute(92f, 28f);
                png.SetAbsolutePosition(fieldPosition.position.Left, fieldPosition.position.Bottom);

                pdfContentByte.AddImage(png);

                pdfStamper.Close();
                pdfReader.Close();
                if (File.Exists(templatePathFromOld))
                    File.Delete(templatePathFromOld);
            }
            else
            {
                Cursor.Clip = new System.Drawing.Rectangle();
                MessageBox.Show("A signature is required to save this to PDF.");
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItem != null)
            {
                loadClient((ClientItem)clientList.SelectedItem);
                newPDFPath = "clientfiles/groupnotes/" + loadClientID + "/";
                newFile = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + ".pdf";
                templatePathFromOld = newPDFPath + firstDayOfWeek.ToString("MM-dd-yyyy") + "-old.pdf";
                DoW.Text = ClientName + "'s Group Notes";

                processPdfGen();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String violators = "";

            if (File.Exists(newFile))
            {
                pdfReader = new PdfReader(newFile);
                AcroFields pdfFormFields = pdfReader.AcroFields;

                foreach (var field in pdfFormFields.Fields)
                {
                    if (field.Key.Contains("Signature"))
                    {
                        String tempValue = pdfFormFields.GetField(field.Key);
                        if (tempValue == "")
                        {
                            violators += field.Key.Replace(" Signature", "\n").Replace("Kick", "Kick-off").Replace("AM", "Morning").Replace("PM", "Afternoon");
                            valid = false;
                        }
                    }
                }
                pdfReader.Close();
            }

            if (!valid)
            {
                DialogResult dialogResult = MessageBox.Show("The following fields were not signed:\n\n" + violators + "\nContinue printing?", "Validation Error", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There was an error opening the print dialog.\n\n" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PastGroupNotesPrompt pastNotesPrompt = new PastGroupNotesPrompt();
            pastNotesPrompt.name = ClientName;
            pastNotesPrompt.id = loadClientID;
            pastNotesPrompt.ShowDialog();
        }

        private void GroupNotes_Load(object sender, EventArgs e)
        {
            if (admin)
                AdminSeePastNotes.Visible = true;
        }

    }
}
