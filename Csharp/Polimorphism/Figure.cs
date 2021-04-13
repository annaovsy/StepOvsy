using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    abstract class Figure
    {
        public double FigPerimetr { get; set; }
        public double FigArea { get; set; }
        public override string ToString()
        {
            return $"Perimetr {FigPerimetr} Area {FigArea}";
        }
        //public abstract double Area();
        //public abstract double Perimeter();
    }
}
