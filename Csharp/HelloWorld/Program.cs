using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    enum Color
    {
        TestRed,
        TestGreen,
        TestBlue
    };
    class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.TestBlue; //писать например color = 100 нельзя!
            int n = 10;
            double d;
            d = n;
            int n2 = (int)d; //в данном случае только явное преобразование типов
            string str = n.ToString();


            Console.Title = "Пример использования";
          //  Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Введите ваше имя: ");
            string name;
            name = Console.ReadLine();
            if (name == "")
                Console.WriteLine("Hello World!");
            else
            {
                Console.WriteLine("Hello " + name + "!");
            }
            Console.WriteLine("Введите целое число");
            str = Console.ReadLine();
          //  n = Convert.ToInt32(str);

            if(int.TryParse(str, out n))
                n = int.Parse(str);

            Console.WriteLine($"n = {n}");

            var temp = 12.5436; //определяет сам тип данных

            int a = 100;
            //if(n) теперь писать нельзя

            Console.WriteLine(a);

            //int? a = 50;
            //int? a2 = null;
            //a2 = a ?? 100;  //тоже самое что
                            //if (a != null)
                            //    a2 = a;
                            //else
                            //    a = 100;
        }
    }
}
