﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTest
{
    public partial class MainForm : Form
    {
        public List<string> files 
        { 
            get { return files; }
            set
            { 
                files = value;
                listBoxFile.Items.Add(files);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormFiles formFiles = new FormFiles();
           
        }
    }
}