using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnonimLambda
{
    public delegate double TestDoubleDelegate(double a, double b);
    public delegate void TestIntDelegate(int a);
    public delegate void TestVoidDelegate();
    public delegate string StrMod(string s);

    class Dispacher
    {
        public event TestDoubleDelegate eventDouble;
        public event TestIntDelegate eventInt;
        public event StrMod eventStr;

        public double OnGenerateDouble(double a, double b) 
        {
            if(eventDouble != null)
                return eventDouble(a, b);

            throw new DivideByZeroException();           
        }

        public void OnGenerateInt(int n)
        {
            eventInt?.Invoke(n);
            //if (eventInt != null) //тоже самое
            //{
            //    eventInt(n);
            //}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dispacher dispacher = new Dispacher();
            //dispacher.eventDouble += delegate (double a, double b)
            //{
            //    if (b != 0)
            //    {
            //        return a / b;
            //    }
            //    throw new DivideByZeroException();
            //};

            dispacher.eventDouble += (a, b) =>  //лямбда-выражение
            {
                if (b != 0)
                {
                    return a / b;
                }
                throw new DivideByZeroException();
            };


            double n1 = 22.78, n2 = 6.7;
            double res = dispacher.OnGenerateDouble(n1, n2);
            Console.WriteLine($"res = {res}");
            int number = 150;

            //dispacher.eventInt += delegate (int n)
            //{
            //    Console.WriteLine($"number + n = {n + number}");
            //    number++;
            //}; 
            dispacher.eventInt += n => Console.WriteLine($"number + n = {n + number}");

            dispacher.OnGenerateInt(10);
            Console.WriteLine($"number = {number}");

            TestVoidDelegate voidDelegate = new TestVoidDelegate(() => { Console.WriteLine("OK!"); });
            voidDelegate += () => { Console.WriteLine("BYE!"); };
            voidDelegate();

            StrMod strReplace = str => str.Replace(' ', '_');

            string result = "Привет Мир!";
            result = strReplace(result);
            Console.WriteLine(result);
            //StrMod strReverse = str2 =>
            //{
            //    string temp = "";
            //    int i;

            //    for (i = 0; i < str2.Length; i++)
            //    {
            //        if (str2[i] != ' ')
            //            temp += str2[i];

            //        return temp;
            //    }
            //};

            int count = 0;

            KeyEvent keyEvent = new KeyEvent();
            keyEvent.KeyPress += (sender, keyArgs) => Console.WriteLine($" | Нажата клавиша {keyArgs.Key}");
            keyEvent.KeyPress += (sender, keyArgs) => count++;

            Console.WriteLine("Введите последовательность символов...Точка для выхода");
            ConsoleKeyInfo keyInf;
            do
            {
                keyInf = Console.ReadKey();
                keyEvent.OnKeyPress(keyInf.KeyChar);

            } while (keyInf.KeyChar != '.');

            Console.WriteLine("Было нажато {0} клавиш", count);


            string test = "fgfs sg ksdjglksj 23586 79s dg";
            int countWords = test.NumberWords();

            Console.WriteLine($"Количество слов = {countWords}");

        }
    }
}
