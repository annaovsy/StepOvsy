using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();

            //auditory.Sort(new DateComparer());
            auditory.Sort(new CardCompare());
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }
        }
    }
}
