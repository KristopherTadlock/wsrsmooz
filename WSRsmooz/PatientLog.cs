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

        public PatientLog()
        {
            InitializeComponent();

            PanelList.SelectedIndex = 0;
            String query = "select * from clients where `Active`=true";
            clients = database.GetTable(query);
            updateClientList();
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
    }
}
