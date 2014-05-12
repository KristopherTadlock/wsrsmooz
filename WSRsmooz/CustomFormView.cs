using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class CustomFormView : Form
    {
        // Grab stuff.
        public String loadFormID { get; set; }
        public String client { get; set; }

        // Local stuff.
        dbConnect database = new dbConnect();
        DataTable form, panels;
        String query;

        public CustomFormView()
        {
            InitializeComponent();
        }

        private void grabForm(object sender, EventArgs e)
        {
            query = "select * from CustomForms where FormID=" + loadFormID;
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
                    newLabel.locked = true;
                    newLabel.Draggable(false);
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
                    newTextbox.locked = true;
                    newTextbox.label.Text = subResults[1];
                    if (subResults[2].Equals("True"))
                    {
                        newTextbox.textBox.Multiline = true;
                        newTextbox.Height = 78;
                    }
                    newTextbox.Draggable(false);
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
                    ComboBoxer newCombobox = new ComboBoxer();
                    newCombobox.pdfAttribute = subResults[0];
                    newCombobox.Name = subResults[0];
                    newCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                    foreach (String line in subResults[3].Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        newCombobox.Items.Add(line);
                    }
                    if (newCombobox.Items.Count > 0)
                        newCombobox.SelectedIndex = 0;
                    newCombobox.Draggable(false);
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
                    CheckBoxer newCheckbox = new CheckBoxer();
                    newCheckbox.pdfAttribute = subResults[0];
                    newCheckbox.Name = subResults[0];
                    newCheckbox.Text = subResults[1];
                    newCheckbox.Draggable(false);
                    Controls.Add(newCheckbox);
                    newCheckbox.Location = new Point(Convert.ToInt32(subResults[2]), Convert.ToInt32(subResults[3]));
                }
            }

            query = "select FormName, Panel from forms where FormID=" + loadFormID;
            form = database.GetTable(query);

            IMPORTANTYESTitleBox.Text = form.Rows[0]["FormName"].ToString();
            this.Text = IMPORTANTYESTitleBox.Text;
        }
    }
}
