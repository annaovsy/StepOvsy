using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeW2
{
    class Program
    {
        public static void Task1()
        {
            int size = 10;
            int[] mass = new int[size];
            int[] massSort = new int[size];

            Random rand = new Random();

            for (int k = 0; k < mass.Length; k++)
            {
                mass[k] = rand.Next(-50, 50);
                Console.Write($"{mass[k]} ");
            }

            int count = 0;

            for (int i = 0; i < mass.Length; i++)
                if (mass[i] < 0)
                {
                    massSort[count] = mass[i];
                    count++;
                }

            for (int i = 0; i < mass.Length; i++)
                if (mass[i] == 0)
                {
                    massSort[count] = mass[i];
                    count++;
                }

            for (int i = 0; i < mass.Length; i++)
                if (mass[i] > 0)
                {
                    massSort[count] = mass[i];
                    count++;
                }

            Console.WriteLine();
            for (int i = 0; i < massSort.Length; i++)
                Console.Write($"{massSort[i]} ");
            Console.WriteLine();
        }

        public static void Task2()
        {
            int size = 5;
            int[,] mass = new int[size, size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mass[i, j] = rand.Next(-100, 100);
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int min = mass[0, 0];
            int max = mass[0, 0];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (min > mass[i, j])
                    {
                        min = mass[i, j];
                    }
                    if (max < mass[i, j])
                    {
                        max = mass[i, j];
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    do
                    {
                        sum += min;
                        min++;
                    }
                    while (min < max);
                }
            }
            Console.WriteLine($"sum = {sum}");

        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
