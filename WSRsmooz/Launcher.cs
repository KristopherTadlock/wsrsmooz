using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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
        Form loginForm, viewPatientLogForm, groupNotesForm, formOrganizationform;
        Form editEmployeesForm, newPatientIntakeForm, dischargePatientForm;
        Form individualNotesForm;
        
        public Launcher()
        {
            CleanUp();
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

        public void CleanUp()
        {
            String gnotes = "clientfiles/groupnotes/";

            if (Directory.Exists(gnotes))
            {
                String[] subDirectories = Directory.GetDirectories(gnotes);

                foreach (string directory in subDirectories)
                {
                    String[] filePaths = Directory.GetFiles(directory);
                    foreach (string file in filePaths)
                    {
                        String[] delimits = new String[] { "-", "." };
                        String[] pdfProps = Path.GetFileName(file).Split(delimits, StringSplitOptions.None);

                        DateTime fileDate = Convert.ToDateTime(pdfProps[0] + "/" + pdfProps[1] + "/" + pdfProps[2]);
                        if ((fileDate - DateTime.Now).TotalDays > 30)
                            File.Delete(file);
                    }
                }
            }
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
                    if (superUser)
                    {
                        launcher_button_employees.Enabled = true;
                        launcher_button_forms.Enabled = true;
                    }
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
                    launcher_button_forms.Enabled = false;
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
            this.currentWindow = "";
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
                shutdownEverything();
                this.currentWindow = "New Patient Intake";
                newPatientIntakeForm = new NewPatientIntake();
                newPatientIntakeForm.MdiParent = this;
                newPatientIntakeForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                newPatientIntakeForm.Show();
            }
        }

        private void launcher_button_viewPatientLog_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("View Patient Log"))
            {
                shutdownEverything();
                this.currentWindow = "View Patient Log";
                viewPatientLogForm = new PatientLog();
                ((PatientLog)viewPatientLogForm).admin = true;
                viewPatientLogForm.MdiParent = this;
                viewPatientLogForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                viewPatientLogForm.Show();
            }
        }

        private void launcher_button_groupClipboard_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("Group Notes"))
            {
                shutdownEverything();
                this.currentWindow = "Group Notes";
                groupNotesForm = new GroupNotes();
                ((GroupNotes)groupNotesForm).admin = true;
                groupNotesForm.MdiParent = this;
                groupNotesForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                groupNotesForm.Show();
            }
        }

        private void launcher_button_employees_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("Edit Employees"))
            {
                shutdownEverything();
                this.currentWindow = "Edit Employees";
                editEmployeesForm = new EditEmployees();
                editEmployeesForm.MdiParent = this;
                editEmployeesForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                editEmployeesForm.Show();
            }
        }

        private void launcher_button_individualNotes_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("Individual Notes"))
            {
                shutdownEverything();
                this.currentWindow = "Individual Notes";
                individualNotesForm = new IndividualNotes();
                individualNotesForm.MdiParent = this;
                individualNotesForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                individualNotesForm.Show();
            }
        }

        private void launcher_button_dischargePatient_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("Discharge Patient"))
            {
                shutdownEverything();
                this.currentWindow = "Discharge Patient";
                dischargePatientForm = new DischargePatient();
                dischargePatientForm.MdiParent = this;
                dischargePatientForm.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                dischargePatientForm.Show();
            }
        }

        private void launcher_button_forms_Click(object sender, EventArgs e)
        {
            if (!this.currentWindow.Equals("Form Organization"))
            {
                shutdownEverything();
                this.currentWindow = "Form Organization";
                formOrganizationform = new FormOrganization();
                formOrganizationform.MdiParent = this;
                formOrganizationform.Size = new Rectangle(0, 0, toolStrip.Width - 4, (this.ClientRectangle.Height - toolStrip.Height - 4)).Size;
                formOrganizationform.Show();
            }
        }
    }

    public class ClientItem
    {
        public String id { get; set; }
        public String clientName { get; set; }
        public override string ToString()
        {
            return clientName;
        }
    }

    public class PanelItem
    {
        public String name { get; set; }
        public List<FormItem> list { get; set; }
        public String id { get; set; }
        public override string ToString()
        {
            return name;
        }
    }

    public class FormItem
    {
        public String name { get; set; }
        public String path { get; set; }
        public Form form { get; set; }
        public String id { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
