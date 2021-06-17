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
    public partial class LineForm : Form
    {
        public Color ColorLine
        {get;set;
            //get { return ColorLine; }
           // set { ColorLine = value; }
        }
        public float Thickness
        {
            get { return trackBarThickness.Value; }
        }
        public LineForm()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value,
              trackBarBlue.Value);
            //textBoxColor.BackColor = clr;
            ColorLine = clr;
            this.Update();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_Paint_1(object sender, PaintEventArgs e)
        {


            Graphics g = this.CreateGraphics();
            Pen line = new Pen(ColorLine, Thickness);
            g.DrawLine(line, 20, 100, 270, 100);
            //line.Dispose();
            //g.Dispose();
        }

        private void pictureBox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_ParentChanged(object sender, EventArgs e)
        {

            pictureBox.Refresh();
        }
    }
}
