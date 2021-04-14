using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    class BitCipher : ICipher
    {
        public string str;

        public BitCipher(short key)
        {
            
        }

        public string Decode(string str)
        {
            throw new NotImplementedException();
        }

        public string Encode(string str)
        {

        }
    }
}
