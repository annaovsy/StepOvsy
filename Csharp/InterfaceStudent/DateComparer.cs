using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student) 
            {
                Student stud1 = x as Student;
                Student stud2 = y as Student;

                return DateTime.Compare(stud1.BirthDate, stud2.BirthDate);
            }
            throw new NotImplementedException();
        }
    }
}
