using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WSRsmooz
{
    public partial class EditClient : Form
    {
        public string client { get; set; } // attribute
        string str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$; Convert Zero Datetime=True; Allow Zero Datetime=True;";

        public EditClient()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string column = "ClientID, ClientName, ClientNum, IntakeDate, NumOfDays, DoB, Age, Race, Gender, Ethinicity, Funder, County, ClientCity, ClientAddr, ClientState, ClientZip, ClientPhone, SecPhone, AName, AAddr, ACPName, ACPNumber";
            string values = "@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22";
            DateTime temp;
            string onupdate = "ClientID = VALUES(ClientID) , ClientName = VALUES(ClientName), IntakeDate = VALUES(IntakeDate),  NumOfDays = VALUES(NumOfDays), DoB = VALUES(DoB), Age = VALUES(Age), Race = VALUES(Race), Gender = VALUES(Gender), Ethinicity = VALUES(Ethinicity), Funder = VALUES(Funder), County = VALUES(County), ClientCity = VALUES(ClientCity), ClientAddr = VALUES(ClientAddr), ClientState = VALUES(ClientState), ClientZip = VALUES(ClientZip), ClientPhone = VALUES(ClientPhone), SecPhone = VALUES(SecPhone), AName = VALUES(AName), AAddr = VALUES(AAddr), ACPName = VALUES(ACPName), ACPNumber = VALUES(ACPNumber)";
            MySqlConnection con = null;
            con = new MySqlConnection(str);
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO ClientInfo (" + column + ")" + " VALUES(" + values + ")ON DUPLICATE KEY UPDATE " + onupdate;
            command.Parameters.Add("@1", client);
            command.Parameters.Add("@2", ClientName.Text);
            command.Parameters.Add("@3", ClientNum.Text);
            try
            {
                temp = Convert.ToDateTime(IntakeDate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, invalid intake date");
                temp = Convert.ToDateTime("1/1/1800");
            }
            command.Parameters.Add("@4", temp);
            command.Parameters.Add("@5", NumOfDays.Text);
            try
            {
                temp = Convert.ToDateTime(DoB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, invalid date of birth");
                temp = Convert.ToDateTime("1/1/1800");
            }
            command.Parameters.Add("@6", temp);
            command.Parameters.Add("@7", Age.Text);
            command.Parameters.Add("@8", Race.Text);
            command.Parameters.Add("@9", Gender.Text);
            command.Parameters.Add("@10", Ethinicity.Text);
            command.Parameters.Add("@11", Funder.Text);
            command.Parameters.Add("@12", County.Text);
            command.Parameters.Add("@13", ClientCity.Text);
            command.Parameters.Add("@14", ClientAddr.Text);
            command.Parameters.Add("@15", ClientState.Text);
            command.Parameters.Add("@16", ClientZip.Text);
            command.Parameters.Add("@17", ClientPhone.Text);
            command.Parameters.Add("@18", SecPhone.Text);
            command.Parameters.Add("@19", AName.Text);
            command.Parameters.Add("@20", AAddr.Text);
            command.Parameters.Add("@21", ACPName.Text);
            command.Parameters.Add("@22", ACPNumber.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully!");
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            string autofill = " SELECT * FROM ClientInfo WHERE ClientID = " + client;
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();
            while (reader.Read())
            {
                ClientName.Text = reader.GetString("ClientName");
                ClientNum.Text = reader.GetString("ClientNum");
                IntakeDate.Text = reader.GetDateTime("IntakeDate").ToString("MM/dd/yyyy");
                NumOfDays.Text = reader.GetString("NumOfDays");
                DoB.Text = reader.GetDateTime("DoB").ToString("MM/dd/yyyy");
                Age.Text = reader.GetString("Age");
                Race.Text = reader.GetString("Race");
                Gender.Text = reader.GetString("Gender");
                Ethinicity.Text = reader.GetString("Ethinicity");
                Funder.Text = reader.GetString("Funder");
                County.Text = reader.GetString("County");
                ClientCity.Text = reader.GetString("ClientCity");
                ClientAddr.Text = reader.GetString("ClientAddr");
                ClientState.Text = reader.GetString("ClientState");
                ClientZip.Text = reader.GetString("ClientZip");
                ClientPhone.Text = reader.GetString("ClientPhone");
                SecPhone.Text = reader.GetString("SecPhone");
                AName.Text = reader.GetString("AName");
                AAddr.Text = reader.GetString("AAddr");
                ACPName.Text = reader.GetString("ACPName");
                ACPNumber.Text = reader.GetString("ACPNumber");
            }
        }
    }
}
