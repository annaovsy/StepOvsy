using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanse
{
    abstract class Human
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

        public abstract void Think();

        public virtual void Print()
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

        public override void Print() 
        {
            base.Print(); //сначала вызовет Print из базового класса, затем из наследника
            Console.WriteLine($"\nЗарплата: {_salary}\n");
        }

        public override void Think()
        {
            throw new NotImplementedException();
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

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Менеджер. Деятельность {_activity} \n");
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

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ученый. Научное направление {_scientificDirection} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Human empl = new Employee("Иванов", "Иван", new DateTime(1996, 05, 23), 20000);
             Employee manager = new Manager("Петров", "Петр", new DateTime(1997, 06, 23), 35000, "Продукты питания");

             Human[] empls = new Human[]
             {
                 empl,
                 manager,
                 new Scinetist("Сидоров", "Владимир", new DateTime(1997, 06, 23), 37000, "История")
             };

             foreach (Employee item in empls)
             {                 
                 item.Print();
             }*/

            Learner[] learners =
            {
                new SchoolChild("Петров","Петр", new DateTime(1996, 07, 13),"Школа №37","10В"),
                new Student("Иванов", "Иван", new DateTime(1997, 06, 23), "ЮФУ", "aaa"),

                new Student("bbb", "Иван", new DateTime(1997, 06, 23), "bbb", "bbb")
            };
            foreach(Learner learner in learners)
            {
                learner.Print();
                learner.Study();
                learner.Think();
                Console.WriteLine();
            }

        }
    }
}
