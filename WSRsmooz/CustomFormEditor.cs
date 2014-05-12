using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class CustomFormEditor : Form
    {
        // Accessable stuff.
        public Boolean preload {get; set;}
        public String loadedPdf {get; set;}
        public int panelIndex { get; set; }
        public Boolean hideLoad { get; set; }

        // Local stuff.
        dbConnect database = new dbConnect();
        DataTable form, panels;
        String query;

        public CustomFormEditor()
        {
            InitializeComponent();
            hideLoad = preload = false;
            fillPanelBox();
        }

        public Point gridify(Point coords)
        {
            return new Point(coords.X - (coords.X % 10), coords.Y - (coords.Y % 10));
        }

        private void checkExisting(object sender, EventArgs e)
        {
            if (hideLoad)
                IMPORTANTYESLoadPDFButton.Enabled = false;

            query = "select count(1) from forms where Path=\"" + Path.GetFileName(loadedPdf) + "\"";
            int result = Convert.ToInt32(database.SelectString(query));

            if (result == 0)
            {
                // new pdf
                loadPdf();
            }
            else
            {
                // exists in db
                loadForm();
            }
        }

        private void loadPdf()
        {
            int rowModifier = 30;
            int column = 1;
            int middleColumn = Convert.ToInt32(0.4 * ClientRectangle.Width);
            IMPORTANTYESTitleBox.Text = Path.GetFileName(loadedPdf);

            if (preload)
            {
                if (loadedPdf.Contains(".pdf"))
                {
                    PdfReader pdfReader = new PdfReader(loadedPdf);

                    foreach (var field in pdfReader.AcroFields.Fields)
                    {
                        CustomTextboxLabel newField = new CustomTextboxLabel();
                        newField.attrName(field.Key);
                        newField.pdfAttribute = field.Key;
                        newField.Name = field.Key;
                        newField.Draggable(true);

                        Controls.Add(newField);
                        newField.Width = newField.label.Width + newField.textBox.Width;

                        switch (column)
                        {
                            case 1:
                                newField.Location = gridify(new Point(5, rowModifier));
                                column = 2;
                                break;
                            case 2:
                                newField.Location = gridify(new Point(middleColumn, rowModifier));
                                column = 3;
                                break;
                            case 3:
                                newField.Location = gridify(new Point(ClientRectangle.Width - newField.Width, rowModifier));
                                rowModifier += 50;
                                column = 1;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void loadForm()
        {
            query = "select FormID from forms where Path=\"" + Path.GetFileName(loadedPdf) + "\" and Hardcoded=0";
            String formID = database.SelectString(query);
            query = "select * from CustomForms where FormID=" + formID;
            form = database.GetTable(query);

            String[] bigDelimit = new String[] { "-&" };
            String[] delimits = new String[] { "-;" };

            // Labels
            String temp = form.Rows[0]["Labels"].ToString();
            String[] results = temp.Split(bigDelimit, StringSplitOptions.None);
            foreach (String s in results)
            {
                if (s != "")
                {
                    String[] subResults = s.Split(delimits, StringSplitOptions.None);
                    EditableLabel newLabel = new EditableLabel();
                    newLabel.Name = subResults[0];
                    newLabel.Text = subResults[1];
                    newLabel.Draggable(true);
                    Controls.Add(newLabel);
                    newLabel.Location = new Point(Convert.ToInt32(subResults[2]), Convert.ToInt32(subResults[3]));
                }
            }

            // Textboxes
            temp = form.Rows[0]["Textboxes"].ToString();
            results = temp.Split(bigDelimit, StringSplitOptions.None);
            foreach (String s in results)
            {
                if (s != "")
                {
                    String[] subResults = s.Split(delimits, StringSplitOptions.None);
                    CustomTextboxLabel newTextbox = new CustomTextboxLabel();
                    newTextbox.pdfAttribute = subResults[0];
                    newTextbox.Name = subResults[0];
                    newTextbox.label.Text = subResults[1];
                    if (subResults[2].Equals("True"))
                    {
                        newTextbox.textBox.Multiline = true;
                        newTextbox.Height = 78;
                    }
                    newTextbox.Draggable(true);
                    Controls.Add(newTextbox);
                    newTextbox.Width = newTextbox.label.Width + newTextbox.textBox.Width;
                    newTextbox.Location = new Point(Convert.ToInt32(subResults[3]), Convert.ToInt32(subResults[4]));
                }
            }

            // Comboboxes
            temp = form.Rows[0]["Comboboxes"].ToString();
            results = temp.Split(bigDelimit, StringSplitOptions.None);
            foreach (String s in results)
            {
                if (s != "")
                {
                    String[] subResults = s.Split(delimits, StringSplitOptions.None);
                    EditableCombobox newCombobox = new EditableCombobox();
                    newCombobox.pdfAttribute = subResults[0];
                    newCombobox.Name = subResults[0];
                    newCombobox.rememberName = subResults[0];

                    foreach (String line in subResults[3].Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        newCombobox.combobox.Items.Add(line);
                    }
                    if (newCombobox.combobox.Items.Count > 0)
                        newCombobox.combobox.SelectedIndex = 0;
                    newCombobox.Draggable(true);
                    Controls.Add(newCombobox);
                    newCombobox.resizeBox();
                    newCombobox.Location = new Point(Convert.ToInt32(subResults[1]), Convert.ToInt32(subResults[2]));
                }
            }

            // Checkboxes
            temp = form.Rows[0]["Checkboxes"].ToString();
            results = temp.Split(bigDelimit, StringSplitOptions.None);
            foreach (String s in results)
            {
                if (s != "")
                {
                    String[] subResults = s.Split(delimits, StringSplitOptions.None);
                    EditableCheckbox newCheckbox = new EditableCheckbox();
                    newCheckbox.pdfAttribute = subResults[0];
                    newCheckbox.Name = subResults[0];
                    newCheckbox.checkbox.Text = subResults[1];
                    newCheckbox.Draggable(true);
                    Controls.Add(newCheckbox);
                    newCheckbox.Location = new Point(Convert.ToInt32(subResults[2]), Convert.ToInt32(subResults[3]));
                }
            }

            query = "select FormName, Panel from forms where FormID=" + formID;
            form = database.GetTable(query);

            IMPORTANTYESTitleBox.Text = form.Rows[0]["FormName"].ToString();
            IMPORTANTYESPanelChoiceBox.SelectedIndex = panelIndex;

        }

        private void DoubleClick(object sender, MouseEventArgs e)
        {
            Point loc = e.Location;
            EditableLabel newLabel = new EditableLabel();
            newLabel.triggerEntry(sender, e);

            if (!newLabel.Text.Equals(String.Empty))
                Controls.Add(newLabel);

            newLabel.Location = loc;
        }

        private void fillPanelBox()
        {
            IMPORTANTYESPanelChoiceBox.Items.Clear();
            query = "select * from panels order by Priority asc";
            panels = database.GetTable(query);

            foreach (DataRow row in panels.Rows)
            {
                PanelItem newPanel = new PanelItem();
                newPanel.name = row["PanelName"].ToString();
                newPanel.id = row["PanelID"].ToString();
                IMPORTANTYESPanelChoiceBox.Items.Add(newPanel);
            }

            if (IMPORTANTYESPanelChoiceBox.Items.Count > 0)
                IMPORTANTYESPanelChoiceBox.SelectedIndex = IMPORTANTYESPanelChoiceBox.Items.Count - 1;
        }

        private void SaveForm(object sender, EventArgs e)
        {
            String preferredPath = "templates/" + Path.GetFileName(loadedPdf);

            if (!File.Exists(preferredPath) && !preferredPath.Equals(loadedPdf))
            {
                File.Copy(loadedPdf, preferredPath);
                loadedPdf = preferredPath;
            }

            // get priority
            query = "select coalesce(max(Priority), 0) as MaxPriority from ";
            query += "forms where Panel=\"" + ((PanelItem)IMPORTANTYESPanelChoiceBox.SelectedItem).id + "\"";
            String newPriorityString = database.SelectString(query);
            int newPriority = Convert.ToInt32(newPriorityString) + 1;

            query = "select FormID from forms where Path=\"" + Path.GetFileName(loadedPdf) + "\"";
            String what = database.SelectString(query);
            int formID = Convert.ToInt32(what);

            // db save button
            query = "insert into forms (FormID, FormName, Panel, Priority, Path) values(" + formID.ToString() + ", ";
            query += "\"" + IMPORTANTYESTitleBox.Text + "\", \"" + ((PanelItem)IMPORTANTYESPanelChoiceBox.SelectedItem).id + "\", \"";
            query += newPriority.ToString() + "\", \"" + Path.GetFileName(loadedPdf) + "\") ";
            query += "on duplicate key update FormName=values(FormName), Panel=values(Panel), ";
            query += "Priority=values(Priority), Path=values(Path)";

            if (!database.Query(query))
            {
                MessageBox.Show("Error reaching database.");
                return;
            }

            query = "select FormID from forms where Path=\"" + Path.GetFileName(loadedPdf) + "\"";
            what = database.SelectString(query);
            formID = Convert.ToInt32(what);

            query = "insert into CustomForms (FormID, Labels, Textboxes, Comboboxes, Checkboxes) values(";
            String labelString, textboxString, comboboxString, CheckboxString;
            labelString = textboxString = comboboxString = CheckboxString = "";
            query += formID.ToString() + ", ";

            // set custom form shit
            foreach (Control c in Controls)
            {
                if (c is EditableLabel)
                    labelString += c.Name + "-;" + ((EditableLabel)c).label.Text + "-;" + c.Location.X + "-;" + c.Location.Y + "-&";
                else if (c is CustomTextboxLabel)
                    textboxString += ((CustomTextboxLabel)c).pdfAttribute + "-;" + ((CustomTextboxLabel)c).label.Text + "-;" + ((CustomTextboxLabel)c).textBox.Multiline.ToString() + "-;" + c.Location.X + "-;" + c.Location.Y + "-&";
                else if (c is EditableCombobox)
                {
                    comboboxString += ((EditableCombobox)c).pdfAttribute + "-;" + c.Location.X + "-;" + c.Location.Y + "-;";

                    if (((EditableCombobox)c).combobox.Items.Count > 0)
                    {
                        for (int i = 0; i < ((EditableCombobox)c).combobox.Items.Count; i++)
                        {
                            if (i < ((EditableCombobox)c).combobox.Items.Count - 1)
                                comboboxString += ((EditableCombobox)c).combobox.Items[i] + "\r\n";
                            else
                                comboboxString += ((EditableCombobox)c).combobox.Items[i];
                        }
                    }

                    comboboxString += "-&";
                }
                else if (c is EditableCheckbox)
                    CheckboxString += ((EditableCheckbox)c).pdfAttribute + "-;" + ((EditableCheckbox)c).checkbox.Text + "-;" + c.Location.X + "-;" + c.Location.Y + "-&";
            }

            query += "\"" + labelString + "\", \"" + textboxString + "\", \"" + comboboxString + "\", \"" + CheckboxString + "\") on duplicate key update ";
            query += "Labels=values(Labels), Textboxes=values(Textboxes), Comboboxes=values(Comboboxes), Checkboxes=values(Checkboxes)";

            if (database.Query(query))
                this.DialogResult = DialogResult.Yes;
        }

        private void LoadPDF(object sender, EventArgs e)
        {
            OpenFileDialog choosePath = new OpenFileDialog();

            if (choosePath.ShowDialog() == DialogResult.OK)
                loadedPdf = choosePath.FileName;
            else
                return;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (!this.Controls[i].Name.Contains("IMPORTANTYES"))
                    this.Controls.RemoveAt(i);
            }

            preload = true;
            checkExisting(sender, e);
        }
    }
}
