using System;
using System.Windows.Forms;
using System.Linq;
using MySql.Data.MySqlClient;

namespace WSRsmooz
{
    public partial class Form_ClientScreeningForm : Form
    {
        public string client { get; set; }
        String connectionString = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
        String query;

        public Form_ClientScreeningForm()
        {
            InitializeComponent();
        }

        private void PrimaryPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //ClientPhone.Text = String.Format("{0:(###) ###-####}", ClientPhone.Text);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            String[] delimit = new String[] { "_" };
            String values = client;
            String update = "FR7_ClientID=VALUES(FR7_ClientID)";
            query = "insert into FR7_ClientScreening (FR7_ClientID";

            MySqlConnection newConnect = new MySqlConnection(connectionString);
            newConnect.Open();

            foreach (Control d in this.Controls.OfType<GroupBox>())
            {
                foreach (Control c in d.Controls)
                {
                    if (c is TextBox)
                    {
                        if (((TextBox)c).Text != "")
                        {
                            query += ", " + c.Name;
                            values += ", \"" + c.Text + "\"";
                            update += ", " + c.Name + "=VALUES(" + c.Name + ")";
                        }
                    }
                    else if (c is CheckBox)
                    {
                        String[] parser = c.Name.Split(delimit, StringSplitOptions.None);
                        query += ", " + parser[1];

                        if (((CheckBox)c).Checked == true)
                            values += ", true";
                        else
                            values += ", false";

                        update += ", " + parser[1] + "=VALUES(" + parser[1] + ")";
                    }
                    else if (c is DateTimePicker)
                    {
                        String[] parser = c.Name.Split(delimit, StringSplitOptions.None);
                        query += ", " + parser[1];
                        values += ", \"" + ((DateTimePicker)c).Value.ToString("yyyy-MM-dd") + "\"";

                        update += ", " + parser[1] + "=VALUES(" + parser[1] + ")";
                    }
                }
            }
            query += ") values(" + values + ") on duplicate key update " + update;
            MySqlCommand newCommand = new MySqlCommand(query, newConnect);
            newCommand.ExecuteNonQuery();
            newConnect.Close();
        }

        private void Form_ClientScreeningForm_Load(object sender, EventArgs e)
        {
            query = "select * from FR7_ClientScreening where FR7_ClientID = '" + client + "'";
            MySqlConnection newConnect = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();

            String[] parser;
            String[] delimit = new String[] { "_" };

            while (reader.Read())
            {
                foreach (Control d in this.Controls.OfType<GroupBox>())
                {
                    foreach (Control c in d.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = reader.GetString(c.Name);
                        }
                        else if (c is CheckBox)
                        {
                            if (c.Name.Contains("cb_"))
                            {
                                parser = c.Name.Split(delimit, StringSplitOptions.None);

                                if (reader.GetInt32(parser[1]) == 1)
                                    ((CheckBox)c).Checked = true;
                            }
                        }
                        else if (c is DateTimePicker)
                        {
                            if (c.Name.Contains("dt_"))
                            {
                                parser = c.Name.Split(delimit, StringSplitOptions.None);
                                ((DateTimePicker)c).Value = reader.GetDateTime(reader.GetOrdinal(parser[1]));
                            }
                        }
                    }
                }
            }
            reader.Close();
            newConnect.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PDFExporter.Print.ClientScreening(Convert.ToInt32(client));
        }
    }
}
