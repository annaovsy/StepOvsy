using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class DateComparer : IComparer<Student> //обобщенный интерфейс
    {
        //public int Compare(object x, object y)
        //{
        //    if (x is Student && y is Student) 
        //    {
        //        Student stud1 = x as Student;
        //        Student stud2 = y as Student;

        //        return DateTime.Compare(stud1.BirthDate, stud2.BirthDate);
        //    }
        //    throw new NotImplementedException();
        //}

        public int Compare(Student x, Student y) //обобщенный интерфейс
        {
            return DateTime.Compare(x.BirthDate, y.BirthDate);
        }
    }
}
