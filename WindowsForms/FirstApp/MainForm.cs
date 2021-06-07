using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            lableCoordinates.Text = CoordtestToString(e);
        }

        private string CoordtestToString(MouseEventArgs args)
        {
            
            return $"Координаты мыши X = {args.X} Y = {args.Y}";
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            var message = "";
            if(e.Button == MouseButtons.Left)
            {
                message = "Вы нажали левую кнопку мыши.\n";
            }
            else if(e.Button == MouseButtons.Right)
            {
                message = "Вы нажали правую кнопку мыши.\n";
            }
            message += CoordtestToString(e);
            MessageBox.Show(message, "Клик мыши", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lableCoordinates.Visible = true;
            buttonYes.Enabled = true;
                
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //if (result == DialogResult.Abort)
            //{
            //    MessageBox.Show("Вы нажали кнопку прервать", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
            //else if (result == DialogResult.Retry)
            //{
            //    MessageBox.Show("Вы нажали кнопку повторить", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
            //else if (result == DialogResult.Ignore)
            //{
            //    MessageBox.Show("Вы нажали кнопку пропустить", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
            //lableCoordinates.Visible = false;
            //buttonYes.Enabled = false;

            MessageBox.Show("Мы не сомневались!", "Inform", MessageBoxButtons.OK);

        }

        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            buttonNo.Top -= e.Y;
            buttonNo.Left += e.X;
            if (buttonNo.Top < -10 || buttonNo.Top > 100)
                buttonNo.Top = 60;
            if (buttonNo.Left < -80 || buttonNo.Left > 250)
                buttonNo.Left = 120;
            // buttonNo.Enabled = false;
        }

        private void buttonNo_MouseLeave(object sender, EventArgs e)
        {
            buttonNo.Enabled = true;
        }

    }
}
