using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class FormOrganization : Form
    {
        dbConnect database = new dbConnect();
        String query = "";
        DataTable panels, forms;
        Boolean skip = false;

        public FormOrganization()
        {
            InitializeComponent();
            fillPanelBox();
        }

        private void fillPanelBox()
        {
            PanelBox.Items.Clear();
            PanelChoiceBox.Items.Clear();
            query = "select * from panels order by Priority asc";
            panels = database.GetTable(query);

            foreach (DataRow row in panels.Rows)
            {
                PanelItem newPanel = new PanelItem();
                newPanel.name = row["PanelName"].ToString();
                newPanel.id = row["PanelID"].ToString();
                PanelBox.Items.Add(newPanel);
                PanelChoiceBox.Items.Add(newPanel);
            }
        }

        private void fillFormList()
        {
            if (PanelBox.SelectedItems.Count > 0)
            {
                FormBox.Items.Clear();

                query = "select * from forms where Panel=\"";
                query += ((PanelItem)PanelBox.SelectedItem).id + "\" order by Priority asc";
                forms = database.GetTable(query);

                foreach (DataRow row in forms.Rows)
                {
                    FormItem newForm = new FormItem();
                    newForm.name = row["FormName"].ToString();
                    newForm.path = row["Path"].ToString();
                    newForm.id = row["FormID"].ToString();
                    newForm.hardcoded = row["Hardcoded"].ToString();
                    FormBox.Items.Add(newForm);
                }
            }
        }

        private void Panel_MoveUp_Click(object sender, EventArgs e)
        {
            Move(PanelBox, 1);
            updatePanelDB();
        }

        private void Panel_MoveDown_Click(object sender, EventArgs e)
        {
            Move(PanelBox, -1);
            updatePanelDB();
        }

        private void updatePanelDB()
        {
            int newPriority = 1;
            foreach (PanelItem panel in PanelBox.Items)
            {
                query = "update panels set Priority=" + newPriority + " where PanelID=";
                query += panel.id;
                database.Query(query);
                newPriority++;
            }
        }

        private void updateFormDB()
        {
            int newPriority = 1;
            foreach (FormItem form in FormBox.Items)
            {
                query = "update forms set Priority=" + newPriority + " where FormID=";
                query += form.id;
                database.Query(query);
                newPriority++;
            }
        }

        private void Move(ListBox listbox, int direction)
        {
            if (listbox.SelectedItem == null || listbox.SelectedIndex < 0)
                return;

            int newIndex = listbox.SelectedIndex - direction;

            if (newIndex < 0 || newIndex >= listbox.Items.Count)
                return;

            object selectedItem = listbox.SelectedItem;

            skip = true;
            listbox.Items.Remove(selectedItem);
            listbox.Items.Insert(newIndex, selectedItem);
            listbox.SetSelected(newIndex, true);
        }

        private void panelClicked(object sender, EventArgs e)
        {
            if (!skip)
            {
                fillFormList();
                PanelName.Text = ((PanelItem)PanelBox.SelectedItem).name;
                FormName.Text = "";
                PanelChoiceBox.SelectedIndex = PanelBox.SelectedIndex;
            }
            skip = false;
        }

        private void SavePanel_Click(object sender, EventArgs e)
        {
            int index = PanelBox.SelectedIndex;
            query = "update panels set PanelName=\"" + PanelName.Text + "\" where PanelID=";
            query += ((PanelItem)PanelBox.SelectedItem).id;

            if (!database.Query(query))
                MessageBox.Show("Could not successfully change panel name.");

            skip = true;
            fillPanelBox();
            PanelBox.SetSelected(index, true);
            PanelChoiceBox.SelectedIndex = PanelBox.SelectedIndex;
        }

        private void Form_MoveUp_Click(object sender, EventArgs e)
        {
            Move(FormBox, 1);
            updateFormDB();
        }

        private void Form_MoveDown_Click(object sender, EventArgs e)
        {
            Move(FormBox, -1);
            updateFormDB();
        }

        private void FormClicked(object sender, EventArgs e)
        {
            if (!skip && FormBox.SelectedItems.Count > 0)
            {
                FormName.Text = ((FormItem)FormBox.SelectedItem).name;

                if (Convert.ToBoolean(((FormItem)FormBox.SelectedItem).hardcoded))
                    EditFormButton.Enabled = RemoveForm.Enabled = false;
                else
                    EditFormButton.Enabled = RemoveForm.Enabled = true;
            }

            skip = false;
        }

        private void SaveForm_Click(object sender, EventArgs e)
        {
            query = "select coalesce(max(Priority), 0) as MaxPriority from ";
            query += "forms where Panel=\"" + ((PanelItem)PanelChoiceBox.SelectedItem).id + "\"";
            String newPriorityString = database.SelectString(query);
            int newPriority = Convert.ToInt32(newPriorityString) + 1;

            int index = FormBox.SelectedIndex;
            query = "update forms set FormName=\"" + FormName.Text + "\", Panel=\"";
            query += ((PanelItem)PanelChoiceBox.SelectedItem).id + "\", Priority=\"";
            query += newPriority.ToString() + "\" where FormID=";
            query += ((FormItem)FormBox.SelectedItem).id;

            if (!database.Query(query))
                MessageBox.Show("Could not successfully change form name.");

            skip = true;
            int tempPanel = PanelChoiceBox.SelectedIndex;
            PanelBox.SelectedIndex = PanelChoiceBox.SelectedIndex = tempPanel;
            fillFormList();

            if (FormBox.Items.Count > 0 && index <= (FormBox.Items.Count-1))
                FormBox.SetSelected(index, true);
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            using (CustomFormEditor form = new CustomFormEditor())
            {
                form.panelIndex = PanelBox.SelectedIndex;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.Yes)
                {
                    fillFormList();
                }
            }
        }

        private void EditFormButton_Click(object sender, EventArgs e)
        {
            if (FormBox.SelectedItems.Count > 0)
            {
                using (CustomFormEditor form = new CustomFormEditor())
                {
                    form.loadedPdf = Path.GetFileName(((FormItem)FormBox.SelectedItem).path);
                    form.panelIndex = Convert.ToInt32(((FormItem)FormBox.SelectedItem).panel);
                    form.preload = form.hideLoad = true;
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                    {
                        fillFormList();
                    }
                }
            }
        }

        private void RemoveForm_Click(object sender, EventArgs e)
        {
            if (FormBox.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + ((FormItem)FormBox.SelectedItem).name +
                    "? This will delete the template PDF. Please have a backup.", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    query = "delete from forms where FormID=" + ((FormItem)FormBox.SelectedItem).id;
                    if (database.Query(query))
                    {
                        //File.Delete("templates/" + ((FormItem)FormBox.SelectedItem).path);
                        fillFormList();
                        updateFormDB();
                    }
                }
            }
        }

        private void AddPanel_Click(object sender, EventArgs e)
        {
            query = "select coalesce(max(Priority), 0) as MaxPriority from panels";
            String newPriorityString = database.SelectString(query);
            int newPriority = Convert.ToInt32(newPriorityString) + 1;

            query = "insert into panels (PanelName, Priority) values(\"Panel " + newPriority.ToString() + "\", " + newPriority.ToString() + ")";

            if (database.Query(query))
            {
                fillPanelBox();
                PanelBox.SelectedIndex = PanelBox.Items.Count - 1;
            }
        }

        private void RemovePanel_Click(object sender, EventArgs e)
        {
            if (PanelBox.SelectedItems.Count > 0)
            {
                if (FormBox.Items.Count == 0)
                {
                    query = "delete from panels where PanelID=" + ((PanelItem)PanelBox.SelectedItem).id;

                    if (database.Query(query))
                    {
                        fillPanelBox();
                        updatePanelDB();
                    }
                }
                else
                {
                    MessageBox.Show("Panel must be empty before removal.");
                }
            }
        }
    }
}
