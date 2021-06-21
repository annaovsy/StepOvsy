using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Menu
{
    public partial class FormTriangle : Form
    {
        public Color ColorLine { get; set; }

        public float Thickness
        {
            get { return trackBarThickness.Value; }
        }

        public FormTriangle()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value,
             trackBarBlue.Value);
            ColorLine = clr;
            this.Update();
            this.Refresh();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FormTriangle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            PointF point1 = new PointF(150, 60);
            PointF point2 = new PointF(190, 30);
            PointF point3 = new PointF(220, 80);

            g.DrawLines(new Pen(ColorLine, Thickness), 
                new[] { point1, point2, point3, point1 });
        }
    }
}
