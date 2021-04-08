using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Square : Figure
    {
        private int _a;

        public Square(int a)
        {
            _a = a;
        }

        public override double Area()
        {
            return _a * _a;
        }

        public override double Perimeter()
        {
            return _a * 4;
        }
    }
}
