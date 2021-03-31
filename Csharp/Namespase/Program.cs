using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExample;
//using Example; //если подключить будет конфликтовать, тогда объявляем через точку 
                 //для этого пространства имен 

namespace Namespase
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment test = new Increment(5);
            test.MyIncrement();
            Example.Increment test2 = new Example.Increment(10);
            test2.MyIncrement();
        }
    }
}
