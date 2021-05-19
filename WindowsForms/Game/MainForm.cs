using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            int number = new Random().Next(1, 10);
            int count = 0;
            DialogResult result;
            while (true)
            {
                result = MessageBox.Show($"Ваше число {number}?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    count++;
                    MessageBox.Show($"Поздравляем! Использовано {count} попыток", "Information", MessageBoxButtons.OKCancel);
                    break;
                }
                else if (result == DialogResult.No)
                {
                    DialogResult res = MessageBox.Show("Продолжить?", "Information", MessageBoxButtons.YesNo);
                    count++;
                    if(res == DialogResult.No)
                    {
                        MessageBox.Show($"Использовано {count} попыток");
                        break;
                    }
                }
            }
           
        }
    }
}
