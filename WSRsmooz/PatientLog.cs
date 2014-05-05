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
        dbConnect database2 = new dbConnect();
        DataTable clientTable = new DataTable();
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
            String query = "select ClientNum, ClientName from ClientInfo where IntakeDate NOT LIKE '0001-01-01%'";
            clientTable = database2.GetTable(query);
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
                        /*if (form.Equals("Client Screening Information"))
                            newFormItem.form = new Form_ClientScreeningForm();
                        else */if (form.Equals("Admission Bookkeeping"))
                            newFormItem.form = new Form_AdmissionBookkeeping();
                        /*else if (form.Equals("ASAM"))
                            newFormItem.form = new Form_ASAM();*/
                        newFormItem.path = "/templates/" + form + ".pdf";
                        newPanel.list.Add(newFormItem);
                    }
                }
            }
        }

        public void updateClientList()
        {
            foreach (DataRow row in clientTable.Rows)
            {
                ClientItem item = new ClientItem();
                item.id = row["ClientNum"].ToString();
                item.clientName = row["ClientName"].ToString();
                clientList.Items.Add(item);
            }
            clientList.SelectedIndex = 0;
        }

        public void loadClient(ClientItem client)
        {
            String query = "select ClientNum, ClientName from ClientInfo where `ClientNum`=\"" + client + "\"";
            DataTable loadedClient = database2.GetTable(query);
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
                query = "select ClientNum, ClientName from ClientInfo";
            }
            else
            {
                query = "select ClientNum, ClientName from ClientInfo where IntakeDate NOT LIKE '0001-01-01%'";
            }
            clientTable = database2.GetTable(query);
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
            /*if (form.form.Equals("Client Screening Information"))
            {
                form.form = new Form_ClientScreeningForm();
                ((Form_ClientScreeningForm)form.form).client = client.id;
            }
            else*/ if (form.form.Equals("Admission Bookkeeping"))
            {
                form.form = new Form_AdmissionBookkeeping();
                ((Form_AdmissionBookkeeping)form.form).client = client.id;
            }/*
            else if (form.form.Equals("ASAM"))
            {
                form.form = new Form_ASAM();
                ((Form_ASAM)form.form).client = client.id;
            }
            form.form.ShowDialog();*/
        }

        private void PatientLog_Load(object sender, EventArgs e)
        {
            if (admin)
                AdminEditPanels.Visible = true;
        }

    }
}
