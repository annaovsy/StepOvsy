using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanse
{
    class Student : Learner
    {
        private string _groupname;

        public Student(string fName, string lName, DateTime date, string institushion, string groupname)
            :base(fName, lName, date, institushion)
        {
            _groupname = groupname;
        }

        public override void Study()
        {
            Console.WriteLine("Я изучаю предметы в институте");
        }

        public override void Think()
        {
            Console.WriteLine("Я думаю как студент");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Я учусь в группе {_groupname}");
        }



    }
}
