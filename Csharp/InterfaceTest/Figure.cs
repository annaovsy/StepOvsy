using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    abstract class Figure
    {
        public double Perimetr { get; set; }
        public double Area { get; set; }
        public override string ToString()
        {
            return $"Perimetr {Perimetr} Area {Area}";
        }
    }
}
