using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Information information = new Information(5, 5, "Иванов", "Иван", new DateTime(1998, 5, 5));
            information.Print();
        }
    }
}
