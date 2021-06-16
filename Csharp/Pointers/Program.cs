using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointers
{
    struct Person
    {
        public int age;
        public int height;
    }

    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* x;
                int y = 10;
                x = &y;
                Console.WriteLine(*x);
                y += 20;
                Console.WriteLine($"x = {*x} y = {y}");
                *x = 50;
                Console.WriteLine($"x = {*x} y = {y}");

                Person person;
                person.age = 29;
                person.height = 176;
                Person* p = &person;
                p->age = 30;
                Console.WriteLine(p->age);

                //разыменование указателя
                (*p).height = 180;
                Console.WriteLine((*p).height);
                Console.WriteLine(person.height);
            }
        }
    }
}
