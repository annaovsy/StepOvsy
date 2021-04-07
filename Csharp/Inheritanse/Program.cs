using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanse
{
    class Human
    {
        private int _id;
        protected string firstName;
        protected string lastName;
        protected DateTime birthday; //тип данных для времени!!!

        public Human(string fName, string lName) : this(fName, lName, DateTime.MinValue) //делегирование конструктора
        {}

        public Human(string fName, string lName, DateTime date)
        {
            firstName = fName;
            lastName = lName;
            birthday = date;
        }

        public void Print()
        {
            Console.WriteLine($"Фамилия: {firstName}\nИмя: {lastName}\nДата рождения: {birthday.ToShortDateString()}"); // ToShortDateString выведет дату без времени
        }

    }

    class Employee:Human
    {
        double _salary;

        public Employee(string fName, string lName) : base(fName, lName) { }

        public Employee(string fName,string lName, double salary) : base(fName, lName)
        {
            _salary = salary;
        }

        public Employee(string fName, string lName,DateTime date, double salary) : base(fName, lName, date)
        {
            _salary = salary;
        }

        public new void Print() 
        {
            base.Print(); //сначала вызовет Print из базового класса, затем из наследника
            Console.WriteLine($"\nЗарплата: {_salary}\n");
        }
    }

    class Manager : Employee
    {
        private string _activity;

        public Manager(string fName, string lName, DateTime date, double salary, string activity)
            :base (fName,lName,date,salary)
        {
            _activity = activity;
        }

        public void ShowManager()
        {
            Console.WriteLine($"Менеджер. Деятельность {_activity} ");
        }
    }

    class Scinetist:Employee
    {
        private string _scientificDirection;

        public Scinetist(string fName, string lName, DateTime date, double salary, string scientificDirection)
            :base(fName, lName, date, salary)
        {
            _scientificDirection = scientificDirection;
        }

        public void ShowScinetist()
        {
            Console.WriteLine($"Ученый. Научное направление {_scientificDirection} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee("Иванов", "Иван", new DateTime(1996,05,23), 20000);
            empl.Print();

            Employee manager = new Manager("Петров", "Петр", new DateTime(1997, 06, 23), 35000, "Продукты питания");

            Employee[] empls = new Employee[]
            {
                manager,
                new Scinetist("Сидоров", "Владимир", new DateTime(1997, 06, 23), 37000, "История")
            };

            foreach(Employee item in empls)
            {
                if (item is Manager)
                {
                    Manager man = item as Manager;
                    man.ShowManager();
                }
                else if(item is Scinetist)
                {
                    Scinetist scinetist = item as Scinetist;
                    scinetist.ShowScinetist();
                }
                else
                {
                    item.Print();
                }
            }

        }
    }
}
