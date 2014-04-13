using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace WSRsmooz
{
    public partial class Login : Form
    {
        dbConnection database = new dbConnection();

        public Login()
        {
            InitializeComponent();
            VerticalScroll.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // delete me
            Login_textbox_employee.Text = "Darryl Nixon";
            Login_textbox_password.Text = "testpassword";

            // Check for empty fields.
            if (Login_textbox_employee.Text.CompareTo(String.Empty) == 0)
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            else if (Login_textbox_password.Text.CompareTo(String.Empty) == 0)
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            // Begin querying for login validation.
            String query = "select password from users where name=\"" + Login_textbox_employee.Text.ToString() + "\"";
            //String hash = database.SelectString(query);
            //String inputHash = crunch(Login_textbox_password.Text);

            //if (inputHash.CompareTo(hash) == 0)
            if (this.Enabled == true)
            {
                if (!((Launcher)MdiParent).loggedIn)
                {
                    ((Launcher)MdiParent).currentUser = Login_textbox_employee.Text;
                    ((Launcher)MdiParent).loggedIn = true;

                    query = "select superUser from users where name=\"" + Login_textbox_employee.Text.ToString() + "\"";
                    ((Launcher)MdiParent).superUser = database.SelectBoolean(query);

                    //((Launcher)MdiParent).superUser = true;
                    ((Launcher)MdiParent).toggleToolstrip();

                    // successful login
                    Login_label_employee.Visible = false;
                    Login_label_password.Visible = false;
                    Login_textbox_employee.Visible = false;
                    Login_textbox_password.Visible = false;
                    Login_label_welcome.Visible = true;
                    Login_label_currentUser.Text = ((Launcher)MdiParent).currentUser;
                    Login_label_currentUser.Visible = true;
                    Login_button_login.Text = "Logout";
                }
                else
                {
                    ((Launcher)MdiParent).logout();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password combination.");
            }

            //this.Close();
        }
    }
}
