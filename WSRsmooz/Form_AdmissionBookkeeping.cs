using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace WSRsmooz
{
    public partial class Form_AdmissionBookkeeping : Form
    {
        public string client { get; set; } // attribute
        public Form_AdmissionBookkeeping()
        {
            InitializeComponent();
            client = "3";
            string autofill = " SELECT * FROM FR18_Bookkeeping WHERE FR18_ClientID = " + client;
            String str = PDFExporter.GlobalVar.SERVER;
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();
            while (reader.Read())
            {

                DSMIV.Text = reader.GetString("ClientDSMIV");
                PCounselor.Text = reader.GetString("ClientPCounselor");
                PaymentMethod.Text = reader.GetString("ClientMethPayInt");
                PrivateCharges.Text = reader.GetString("ClientPCharges");
                AuthorizationDate.Text = reader.GetDateTime(reader.GetOrdinal("ClientAuthStart")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ClientAuthStart")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    AuthorizationDate.Text = "";
                }

                EndDate.Text = reader.GetDateTime(reader.GetOrdinal("ClientAuthEnd")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ClientAuthStart")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    EndDate.Text = "";
                }

                Status1.Text = reader.GetString("ClientChangeStatus1");
                Status2.Text = reader.GetString("ClientChangeStatus2");
                Status3.Text = reader.GetString("ClientChangeStatus3");
                EffectiveDate1.Text = reader.GetDateTime(reader.GetOrdinal("ChangeDate1")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ChangeDate1")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    EffectiveDate1.Text = "";
                }
                BillingNotified1.Text = reader.GetDateTime(reader.GetOrdinal("ClientChangeBill1")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ClientChangeBill1")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    BillingNotified1.Text = "";
                }
                EffectiveDate2.Text = reader.GetDateTime(reader.GetOrdinal("ChangeDate2")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ChangeDate2")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    EffectiveDate2.Text = "";
                }
                BillingNotified2.Text = reader.GetDateTime(reader.GetOrdinal("ClientChangeBill2")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ClientChangeBill2")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    BillingNotified2.Text = "";
                }
                EffectiveDate3.Text = reader.GetDateTime(reader.GetOrdinal("ChangeDate3")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ChangeDate3")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    EffectiveDate3.Text = "";
                }
                BillingNotified3.Text = reader.GetDateTime(reader.GetOrdinal("ClientChangeBill3")).ToString("yyyy-MM-dd");
                if (reader.GetDateTime(reader.GetOrdinal("ClientChangeBill3")).ToString("yyyy-MM-dd") == "0001-01-01")
                {
                    BillingNotified3.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String message = ("Are you sure you want to cancel? All unsaved progress will be lost");
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void DSMIV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string column = "FR18_ClientID, ClientDSMIV, ClientPCounselor, ClientMethPayInt, ClientPCharges, ClientAuthStart, ClientAuthEnd, ChangeDate1, ChangeDate2, ChangeDate3, ClientChangeStatus1, ClientChangeStatus2, ClientChangeStatus3, ClientChangeBill1, ClientChangeBill2, ClientChangeBill3";
            string values = "'" + client + "', + '" + DSMIV.Text + "', + '" + PCounselor.Text + "', + '" + PaymentMethod.Text + "', + '" + PrivateCharges.Text + "', + '" + AuthorizationDate.Text + "', + '" + EndDate.Text + "', + '" + EffectiveDate1.Text + "', +'" + EffectiveDate2.Text + "', + '" + EffectiveDate3.Text + "', + '" + Status1.Text + "', + '" + Status2.Text + "', + '" + Status3.Text + "', + '" + BillingNotified1.Text + "', + '" + BillingNotified2.Text + "', + '" + BillingNotified3.Text + "'";
            string onupdate = "FR18_ClientID = VALUES(FR18_ClientID) , ClientDSMIV = VALUES(ClientDSMIV), ClientPCounselor = VALUES(ClientPCounselor), ClientMethPayInt = VALUES(ClientMethPayInt), ClientPCharges = VALUES(ClientPCharges), ClientAuthStart = VALUES(ClientAuthStart), ClientAuthEnd = VALUES(ClientAuthEnd), ChangeDate1 = VALUES(ChangeDate1), ChangeDate2 = VALUES(ChangeDate2), ChangeDate3 = VALUES(ChangeDate3), ClientChangeStatus1 = VALUES(ClientChangeStatus1), ClientChangeStatus2 = VALUES(ClientChangeStatus2), ClientChangeStatus3 = VALUES(ClientChangeStatus3), ClientChangeBill1 = VALUES(ClientChangeBill1), ClientChangeBill2 = VALUES(ClientChangeBill2), ClientChangeBill3 = VALUES(ClientChangeBill3)";
            MySqlConnection con = null;
            con = new MySqlConnection(PDFExporter.GlobalVar.SERVER);
            con.Open();

            MySqlCommand command = con.CreateCommand();
            //command.CommandText = "insert into FR18_Bookkeeping (ClientDSMIV, ClientPCounselor, ClientMethPayInt, ClientPCharges, ClientAuthStart, ClientAuthEnd, ChangeDate1, ClientChangeStatus1, ClientChangeBill1, ChangeDate2, ClientChangeStatus2, ClientChangeBill2, ChangeDate3, ClientChangeStatus3, ClientChangeBill3 '" + EffectiveDate1.Text + "', + '" + Status1.Text + "', + '" + BillingNotified1.Text + "', + '" + EffectiveDate2.Text + "', + '" + Status2.Text + "', + '" + BillingNotified2.Text + "', + '" + EffectiveDate3.Text + "', + '" + Status3.Text + "', + '" + BillingNotified3.Text + "') values('0' , '" + DSMIV.Text + "', + '" + PCounselor.Text + "', + '" + PaymentMethod.Text + "', + '" + PrivateCharges.Text + "', + '" + AuthorizationDate.Text + "', + '" + EndDate.Text + "' , '" + EffectiveDate1.Text + "', + '" + Status1.Text + "', + '" + BillingNotified1.Text + "', + '" + EffectiveDate2.Text + "', + '" + Status2.Text + "', + '" + BillingNotified2.Text + "', + '" + EffectiveDate3.Text + "', + '" + Status3.Text + "', + '" + BillingNotified3.Text + "')ON DUPLICATE KEY UPDATE ClientDSMIV = VALUES(ClientDSMIV), ClientPCounselor = VALUES(ClientPCounselor), ClientMethPayInt = VALUES(ClientMethPayInt), ClientPCharges = VALUES(ClientPCharges), ClientAuthStart = VALUES(ClientAuthStart), ClientAuthEnd = VALUES(ClientAuthEnd)  ChangeDate1 = VALUES(ChangeDate1), ChangeDate2 = VALUES(ChangeDate2), ChangeDate3 = VALUES(ChangeDate3), ClientChangeStatus1 = VALUES(ClientChangeStatus1), ClientChangeStatus2 = VALUES(ClientChangeStatus2), ClientChangeStatus3 = VALUES(ClientChangeStatus3), ClientChangeBill1 = VALUES(ClientChangeBill1), ClientChangeBill2 = VALUES(ClientChangeBill2), ClientChangeBill3 = VALUES(ClientChangeBill3)";

            command.CommandText = "INSERT INTO FR18_Bookkeeping (" + column + ")" + " VALUES(" + values + ")ON DUPLICATE KEY UPDATE " + onupdate;
            command.ExecuteNonQuery();
            con.Close();
            //this.Hide();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PDFExporter.Print.Bookkeping(Convert.ToInt32(client));
        }

        private void Status2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
