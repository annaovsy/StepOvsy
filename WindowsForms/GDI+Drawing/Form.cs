using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Drawing
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Point> points = new List<Point>();
        public Form()
        {
            InitializeComponent();
            //this.Show();
            //Graphics g = this.CreateGraphics();
            //SolidBrush redBrush = new SolidBrush(Color.Red);
            //Rectangle rect = new Rectangle(0, 0, 250, 140);
            //g.FillRectangle(redBrush, rect);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            // * Эллипс * 
            //Graphics gr = e.Graphics;
            //Pen pen = new Pen(Brushes.Blue, 3);
            //pen.DashStyle = DashStyle.Dash;
            //gr.DrawEllipse(pen, 50, 100, 170, 100);
            //gr.Dispose();

            // * Прямоугольник *
            //Graphics gr = e.Graphics;
            //Rectangle rect = new Rectangle(20, 20, 200, 40);
            //LinearGradientBrush lgBrush = new LinearGradientBrush(rect, Color.Red, Color.Blue, 0.0f, true);
            //gr.FillRectangle(lgBrush, rect);

            //Rectangle rect2 = new Rectangle(20, 80, 200, 40);
            //HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.Blue);
            //gr.FillRectangle(hatchBrush, rect2);

            //TextureBrush txBrush = new TextureBrush(new Bitmap("i.jpg"));
            //Rectangle rect3 = new Rectangle(20, 140, 200, 40);
            //gr.FillRectangle(txBrush, rect3);

            //// * Текст *
            //Font f = new Font("Verdana", 14, FontStyle.Bold | FontStyle.Italic);
            //gr.DrawString("Hello Font!", f, Brushes.Blue, 100, 200);
            //gr.Dispose();

            ////*картинка*
            //Graphics g = e.Graphics;
            //Rectangle rect = this.ClientRectangle;
            //Image im = new Bitmap("картинка.jpg");
            //g.DrawImage(im, rect);
            //g.Dispose();

            ////* Линии *
            //Graphics g = e.Graphics;
            //Point[] points = new Point[]
            //{
            //    new Point(5, 10),
            //    new Point(23,130),
            //    new Point(130,57)
            //};
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(170, 170, 100, 50);
            //g.FillPath(Brushes.Aqua, path);
            //path.StartFigure();
            //path.AddCurve(points, 0.5F);
            //path.AddArc(100, 50, 100, 100, 0, 120);
            //path.AddLine(50, 150, 50, 220);
            //path.CloseFigure();
            //path.StartFigure();
            //path.AddArc(180, 30, 60, 60, 0, -170);
            //g.DrawPath(new Pen(Color.Blue, 3), path);
            //g.Dispose();
            /* try
             {
                 Bitmap img = new Bitmap("NewBackground.bmp");
                 Graphics g = e.Graphics;
                 g.DrawImage(img, 0, 0, 300, 200);
                 img.Dispose();
                 g.Dispose();
             }
             catch { }*/

            //Graphics g = e.Graphics;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);
            //g.DrawRectangle(new Pen(Color.Green), 100, 100, 50, 50);
            //g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150, 90, 180);
            //g.DrawString("Hello GDI+!", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 0, 240);
            //PointF[] pArray = 
            //{
            //     new PointF(10.0F, 50.0F),
            //     new PointF(200.0F, 200.0F),
            //     new PointF(90.0F, 20.0F),
            //     new PointF(140.0F, 50.0F),
            //     new PointF(40.0F, 150.0F)
            //};
            //g.DrawPolygon(new Pen(Color.Aqua, 2), pArray);


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap("картинка.jpg");
            Graphics gFromImage = Graphics.FromImage(img);
            Font font = new Font("Verdana", 8, FontStyle.Italic);
            string helloStr = "Hello World!";

            SizeF sz = gFromImage.MeasureString(helloStr, font);
            gFromImage.DrawString(helloStr, font, Brushes.Blue, 10, 10);
            gFromImage.DrawRectangle(new Pen(Color.Red, 2), 10, 10, sz.Width, sz.Height);
            img.Save(@"NewBackground.bmp");
            img.Dispose();
            gFromImage.Dispose();
            this.Invalidate();


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach(var point in points)
            {
                gr.FillEllipse(Brushes.Black, point.X, point.Y, 10, 10);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            pictureBox1.Refresh();
        }
    }
}
