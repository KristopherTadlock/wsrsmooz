using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WSRsmooz
{
    public partial class PatientLog : Form
    {
        dbConnection database = new dbConnection();
        DataSet clients = new DataSet();
        DataSet forms = new DataSet();
        List<String>[] panels;
        public Boolean admin { get; set; }

        public PatientLog()
        {
            InitializeComponent();
            admin = false;

            panels = new List<String>[7];
            resetFormList();
            PanelList.SelectedIndex = 0;
            String query = "select * from clients where `Active`=true";
            clients = database.GetTable(query);
            updateClientList();
        }

        public void resetFormList()
        {
            String query = "select table_name from INFORMATION_SCHEMA.TABLES where " +
                "table_name like 'form_%'";
            forms = database.GetFormTemplates(query);
            PanelList.Items.Clear();
            for (int i = 0; i < panels.Length; i++)
                panels[i] = new List<String>(64);

            foreach (DataTable table in forms.Tables)
            {
                if (table.Columns.Contains("Panel"))
                {
                    int panelNumber = Convert.ToInt32(table.Rows[0]["Panel"]);
                    panels[panelNumber].Add(table.TableName.ToString());
                }
            }

            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].Count > 0)
                {
                    PanelItem newPanel = new PanelItem();
                    newPanel.name = "Panel " + i;
                    newPanel.list = new List<FormItem>(16);
                    PanelList.Items.Add(newPanel);

                    foreach (String form in panels[i])
                    {
                        FormItem newFormItem = new FormItem();
                        newFormItem.name = form;
                        if (form.Equals("Client Screening Information"))
                            newFormItem.form = new Form_ClientScreeningForm();
                        newFormItem.path = "/templates/" + form + ".pdf";
                        newPanel.list.Add(newFormItem);
                    }
                }
            }
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
            clientList.SelectedIndex = 0;
        }

        public void loadClient(ClientItem client)
        {
            String query = "select * from clients where `ID`=\"" + client + "\"";
            DataTable loadedClient = database.GetTable(query).Tables[0];
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItem != null)
            {
                loadClient((ClientItem)clientList.SelectedItem);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            String query = "";
            clientList.Items.Clear();
            if (checkBox1.Checked)
            {
                query = "select * from clients";
            }
            else
            {
                query = "select * from clients where `Active`=true";
            }
            clients = database.GetTable(query);
            updateClientList();
        }

        private void PanelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtonList((PanelItem)PanelList.SelectedItem);
        }

        private void updateButtonList(PanelItem panel)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    if (!Controls[i].Name.Contains("Admin"))
                    {
                        Controls.RemoveAt(i);
                        i--;
                    }
                }
            }

            int buttonX = 384;
            int buttonY = 109;
            int tabIndex = 1;
            foreach (FormItem form in panel.list)
            {
                Button newButton = new Button();
                newButton.Location = new Point(buttonX, buttonY);
                newButton.BackColor = SystemColors.Window;
                newButton.FlatStyle = FlatStyle.Popup;
                newButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                newButton.Size = new Size(400, 40);
                newButton.TabIndex = tabIndex;
                newButton.Text = form.name;
                newButton.UseVisualStyleBackColor = false;
                newButton.Click += (s, e) => { openForm(form, (ClientItem)clientList.SelectedItem);  };
                Controls.Add(newButton);

                buttonY += 45;
                tabIndex++;
            }
        }

        public void openForm(FormItem form, ClientItem client)
        {
            //MessageBox.Show("Open " + form + " for " + client.clientName + ".");
            form.form = new Form_ClientScreeningForm();
            ((Form_ClientScreeningForm)form.form).clientID = client.id;
            form.form.ShowDialog();
        }

        private void PatientLog_Load(object sender, EventArgs e)
        {
            if (admin)
                AdminEditPanels.Visible = true;
        }

    }
        public class PanelItem
        {
            public String name { get; set; }
            public List<FormItem> list { get; set; }
            public override string ToString()
            {
                return name;
            }
        }

    public class FormItem
    {
        public String name { get; set; }
        public String path { get; set; }
        public Form form { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
