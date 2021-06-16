using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Clock
{
    public partial class FormClock : Form
    {
        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true; //для предотвращения мерцания
            timer.Enabled = true;

        }

        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            var graph = e.Graphics; 
            graph.Clear(BackColor); 
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            graph.TranslateTransform(pictureBoxClock.Width / 2, pictureBoxClock.Height / 2);
           
            DrawClockFace(graph);

            e.Graphics.FillEllipse(Brushes.Black, -5, -5, 10, 10);

            DrawClockHand(graph);
        }

        private void DrawClockFace(Graphics gr)
        {
            using(Pen tick_pen = new Pen(Color.Blue, 4))
            {
                gr.DrawEllipse(tick_pen,
                    -pictureBoxClock.Width / 2 + 3, -pictureBoxClock.Height / 2 + 3,
                    pictureBoxClock.Width - 5, pictureBoxClock.Height - 7);

                float outer_x_factor = 0.45f * pictureBoxClock.Width;
                float outer_y_factor = 0.45f * pictureBoxClock.Height;
                float inner_x_factor = 0.425f * pictureBoxClock.Width;
                float inner_y_factor = 0.425f * pictureBoxClock.Height;
                float big_x_factor = 0.4f * pictureBoxClock.Width;
                float big_y_factor = 0.4f * pictureBoxClock.Height;

                tick_pen.StartCap = LineCap.Triangle;

                for (int i = 0; i <= 360; i += 6)
                {
                    double angle = i * Math.PI / 180;
                    float cos_angle = (float)Math.Cos(angle);
                    float sin_angle = (float)Math.Sin(angle);
                    PointF outer_pt = new PointF(
                        outer_x_factor * cos_angle,
                        outer_y_factor * sin_angle);
                    if (i % 5 == 0)
                    {
                        PointF inner_pt = new PointF(
                            big_x_factor * cos_angle,
                            big_y_factor * sin_angle);
                        gr.DrawLine(tick_pen, inner_pt, outer_pt);
                    }
                    else
                    {
                        PointF inner_pt = new PointF(
                            inner_x_factor * cos_angle,
                            inner_y_factor * sin_angle);
                        gr.DrawLine(Pens.Blue, inner_pt, outer_pt);
                    }
                }

            }
        }

        private void DrawClockHand(Graphics gr)
        {
            using(Pen tick_pen = new Pen(Color.Red, 4))
            {
                DateTime currentDate = DateTime.Now;
                float hour = currentDate.Hour +
                    currentDate.Minute / 60f +
                    currentDate.Second / 3600f;

                float minute = currentDate.Minute +
                    currentDate.Second / 60f;

                double x_factor = 0.2f * pictureBoxClock.Width;
                double y_factor = 0.2f * pictureBoxClock.Height;

                tick_pen.Color = Color.Red;

                DrawHands(gr, x_factor, y_factor, hour / 12.0, tick_pen);

                x_factor = 0.3f * pictureBoxClock.Width;
                y_factor = 0.3f * pictureBoxClock.Height;

                tick_pen.Width = 2;

                DrawHands(gr, x_factor, y_factor, minute / 60.0, tick_pen);

                x_factor = 0.4f * pictureBoxClock.Width;
                y_factor = 0.4f * pictureBoxClock.Height;

                DrawHands(gr, x_factor, y_factor, currentDate.Second / 60.0, tick_pen);
            }
        }

        private void DrawHands(Graphics gr, double x_factor, double y_factor,
            double value, Pen pen)
        {
            PointF center = new PointF(0, 0);

            double hour_angle = -Math.PI / 2 + 2 * Math.PI * value;
            PointF hour_pt = new PointF(
                (float)(x_factor * Math.Cos(hour_angle)),
                (float)(y_factor * Math.Sin(hour_angle)));

            gr.DrawLine(pen, hour_pt, center);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBoxClock.Refresh();
        }
    }
}
