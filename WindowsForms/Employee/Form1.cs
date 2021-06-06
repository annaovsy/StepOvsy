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

namespace Employee
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (!string.IsNullOrWhiteSpace(textBoxSurname.Text))
                employee.Surname = textBoxSurname.Text;
            employee.Salary = double.Parse(textBoxSalary.Text);
            employee.Position = comboBoxPosition.Text;
            employee.City = comboBoxCity.Text;           
            
            listBoxListEmpl.Items.Add(employee.Surname);
            employees.Add(employee);
            SaveToFile("Employees.txt", employees);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxListEmpl.SelectedItems?.Count != null)
            {
                int i = 0;
                while (listBoxListEmpl.SelectedItems.Count != 0)
                {
                    listBoxListEmpl.Items.Remove(listBoxListEmpl.SelectedItems[i]);
                }
            }
        }

        private void SaveToFile(string filename, List<Employee> employees)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    foreach (var item in employees)
                    {
                        writer.WriteLine($"Фамилия: {item.Surname}");
                        writer.WriteLine($"Зарплата: {item.Salary}");
                        writer.WriteLine($"Должность: {item.Position}");
                        writer.WriteLine($"Город: {item.City}");
                        writer.WriteLine();
                    }
                }
            }
        }

    }
   
}
