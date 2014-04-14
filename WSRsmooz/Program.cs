using System;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace WSRsmooz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }
    }
}
