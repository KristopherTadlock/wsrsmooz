using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace WSRsmooz
{
    public partial class SignatureCapturePad : Panel
    {
        private List<Point>[] drawnPointer;
        int load;
        Point min = new Point(int.MaxValue, int.MaxValue);
        Point max = new Point(int.MinValue, int.MinValue);

        public SignatureCapturePad()
        {
            InitializeComponent();
            drawnPointer = new List<Point>[128];
            load = 0;

            this.DoubleBuffered = true;
        }

        public SignatureCapturePad(IContainer container)
        {
            this.BackColor = Color.White;
            container.Add(this);
            InitializeComponent();
            drawnPointer = new List<Point>[128];
            load = 0;

            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (drawnPointer[load] == null)
                drawnPointer[load] = new List<Point>();

            using (Brush brush = new SolidBrush(Color.Black))
            {
                using (Pen pen = new Pen(brush, 2))
                {
                    for (int j = 0; j < load; j++)
                    {
                        for (int m = 1; m < drawnPointer[j].Count; m++)
                            e.Graphics.DrawLine(pen, drawnPointer[j][m - 1], drawnPointer[j][m]);
                    }

                    for (int i = 1; i < drawnPointer[load].Count; i++)
                    {
                        e.Graphics.DrawLine(pen, drawnPointer[load][i - 1], drawnPointer[load][i]);
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (drawnPointer[load] == null)
                drawnPointer[load] = new List<Point>();

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                drawnPointer[load].Add(e.Location);
                if (e.X < min.X) min.X = e.X;
                if (e.Y < min.Y) min.Y = e.Y;
                if (e.X > max.X) max.X = e.X;
                if (e.Y > max.Y) max.Y = e.Y;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            load++;
        }

        public void clear()
        {
            for (int j = 0; j < load; j++)
                drawnPointer[j].Clear();
            this.Invalidate();
            max = new Point(int.MaxValue, int.MaxValue);
            min = new Point(int.MinValue, int.MinValue);
        }

        public MemoryStream savePng()
        {

            for (int j = 0; j < load; j++)
                for (int m = 0; m < drawnPointer[j].Count; m++)
                    drawnPointer[j][m] = new Point(drawnPointer[j][m].X - min.X, drawnPointer[j][m].Y - min.Y);

            using (Bitmap bmp = new Bitmap(max.X - min.X, max.Y - min.Y))
            {
                Rectangle test = new Rectangle(Point.Empty, bmp.Size);
                DrawToBitmap(bmp, test);

                bmp.MakeTransparent(Color.White);

                Image img = (Image)bmp;
                MemoryStream saveStream = new MemoryStream();
                img.Save(saveStream, ImageFormat.Png);
                return saveStream;

                /*using (FileStream saveStream = new FileStream("test" + ".png", FileMode.OpenOrCreate))
                {
                    img = (Image)bmp;
                    img.Save(saveStream, ImageFormat.Png);
                }*/
            }

        }


    }
}
