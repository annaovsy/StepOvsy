using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void ExamHendler(object sender, ExamEventArgs args)
        {
            Console.WriteLine($"Студент {LastName} сдал {args.Task}");
        }
    }

    class Teacher
    {
        private SortedList<int, EventHandler<ExamEventArgs>> _sortedList = new SortedList<int, EventHandler<ExamEventArgs>>();

        Random _rand = new Random();

        public event EventHandler<ExamEventArgs> examEvent
        {
            add
            {
                for(int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedList.ContainsKey(key) && _sortedList.Count < 5)
                    {
                        _sortedList.Add(key, value); //value - метод ExamHendler
                        break;
                    }
                    else
                        throw new Exception("Нельзя добавить больше 5");
                }
            }
            remove
            {
                _sortedList.RemoveAt(_sortedList.IndexOfValue(value));
            }
        }

        public void OnExam(string task) //метод генерации события
        {
            foreach(var item in _sortedList.Keys)
            {
                if (_sortedList[item] != null)
                    _sortedList[item](this, new ExamEventArgs { Task = task });
            }
        }
    }

    class Program
    {
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
                     FirstName = "Иванова",
                     LastName = "Мария",
                     BirthDate = new DateTime(1996,11,30)
                },
                new Student
                {
                     FirstName = "Соколова",
                     LastName = "Ксения",
                     BirthDate = new DateTime(1996,11,30)
                }
            };

            Teacher teacher = new Teacher();
            try
            {
                foreach (Student stud in studGroup)
                {
                    teacher.examEvent += stud.ExamHendler; //добавляет
                }
                teacher.examEvent -= studGroup[2].ExamHendler; //удаляет по индексу

                teacher.OnExam(".Net Framework");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
           

         

        }
    }
}
