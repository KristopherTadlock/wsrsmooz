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
        Launcher parent;

        public Login()
        {
            InitializeComponent();
            VerticalScroll.Visible = true;
            parent = (Launcher)this.MdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // login check goes here
            ((Launcher)MdiParent).currentUser = "Test";
            ((Launcher)MdiParent).loggedIn = true;
            ((Launcher)MdiParent).superUser = true;
            ((Launcher)MdiParent).toggleToolstrip();
            this.Close();
        }
    }
}
