using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Square : Figure, ISimpelFigure
    {
        private int _a;

        public Square(int a)
        {
            _a = a;
        }

        public double Area()
        {
            FigArea = _a * _a;
            return FigArea;
        }

        public double Perimetr()
        {
            FigPerimetr = _a * 4;
            return FigPerimetr;
        }
    }
}
