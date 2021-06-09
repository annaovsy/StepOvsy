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
        MenuStrip dynMenu;
        public MainForm()
        {
            InitializeComponent();
            formColor = BackColor;
            menuStripEng.Visible = false;
            dynMenu = new MenuStrip();
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

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            if (buttonLanguage.Text == "English")
            {
                buttonLanguage.Text = "Русский";
                menuStripEng.Visible = true;
                menuStrip.Visible = false;
            }
            else
            {
                buttonLanguage.Text = "Русский";
                menuStripEng.Visible = false;
                menuStrip.Visible = true;
            }
        }

        private void buttonCreateMenu_Click(object sender, EventArgs e)
        {
            menuStripEng.Visible = false;
            menuStrip.Visible = false;

            var file = dynMenu.Items.Add("File");
            var edit = dynMenu.Items.Add("Edit");
            this.menuStrip = dynMenu;
            Controls.Add(dynMenu);
            var closeItem = ((ToolStripMenuItem)file).DropDownItems.Add("Close");
            closeItem.Click += (obsender, args) => Close();
        }

        private void contextOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
           // if(openFileDialog.ShowDialog() == DialogResult.Ok)
             //   textBox1.Text = openFileDialog
        }
    }
}
