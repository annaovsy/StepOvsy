using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class CardCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                Student stud1 = x as Student;
                Student stud2 = y as Student;

                if(stud1.studentCard.Number < stud2.studentCard.Number)
                {
                    return -1;
                }
                else if (stud1.studentCard.Number > stud2.studentCard.Number)
                {
                    return 1;
                }
                return 0;   
            }
            throw new NotImplementedException();
        }
    }
}
