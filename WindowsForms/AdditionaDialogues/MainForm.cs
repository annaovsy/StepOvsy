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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxGoods.Items.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(listBoxGoods.SelectedIndex !=-1)
            {
                listBoxGoods.Items.RemoveAt(listBoxGoods.SelectedIndex);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var tovar = new Tovar();
            AddEditForm formAdd = new AddEditForm(tovar, true);
            if(formAdd.ShowDialog() == DialogResult.OK)
            {
                listBoxGoods.Items.Add(tovar);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedIndex != -1)
            {
                int index = listBoxGoods.SelectedIndex;
                var tovar = (Tovar)listBoxGoods.Items[index];

                AddEditForm formAdd = new AddEditForm(tovar, false);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    listBoxGoods.Items.RemoveAt(index);
                    listBoxGoods.Items.Insert(index, tovar);
                    listBoxGoods.SelectedIndex = index;
                }

            }
        }
    }
}
