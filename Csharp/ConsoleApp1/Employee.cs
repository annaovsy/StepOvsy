using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private string _name;
        private int _age;
        private double _salary;

        public string Name //свойство
        {
            get 
            {
                return string.IsNullOrEmpty(_name) ? "Не задано" : _name;  //проверка на null
            }

            set 
            {
                _name = value.ToUpper(); //value - значение, которое передаем свойству   
            }
        }

        public int Age
        {
            get { return _age; }

            set 
            {
                if (value > 0 && value <= 120)
                    _age = value;
                else
                    _age = 0;
            }
        }

        public double Salary
        {
            get { return _salary; }

            set { _salary = value < 0 ? 0 : value; }
        }

        public string Print()
        {
            return $"Имя: {Name} \nВозраст: {Age} \nЗарплата: {Salary}\n";
        }
    }
}
