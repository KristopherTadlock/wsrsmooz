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
    public partial class Launcher : Form
    {
        // initialize basic variables
        private String defaultTitle = "West Slope Recovery";

        // initialize user control variables
        public bool loggedIn { get; set; }
        public bool superUser { get; set; }
        public String currentUser { get; set; }
        public String currentWindow { get; set; }

        // initialize form children
        Form loginForm;
        Form newPatientIntakeForm;
        
        public Launcher()
        {
            InitializeComponent();

            loggedIn = false;
            superUser = false;
            currentUser = "";
            currentWindow = "Login";

            // set form children properties properly to fit within mdi
            loginForm = new Login();
            loginForm.MdiParent = this;
            loginForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
            loginForm.Show();

        }

        public void toggleToolstrip()
        {
            switch (loggedIn)
            {
                case true:
                    launcher_button_viewPatientLog.Enabled = true;
                    launcher_button_newPatientIntake.Enabled = true;
                    launcher_button_groupClipboard.Enabled = true;
                    launcher_button_individualNotes.Enabled = true;
                    launcher_button_dischargePatient.Enabled = true;
                    if (superUser) launcher_button_employees.Enabled = true;
                    launcher_button_login.Text = "&Logout";
                    launcher_button_login.Image = WSRsmooz.Properties.Resources.logout;
                    this.Text = defaultTitle + " - [" + currentUser + "]";
                    break;
                default:
                    launcher_button_viewPatientLog.Enabled = false;
                    launcher_button_newPatientIntake.Enabled = false;
                    launcher_button_groupClipboard.Enabled = false;
                    launcher_button_individualNotes.Enabled = false;
                    launcher_button_dischargePatient.Enabled = false;
                    launcher_button_employees.Enabled = false;
                    launcher_button_login.Text = "&Login";
                    launcher_button_login.Image = WSRsmooz.Properties.Resources.login;
                    this.Text = defaultTitle;
                    break;
            }
        }

        private void refreshLoginScreen()
        {
            this.currentWindow = "Login";
            loginForm = new Login();
            loginForm.MdiParent = this;
            loginForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
            loginForm.Show();
        }

        public void logout()
        {
            loggedIn = false;
            superUser = false;
            currentUser = "";
            toggleToolstrip();
            shutdownEverything();
            refreshLoginScreen();
        }

        public void shutdownEverything()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Launcher")
                    Application.OpenForms[i].Close();
            }
        }

        private void launcher_button_login_Click(object sender, EventArgs e)
        {
            if (loggedIn)
                logout();
            else
                if (!this.currentWindow.Equals("Login"))
                   refreshLoginScreen();
        }

        private void launcher_button_newPatientIntake_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("New Patient Intake"))
            {
                this.currentWindow = "New Patient Intake";
                newPatientIntakeForm = new NewPatientIntake();
                newPatientIntakeForm.MdiParent = this;
                newPatientIntakeForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                newPatientIntakeForm.Show();
            }
        }
    }
}
