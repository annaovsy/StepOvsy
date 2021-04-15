using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    interface ICipher
    {
        string Encode(string str);
        string Decode(string str);
    }
}
