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
        public LineForm()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value,
              trackBarBlue.Value);
            textBoxColor.BackColor = clr;
            this.Update();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
