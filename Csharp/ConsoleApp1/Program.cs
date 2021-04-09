using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Sum(new int[] { 1, 2, 3 });
            Console.WriteLine($"s={s}");
            s = Sum(new int[] { 10, 20, 30, 40 });
            Console.WriteLine($"s={s}");

            Ex ex = new Ex();
            ex.Num = 10;
            Console.WriteLine("val = " + ex.Num);
            
            Employee em1 = new Employee
            {
                Name = "Иванов",
                Age = 25,
                Salary = 30000
            };

            Employee em2 = new Employee();
            em2.Age = 35;
            em2.Salary = -100;
            
            Console.WriteLine(em1.Print());
            Console.WriteLine(em2.Print());
        }

        private static int Sum(params int[] args)
        {
            int sum = 0;
            foreach(var s in args)
            {
                sum += s;
            }
            return sum;
        }
    }
}
