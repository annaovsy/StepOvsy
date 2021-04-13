                                     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class MixFigure:Figure
    {
        private Figure[] _figures;
        public double sumArea = 0;

        public MixFigure(Figure[] figures)
        {
            _figures = figures;
        }

        //public override double Area()
        //{
           
        //    foreach(Figure figure in _figures)
        //    {

        //    }
        //}

        //public override double Perimeter()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
