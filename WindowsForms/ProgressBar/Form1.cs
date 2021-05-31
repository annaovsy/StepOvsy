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

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                                                                                                                                                                                                                             
        private void buttonProgress_Click(object sender, EventArgs e)                                                                                                                                                                                       
        {
            progressBarTemp.Minimum = 0;
            using (var file = new FileStream("123.txt", FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[100];
                progressBarTemp.Step = bytes.Length;
                progressBarTemp.Maximum = (int)file.Length;
               
                while(file.Position != file.Length)
                {
                    file.Read(bytes, 0, bytes.Length);
                    progressBarTemp.PerformStep();
                    labelVal.Text = progressBarTemp.Value.ToString();
                    this.Update();
                    Thread.Sleep(50);
                }
            }

            //progressBarTemp.Minimum = 0;
            //progressBarTemp.Maximum = 50;
            //progressBarTemp.Step = 1;

            //for (int i = 0; i < progressBarTemp.Maximum; i++) 
            //{
            //    progressBarTemp.PerformStep();
            //    labelVal.Text = progressBarTemp.Value.ToString();
            //    this.Update();
            //    Thread.Sleep(50);
            //}

        }

    }
}
