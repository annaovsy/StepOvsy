using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            listBoxCar.Items.Add("Nisan");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var str = textBoxCar.Text;
            if (!string.IsNullOrWhiteSpace(str) && !listBoxCar.Items.Contains(str))
                listBoxCar.Items.Add(str);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBoxCar.SelectedItems?.Count != null)
            {
                int i = 0;
                while(listBoxCar.SelectedItems.Count != 0)
                {
                    listBoxCar.Items.Remove(listBoxCar.SelectedItems[i]);
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            listBoxCarCopy.Items.Clear();
            listBoxCarCopy.Items.AddRange(listBoxCar.Items);
        }

        private void buttonDelChecked_Click(object sender, EventArgs e)
        {
            var index = checkedListBoxName.SelectedIndex;
            if (index != -1 && checkedListBoxName.GetItemChecked(index))
                checkedListBoxName.Items.RemoveAt(index);
        }
    }
}
