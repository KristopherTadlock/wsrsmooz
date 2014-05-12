using System.Collections.Generic;
using System.Windows.Forms;

namespace WSRsmooz
{
    public static class ControlExtension
    {
        private static Dictionary<Control, bool> draggables = new Dictionary<Control, bool>();
        private static System.Drawing.Size mouseOffset;

        public static void Draggable(this Control control, bool Enable)
        {
            if (Enable)
            {
                if (draggables.ContainsKey(control))
                    return;
                draggables.Add(control, false);

                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
                control.MouseMove += new MouseEventHandler(control_MouseMove);
            }
            else
            {
                if (!draggables.ContainsKey(control))
                    return;
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                draggables.Remove(control);
            }
        }
        static void control_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new System.Drawing.Size(e.Location);
            draggables[(Control)sender] = true;
        }
        static void control_MouseUp(object sender, MouseEventArgs e)
        {
            draggables[(Control)sender] = false;
        }
        static void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggables[(Control)sender] == true)
            {
                System.Drawing.Point newLocationOffset = (e.Location - mouseOffset);
                ((Control)sender).Left += newLocationOffset.X - newLocationOffset.X % 10;
                ((Control)sender).Top += newLocationOffset.Y - newLocationOffset.Y % 10;
            }
        }
    }
}