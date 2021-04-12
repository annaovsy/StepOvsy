using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class CompoundFigure : ISimpleFigure
    {
        List<ISimpleFigure> simpleFigures { get; set; }

        public double Area()
        {
            return ;
        }

        public double Perimetr()
        {
            Console.WriteLine("Perimetr");
        }
    }
}
