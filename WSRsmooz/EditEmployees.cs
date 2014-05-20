using System;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace WSRsmooz
{
    public partial class EditEmployees : Form
    {
        dbConnect database = new dbConnect();
        DataTable employees = new DataTable();
        private DataTable logTable = new DataTable();

        public EditEmployees()
        {
            InitializeComponent();
            String query = "select * from users where `Active`=true";
            employees = database.GetTable(query);

            updateEmployeeList();
            employeeList.SetSelected(0, true);
        }

        static string crunch(String bunch)
        {
            SHA256Managed encrypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = encrypt.ComputeHash(Encoding.UTF8.GetBytes(bunch), 0, Encoding.UTF8.GetByteCount(bunch));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }

        public void updateEmployeeList()
        {
            employeeList.Items.Clear();
            String query = "select * from users where `Active`=true";
            employees = database.GetTable(query);

            DataTable employeeTable = employees;
            foreach (DataRow row in employeeTable.Rows)
            {
                EmployeeItem item = new EmployeeItem();
                item.id = row["employeeID"].ToString();
                item.employeeName = row["name"].ToString();
                item.superUser = Convert.ToBoolean(row["superUser"].ToString());
                item.promptOnLogin = Convert.ToBoolean(row["PasswordPromptOnLogin"].ToString());
                employeeList.Items.Add(item);
            }
            employeeList.SetSelected(0, true);
        }

        public void loadEmployee(EmployeeItem employee)
        {
            String query = "select * from users where `employeeID`=\"" + employee + "\"";
            DataTable loadedClient = database.GetTable(query);

            EmpName.Text = employee.employeeName;

            if (employee.superUser)
                EmpAdmin.Checked = true;
            else
                EmpAdmin.Checked = false;

            if (employee.promptOnLogin)
                EmpPrompt.Checked = true;
            else
                EmpPrompt.Checked = false;            
        }

        private void employeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeList.SelectedItem != null)
            {
                loadEmployee((EmployeeItem)employeeList.SelectedItem);
                updateLog((EmployeeItem)employeeList.SelectedItem);
            }
        }

        private void updateLog(EmployeeItem employee)
        {
            String query = "select timestamp, message from AdminLog where empID=" + employee.id + " order by timestamp desc";
            logTable = database.GetTable(query);

            if (logTable.Rows.Count > 0)
            {
                adminLog.Visible = true;
                adminLog.DataSource = logTable;
                adminLog.Refresh();
            }
            else
            {
                adminLog.Visible = false;
            }
        }

        private void EmpCommit_Click(object sender, EventArgs e)
        {
            String query = "";
            if (EmpPassword.Text == "")
                query = "insert into users (employeeID, name, superUser, PasswordPromptOnLogin) ";
            else
                query = "insert into users (employeeID, name, superUser, PasswordPromptOnLogin, password) ";
            query += "values(" + ((EmployeeItem)employeeList.SelectedItem).id + ", \"";
            query += EmpName.Text + "\", ";

            if (EmpAdmin.Checked) query += "true, ";
            else query += "false, ";

            if (EmpPrompt.Checked) query += "true";
            else query += "false";

            if (EmpPassword.Text != "")
                query += ", \"" + crunch(EmpPassword.Text.ToString()) + "\"";

            query += ") on duplicate key update employeeID=values(employeeID), ";
            query += "name=values(name), superUser=values(superUser), ";
            query += "PasswordPromptOnLogin=values(PasswordPromptOnLogin)";

            if (EmpPassword.Text != "")
                query += ", password=\"" + crunch(EmpPassword.Text.ToString()) + "\"";

            EmpPassword.Text = "";

            if (database.Query(query))
            {
                MessageBox.Show(((EmployeeItem)employeeList.SelectedItem).employeeName + " saved successfully.");
                updateEmployeeList();
            }

            query = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
            query += "edited employee " + EmpName.Text;
            query += ".\")";
            database.Query(query);
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePrompt AddEmployeePrompt = new AddEmployeePrompt();
            DialogResult EmployeePromptResult = AddEmployeePrompt.ShowDialog();

            if (EmployeePromptResult == DialogResult.OK)
            {
                string query = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                query += "added a new employee";
                query += ".\")";
                database.Query(query);
                updateEmployeeList();
            }
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            String query = "delete from users where CannotBeRemoved=false and employeeID=";
            query += ((EmployeeItem)employeeList.SelectedItem).id;

            if (database.Query(query))
            {
                query = "insert into AdminLog(empID, message) values(" + ((Launcher)MdiParent).currentID + ", \"" + ((Launcher)MdiParent).currentUser + " ";
                query += "removed employee " + ((EmployeeItem)employeeList.SelectedItem).employeeName;
                query += ".\")";
                database.Query(query);
                updateEmployeeList();
            }
        }
    }
    public class EmployeeItem
    {
        public String id { get; set; }
        public String employeeName { get; set; }
        public Boolean superUser { get; set; }
        public Boolean promptOnLogin { get; set; }
        public override string ToString()
        {
            return employeeName;
        }
    }
}
