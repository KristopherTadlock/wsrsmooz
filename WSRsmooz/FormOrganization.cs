using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            query = "select * from panels order by Priority asc";
            panels = database.GetTable(query);

            foreach (DataRow row in panels.Rows)
            {
                PanelItem newPanel = new PanelItem();
                newPanel.name = row["PanelName"].ToString();
                newPanel.id = row["PanelID"].ToString();
                PanelBox.Items.Add(newPanel);
            }
        }

        private void fillFormList()
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
                FormBox.Items.Add(newForm);
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
            if (!skip)
                FormName.Text = ((FormItem)FormBox.SelectedItem).name;

            skip = false;
        }

        private void SaveForm_Click(object sender, EventArgs e)
        {
            int index = FormBox.SelectedIndex;
            query = "update forms set FormName=\"" + FormName.Text + "\" where FormID=";
            query += ((FormItem)FormBox.SelectedItem).id;

            if (!database.Query(query))
                MessageBox.Show("Could not successfully change form name.");

            skip = true;
            fillFormList();
            FormBox.SetSelected(index, true);
        }
    }
}
