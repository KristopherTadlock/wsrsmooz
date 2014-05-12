using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WSRsmooz
{
    public class CustomTransparentLabel : Label
    {
        protected override void WndProc(ref Message m)
        {
            int WM_NCHITTEST = 0x0084;
            int HTTRANSPARENT = -1;
            if (m.Msg == (int)WM_NCHITTEST)
                m.Result = (IntPtr)HTTRANSPARENT;
            else
                base.WndProc(ref m);
        }
    }

    public class CustomTransparentCheckBox : CheckBox
    {
        protected override void WndProc(ref Message m)
        {
            int WM_NCHITTEST = 0x0084;
            int HTTRANSPARENT = -1;
            if (m.Msg == (int)WM_NCHITTEST)
                m.Result = (IntPtr)HTTRANSPARENT;
            else
                base.WndProc(ref m);
        }
    }

    public class CustomTransparentComboBox : ComboBox
    {
        protected override void WndProc(ref Message m)
        {
            int WM_NCHITTEST = 0x0084;
            int HTTRANSPARENT = -1;
            if (m.Msg == (int)WM_NCHITTEST)
                m.Result = (IntPtr)HTTRANSPARENT;
            else
                base.WndProc(ref m);
        }
    }
}