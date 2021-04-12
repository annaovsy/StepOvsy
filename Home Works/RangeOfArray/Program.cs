using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            Console.Write("Начало: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Конец: ");
            end = int.Parse(Console.ReadLine());
            RangeOfArray array = new RangeOfArray(start, end);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"array[{i}] - {i}"); ;
            }
        }
    }
}
