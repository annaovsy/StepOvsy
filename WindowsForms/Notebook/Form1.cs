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

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamReader(openFileDialog.FileName))
                {
                    textBoxNotebook.Text = stream.ReadToEnd();
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.FileName == "") //здесь имя текущего файла
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new StreamWriter(saveFileDialog.FileName))
                    {
                        stream.Write(textBoxNotebook.Text);
                    }
                }
            }
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamWriter(saveFileDialog.FileName))
                {
                    stream.Write(textBoxNotebook.Text);
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия ПО: 1.0.0", "Изучение меню");
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxNotebook.Font = fontDialog.Font;
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxNotebook.SelectedText);
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxNotebook.SelectedText);
            textBoxNotebook.SelectedText = "";
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = Clipboard.GetText();

            var indx = textBoxNotebook.SelectionStart;
            var text = textBoxNotebook.Text.Substring(0, indx) + str + textBoxNotebook.Text.Substring(indx);

            textBoxNotebook.Text = text;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(var stream = new StreamReader(openFileDialog.FileName))
                {
                    textBoxNotebook.Text = stream.ReadToEnd();
                    Text = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }
    }
}
