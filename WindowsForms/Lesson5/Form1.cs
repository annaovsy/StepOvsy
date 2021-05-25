using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCurrentDataArrival.Text = dateTimePicker1.Value.ToLongDateString();
            labelCurrentDataDeparture.Text = dateTimePickerDepart.Value.ToLongDateString();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            SendKeys.Send("%{DOWN}"); 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelCurrentDataArrival.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePickerDepart_ValueChanged(object sender, EventArgs e)
        {
            labelCurrentDataDeparture.Text = dateTimePickerDepart.Value.ToLongDateString();
            var days = dateTimePickerDepart.Value.Date - dateTimePicker1.Value.Date;
            labelNumberofdays.Text = days.Days.ToString();
        }

        private void textBoxBirthday_TextChanged(object sender, EventArgs e)
        {
            var str = textBoxBirthday.Text;
            if(DateTime.TryParse(str, out var dayBirth))
            {
                monthCalendarBirthday.SetDate(dayBirth);
            }
        }
    }
}
