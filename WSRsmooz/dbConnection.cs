using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace WSRsmooz
{
    class dbConnection
    {
        private MySqlConnection connection;
        private string server, port, database, uid, password;

        public dbConnection()
        {
            // Change to local MySQL server ISP.
            // 192.241.235.225  DigitalOcean Dev Droplet
            server =    "192.241.235.225";
            port =      "3306";

            database =  "westSlopeDB";
            uid =       "westslope";
            password =  "whatwhat";

            string newConnection = "Server=" + server +
                ";Port=" + port + ";Database=" + database +
                ";Uid=" + uid + ";Pwd=" + password + ";";

            connection = new MySqlConnection(newConnection);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: // Cannot connect to server.
                        MessageBox.Show("Cannot connect to server. Please check connection.");
                        break;

                    case 1045: // Invalid username or password.
                        MessageBox.Show("Invalid username/password. Please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Query(String query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1060:
                            break;
                        default:
                            MessageBox.Show(ex.ToString());
                            break;
                    }
                }
                this.CloseConnection();
                return true;
            }
            return false;
        }

        public Dictionary<string, string> GetTableData(String query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                Dictionary<string, string> dict = new Dictionary<string, string>();
                for (int lp = 0; lp < dataReader.FieldCount; lp++)
                {
                    dict.Add(dataReader.GetName(lp), dataReader.GetValue(lp).ToString());
                }

                dataReader.Close();
                this.CloseConnection();

                return dict;
            }
            else
            {
                return null;
            }
        }

        /*public DataSet GetTables(String query)
        {
            if (this.OpenConnection() == true)
            {
                DataSet grid = new DataSet();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader[0].GetType);
                    DataTable newTable = (DataTable)dataReader[0];
                    grid.Tables.Add(newTable);
                }

                dataReader.Close();
                this.CloseConnection();
                return grid;
            }
            else
            {
                return null;
            }
        }*/

        public DataSet GetFormTemplates(String query)
        {
            if (this.OpenConnection() == true)
            {
                DataSet grid = new DataSet();
                List<String> tableNames = new List<String>();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    tableNames.Add(dataReader[0].ToString());
                }

                dataReader.Close();
                this.CloseConnection();

                foreach (String table in tableNames)
                {
                    DataSet temp = new DataSet();
                    String tempQuery = "select * from `" + table + "`";
                    temp = GetTable(tempQuery);
                    temp.Tables[0].TableName = temp.Tables[0].Rows[0]["Form Name"].ToString();
                    DataTable tempTable = temp.Tables[0].Copy();
                    grid.Tables.Add(tempTable);
                }

                return grid;
            }
            else
            {
                return null;
            }
        }

        public DataSet GetTable(String query)
        {
            if (this.OpenConnection() == true)
            {
                DataSet grid = new DataSet();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(grid);

                this.CloseConnection();
                return grid;
            }
            else
            {
                return null;
            }
        }

        public String SelectString(String query)
        {
            if (this.OpenConnection() == true)
            {
                String result = null;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                if (dataReader.HasRows)
                    result = dataReader.GetValue(0).ToString();

                dataReader.Close();
                this.CloseConnection();

                return result;
            }
            else
            {
                return null;
            }
        }

        public Boolean SelectBoolean(String query)
        {
            if (this.OpenConnection() == true)
            {
                Boolean result = false;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                if (dataReader.HasRows)
                    result = Convert.ToBoolean(dataReader.GetValue(0));

                dataReader.Close();
                this.CloseConnection();

                return result;
            }
            else
            {
                return false;
            }
        }
    }
}
