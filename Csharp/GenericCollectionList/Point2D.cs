using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Point2D<T> //позволяет создавать обобщенный тип данных
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D()
        {
            X = default;
            Y = default; //на основе реального типа данных присвоит либо null либо 0

        }

    }
}
