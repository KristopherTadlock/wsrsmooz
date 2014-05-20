using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using System.IO;

namespace WSRsmooz
{
    public partial class PrintGeneric : Form
    {
        public FormItem f { get; set; }
        public PrintGeneric()
        {
            InitializeComponent();
            f = new FormItem();
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            switch (this.f.name)
            {
                case "Urine Analysis":
                    i = UA(Convert.ToInt32(this.f.id));
                    break;
                case "Criminal Justice Release":
                    CrimJust(Convert.ToInt32(this.f.id));
                    break;
                case "Safekeeping Agreement":
                    SafeKeep(Convert.ToInt32(this.f.id));
                    break;
                case "Phase I Evaluation":
                    PhaseEval(Convert.ToInt32(this.f.id));
                    break;
                case "Release of Health":
                    Authorization(Convert.ToInt32(this.f.id));
                    break;
                case "Follow-up and Consent":
                    FollowupandCon(Convert.ToInt32(this.f.id));
                    break;
                case "Health Questionairre":
                    HQ(Convert.ToInt32(this.f.id));
                    break;
                case "CFR Statement":
                    CFR(Convert.ToInt32(this.f.id));
                    break;
                case "Consent for Release":
                    ReleaseInfor(Convert.ToInt32(this.f.id));
                    break;
                case "Discharge Criteria":
                    DisC(Convert.ToInt32(this.f.id));
                    break;
                case "Self Evaluation":
                    ClientSelf(Convert.ToInt32(this.f.id));
                    break;
                case "Clients Rights":
                    ClientRights(Convert.ToInt32(this.f.id));
                    break;
                case "Phase II Evaluation":
                    PhaseII(Convert.ToInt32(this.f.id));
                    break;
                case "Residental Rules":
                    TProgram(Convert.ToInt32(this.f.id));
                    break;
                case "Group Rules":
                    GroupRu(Convert.ToInt32(this.f.id));
                    break;
                case "Hygiene Standards":
                    Hygiene(Convert.ToInt32(this.f.id));
                    break;
                case "Fire Response Plan":
                    FireResp(Convert.ToInt32(this.f.id));
                    break;
                default:
                    break;
            }
            this.Close();
        }
        public static int UA(int ID)
        {
            string Document = "1-UA.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));

                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int CrimJust(int ID)
        {
            string Document = "7-Criminal Justice Release Doc3.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int SafeKeep(int ID)
        {
            string Document = "6-Safekeeping Agreement.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int PhaseEval(int ID)
        {
            string Document = "6-Phase Eval.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                    pdfFormFields.SetField("Date", DateTime.Now.ToString("d"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int Authorization(int ID)
        {
            DateTime def = new DateTime(1, 1, 1);
            DateTime temp;
            string Document = "4-AUTHORIZATION FOR RELEASE OF PSYCHIATRIC.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                    temp = reader2.GetDateTime("DOB");
                    if (temp != def)
                    {
                        pdfFormFields.SetField("DoB", temp.Date.ToString("d"));
                    }
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int FollowupandCon(int ID)
        {
            string Document = "3-Follow-up and Consent.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));

                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int HQ(int ID)
        {
            string Document = "2-H.Q..pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum1", reader2.GetString("ClientNum"));
                    pdfFormFields.SetField("ClientNum2", reader2.GetString("ClientNum"));
                    pdfFormFields.SetField("ClientNum3", reader2.GetString("ClientNum"));
                    pdfFormFields.SetField("ClientNum4", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int CFR(int ID)
        {
            string Document = "2-CFR Statement.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int ReleaseInfor(int ID)
        {
            string Document = "5-Consent Doc1.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command = new MySqlCommand(autofill, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                pdfFormFields.SetField("ClientName", reader.GetString("ClientName"));
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int DisC(int ID)
        {
            string Document = "3-Discharge Criteria.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int ClientSelf(int ID)
        {
            string Document = "5-Client Self Evaluation and Exit Plan.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                    pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int ClientRights(int ID)
        {
            string Document = "6-CLIENT RIGHTS AND CONSENT to TREATMENT.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));

                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }

        public static int PhaseII(int ID)
        {
            string Document = "7-Phase II info.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));

                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }

        public static int TProgram(int ID)
        {
            string Document = "7-The Program and Resident Rules.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));

                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int GroupRu(int ID)
        {
            string Document = "8-Group Rules.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        public static int Hygiene(int ID)
        {
            string Document = "9-Hygiene Standards.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientNum"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }

        public static int FireResp(int ID)
        {
            string Document = "10-Fire Response Plan.pdf";
            string PDF = GlobalVar.FILEPATH + Document;
            string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
            PdfReader PDFnew = new PdfReader(PDF);
            PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            string autofill2 = " SELECT * FROM ClientInfo WHERE " + ID.ToString() + " = ClientID";
            MySqlConnection connect2 = new MySqlConnection(GlobalVar.SERVER);
            MySqlCommand command2 = new MySqlCommand(autofill2, connect2);
            connect2.Open();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                if (reader2.GetInt32("ClientNum") != 0)
                {
                    pdfFormFields.SetField("ClientNum", reader2.GetString("ClientID"));
                }
            }
            else
            {
                pdfStamper.Close();
                return 0;
            }
            pdfStamper.Close();
            return print(newPDF);
        }
        static int print(string file)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "printpdf.exe";
                proc.StartInfo.Arguments = "-print-dialog -exit-on-print \"" + file + "\"";
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
                proc.WaitForExit();
                //File.Delete(file);
                return 1;
            }
            catch (Exception)
            {
                File.Delete(file);
                return -1;
            }
        }

        private void PrintGeneric_Load(object sender, EventArgs e)
        {
            label2.Text = f.name;
        }
    }
}
