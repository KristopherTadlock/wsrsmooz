using System;
using System.IO;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;

namespace PDFExporter
{
    public class GlobalVar
    {
        public const string SERVER = "Server=192.241.235.225;Database=development;Uid=dev;Pwd=rqki4t#Kr$;";
        public const string FILEPATH = "templates/";
    }
    public class Print
    {
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
                        File.Delete(file);
                        return 1;
                    }
                    catch (Exception)
                    {
                        File.Delete(file);
                        return -1;
                    }
                }
                public static int ClientScreening(int ID)
                {
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp;
                    int temp2;
                    string Document = "1-Screening & Client Information.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR7_ClientScreening WHERE " + ID.ToString() + " = FR7_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        pdfFormFields.SetField("ClientNameFirst", reader.GetString("ClientName"));
                        pdfFormFields.SetField("ClientNameLast", reader.GetString("ClientLName"));
                        temp = reader.GetDateTime("DoB");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DoB", temp.Date.ToString("d"));
                        }
                        if (reader.GetString("Vet").Equals("True"))
                        {
                            pdfFormFields.SetField("Vet", "X");
                        }
                        temp2 = reader.GetInt32("Age");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("Age", temp2.ToString());
                        }
                        pdfFormFields.SetField("ClientAddr", reader.GetString("ClientAddr"));
                        pdfFormFields.SetField("ClientCity", reader.GetString("ClientCity"));
                        pdfFormFields.SetField("ClientState", reader.GetString("ClientState"));
                        temp2 = reader.GetInt32("ClientZip");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("ClientZip", temp2.ToString());
                        }
                        pdfFormFields.SetField("County", reader.GetString("County"));
                        temp2 = reader.GetInt32("numYears");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("numYears", temp2.ToString());
                        }
                        pdfFormFields.SetField("ClientPhone", reader.GetString("ClientPhone"));
                        pdfFormFields.SetField("ClientWCM", reader.GetString("ClientWCM"));
                        pdfFormFields.SetField("SSN", reader.GetString("SSN"));
                        pdfFormFields.SetField("DL", reader.GetString("DL"));
                        pdfFormFields.SetField("DLS", reader.GetString("DLS"));
                        pdfFormFields.SetField("MAR", reader.GetString("MAR"));
                        pdfFormFields.SetField("Partner", reader.GetString("Partner"));
                        pdfFormFields.SetField("EName", reader.GetString("EFName"));
                        pdfFormFields.SetField("ERel", reader.GetString("ERel"));
                        pdfFormFields.SetField("EPhone", reader.GetString("FPhone"));
                        pdfFormFields.SetField("Eaddr", reader.GetString("Eaddr"));
                        pdfFormFields.SetField("ECity", reader.GetString("ECity"));
                        pdfFormFields.SetField("EState", reader.GetString("EState"));
                        pdfFormFields.SetField("EZip", reader.GetString("EZIP"));
                        pdfFormFields.SetField("ECWPhone", reader.GetString("ECWPhone"));
                        pdfFormFields.SetField("AName", reader.GetString("AName"));
                        pdfFormFields.SetField("ACPName", reader.GetString("ACPName"));
                        pdfFormFields.SetField("ACounty", reader.GetString("ACounty"));
                        pdfFormFields.SetField("ACPnumber", reader.GetString("ACPnumber"));
                        pdfFormFields.SetField("AAddr", reader.GetString("AAddr"));
                        pdfFormFields.SetField("ACity", reader.GetString("ACity"));
                        pdfFormFields.SetField("AState", reader.GetString("AState"));
                        temp2 = reader.GetInt32("AZIP");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("AZIP", temp2.ToString());
                        }
                        pdfFormFields.SetField("ACnumber", reader.GetString("ACnumber"));
                        if (reader.GetString("Pris").Equals("True"))
                        {
                            pdfFormFields.SetField("Pris", "X");
                        }
                        pdfFormFields.SetField("POName", reader.GetString("POName"));
                        if (reader.GetString("Par").Equals("True"))
                        {
                            pdfFormFields.SetField("Par", "X");
                        }
                        pdfFormFields.SetField("POAddr", reader.GetString("POAddr"));
                        pdfFormFields.SetField("PStatmt", reader.GetString("PStatmt"));
                        pdfFormFields.SetField("POCphone", reader.GetString("POCphone"));
                        if (reader.GetString("PHdays").Equals("True"))
                        {
                            pdfFormFields.SetField("PHDdays", "X");
                        }
                        pdfFormFields.SetField("PHwhy", reader.GetString("PHwhy"));
                        if (reader.GetString("MHdays").Equals("True"))
                        {
                            pdfFormFields.SetField("MHdays", "X");
                        }
                        pdfFormFields.SetField("MHwhy", reader.GetString("MHwhy"));
                        pdfFormFields.SetField("Substance1", reader.GetString("Substance1"));
                        pdfFormFields.SetField("Substance2", reader.GetString("Substance2"));
                        pdfFormFields.SetField("Substance3", reader.GetString("Substance3"));
                        temp = reader.GetDateTime("lastUseDate1");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DLU1", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("lastUseDate2");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DLU2", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("lastUseDate3");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DLU3", temp.Date.ToString("d"));
                        }
                        pdfFormFields.SetField("Freq1", reader.GetString("Frequency1"));
                        pdfFormFields.SetField("Freq2", reader.GetString("Frequency2"));
                        pdfFormFields.SetField("Freq3", reader.GetString("Frequency3"));
                        temp2 = reader.GetInt32("AmountUsed1");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("Amount1", temp2.ToString());
                        }
                        temp2 = reader.GetInt32("AmountUsed2");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("Amount2", temp2.ToString());
                        }
                        temp2 = reader.GetInt32("AmountUsed3");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("Amount3", temp2.ToString());
                        }
                        pdfFormFields.SetField("Method1", reader.GetString("Method1"));
                        pdfFormFields.SetField("Method2", reader.GetString("Method2"));
                        pdfFormFields.SetField("Method3", reader.GetString("Method3"));
                        if (reader.GetString("IVU").Equals("True"))
                        {
                            pdfFormFields.SetField("IVU", "X");
                        }
                        if (reader.GetString("PT").Equals("True"))
                        {
                            pdfFormFields.SetField("PT", "X");
                        }
                        pdfFormFields.SetField("HMT", reader.GetString("HMT"));
                        pdfFormFields.SetField("WWTreat", reader.GetString("WWTreat"));
                        if (reader.GetString("CrimeS").Equals("True"))
                        {
                            pdfFormFields.SetField("CrimeS", "X");
                        }
                        if (reader.GetString("CrimeA").Equals("True"))
                        {
                            pdfFormFields.SetField("CrimeA", "X");
                        }
                        pdfFormFields.SetField("Referrals", reader.GetString("Referrals"));
                        pdfFormFields.SetField("ASAMone", reader.GetString("ASAMone"));
                        pdfFormFields.SetField("ASAMtwo", reader.GetString("ASAMtwo"));
                        pdfFormFields.SetField("ASAMthree", reader.GetString("ASAMthree"));
                        pdfFormFields.SetField("ASAMFour", reader.GetString("ASAMfour"));
                        if (reader.GetString("ASAMLim").Equals("True"))
                        {
                            pdfFormFields.SetField("ASAMLim", "X");
                        }
                        pdfFormFields.SetField("ASAMlimEx", reader.GetString("ASAMLimEx"));
                        pdfFormFields.SetField("Diag1", reader.GetString("Diagnosis1"));
                        pdfFormFields.SetField("Diag2", reader.GetString("Diagnosis2"));
                        pdfFormFields.SetField("Diag3", reader.GetString("Diagnosis3"));
                        pdfFormFields.SetField("Diag4", reader.GetString("Diagnosis4"));
                        pdfFormFields.SetField("Meds1", reader.GetString("medName1"));
                        pdfFormFields.SetField("Meds2", reader.GetString("medName2"));
                        pdfFormFields.SetField("Meds3", reader.GetString("medName3"));
                        pdfFormFields.SetField("Meds4", reader.GetString("medName4"));
                        pdfFormFields.SetField("Dos1", reader.GetString("dosFreq1"));
                        pdfFormFields.SetField("Dos2", reader.GetString("dosFreq2"));
                        pdfFormFields.SetField("Dos3", reader.GetString("dosFreq3"));
                        pdfFormFields.SetField("Dos4", reader.GetString("dosFreq4"));

                        connect.Close();
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
                            }
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
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
                public static int ASAM(int ID)
                {
                    int A, B, C, D, E, F, G, H, I, J, K, L, M;
                    A = B = C = D = E = F = G = H = I = J = K = L = M = 0;
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp;
                    int temp2;
                    string Document = "2-ASAM.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR8_ASAM WHERE " + ID.ToString() + " = FR8_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        temp = reader.GetDateTime("intDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("intDate", temp.Date.ToString("d"));
                        }
                        if (reader.GetString("Ext").Equals("True"))
                        {
                            pdfFormFields.SetField("ASAMExit", "X");
                        }
                        if (reader.GetString("PI").Equals("True"))
                        {
                            pdfFormFields.SetField("PhInt", "X");
                        }
                        if (reader.GetString("Adm").Equals("True"))
                        {
                            pdfFormFields.SetField("Admit", "X");
                        }
                        if (reader.GetString("DurTX").Equals("True"))
                        {
                            pdfFormFields.SetField("DuringTX", "X");
                        }
                        if (reader.GetString("immTriage1a").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageOneAyes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("ImmTriageOneAno", "X");
                        }
                        if (reader.GetString("immTriage1b").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageOneByes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageOneBno", "X");
                        }
                        if (reader.GetString("immTriage2").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageTwoyes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageTwono", "X");
                        }
                        if (reader.GetString("immTriage3").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageThreeyes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageThreeno", "X");
                        }
                        if (reader.GetString("immTriage4a").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageFourAYes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageFourAno", "X");
                        }
                        if (reader.GetString("immTriage4b").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageFourByes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageFourBno", "X");
                        }
                        if (reader.GetString("immTriage5a").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageFiveAyes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageFiveAno", "X");
                        }
                        if (reader.GetString("immTriage5b").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageFiveByes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageFiveBno", "X");
                        }
                        if (reader.GetString("immTriage6").Equals("True"))
                        {
                            pdfFormFields.SetField("immTriageSixyes", "X");
                        }
                        else
                        {
                            pdfFormFields.SetField("immTriageSixno", "X");
                        }
                        temp2 = reader.GetInt32("levelFunction1");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionOneH", "XXXXX");
                            pdfFormFields.SetField("1", "X"); A++;
                            pdfFormFields.SetField("47", "X"); F++;
                            pdfFormFields.SetField("59", "X"); G++;
                            pdfFormFields.SetField("71", "X"); H++;
                            pdfFormFields.SetField("82", "X"); I++;
                            pdfFormFields.SetField("93", "X"); J++;
                            pdfFormFields.SetField("103", "X"); K++;
                            pdfFormFields.SetField("112", "X"); L++;
                            pdfFormFields.SetField("122", "X"); M++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionOneM", "XXXXX");
                            pdfFormFields.SetField("2", "X"); A++;
                            pdfFormFields.SetField("12", "X"); B++;
                            pdfFormFields.SetField("24", "X"); C++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionOneL", "XXXXX");
                            pdfFormFields.SetField("13", "X"); B++;
                            pdfFormFields.SetField("25", "X"); C++;
                            pdfFormFields.SetField("33", "X"); D++;
                            pdfFormFields.SetField("43", "X"); E++;
                        }
                        temp2 = reader.GetInt32("levelFunction2");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionTwoH", "XXXXX");
                            pdfFormFields.SetField("3", "X"); A++;
                            pdfFormFields.SetField("48", "X"); F++;
                            pdfFormFields.SetField("60", "X"); G++;
                            pdfFormFields.SetField("72", "X"); H++;
                            pdfFormFields.SetField("83", "X"); I++;
                            pdfFormFields.SetField("94", "X"); J++;
                            pdfFormFields.SetField("104", "X"); K++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionTwoM", "XXXXX");
                            pdfFormFields.SetField("4", "X"); A++;
                            pdfFormFields.SetField("14", "X"); B++;
                            pdfFormFields.SetField("26", "X"); C++;
                            pdfFormFields.SetField("34", "X"); D++;
                            pdfFormFields.SetField("49", "X"); F++;
                            pdfFormFields.SetField("61", "X"); G++;
                            pdfFormFields.SetField("73", "X"); H++;
                            pdfFormFields.SetField("84", "X"); I++;
                            pdfFormFields.SetField("95", "X"); J++;
                            pdfFormFields.SetField("105", "X"); K++;
                            pdfFormFields.SetField("113", "X"); L++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionTwoL", "XXXXX");
                            pdfFormFields.SetField("15", "X"); B++;
                            pdfFormFields.SetField("35", "X"); D++;
                            pdfFormFields.SetField("44", "X"); E++;
                            pdfFormFields.SetField("114", "X"); L++;
                            pdfFormFields.SetField("123", "X"); M++;
                        }
                        temp2 = reader.GetInt32("levelFunction3");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionThreeH", "XXXXX");
                            pdfFormFields.SetField("5", "X"); A++;
                            pdfFormFields.SetField("50", "X"); F++;
                            pdfFormFields.SetField("62", "X"); G++;
                            pdfFormFields.SetField("74", "X"); H++;
                            pdfFormFields.SetField("96", "X"); J++;
                            pdfFormFields.SetField("106", "X"); K++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionThreeM", "XXXXX");
                            pdfFormFields.SetField("6", "X"); A++;
                            pdfFormFields.SetField("16", "X"); B++;
                            pdfFormFields.SetField("27", "X"); C++;
                            pdfFormFields.SetField("36", "X"); D++;
                            pdfFormFields.SetField("45", "X"); E++;
                            pdfFormFields.SetField("51", "X"); F++;
                            pdfFormFields.SetField("63", "X"); G++;
                            pdfFormFields.SetField("75", "X"); H++;
                            pdfFormFields.SetField("86", "X"); I++;
                            pdfFormFields.SetField("97", "X"); J++;
                            pdfFormFields.SetField("107", "X"); K++;
                            pdfFormFields.SetField("115", "X"); L++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionThreeL", "XXXXX");
                            pdfFormFields.SetField("17", "X"); B++;
                            pdfFormFields.SetField("37", "X"); D++;
                            pdfFormFields.SetField("46", "X"); E++;
                            pdfFormFields.SetField("116", "X"); L++;
                            pdfFormFields.SetField("124", "X"); M++;
                        }
                        temp2 = reader.GetInt32("levelFunction4");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionFourH", "XXXXX");
                            pdfFormFields.SetField("7", "X"); A++;
                            pdfFormFields.SetField("52", "X"); F++;
                            pdfFormFields.SetField("64", "X"); G++;
                            pdfFormFields.SetField("76", "X"); H++;
                            pdfFormFields.SetField("87", "X"); I++;
                            pdfFormFields.SetField("98", "X"); J++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionFourM", "XXXXX");
                            pdfFormFields.SetField("8", "X"); A++;
                            pdfFormFields.SetField("18", "X"); B++;
                            pdfFormFields.SetField("28", "X"); C++;
                            pdfFormFields.SetField("38", "X"); D++;
                            pdfFormFields.SetField("53", "X"); F++;
                            pdfFormFields.SetField("65", "X"); G++;
                            pdfFormFields.SetField("77", "X"); H++;
                            pdfFormFields.SetField("88", "X"); I++;
                            pdfFormFields.SetField("99", "X"); J++;
                            pdfFormFields.SetField("108", "X"); K++;
                            pdfFormFields.SetField("117", "X"); L++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionFourL", "XXXXX");
                            pdfFormFields.SetField("19", "X"); B++;
                            pdfFormFields.SetField("29", "X"); C++;
                            pdfFormFields.SetField("39", "X"); D++;
                            pdfFormFields.SetField("54", "X"); F++;
                            pdfFormFields.SetField("66", "X"); G++;
                            pdfFormFields.SetField("109", "X"); K++;
                            pdfFormFields.SetField("118", "X"); L++;
                        }
                        temp2 = reader.GetInt32("levelFunction5");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionFiveH", "XXXXX");
                            pdfFormFields.SetField("9", "X"); A++;
                            pdfFormFields.SetField("20", "X"); B++;
                            pdfFormFields.SetField("55", "X"); F++;
                            pdfFormFields.SetField("67", "X"); G++;
                            pdfFormFields.SetField("100", "X"); J++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionFiveM", "XXXXX");
                            pdfFormFields.SetField("21", "X"); B++;
                            pdfFormFields.SetField("30", "X"); C++;
                            pdfFormFields.SetField("40", "X"); D++;
                            pdfFormFields.SetField("56", "X"); F++;
                            pdfFormFields.SetField("68", "X"); G++;
                            pdfFormFields.SetField("78", "X"); H++;
                            pdfFormFields.SetField("89", "X"); I++;
                            pdfFormFields.SetField("101", "X"); J++;
                            pdfFormFields.SetField("119", "X"); L++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionFiveL", "XXXXX");
                            pdfFormFields.SetField("31", "X"); C++;
                            pdfFormFields.SetField("41", "X"); D++;
                            pdfFormFields.SetField("79", "X"); H++;
                            pdfFormFields.SetField("90", "X"); I++;
                            pdfFormFields.SetField("110", "X"); K++;
                            pdfFormFields.SetField("120", "X"); L++;
                        }
                        temp2 = reader.GetInt32("levelFunction6");
                        if (temp2 == 1)
                        {
                            pdfFormFields.SetField("levelFunctionSixH", "XXXXX");
                            pdfFormFields.SetField("10", "X"); A++;
                            pdfFormFields.SetField("22", "X"); B++;
                            pdfFormFields.SetField("57", "X"); F++;
                            pdfFormFields.SetField("69", "X"); G++;
                            pdfFormFields.SetField("80", "X"); H++;
                            pdfFormFields.SetField("91", "X"); I++;
                        }
                        else if (temp2 == 2)
                        {
                            pdfFormFields.SetField("levelFunctionSixM", "XXXXX");
                            pdfFormFields.SetField("11", "X"); A++;
                            pdfFormFields.SetField("23", "X"); B++;
                            pdfFormFields.SetField("58", "X"); F++;
                            pdfFormFields.SetField("70", "X"); G++;
                            pdfFormFields.SetField("81", "X"); H++;
                            pdfFormFields.SetField("92", "X"); I++;
                        }
                        else if (temp2 == 3)
                        {
                            pdfFormFields.SetField("levelFunctionSixL", "XXXXX");
                            pdfFormFields.SetField("32", "X"); C++;
                            pdfFormFields.SetField("42", "X"); D++;
                            pdfFormFields.SetField("102", "X"); J++;
                            pdfFormFields.SetField("111", "X"); K++;
                            pdfFormFields.SetField("121", "X"); L++;
                        }
                        pdfFormFields.SetField("A", A.ToString());
                        pdfFormFields.SetField("B", B.ToString());
                        pdfFormFields.SetField("C", C.ToString());
                        pdfFormFields.SetField("D", D.ToString());
                        pdfFormFields.SetField("E", E.ToString());
                        pdfFormFields.SetField("F", F.ToString());
                        pdfFormFields.SetField("G", G.ToString());
                        pdfFormFields.SetField("H", H.ToString());
                        pdfFormFields.SetField("I", I.ToString());
                        pdfFormFields.SetField("J", J.ToString());
                        pdfFormFields.SetField("K", K.ToString());
                        pdfFormFields.SetField("L", L.ToString());
                        pdfFormFields.SetField("M", M.ToString());

                        connect.Close();
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
                            }
                            pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
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
                public static int ClientAdmissionAgreement(int ID)
                {
                    int temp;
                    string Document = "4-CLIENT ADMISSION AGREEMENT.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR9_ClientAdmissionAgreement WHERE " + ID.ToString() + " = FR9_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        pdfFormFields.SetField("Date", (DateTime.Now).ToString("d"));
                        pdfFormFields.SetField("ACPName", reader.GetString("ACPName"));
                        pdfFormFields.SetField("AName", reader.GetString("AName"));
                        pdfFormFields.SetField("ACnumber", reader.GetString("ACnumber"));
                        pdfFormFields.SetField("AAdr", reader.GetString("AAddr"));
                        pdfFormFields.SetField("ACity", reader.GetString("ACity"));
                        pdfFormFields.SetField("AState", reader.GetString("AState"));
                        temp = reader.GetInt32("AZIP");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("AZIP", reader.GetString("AZIP"));
                        }
                        connect.Close();
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
                            pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
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
                public static int FinancialAsessment(int ID)
                {
                    double temp;
                    string Document = "5-Financial West Slope Recovery.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR10_FinancialAsessment WHERE " + ID.ToString() + " = FR10_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        temp = reader.GetDouble("UBIncome");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("UBIncome", temp.ToString());
                        }
                        temp = reader.GetDouble("RPIncome");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("RPIncome", temp.ToString());
                        }
                        temp = reader.GetDouble("SSI");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("SSI", temp.ToString());
                        }
                        temp = reader.GetDouble("SDI");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("SDI", temp.ToString());
                        }
                        temp = reader.GetDouble("AFDC");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("AFDC", temp.ToString());
                        }
                        temp = reader.GetDouble("VAIncome");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("VAIncome", temp.ToString());
                        }
                        temp = reader.GetDouble("FMIncome");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("FMIncome", temp.ToString());
                        }
                        temp = reader.GetDouble("OtherIncome");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("OtherIncome", temp.ToString());
                        }
                        temp = reader.GetDouble("BFunds");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("BFunds", temp.ToString());
                        }
                        temp = reader.GetDouble("HFunds");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("HFunds", temp.ToString());
                        }
                        temp = reader.GetDouble("SBFunds");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("SBFunds", temp.ToString());
                        }
                        temp = reader.GetDouble("ITRFunds");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("ITRFunds", temp.ToString());
                        }
                        pdfFormFields.SetField("VM1", reader.GetString("VM1"));
                        pdfFormFields.SetField("VM2", reader.GetString("VM2"));
                        pdfFormFields.SetField("VModel1", reader.GetString("VModel1"));
                        pdfFormFields.SetField("VModel2", reader.GetString("VModel2"));
                        temp = reader.GetInt32("VYear1");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("VYear1", temp.ToString());
                        }
                        temp = reader.GetInt32("VYear2");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("VYear2", temp.ToString());
                        }
                        temp = reader.GetInt32("VValue1");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("VValue1", temp.ToString());
                        }
                        temp = reader.GetInt32("VValue2");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("VValue2", temp.ToString());
                        }
                        if (reader.GetString("PROmon").Equals("True"))
                        {
                            pdfFormFields.SetField("PROmon", "X");
                        }
                        temp = reader.GetInt32("PROamo");
                        if (temp != 0)
                        {
                            pdfFormFields.SetField("PROamo", temp.ToString());
                        }
                        pdfFormFields.SetField("PROname", reader.GetString("PROname"));
                        pdfFormFields.SetField("PROaddr", reader.GetString("PROadr"));
                        pdfFormFields.SetField("PROrel", reader.GetString("PROrel"));
                        pdfFormFields.SetField("PROphone", reader.GetString("PROphone"));
                        if (reader.GetString("FUND").Equals("True"))
                        {
                            pdfFormFields.SetField("FUND", "X");
                        }
                        connect.Close();
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
                            pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                            pdfFormFields.SetField("SSN", reader2.GetString("SSN"));
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
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
                public static int Bookkeeping(int ID)
                {
                    double temp;
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp2;
                    int temp3;
                    string Document = "1-ADMISSION BOOKKEEPING FORM.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR18_Bookkeeping WHERE " + ID.ToString() + " = FR18_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        temp3 = reader.GetInt32("ClientDSMIV");
                        if (temp3 != 0)
                        {
                            pdfFormFields.SetField("ClientDSMIV", temp3.ToString());
                        }
                        pdfFormFields.SetField("ClientPCounselor", reader.GetString("ClientPCounselor"));
                        pdfFormFields.SetField("ClientMethPayInt", reader.GetString("ClientMethPayInt"));
                        temp = reader.GetDouble("ClientPCharges");
                        if (temp3 != 0)
                        {
                            pdfFormFields.SetField("ClientPCharges", temp.ToString());
                        }
                        temp2 = reader.GetDateTime("ClientAuthStart");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientAuthStart", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ClientAuthEnd");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientAuthEnd", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ChangeDate1");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeDate1", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ChangeDate2");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeDate2", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ChangeDate3");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeDate3", temp2.Date.ToString("d"));
                        }
                        pdfFormFields.SetField("ClientChangeStatus1", reader.GetString("ClientChangeStatus1"));
                        pdfFormFields.SetField("ClientChangeStatus2", reader.GetString("ClientChangeStatus2"));
                        pdfFormFields.SetField("ClientChangeStatus3", reader.GetString("ClientChangeStatus3"));
                        temp2 = reader.GetDateTime("ClientChangeBill1");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeBill1", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ClientChangeBill2");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeBill2", temp2.Date.ToString("d"));
                        }
                        temp2 = reader.GetDateTime("ClientChangeBill3");
                        if (temp2 != def)
                        {
                            pdfFormFields.SetField("ClientChangeBill3", temp2.Date.ToString("d"));
                        }
                        connect.Close();
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
                            pdfFormFields.SetField("ClientName", reader2.GetString("ClientName"));
                            pdfFormFields.SetField("SSN", reader2.GetString("SSN"));
                            temp2 = reader2.GetDateTime("IntakeDate");
                            if (temp2 != def)
                            {
                                pdfFormFields.SetField("ADate", temp2.Date.ToString("d"));
                            }
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
                        }
                        connect2.Close();
                        string autofill3 = " SELECT * FROM FR7_ClientScreening WHERE " + ID.ToString() + " = FR7_ClientID";
                        MySqlConnection connect3 = new MySqlConnection(GlobalVar.SERVER);
                        MySqlCommand command3 = new MySqlCommand(autofill3, connect3);
                        connect3.Open();
                        MySqlDataReader reader3 = command3.ExecuteReader();
                        if (reader3.Read())
                        {
                            pdfFormFields.SetField("ClientAddr", reader3.GetString("ClientAddr"));
                            pdfFormFields.SetField("ClientCity", reader3.GetString("ClientCity"));
                            pdfFormFields.SetField("ClientState", reader3.GetString("ClientState"));
                            temp3 = reader3.GetInt32("ClientZip");
                            if (temp3 != 0)
                            {
                                pdfFormFields.SetField("ClientZip", temp3.ToString());
                            }
                            pdfFormFields.SetField("ClientPhone", reader3.GetString("ClientPhone"));
                            pdfFormFields.SetField("ClientWCM", reader3.GetString("ClientWCM"));
                            pdfFormFields.SetField("County", reader3.GetString("County"));
                            temp2 = reader3.GetDateTime("DoB");
                            if (temp2 != def)
                            {
                                pdfFormFields.SetField("DoB", temp2.Date.ToString("d"));
                            }
                        }
                        else
                        {
                            pdfStamper.Close();
                            return 0;
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

                public static int ExitBookkeeping(int ID)
                {
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp;
                    int temp2;
                    string Document = "1-Exit Bookkeeping.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM FR29_ExitBookkeep, FR7_ClientScreening, ClientInfo WHERE " + ID.ToString() + " = FR29_ClientID AND " + ID.ToString() + "= FR7_ClientID AND " + ID.ToString() + "= ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        pdfFormFields.SetField("ClientPCounselor", reader.GetString("ClientPCounselor"));
                        pdfFormFields.SetField("ClientMethPay", reader.GetString("ClientMethPay"));
                        pdfFormFields.SetField("ClientOwedAmt", reader.GetString("ClientOwedAmt"));
                        pdfFormFields.SetField("ClientMoneyOwed", reader.GetString("ClientDoubleOwed"));
                        pdfFormFields.SetField("ClientName", reader.GetString("ClientName"));
                        pdfFormFields.SetField("ClientAddr", reader.GetString("ClientAddr"));
                        pdfFormFields.SetField("ClientCity", reader.GetString("ClientCity"));
                        pdfFormFields.SetField("ClientState", reader.GetString("ClientState"));
                        temp2 = reader.GetInt32("ClientZip");
                        if (temp2 != 0)
                        {
                            pdfFormFields.SetField("ClientZip", temp2.ToString());
                        }
                        temp = reader.GetDateTime("DoB");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DoB", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("IntakeDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("ADate", temp.Date.ToString("d"));
                        }
                        pdfFormFields.SetField("SSN", reader.GetString("SSN"));
                        pdfFormFields.SetField("ClientPhone", reader.GetString("ClientPhone"));
                        pdfFormFields.SetField("ClientWCM", reader.GetString("ClientWCM"));
                        pdfFormFields.SetField("County", reader.GetString("County"));
                        pdfFormFields.SetField("ClientDSMIV", reader.GetString("DSMIV"));
                        pdfFormFields.SetField("ClientNum", reader.GetString("ClientNum"));
                        temp = reader.GetDateTime("ExitDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DCharge", temp.Date.ToString("d"));
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
                public static int OneonOne(int ID)
                {
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp;
                    string Document = "2- 1on1 notes 2.pdf";
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
                            pdfFormFields.SetField("CLIENT NAME", reader2.GetString("ClientName"));
                            pdfFormFields.SetField("CLIENT LOG", reader2.GetString("ClientID"));
                        }
                    }
                    else
                    {
                        pdfStamper.Close();
                        return 0;
                    }
                    connect2.Close();
                    string autofill = " SELECT * FROM FR28_OneOnOne WHERE " + ID.ToString() + " = FR28_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        pdfFormFields.SetField("T1", reader.GetString("TimeOne"));
                        pdfFormFields.SetField("T3", reader.GetString("Timetwo"));
                        pdfFormFields.SetField("NOTE", reader.GetString("oneNotes"));
                        temp = reader.GetDateTime("oneDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("D1", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("Datethru");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("D4", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("Dateof");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("D7", temp.Date.ToString("d"));
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
                public static int Linen(int ID)
                {
                    string Document = "7-LINEN AGREEMENT.pdf";
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
                            pdfFormFields.SetField("ClientNum", reader2.GetString("ClientID"));
                        }
                    }
                    else
                    {
                        pdfStamper.Close();
                        return 0;
                    }
                    connect2.Close();
                    string autofill = " SELECT * FROM FR27_LinenAgreement WHERE " + ID.ToString() + " = FR27_ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetInt32("FR27_ClientID") != 0)
                        {
                            if (reader.GetString("MPintake").Equals("True"))
                            {
                                pdfFormFields.SetField("MPIntake", "X");
                            }
                            if (reader.GetString("TSintake").Equals("True"))
                            {
                                pdfFormFields.SetField("TPIntake", "X");
                            }
                            if (reader.GetString("FBSintake").Equals("True"))
                            {
                                pdfFormFields.SetField("FBSIntake", "X");
                            }
                            if (reader.GetString("PCintake").Equals("True"))
                            {
                                pdfFormFields.SetField("PCIntake", "X");
                            }
                            if (reader.GetString("Pintake").Equals("True"))
                            {
                                pdfFormFields.SetField("PIntake", "X");
                            }
                            if (reader.GetString("Bintake").Equals("True"))
                            {
                                pdfFormFields.SetField("BIntake", "X");
                            }
                            if (reader.GetString("CBintake").Equals("True"))
                            {
                                pdfFormFields.SetField("CBIntake", "X");
                            }
                            if (reader.GetString("Tintake").Equals("True"))
                            {
                                pdfFormFields.SetField("TIntake", "X");
                            }
                            if (reader.GetString("WCintake").Equals("True"))
                            {
                                pdfFormFields.SetField("WCIntake", "X");
                            }
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
                public static int DischargeSummary(int ID)
                {
                    DateTime def = new DateTime(1, 1, 1);
                    DateTime temp;
                    string Document = "4-Discharge Summary.pdf";
                    string PDF = GlobalVar.FILEPATH + Document;
                    string newPDF = GlobalVar.FILEPATH + ID.ToString() + Document;
                    PdfReader PDFnew = new PdfReader(PDF);
                    PdfStamper pdfStamper = new PdfStamper(PDFnew, new FileStream(newPDF, FileMode.Create));
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    string autofill = " SELECT * FROM ClientInfo, FR25_DischargeSum, FR7_ClientScreening WHERE " + ID.ToString() + " = FR25_ClientID AND " + ID.ToString() + " = FR7_ClientID AND " + ID.ToString() + " = ClientID";
                    MySqlConnection connect = new MySqlConnection(GlobalVar.SERVER);
                    MySqlCommand command = new MySqlCommand(autofill, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        temp = reader.GetDateTime("ADate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("ADate", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("DDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DDate", temp.Date.ToString("d"));
                        }
                        temp = reader.GetDateTime("DNotifyDate");
                        if (temp != def)
                        {
                            pdfFormFields.SetField("DNotifyDate", temp.Date.ToString("d"));
                        }
                        if (reader.GetString("RFD1").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge1", "X");
                        }
                        if (reader.GetString("RFD2").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge2", "X");
                        }
                        if (reader.GetString("RFD3").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge3", "X");
                        }
                        if (reader.GetString("RFD4").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge4", "X");
                        }
                        if (reader.GetString("RFD5").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge5", "X");
                        }
                        if (reader.GetString("RFD6").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge6", "X");
                        }
                        if (reader.GetString("RFD7").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge7", "X");
                        }
                        if (reader.GetString("RFD8").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge8", "X");
                        }
                        if (reader.GetString("RFD9").Equals("True"))
                        {
                            pdfFormFields.SetField("ReasonForDischarge9", "X");
                        }
                        if (reader.GetString("ProgG").Equals("True"))
                        {
                            pdfFormFields.SetField("Prognis1", "X");
                        }
                        if (reader.GetString("ProgF").Equals("True"))
                        {
                            pdfFormFields.SetField("Prognis2", "X");
                        }
                        if (reader.GetString("ProgP").Equals("True"))
                        {
                            pdfFormFields.SetField("Prognis3", "X");
                        }
                        pdfFormFields.SetField("Treatsum", reader.GetString("Treatsum"));
                        pdfFormFields.SetField("1", reader.GetString("TPG1"));
                        pdfFormFields.SetField("2", reader.GetString("TPG2"));
                        pdfFormFields.SetField("3", reader.GetString("TPG3"));
                        pdfFormFields.SetField("4", reader.GetString("TPG4"));
                        pdfFormFields.SetField("5", reader.GetString("TPG5"));
                        pdfFormFields.SetField("6", reader.GetString("TPG6"));
                        pdfFormFields.SetField("1_2", reader.GetString("TPGM1"));
                        pdfFormFields.SetField("2_2", reader.GetString("TPGM2"));
                        pdfFormFields.SetField("3_2", reader.GetString("TPGM3"));
                        pdfFormFields.SetField("4_2", reader.GetString("TPGM4"));
                        pdfFormFields.SetField("5_2", reader.GetString("TPGM5"));
                        pdfFormFields.SetField("6_2", reader.GetString("TPGM6"));
                        pdfFormFields.SetField("CDUsage", reader.GetString("CDUsage"));
                        pdfFormFields.SetField("CCInvolve", reader.GetString("CCInvolve"));
                        pdfFormFields.SetField("DNotifyTitle", reader.GetString("DNotifyTitle"));
                        pdfFormFields.SetField("AXIS I", reader.GetString("AXIS I"));
                        pdfFormFields.SetField("AXIS II", reader.GetString("AXIS II"));
                        pdfFormFields.SetField("AXIS III", reader.GetString("AXIS III"));
                        pdfFormFields.SetField("AXIS IV", reader.GetString("AXIS IV"));
                        pdfFormFields.SetField("AXIS V GAF SCORE", reader.GetString("AXIS V"));
                        pdfFormFields.SetField("AXIS I_2", reader.GetString("DAXIS I"));
                        pdfFormFields.SetField("AXIS II_2", reader.GetString("DAXIS II"));
                        pdfFormFields.SetField("AXIS III_2", reader.GetString("DAXIS III"));
                        pdfFormFields.SetField("AXIS IV_2", reader.GetString("DAXIS IV"));
                        pdfFormFields.SetField("AXIS V GAF SCORE_2", reader.GetString("DAXIS V"));
                        pdfFormFields.SetField("TransPlan1", reader.GetString("TransPlan1"));
                        pdfFormFields.SetField("TransPlan2", reader.GetString("TransPlan2"));
                        pdfFormFields.SetField("TransPlan3", reader.GetString("TransPlan3"));
                        pdfFormFields.SetField("TransPlan4", reader.GetString("TransPlan4"));
                        pdfFormFields.SetField("Drecommendation", reader.GetString("Drecommendation"));
                        pdfFormFields.SetField("ACPName", reader.GetString("ACPName"));
                        pdfFormFields.SetField("ACPNumber", reader.GetString("ACPNumber"));
                        pdfFormFields.SetField("ClientNum1", reader.GetString("ClientNum"));
                        pdfFormFields.SetField("ClientNum2", reader.GetString("ClientNum"));
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
        }
    }