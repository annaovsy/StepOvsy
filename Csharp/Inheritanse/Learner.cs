using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanse
{
    abstract class Learner : Human
    {
        private string _institushion;
        public Learner(string fName, string lName, DateTime date, string institushion)
            :base(fName, lName, date)
        {
            _institushion = institushion ?? throw new ArgumentNullException(nameof(institushion)); //если null, то сгенерируется исключение
        }

        public abstract void Study();

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Учебное заведение: {_institushion}");
        }
    }
}
