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
using System.Xml.Serialization;

namespace FormPerson
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
        //    Person person = new Person();
        //    person.Surname = textBoxSurname.Text;
        //    person.Name = textBoxName.Text;
        //    person.Patronymic = textBoxPatronymic.Text;
        //    person.Country = textBoxCountry.Text;
        //    person.City = textBoxCity.Text;
        //    person.Phone = textBoxPhone.Text;
        //    person.Birthday = dateTimePickerBirthday.Value;
        //    person.Pol = radioButtonMan.Checked;
        //    Serialize("Person.xml", person);

            MessageBox.Show("Данные успешно сохранены!", "Inform", MessageBoxButtons.OK);

        }

        static void Serialize(string path, Person person)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Person));
            using (var file = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(file, person);
            }
        }
    }
}
