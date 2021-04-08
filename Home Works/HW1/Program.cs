using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Введите символы: ");
            char smb;
            int spaceCount = 0;
            do
            {
                smb = Console.ReadKey().KeyChar;
                if (smb == ' ')
                    spaceCount++;
            }
            while (smb != '.');

            Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
        }

        public static void Task2()
        {
            Console.WriteLine("Введите номер трамвайного билета: ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine($"Счастливый билет: {leftNumber} = {rightNumber}");
                }

                else Console.WriteLine($"Не счастливый билет:  {leftNumber} != {rightNumber}");
            }

            else Console.WriteLine("Число введено не правильно!");
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
        }
    }
}
