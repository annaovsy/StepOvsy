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
    public partial class FormRectangle : Form
    {
        public Color ColorLine { get; set; }

        public float Thickness
        {
            get { return trackBarThickness.Value; }
        }

        public FormRectangle()
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

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
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

        private void FormRectangle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen rectangle = new Pen(ColorLine, Thickness);
            g.DrawRectangle(rectangle, 150, 25, 145, 60);
        }
    }
}
