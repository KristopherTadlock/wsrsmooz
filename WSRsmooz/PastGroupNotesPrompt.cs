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
    public partial class PastGroupNotesPrompt : Form
    {
        public String name { get; set; }

        public PastGroupNotesPrompt()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void PastGroupNotesPrompt_Load(object sender, EventArgs e)
        {
            ClientName.Text = name;
        }
    }
}
