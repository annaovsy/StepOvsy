using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class CompoundFigure : Figure,  ISimpelFigure
    {
        List<ISimpelFigure> SimpleFigures { get; set; } = new List<ISimpelFigure>();

        public void AddFigure(ISimpelFigure figure)
        {
            SimpleFigures.Add(figure);
        }

        public double Area()
        {
            double sum=0;
           foreach(ISimpelFigure figure in SimpleFigures)
            {
                sum+=figure.Area();
                
            }
            return sum;
        }

        public double Perimetr()
        {
            double sum = 0;
            foreach (ISimpelFigure figure in SimpleFigures)
            {
                sum += figure.Perimetr();

            }
            return sum;
        }
    }
}
