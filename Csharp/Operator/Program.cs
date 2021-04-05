using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static Point operator++(Point ob) //обязательно static
        {
            ob.X++;
            ob.Y++;

            return ob;
        }
        public static Point operator --(Point ob) 
        {
            ob.X--;
            ob.Y--;

            return ob;
        }
        public static Point operator -(Point ob)
        {
            new Point()
            {
                X = ob.X * -1,
                Y = ob.Y * -1,
            };
            return ob;
        }
        public static Point operator +(Point ob, Point ob2)
        {
            new Point()
            {
                X = ob.X + ob2.X,
                Y = ob.Y + ob2.Y,
            };
            return ob;
        }
        public static Point operator -(Point ob, Point ob2)
        {
            new Point()
            {
                X = ob.X - ob2.X,
                Y = ob.Y - ob2.Y,
            };
            return ob;
        }

        public void Show()
        {
            Console.WriteLine($"\n\tX = {X} , Y = {Y}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point()
            {
                X = 10,
                Y = 20,
            };
            //point1--.Show();
            //point1++.Show(); //в c# не имеет значения префиксная или постфиксная форма
            Point point2 = new Point();
            point2 = - point1;
            point2.Show();
            point1.Show();
        }
    }
}
