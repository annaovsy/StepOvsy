using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   // delegate void ExamDelegate(string str);
    class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }

    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }

            public void Exam(object sender, ExamEventArgs args)
            {
                Console.WriteLine($"Студент {LastName} сдал {args.Task}");
            }
        }

        class Teacher
        {
            public event EventHandler<ExamEventArgs> examEvent;

            public void OnExam(string task)
            {
                if (examEvent != null)
                {
                    examEvent.Invoke(this, new ExamEventArgs { Task = task });
                }
            }
        }

        static void Main(string[] args)
        {
            List<Student> studGroup = new List<Student>()
            {
                new Student 
                {
                     FirstName = "Иванов",
                     LastName = "Иван",
                     BirthDate = new DateTime(1997,3,12)
                },
                new Student 
                {
                     FirstName = "Петров",
                     LastName = "Роман",
                     BirthDate = new DateTime(1998,7,22)
                },
                new Student 
                {
                     FirstName = "Joey",
                     LastName = "Finch",
                     BirthDate = new DateTime(1996,11,30)
                }
            };

            studGroup.ForEach(FullName);
            IEnumerable<string> names = studGroup.Select(FullName2);
            var studs = studGroup.FindAll(OnlySpring);
            studGroup.Sort(SortBirthday);
            studGroup.ForEach(FullName);

            void FullName(Student stud)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}");
            }
            string FullName2(Student stud)
            {
                return $"{stud.FirstName} {stud.LastName}";
            }
            bool OnlySpring(Student stud)
            {
                return stud.BirthDate.Month >= 3 && stud.BirthDate.Month <= 5;
            }
            int SortBirthday(Student student1, Student student2)
            {
                return student1.BirthDate.CompareTo(student2.BirthDate);
            }

            Teacher teacher = new Teacher();
            foreach(Student stud in studGroup)
            {
                teacher.examEvent += stud.Exam;
            }
            teacher.OnExam(".Net Framework");

            Console.WriteLine("Введите выражение");

            //string expression = Console.ReadLine();
            //char sign = ' ';
            //// определения знака арифметического действия
            //foreach (char item in expression)
            //{
            //    if (item == '+' || item == '-' || item ==
            //    '*' || item == '/')
            //    {
            //        sign = item;
            //        break;
            //    }
            //}

            //try
            //{
            //    string[] numbers = expression.Split(sign);
            //    Calculator calc = new Calculator();
            //    CalcDelegate calcDeleg = null;

            //    switch (sign)
            //    {
            //        case '+':
            //            calcDeleg = new CalcDelegate(calc.Add); //можно так
            //            break;
            //        case '-':
            //            calcDeleg = calc.Sub;  //а можно так
            //            break;
            //        case '*':
            //            calcDeleg = calc.Mult;
            //            break;
            //        case '/':
            //            calcDeleg = calc.Div;
            //            break;
            //        default:
            //            throw new
            //            InvalidOperationException();
            //    }

            //    double x = double.Parse(numbers[0]);
            //    double y = double.Parse(numbers[1]);

            //    var result = calcDeleg(x, y);

            //    Console.WriteLine("result = {0}", result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
