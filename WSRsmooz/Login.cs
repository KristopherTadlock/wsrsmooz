using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRsmooz
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            VerticalScroll.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // login check goes here
            if (!((Launcher)MdiParent).loggedIn)
            {
                ((Launcher)MdiParent).currentUser = Login_textbox_employee.Text;
                ((Launcher)MdiParent).loggedIn = true;
                ((Launcher)MdiParent).superUser = true;
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

            //this.Close();
        }
    }
}
