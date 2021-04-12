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
            /*Описание действия метода: 
             * Результат:*/
            //определяет является ли символ
            //управляющим 
            //Console.WriteLine(char.sControl('\t')); //True 
            //определяет является ли символ цифрой
            Console.WriteLine(char.IsDigit('5'));
            //определяет является ли символ бувенным 
            Console.WriteLine(char.IsLetter('5')); //True 
            //определяет находится ли символ 
            //в нижнем регистре
            Console.WriteLine(char.IsLower('m')); //True
            //определяет находится ли символ 
            //в верхнем регистре 
            Console.WriteLine(char.IsUpper('P')); //True
            //определяет является ли символ числом 

            Console.WriteLine(char.IsNumber('2')); //True
            //определяет является ли символ
            //разделителем 
            Console.WriteLine(char.IsSeparator('.')); //False
            //определяет является ли символ 
            //специальным символом 
            Console.WriteLine(char.IsSymbol('<')); //True
            //определяет является ли символ пробелом 
            Console.WriteLine(char.IsWhiteSpace(' ')); //True
            //переводит символ в нижний регистр 
            Console.WriteLine(char.ToLower('T')); //t
            //переводит символ в верхний регистр
            Console.WriteLine(char.ToUpper('t'));

        }
    }
}
