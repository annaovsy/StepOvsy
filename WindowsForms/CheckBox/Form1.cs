using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                var myfont = new Font(labelText.Font, FontStyle.Bold);
                labelText.Font = myfont;
            }
            else
            {
                var myfont = new Font(labelText.Font, FontStyle.Regular);
                labelText.Font = myfont;
            }


        }
    }
}
