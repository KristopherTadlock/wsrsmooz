using System;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class AddEmployeePrompt : Form
    {
        dbConnection database = new dbConnection();

        public AddEmployeePrompt()
        {
            InitializeComponent();
        }

        private void EmpCommit_Click(object sender, EventArgs e)
        {
            if (EmpName.Text != "")
            {
                String query = "insert into users (name, superUser) values(\"";
                query += EmpName.Text + "\", ";

                if (EmpAdmin.Checked)
                    query += "true)";
                else
                    query += "false)";

                database.Query(query);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
