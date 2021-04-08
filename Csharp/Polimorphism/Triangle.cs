using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Triangle : Figure
    {
        private int _a;
        private int _b;
        private int _c;
        private int _radius;

        public Triangle(int a, int b, int c, int radius) 
        {
            _a = a;
            _b = b;
            _c = c;
            _radius = radius;
        }

        public override double Area()
        {
            return (_a * _b * _c) / (4 * _radius);
        }

        public override double Perimeter()
        {
            return _a + _b + _c;
        }
    }
}
