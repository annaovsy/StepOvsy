using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        //static int CalcBits(ushort chMask)
        //{
        //    ushort temp = chMask;

        //    int count = 0;
        //    while(temp!=0)
        //    {
        //        if ((temp & 1) != 0)
        //            ++count;

        //        temp >>= 1; //побитовый сдвиг
        //    }
        //    return count;
        //}
        //static bool IsPolindrom(string str)
        //{
        //    int counter = 0;

        //    for (int i = 0, j = str.Length - 1; i < j; i++, j++) 
        //    {
        //        if (str[i] != str[j])
        //            return false;

        //        counter++;
        //    }
        //    if (counter == str.Length / 2)
        //        return true;          
        //}

        //  static void Swap(ref int n1, ref int n2) //ref передача по ссылке
        // {   int temp = n1;    n1 = n2; n2 = temp;}

        static int Reverse(string str)
        {
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; --i)
            {
                str2 += str[i];
            }
            return int.Parse(str2);
        }
        static int Reverse(int val)
        {
            int size = 0;
            int temp = val;
            int result = 0;
            while (val > 0) 
            {
                temp /= 10;
                ++size;
            }
            while (size > 0) 
            {
                result += (val % 10) * (int)Math.Pow(10, size - 1);
                --size;
                val /= 10;
            }
            return result;
        }

        static void TestShow(int a, int b)
        {
            for(int i=a;i<=b;i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            //ushort chMask = 135;
            //var countChannel = CalcBits(chMask);
            //Console.WriteLine($"countChannel = {countChannel}");
            ////Console.ReadKey();
            //if(IsPolindrom("кабак"))
            //    Console.WriteLine("полиндром");
            //else
            //    Console.WriteLine("не полиндром");

            int n1 = 10;
            int n2 = 15;
            //  Swap(ref n1, ref n2);
            //Console.WriteLine("n1 = {0} n2 = {1}", n1, n2);

            // string str = Console.ReadLine();
            // n1 = Reverse(str);

            // Console.WriteLine("str = {0} n1 = {1}", str, n1);

            // n1 = Reverse(int.Parse(str));
            // Console.WriteLine("str = {0} n1 = {1}", str, n1);

            TestShow(3, 7);

        }
    }
}
