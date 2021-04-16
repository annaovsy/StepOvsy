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
            Console.WriteLine("SimpleCipher");
            SimpleCipher simpleCipher = new SimpleCipher();
            string str = simpleCipher.Encode("abc");
            Console.WriteLine(str);
            str = simpleCipher.Decode(str);
            Console.WriteLine(str + "\n");

            Console.WriteLine("BitCipher");
            BitCipher bit = new BitCipher(16);
            string strBit = bit.Encode("abc");
            Console.WriteLine(strBit);
            strBit = bit.Decode(strBit);
            Console.WriteLine(strBit + "\n");

            UnlistedPhone[] unlistedPhones =
            {
                new UnlistedPhone("Мария", "8-952-815-96-97", new BitCipher(6)),
                new UnlistedPhone("Борис", "8-988-213-86-06", new BitCipher(19)),
                new UnlistedPhone("Ксения", "8-961-599-78-00", new BitCipher(23)),
            };
            foreach(UnlistedPhone unlistedPhone in unlistedPhones)
            {
                Console.WriteLine(unlistedPhone.ToString());
            }
        }
    }
}
