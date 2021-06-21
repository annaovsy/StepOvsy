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

namespace GDI_Menu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tuningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineForm lineForm = new LineForm();
            if (lineForm.ShowDialog() == DialogResult.OK)
            {
                Graphics g = this.CreateGraphics();
                Pen line = new Pen(lineForm.ColorLine, lineForm.Thickness);
                g.DrawLine(line, 20, 50, 220, 50);
                line.Dispose();
                g.Dispose();
            }
        }

        private void SquareSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSquare formSquare = new FormSquare();
            if (formSquare.ShowDialog() == DialogResult.OK)
            {
                Graphics g = this.CreateGraphics();
                Pen square = new Pen(formSquare.ColorLine, formSquare.Thickness);
                g.DrawRectangle(square, 20, 80, 70, 70);
                square.Dispose();
                g.Dispose();
            }
        }

        private void SettingRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRectangle formRectangle = new FormRectangle();
            if (formRectangle.ShowDialog() == DialogResult.OK)
            {
                Graphics g = this.CreateGraphics();
                Pen rectangle = new Pen(formRectangle.ColorLine, formRectangle.Thickness);
                g.DrawRectangle(rectangle, 20, 180, 145, 60);
                rectangle.Dispose();
                g.Dispose();
            }
        }

        private void SettingTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTriangle formTriangle = new FormTriangle();
            if (formTriangle.ShowDialog() == DialogResult.OK)
            {
                Graphics g = this.CreateGraphics();
                PointF point1 = new PointF(300, 300);
                PointF point2 = new PointF(340, 270);
                PointF point3 = new PointF(370, 320);
                g.DrawLines(new Pen(formTriangle.ColorLine, formTriangle.Thickness),
                    new[] { point1, point2, point3, point1 });
               
                g.Dispose();
            }
        }
    }
}
