using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WSRsmooz
{
    public partial class NewPasswordPrompt : Form
    {
        dbConnection database = new dbConnection();
        public String employee { get; set; }

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

        public NewPasswordPrompt()
        {
            InitializeComponent();
        }

        private void Success_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text != "")
            {
                String inputHash = crunch(NewPasswordTextBox.Text);

                String query = "update users set password=\"";
                query += inputHash + "\", PasswordPromptOnLogin=false where name=\"" + employee + "\"";

                database.Query(query);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NewPasswordTextBox.PasswordChar = ShowPWCheckbox.Checked ? '\0' : '*';
        }
    }
}
