﻿using System;
using System.Windows.Forms;
using System.IO;

namespace WSRsmooz
{
    public partial class SignaturePrompt : Form
    {
        public MemoryStream sigStream { get; set; }

        public SignaturePrompt()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sigStream = signatureCapturePad.savePng();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            signatureCapturePad.clear();
        }

        private void SignaturePrompt_Load(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor.Clip = this.Bounds;
        }
    }
}
