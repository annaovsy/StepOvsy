using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    class BitCipher : ICipher
    {
        public short key;
        public BitCipher(short key)
        {
            this.key = key;
        }

        public string Decode(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + (char)(str[i] ^ key);
            }           
            return result;
        }

        public string Encode(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + (char)(str[i] ^ key);
            }
            return result;           
        }
    }
}
