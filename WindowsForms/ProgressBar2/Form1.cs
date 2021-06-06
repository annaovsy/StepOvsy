using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowListFiles()
        {
            var dirSourse = textBoxCatalog.Text;
            if (Directory.Exists(dirSourse))
            {
                var files = Directory.GetFiles(dirSourse);
                listBox.DataSource = files;
            }
            var dirDst = textBoxCatalogCopy.Text;
            if (Directory.Exists(dirSourse))
            {
                var files = Directory.GetFiles(dirDst);
                listBoxCopy.DataSource = files;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            progressBarTemp.Minimum = 0;
           
            string srcPath = listBox.SelectedItems.ToString();
            string dstPath = Path.Combine(textBoxCatalogCopy.Text, Path.GetFileName(srcPath));

            using (var fileSrc = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
            using (var fileDst = new FileStream(dstPath, FileMode.Create, FileAccess.Write))
            {
                progressBarTemp.Maximum = (int)fileSrc.Length;
                progressBarTemp.Step = 1024;
                var bytes = new byte[1024];

                while (fileSrc.Position != fileSrc.Length)
                {
                    fileSrc.Read(bytes, 0, bytes.Length);
                    fileDst.Write(bytes, 0, bytes.Length);

                    progressBarTemp.PerformStep();
                    labelVal.Text = progressBarTemp.Value.ToString();
                    this.Update();
                    Thread.Sleep(50);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowListFiles();
        }

        private void textBoxCatalogCopy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
