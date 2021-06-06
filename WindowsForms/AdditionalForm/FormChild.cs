using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalForm
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        public FormChild(string text):this()
        {
            textBoxMessage.Text = text;
        }

        public string Message
        {
            set { textBoxMessage.Text = value; }
            get { return textBoxMessage.Text; }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public DialogResult ShowDialog(string text)
        {
            textBoxMessage.Text = text;
            return ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
