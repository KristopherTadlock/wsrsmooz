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
using System.Collections;

namespace WSRsmooz
{
    public partial class PatientLog : Form
    {
        dbConnect database = new dbConnect();
        DataTable clientTable;
        DataTable forms;
        DataTable panels;
        public Boolean admin { get; set; }
        String query = "";
        ArrayList formItems = new ArrayList();

        public PatientLog()
        {
            InitializeComponent();
            admin = false;
        }

        private void PatientLog_Load(object sender, EventArgs e)
        {
            if (admin)
                AdminEditPanels.Visible = true;

            fillPanelBox();
            PanelList.SelectedIndex = 0;
            resetFormList();
            query = "select ClientNum, ClientName from ClientInfo where IntakeDate NOT LIKE '0001-01-01%'";
            clientTable = database.GetTable(query);
            updateClientList();
            triggerButtonSwap();
        }

        private void fillPanelBox()
        {
            PanelList.Items.Clear();
            query = "select * from panels order by Priority asc";
            panels = database.GetTable(query);

            foreach (DataRow row in panels.Rows)
            {
                PanelItem newPanel = new PanelItem();
                newPanel.name = row["PanelName"].ToString();
                newPanel.id = row["PanelID"].ToString();
                PanelList.Items.Add(newPanel);
            }
        }

        public void resetFormList()
        {
            formItems.Clear();

            query = "select * from forms where Panel=" + ((PanelItem)PanelList.SelectedItem).id + " order by Priority asc";
            forms = database.GetTable(query);

            foreach (DataRow form in forms.Rows)
            {
                FormItem newFormItem = new FormItem();
                newFormItem.id = form["FormID"].ToString();
                newFormItem.name = form["FormName"].ToString();
                newFormItem.panel = form["Panel"].ToString();
                newFormItem.path = "/templates/" + form["Path"].ToString() + ".pdf";

                //
                // ADD HARCODED FORMS HERE
                //
                switch (newFormItem.id)
                {
                    case "1": // Screening & Client Information 
                        newFormItem.form = new Form_ClientScreeningForm();
                        break;
                    case "2": // Admission Bookkeeping
                        newFormItem.form = new Form_AdmissionBookkeeping();
                        break;
                    case "3": // Urine Analysis
                        break;
                    default:
                        newFormItem.form = null;
                        break;
                }
                //
                // FINISH ADDING HARDCODED FORMS HERE
                //

                formItems.Add(newFormItem);
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
            DataTable loadedClient = database.GetTable(query);
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
            clientTable = database.GetTable(query);
            updateClientList();
        }

        private void triggerButtonSwap()
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

            foreach (FormItem form in formItems)
            {
                if (form.panel.Equals(((PanelItem)PanelList.SelectedItem).id))
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
                    newButton.Click += (s, e) => { openForm(form, (ClientItem)clientList.SelectedItem); };
                    Controls.Add(newButton);

                    buttonY += 45;
                    tabIndex++;
                }
            }
        }

        public void openForm(FormItem form, ClientItem client)
        {
            switch (form.id)
            {
                case "1": // Screening & Client Information 
                    ((Form_ClientScreeningForm)form.form).client = client.id;
                    break;
                case "2": // Admission Bookkeeping
                    ((Form_AdmissionBookkeeping)form.form).client = client.id;
                    break;
                case "3": // Urine Analysis
                    break;
                default: // ((Form_ASAM)form.form).client = client.id;
                    break;
            }
            form.form.ShowDialog();
        }

        private void PanelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFormList();
            triggerButtonSwap();
        }
    }
}
