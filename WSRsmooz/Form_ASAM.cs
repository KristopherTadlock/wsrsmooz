using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WSRsmooz
{
    public partial class Form_ASAM : Form
    {
        public string client { get; set; }
        public Form_ASAM()
        {
            InitializeComponent();
            string autofill = " SELECT * FROM FR8_ASAM WHERE FR8_ClientID = '" + client + "' ";
            String str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();
            while (reader.Read())
            {
                intDate.Text = reader.GetDateTime(reader.GetOrdinal("intDate")).ToString("yyyy-MM-dd");
                if (intDate.Text == "0001-01-01")
                {
                    intDate.Text = "";
                }

                if (reader.GetInt32("PI") == 1)
                    PIch.Checked = true;
                else
                    PIch.Checked = false;

                if (reader.GetInt32("Adm") == 1)
                    Admitch.Checked = true;
                else
                    Admitch.Checked = false;

                if (reader.GetInt32("DurTX") == 1)
                    TXch.Checked = true;
                else
                    TXch.Checked = false;

                if (reader.GetInt32("Ext") == 1)
                    Exitch.Checked = true;
                else
                    Exitch.Checked = false;

                if (reader.GetInt32("immTriage1a") == 1)
                {
                    immTriage1ayes.Checked = true;
                    immTriage1ano.Checked = false;
                }
                else
                {
                    immTriage1ayes.Checked = false;
                    immTriage1ano.Checked = true;
                }

                if (reader.GetInt32("immTriage1b") == 1)
                {
                    immTriage1byes.Checked = true;
                    immTriage1bno.Checked = false;
                }
                else
                {
                    immTriage1byes.Checked = false;
                    immTriage1bno.Checked = true;
                }

                if (reader.GetInt32("immTriage2") == 1)
                {
                    immTriage2yes.Checked = true;
                    immTriage2no.Checked = false;
                }
                else
                {
                    immTriage2yes.Checked = false;
                    immTriage2no.Checked = true;
                }

                if (reader.GetInt32("immTriage3") == 1)
                {
                    immTriage3yes.Checked = true;
                    immTriage3no.Checked = false;
                }
                else
                {
                    immTriage3yes.Checked = false;
                    immTriage3no.Checked = true;
                }
            }
        }

        private void ASAMp2next_Click(object sender, EventArgs e)
        {
            String str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
            MySqlConnection con = null;
            con = new MySqlConnection(str);
            con.Open();

            int pi, adm, dtx, ext;
            if (PIch.Checked)
                pi = 1;
            else
                pi = 0;

            if (Admitch.Checked)
                adm = 1;
            else
                adm = 0;

            if (TXch.Checked)
                dtx = 1;
            else
                dtx = 0;

            if (Exitch.Checked)
                ext = 1;
            else
                ext = 0;

            int ASAM1a, ASAM1b, ASAM2, ASAM3;
            if (immTriage1ayes.Checked)
            {
                ASAM1a = 1;
            }
            else
            {
                ASAM1a = 0;
            }

            if (immTriage1byes.Checked)
            {
                ASAM1b = 1;
            }
            else
            {
                ASAM1b = 0;
            }

            if (immTriage2yes.Checked)
            {
                ASAM2 = 1;
            }
            else
            {
                ASAM2 = 0;
            }

            if (immTriage3yes.Checked)
            {
                ASAM3 = 1;
            }
            else
            {
                ASAM3 = 0;
            }

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "insert into FR8_ASAM (FR8_ClientID, intDate, PI, Adm, DurTX, Ext, immTriage1a, immTriage1b, immTriage2, immTriage3) values('" + client + "' , '" + intDate.Text + "', + '" + pi + "', + '" + adm + "', + '" + dtx + "', + '" + ext + "', + '" + ASAM1a + "', + '" + ASAM1b + "', + '" + ASAM2 + "', + '" + ASAM3 + "')ON DUPLICATE KEY UPDATE intDate = VALUES(intDate), PI = VALUES(PI), Adm = VALUES(Adm), DurTX = VALUES(DurTX), Ext = VALUES(Ext), immTriage1a = VALUES(immTriage1a), immTriage1b = VALUES(immTriage1b), immTriage2 = VALUES(immTriage2), immTriage3 = VALUES(immTriage3)";

            command.ExecuteNonQuery();
            Form_ASAM2 asam3 = new Form_ASAM2();
            asam3.client = client;
            this.Hide();
            asam3.ShowDialog();
            con.Close();
        }

        private void PIch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ASAMp2cancel_Click(object sender, EventArgs e)
        {
            String message = ("Are you sure you want to cancel? All unsaved progress will be lost");
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

    }
}
