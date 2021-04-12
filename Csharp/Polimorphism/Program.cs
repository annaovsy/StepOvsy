using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoundFigure figure = new CompoundFigure();
            figure.AddFigure(new Rectangle(5,6));

            figure.Area();
            figure.Perimetr();
            Console.WriteLine(figure);

            figure.AddFigure(new Triangle(1,2,3,4));

            figure.Area();
            figure.Perimetr();
            Console.WriteLine(figure);


            //Figure[] figures =
            //{
            //    new Triangle(5,4,3,7),
            //    new Rectangle(5,7),
            //    new Square(9)
            //};

            //foreach(Figure figure in figures)
            //{
            //    double area = figure.Area();
            //    double perimetr = figure.Perimeter();
            //    Console.WriteLine($"Area = {area} Perimeter = { perimetr}")
            //}


        }
    }
}
