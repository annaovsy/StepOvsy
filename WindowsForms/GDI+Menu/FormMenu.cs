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
                g.DrawLine(line, 20, 100, 270, 100);
                line.Dispose();
                g.Dispose();
            }
        }
    }
}
