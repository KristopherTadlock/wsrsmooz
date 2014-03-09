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

        // initialize form children
        Form formB = new Login();
        
        public Launcher()
        {
            InitializeComponent();
            loggedIn = false;
            superUser = false;
            currentUser = "";

            // set form children properties properly to fit within mdi
            formB.MdiParent = this;
            formB.Size = new Rectangle(0, 0, toolStrip.Width-4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
            formB.Show();

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
            formB.Close();
            formB = new Login();
            formB.MdiParent = this;
            formB.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
            formB.Show();
        }

        private void launcher_button_login_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                loggedIn = false;
                superUser = false;
                currentUser = "";
                toggleToolstrip();
                //shutdownEverything();
                refreshLoginScreen();
            }
            else
            {
                refreshLoginScreen();
            }
        }
    }
}
