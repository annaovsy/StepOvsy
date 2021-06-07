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

namespace FileTest
{
    public partial class FormFiles : Form
    {
        
        public FormFiles()
        {
            InitializeComponent();
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            string str = textBoxCatalog.Text;
            string strSearch = textBoxSearch.Text;
            var res = Directory.GetFiles(str, strSearch);
            //var res = Directory.GetFiles(str).Where(s => Path.GetExtension(s)== strSearch).ToList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCatalog.Text = folderBrowserDialog.SelectedPath;
                
            }
        }
    }
}
