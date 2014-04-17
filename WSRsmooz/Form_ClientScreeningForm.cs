using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WSRsmooz
{
    public partial class Form_ClientScreeningForm : Form
    {
        public String clientID { get; set; }
        String connectionString = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
        String query;

        public Form_ClientScreeningForm()
        {
            InitializeComponent();
        }

        private void PrimaryPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ClientPhone.Text = String.Format("{0:(###) ###-####}", ClientPhone.Text);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            String[] delimit = new String[] { "_" };
            String values = clientID;
            String update = "FR7_ClientID=VALUES(FR7_ClientID)";
            query = "insert into FR7_ClientScreening (FR7_ClientID";

            MySqlConnection newConnect = new MySqlConnection(connectionString);
            newConnect.Open();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    query += ", " + Controls[i].Name;
                    values += ", " + Controls[i].Text;
                    update += ", " + Controls[i].Name + "=VALUES(" + Controls[i].Name + ")";
                }
                else if (Controls[i] is CheckBox)
                {
                    String[] parser = Controls[i].Name.Split(delimit, StringSplitOptions.None);
                    query += ", \"" + parser[1] + "\"";

                    if (((CheckBox)Controls[i]).Checked == true)
                        values += ", true";
                    else
                        values += ", false";

                    update += ", " + Controls[i].Name + "=VALUES(" + Controls[i].Name + ")";
                }
                else if (Controls[i] is DateTimePicker)
                {
                    String[] parser = Controls[i].Name.Split(delimit, StringSplitOptions.None);
                    values += ", \"" + ((DateTimePicker)Controls[i]).Value.ToString("yyyy-MM-dd") + "\"";

                    update += ", " + Controls[i].Name + "=VALUES(" + Controls[i].Name + ")";
                }
            }
            query += ") values(" + values + ") on duplicate key update " + update;

            MySqlCommand newCommand = new MySqlCommand(query, newConnect);
            newCommand.ExecuteNonQuery();
            newConnect.Close();
        }

        private void Form_ClientScreeningForm_Load(object sender, EventArgs e)
        {
            query = "select * from FR7_ClientScreening where FR7_ClientID = '" + clientID + "' ";
            MySqlConnection newConnect = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();

            String[] parser;
            String[] delimit = new String[] { "_" };

            while (reader.Read())
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = reader.GetString(Controls[i].Name);
                    }
                    else if (Controls[i] is CheckBox)
                    {
                        if (Controls[i].Name.Contains("cb_"))
                        {
                            parser = Controls[i].Name.Split(delimit, StringSplitOptions.None);

                            if (reader.GetInt32(parser[1]) == 1)
                                ((CheckBox)Controls[i]).Checked = true;
                        }
                    }
                    else if (Controls[i] is DateTimePicker)
                    {
                        if (Controls[i].Name.Contains("dt_"))
                        {
                            parser = Controls[i].Name.Split(delimit, StringSplitOptions.None);
                            String dateString = reader.GetString(parser[1]);
                            ((DateTimePicker)Controls[i]).Value = Convert.ToDateTime(dateString);
                        }
                    }
                }
            }
            reader.Close();
            newConnect.Close();
        }
    }
}
