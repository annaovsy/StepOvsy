using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value,
                trackBarBlue.Value);
            BackColor = clr;
            toolStripColorLable.Text = $"Red: {trackBarRed.Value}  Green: {trackBarGreen.Value}  Blue: {trackBarBlue.Value}";
            toolStripColorLable.BackColor = Color.White;
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChild form = new FormChild();
            form.ShowDialog();
            MessageBox.Show("Конец программы!");
        }
    }
}
