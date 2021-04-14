using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCipher simpleCipher = new SimpleCipher();

            string str=simpleCipher.Encode("abc");
            Console.WriteLine(str);

            str = simpleCipher.Decode(str);
            Console.WriteLine(str);


        }
    }
}
