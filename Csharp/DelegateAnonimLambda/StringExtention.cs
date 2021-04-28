using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelegateAnonimLambda
{
    static class StringExtention
    {
        public static int NumberWords(this string data) //метод расширения (считает слова в строке)
        {
            if (string.IsNullOrEmpty(data))
                return 0;

            data = Regex.Replace(data.Trim(), @"\s+", " ");

            return data.Split(' ').Length;
        }

        public static string ReversString(this string data)
        {
            string temp = "";
            

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != ' ')
                    temp += data[i];

                return temp;
            }





        }
    }
}
