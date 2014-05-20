using System;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;

namespace WSRsmooz
{
    public partial class PastGroupNotesPrompt : Form
    {
        String pdfPath = "clientfiles/groupnotes/";

        public String name { get; set; }
        public int id { get; set; }
        public PdfReader pdfReader;
        dbConnect database = new dbConnect();

        public void grabPDFs()
        {
            PastNotes.Items.Clear();

            String cool = pdfPath;
            cool += id + "/";

            if (Directory.Exists(cool))
            {
                String[] filePaths = Directory.GetFiles(cool);
                foreach (string file in filePaths)
                {
                    String[] delimits = new String[] { "." };
                    String[] pdfProps = Path.GetFileName(file).Split(delimits, StringSplitOptions.None);

                    //String month = pdfProps[1];
                    //String day = pdfProps[2];
                    //String year = pdfProps[3];
                    //year = year.Substring(0, year.Length - 4);

                    String listedName = pdfProps[0];
                    PastNotes.Items.Add(listedName);
                }
            }
        }

        public PastGroupNotesPrompt()
        {
            InitializeComponent();

            name = String.Empty;
            id = -1;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PastNotes.SelectedItems.Count < 1) return;

            Boolean valid = true;
            String violators = "";
            String newFile = pdfPath + id + "/" + PastNotes.SelectedItem.ToString() + ".pdf";

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

        private void PastGroupNotesPrompt_Load(object sender, EventArgs e)
        {
            if (name == String.Empty || id == -1) this.Close();
            ClientName.Text = name;
            grabPDFs();
            if (PastNotes.Items.Count > 0)
                PastNotes.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PastNotes.SelectedItems.Count < 1) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            string temp = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
            temp += "deleted " + name + "'s group notes from " + PastNotes.SelectedItem.ToString();
            temp += ".\")";
            database.Query(temp);

            String delFile = pdfPath + id + "/" + PastNotes.SelectedItem.ToString() + ".pdf";
            File.Delete(delFile);
            grabPDFs();
        }
    }
}
