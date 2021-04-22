using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistic statistic = new Statistic();
            string str = statistic.ReadFile("text.txt");
            statistic.CalcWords(str);
            statistic.Show();

        }
    }
}
