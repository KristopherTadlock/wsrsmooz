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
using PDFExporter;

namespace WSRsmooz
{
    public partial class Form_ASAM2 : Form
    {
        public string client { get; set; }
        public Form_ASAM2()
        {
            InitializeComponent();
            string autofill = " SELECT * FROM FR8_ASAM WHERE FR8_ClientID = " + client;
            String str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32("immTriage4a") == 1)
                {
                    immTriage4ayes.Checked = true;
                    immTriage4ano.Checked = false;
                }
                else
                {
                    immTriage4ayes.Checked = false;
                    immTriage4ano.Checked = true;
                }

                if (reader.GetInt32("immTriage4b") == 1)
                {
                    immTriage4byes.Checked = true;
                    immTriage4bno.Checked = false;
                }
                else
                {
                    immTriage4byes.Checked = false;
                    immTriage4bno.Checked = true;
                }

                if (reader.GetInt32("immTriage5a") == 1)
                {
                    immTriage5ayes.Checked = true;
                    immTriage5ano.Checked = false;
                }
                else
                {
                    immTriage5ayes.Checked = false;
                    immTriage5ano.Checked = true;
                }

                if (reader.GetInt32("immTriage5b") == 1)
                {
                    immTriage5byes.Checked = true;
                    immTriage5bno.Checked = false;
                }
                else
                {
                    immTriage5byes.Checked = false;
                    immTriage5bno.Checked = true;
                }

                if (reader.GetInt32("immTriage6") == 1)
                {
                    immTriage6yes.Checked = true;
                    immTriage6no.Checked = false;
                }
                else
                {
                    immTriage6yes.Checked = false;
                    immTriage6no.Checked = true;
                }

                if (reader.GetInt32("levelFunction1") == 1)
                {
                    LF1H.Checked = true;
                    LF1M.Checked = false;
                    LF1L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction1") == 2)
                {
                    LF1H.Checked = false;
                    LF1M.Checked = true;
                    LF1L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction1") == 3)
                {
                    LF1H.Checked = false;
                    LF1M.Checked = false;
                    LF1L.Checked = true;
                }
                else
                {
                    LF1H.Checked = false;
                    LF1M.Checked = false;
                    LF1L.Checked = false;
                }

                if (reader.GetInt32("levelFunction2") == 1)
                {
                    LF2H.Checked = true;
                    LF2M.Checked = false;
                    LF2L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction2") == 2)
                {
                    LF2H.Checked = false;
                    LF2M.Checked = true;
                    LF2L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction2") == 3)
                {
                    LF2H.Checked = false;
                    LF2M.Checked = false;
                    LF2L.Checked = true;
                }
                else
                {
                    LF2H.Checked = false;
                    LF2M.Checked = false;
                    LF2L.Checked = false;
                }

                if (reader.GetInt32("levelFunction3") == 1)
                {
                    LF3H.Checked = true;
                    LF3M.Checked = false;
                    LF3L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction3") == 2)
                {
                    LF3H.Checked = false;
                    LF3M.Checked = true;
                    LF3L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction2") == 3)
                {
                    LF3H.Checked = false;
                    LF3M.Checked = false;
                    LF3L.Checked = true;
                }
                else
                {
                    LF3H.Checked = false;
                    LF3M.Checked = false;
                    LF3L.Checked = false;
                }

                if (reader.GetInt32("levelFunction4") == 1)
                {
                    LF4H.Checked = true;
                    LF4M.Checked = false;
                    LF4L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction4") == 2)
                {
                    LF4H.Checked = false;
                    LF4M.Checked = true;
                    LF4L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction4") == 3)
                {
                    LF4H.Checked = false;
                    LF4M.Checked = false;
                    LF4L.Checked = true;
                }
                else
                {
                    LF4H.Checked = false;
                    LF4M.Checked = false;
                    LF4L.Checked = false;
                }

                if (reader.GetInt32("levelFunction5") == 1)
                {
                    LF5H.Checked = true;
                    LF5M.Checked = false;
                    LF5L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction5") == 2)
                {
                    LF5H.Checked = false;
                    LF5M.Checked = true;
                    LF5L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction5") == 3)
                {
                    LF5H.Checked = false;
                    LF5M.Checked = false;
                    LF5L.Checked = true;
                }
                else
                {
                    LF5H.Checked = false;
                    LF5M.Checked = false;
                    LF5L.Checked = false;
                }

                if (reader.GetInt32("levelFunction6") == 1)
                {
                    LF6H.Checked = true;
                    LF6M.Checked = false;
                    LF6L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction6") == 2)
                {
                    LF6H.Checked = false;
                    LF6M.Checked = true;
                    LF6L.Checked = false;
                }
                else if (reader.GetInt32("levelFunction6") == 3)
                {
                    LF6H.Checked = false;
                    LF6M.Checked = false;
                    LF6L.Checked = true;
                }
                else
                {
                    LF6H.Checked = false;
                    LF6M.Checked = false;
                    LF6L.Checked = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            String str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
            MySqlConnection con = null;
            con = new MySqlConnection(str);
            con.Open();

            int ASAM4a, ASAM4b, ASAM5a, ASAM5b, ASAM6;
            if (immTriage4ayes.Checked)
            {
                ASAM4a = 1;
            }
            else
            {
                ASAM4a = 0;
            }

            if (immTriage4byes.Checked)
            {
                ASAM4b = 1;
            }
            else
            {
                ASAM4b = 0;
            }

            if (immTriage5ayes.Checked)
            {
                ASAM5a = 1;
            }
            else
            {
                ASAM5a = 0;
            }

            if (immTriage5byes.Checked)
            {
                ASAM5b = 1;
            }
            else
            {
                ASAM5b = 0;
            }

            if (immTriage6yes.Checked)
            {
                ASAM6 = 1;
            }
            else
            {
                ASAM6 = 0;
            }

            int lf1, lf2, lf3, lf4, lf5, lf6;


            if (LF1H.Checked)
                lf1 = 1;
            else if (LF1M.Checked)
                lf1 = 2;
            else if (LF1L.Checked)
                lf1 = 3;
            else
                lf1 = 0;

            if (LF2H.Checked)
                lf2 = 1;
            else if (LF2M.Checked)
                lf2 = 2;
            else if (LF2L.Checked)
                lf2 = 3;
            else
                lf2 = 0;

            if (LF3H.Checked)
                lf3 = 1;
            else if (LF3M.Checked)
                lf3 = 2;
            else if (LF3L.Checked)
                lf3 = 3;
            else
                lf3 = 0;

            if (LF4H.Checked)
                lf4 = 1;
            else if (LF4M.Checked)
                lf4 = 2;
            else if (LF4L.Checked)
                lf4 = 3;
            else
                lf4 = 0;

            if (LF5H.Checked)
                lf5 = 1;
            else if (LF5M.Checked)
                lf5 = 2;
            else if (LF5L.Checked)
                lf5 = 3;
            else
                lf5 = 0;

            if (LF6H.Checked)
                lf6 = 1;
            else if (LF6M.Checked)
                lf6 = 2;
            else if (LF6L.Checked)
                lf6 = 3;
            else
                lf6 = 0;

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "insert into FR8_ASAM (FR8_ClientID, levelFunction1, levelFunction2, levelFunction3, levelFunction4, levelFunction5, levelFunction6, immTriage4a, immTriage4b, immTriage5a, immTriage5b, immTriage6) values('" + client + "', '" + lf1 + "' , + '" + lf2 + "', + '" + lf3 + "', + '" + lf4 + "', + '" + lf5 + "', + '" + lf6 + "', + '" + ASAM4a + "', + '" + ASAM4b + "', + '" + ASAM5a + "', + '" + ASAM5b + "', + '" + ASAM6 + "')ON DUPLICATE KEY UPDATE FR8_ClientID = VALUES(FR8_ClientID), levelFunction1 = VALUES(levelFunction1), levelFunction2 = VALUES(levelFunction2), levelFunction3 = VALUES(levelFunction3), levelFunction4 = VALUES(levelFunction4), levelFunction5 = VALUES(levelFunction5), levelFunction6 = VALUES(levelFunction6), immTriage4a = VALUES(immTriage4a), immTriage4b = VALUES(immTriage4b), immTriage5a = VALUES(immTriage5a), immTriage5b = VALUES(immTriage5b), immTriage6 = VALUES(immTriage6)";

            command.ExecuteNonQuery();
            con.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PDFExporter.Print.ASAM(Convert.ToInt32(client));
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Form_ASAM asam2 = new Form_ASAM();
            asam2.client = client;
            this.Hide();
            asam2.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
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
