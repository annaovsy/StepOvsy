using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class MainForm : Form
    {
        Color formColor;
        public MainForm()
        {
            InitializeComponent();
            formColor = BackColor;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия ПО: 1.0.0", "Изучение меню");
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = formColor;
            }
        }
    }
}
