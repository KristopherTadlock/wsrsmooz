using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace WSRsmooz
{
    public partial class ViewPatientLog : Form
    {
        dbConnection database = new dbConnection();
        DataSet clients = new DataSet();
        DataSet forms = new DataSet();
        List<String>[] panels;
        String pdfPath = "clientfiles/";

        public ViewPatientLog()
        {
            InitializeComponent();

            String query = "select * from clients where `Active`=true";
            clients = database.GetTable(query);
            panels = new List<String>[7];
            for (int i = 0; i < panels.Length; i++)
                panels[i] = new List<String>(64);
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
            listForms.Enabled = true;

            ViewPatientLog_label_patientName.Text = client.clientName;
        }

        public void resetFormList()
        {
            String query = "select table_name from INFORMATION_SCHEMA.TABLES where " + 
                "table_name like 'form_%'";
            forms = database.GetFormTemplates(query);
            listForms.Items.Clear();
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
                    ListViewItem tempHeader = new ListViewItem();
                    String headerTitle = "- Panel " + i;
                    tempHeader.BackColor = System.Drawing.Color.Silver;
                    tempHeader.Text = headerTitle;
                    listForms.Items.Add(tempHeader);

                    foreach (String form in panels[i])
                    {
                        ListViewItem tempForm = new ListViewItem(i + "-" + form);
                        listForms.Items.Add(tempForm);
                    }
                }
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

        private void listForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewPatientLog_button_newForm.Visible = true;
            ViewPatientLog_label_formName.Visible = true;
            if (listForms.SelectedItems.Count > 0)
            {
                if (listForms.SelectedItems[0].Text.StartsWith("-"))
                {
                    int selectedIndex = listForms.SelectedIndices[0];
                    selectedIndex++;
                    listForms.Items[selectedIndex].Selected = true;
                    listForms.Select();
                }
                ViewPatientLog_label_formName.Text = listForms.SelectedItems[0].Text;
                grabPDFs();
            }
        }

        public void grabPDFs()
        {
            fileListBox.Items.Clear();
            if (listForms.SelectedItems.Count < 1 || clientList.SelectedItems.Count < 1) return;
            String cool = pdfPath;
            cool += ((ClientItem)clientList.SelectedItem).id + "/";
            cool += listForms.SelectedItems[0].Text + "/";
            
            if (Directory.Exists(cool))
            {
                String[] filePaths = Directory.GetFiles(cool);
                foreach (string file in filePaths)
                {
                    String[] delimits = new String[] { "_" };
                    String[] pdfProps = Path.GetFileName(file).Split(delimits, StringSplitOptions.None);

                    String month = pdfProps[1];
                    String day = pdfProps[2];
                    String year = pdfProps[3];
                    year = year.Substring(0, year.Length - 4);

                    String listedName = month + "/" + day + "/" + year + ": " + listForms.SelectedItems[0].Text;

                    if (pdfProps[0].CompareTo("c") == 0)
                        listedName += " (completed)";
                    else
                        listedName += " (incomplete)";

                    fileListBox.Items.Add(listedName);
                }
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItem != null)
            {
                ViewPatientLog_label_patientName.Visible = true;
                fileListBox.Visible = true;
                resetFormList();
                loadClient((ClientItem)clientList.SelectedItem);
                grabPDFs();
            }
        }
    }
    public class ClientItem
    {
        public String id { get; set; }
        public String clientName { get; set; }
        public override string ToString()
        {
            return clientName;
        }
    }
}
