using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace WSRsmooz
{
    public partial class ClientLog : Form
    {
        private Font printFont;
        private StreamReader streamToPrint;
        public ClientLog()
        {
            InitializeComponent();
            string str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$; Convert Zero Datetime=True;";
            string autofill = "SELECT ClientName, ClientNum, IntakeDate, ExitDate, NumOfDays, DoB, Age, Race, Ethinicity, Funder, County, Success from ClientInfo where IntakeDate > '0001-01-01' order by ClientNum ASC";
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            DataSet grid = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(newCommand);
            dataAdapter.Fill(grid, "Client Log");
            dataGridView1.Refresh();
            dataGridView1.DataSource = grid;
            dataGridView1.DataMember = "Client Log";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            string line = "";
            string temp = "";
            string filePath = "templates/DemographicReport.txt";
            string str = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            string autofill = "SELECT ClientName, ClientNum, IntakeDate, ExitDate, NumOfDays, DoB, Age, Race, Ethinicity, Funder, County, Success from ClientInfo where IntakeDate > '0001-01-01' order by ClientNum ASC";
            MySqlConnection newConnect = new MySqlConnection(str);
            MySqlCommand newCommand = new MySqlCommand(autofill, newConnect);
            newConnect.Open();
            MySqlDataReader reader = newCommand.ExecuteReader();
            int lineNum = 1;
            DateTime def = new DateTime(1, 1, 1);
            while (reader.Read())
            {
                count = reader.FieldCount;
                for (int i = 0; i < count; i += 12)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                    {
                        line = lineNum.ToString() + ":    ";
                        lineNum++;
                        for (int j = 0; j < 12; j++)
                        {
                            temp = reader.GetValue(i + j) + ", ";
                            if ((line.Length + temp.Length) < 91)
                            {
                                line += temp;
                            }
                            else if (temp.Length < 91)
                            {
                                file.WriteLine(line);
                                line = temp;
                            }
                        }
                        file.WriteLine(line);
                        file.WriteLine("___________________________________________________________________________");
                    }
                }
            }
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                Printing(filePath);
                File.Delete(filePath);
            }
            else
            {
                File.Delete(filePath);
            }
            reader.Close();
        }
        public void Printing(string filePath)
        {
            try
            {
                streamToPrint = new StreamReader(filePath);
                try
                {
                    printFont = new Font("Arial", 12);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    // Print the document.
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            String line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Iterate over the file, printing each line. 
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
