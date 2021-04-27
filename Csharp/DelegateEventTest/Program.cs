using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventTest
{
    class Program
    {
        class TestEvent
        {
            public void ChangeMark(Student student, double mark)
            {
                student.Mark = mark;
            }
            public void ChangeName(Student student, string name)
            {
                student.Name = name;
            }
            public void ChangeGroup(Student student, string group)
            {
                student.Group = group;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Jack",
                Mark = 7,
                Group = "fdhdsh"
            };
            TestEvent testEvent = new TestEvent();

            //student.PropertyChanged += Student_PropertyChanged; //Student_PropertyChanged - метод, который вызывается в ответ на событие
            //вместо этого можно так 
            student.PropertyChanged +=
                delegate (object sender, PropertyEventArgs e)
                {
                    Console.WriteLine($"Изменено свойство {e.Name}");
                };

            testEvent.ChangeMark(student, 5.5);
            testEvent.ChangeName(student, "Don");
            testEvent.ChangeGroup(student, "68934abcd");
        }

        //private static void Student_PropertyChanged(object sender, PropertyEventArgs e)
        //{
        //    Console.WriteLine($"Изменено свойство {e.Name}");
        //}
    }
}
