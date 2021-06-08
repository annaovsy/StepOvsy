using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(var stream = new StreamReader(openFileDialog.FileName))
                {
                    textBoxFile.Text = stream.ReadToEnd();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamWriter(saveFileDialog.FileName))
                {
                    stream.Write(textBoxFile.Text);
                }
            }
        }
    }
}
