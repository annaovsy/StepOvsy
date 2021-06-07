using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionaDialogues
{
    public partial class AddEditForm : Form
    {
        private Tovar _tovar;
        public AddEditForm(Tovar tovar, bool addNew)
        {
            InitializeComponent();
            _tovar = tovar;
            if(!addNew)
            {
                Text = "Редактирования товара";
                textBoxName.Text = tovar.Name;
                textBoxMadeIn.Text = tovar.Madein;
                textBoxPrice.Text = tovar.Price.ToString();
            }
            else
            {
                Text = "Добавление товара";
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "" || textBoxMadeIn.Text == ""
                || textBoxPrice.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            _tovar.Name = textBoxName.Text;
            _tovar.Madein = textBoxMadeIn.Text;
            if(double.TryParse(textBoxPrice.Text, out var price))
            {
                _tovar.Price = price;
            }
            else
            {
                MessageBox.Show("Цена указана неверно");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
