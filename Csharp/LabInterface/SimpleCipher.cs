using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    class SimpleCipher : ICipher
    {
        public string Decode(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += (char)(str[i] - 1);
            }
            return result;
        }

        public string Encode(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++) 
            {
                result += (char)(str[i] + 1);
            }
            return result;
        }
    }
}
