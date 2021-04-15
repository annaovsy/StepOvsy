using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class Auditory : IEnumerable
    {
        Student[] students =
        {
          
            new Student
            {
                FirstName = "Петров",
                LastName = "Петр",
                BirthDate = new DateTime(1998,5,23),
                studentCard = new StudentCard
                {
                    Number = 2,
                    Series = "hxbh"
                }
            },
            new Student
            {
                FirstName = "Сидоров",
                LastName = "Олег",
                BirthDate = new DateTime(2000,5,23),
                studentCard = new StudentCard
                {
                    Number = 3,
                    Series = "ldfshg"
                }
            },
            new Student
            {
                FirstName = "Иванов",
                LastName = "Иван",
                BirthDate = new DateTime(1999,5,23),
                studentCard = new StudentCard
                {
                    Number = 1,
                    Series = "skgjlsk"
                }
            },
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }


    }
}
