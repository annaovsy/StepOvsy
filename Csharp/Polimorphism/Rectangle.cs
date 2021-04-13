using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Rectangle : Figure, ISimpelFigure
    {
        private int _a;
        private int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }
        
        public double Area()
        {
            FigArea = _a * _b;
            return FigArea;
        }

        public double Perimetr()
        {
            FigPerimetr = (_a + _b) * 2;
            return FigPerimetr;
        }

       
    }
}
