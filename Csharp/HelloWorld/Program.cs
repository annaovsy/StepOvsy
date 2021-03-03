using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ваше имя: ");
            string name;
            name = Console.ReadLine();
            if (name == "")
                Console.WriteLine("Hello World!");
            else
            {
                Console.WriteLine("Hello " + name + "!");
            }

            int n = 100;
            //if(n) теперь писать нельзя

            Console.WriteLine(n);

            int? a = 50;
            int? a2 = null;
            a2 = a ?? 100; //тоже самое что
                            //if (a != null)
                            //    a2 = a;
                            //else
                            //    a = 100;
        }
    }
}
