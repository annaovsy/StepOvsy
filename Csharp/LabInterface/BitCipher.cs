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
            throw new NotImplementedException();
        }

        public string Encode(string str)
        {
            res = res+ (char)(str[i] ^ key);
        }
    }
}
