using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Vector
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public Point MyPoint { get; set; }

        public Vector() { }

        public Vector(Point begin, Point end)
        {
            MyPoint.X = end.X - begin.X;
            MyPoint.Y = end.Y - begin.Y;
        }

        public static Vector operator +(Vector v1,Vector v2)
        {
            return new Vector() //делаем new чтобы объект не изменялся
            {
                MyPoint = v1.MyPoint + v2.MyPoint
            };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector()
            {
                MyPoint = v1.MyPoint - v2.MyPoint
            };
        }

    }
}
