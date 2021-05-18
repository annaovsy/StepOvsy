using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Personage
    {
        public void Feed() 
        {                      
            Console.Clear();
            Console.WriteLine("^-^");
        }

        public void Walk()
        { 
            Console.Clear();
            Console.WriteLine("^-^");
        }
        public void Sleep()
        {
            Console.Clear();
            Console.WriteLine("^-^");
        }

        public void Heal()
        { 
            Console.Clear();
            Console.WriteLine("^-^");
        }

        public void Play()
        { 
            Console.Clear();
            Console.WriteLine("^-^");
        }

        public void Sick()
        {
            Console.Clear();
            Console.WriteLine("Я заболел");
            Console.WriteLine(":(");
        }

        public void Die()
        {
            Console.WriteLine("*");
        }

    }
}
