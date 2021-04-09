using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Rectangle : Figure
    {
        private int _a;
        private int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }
        
        public override double Area()
        {
            return _a * _b;
        }

        public override double Perimeter()
        {
            return (_a + _b) * 2;
        }
    }
}
