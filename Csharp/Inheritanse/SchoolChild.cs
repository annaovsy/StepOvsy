using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanse
{
    class SchoolChild : Learner
    {
        private string _className;

        public SchoolChild(string fName, string lName, DateTime date, string institushion, string className)
            : base(fName, lName, date, institushion)
        {
            _className = className;
        }

        public override void Study()
        {
            Console.WriteLine("Я изучаю предметы в школе.");
        }

        public override void Think()
        {
            Console.WriteLine("Я думаю как школьник.");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Я учусь в классе {_className}");
        }
    }
}
