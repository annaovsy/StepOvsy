using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator2
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj) //сравнение объектов
        {
            // Point p = (Point)obj;
            // return p.X == this.X && p.Y == this.Y; //критерий равенства объектов
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode(); //GetHashCode теперь каждый раз уникальный
        }

        public override string ToString()
        {
            return $"point: X = {X}, Y = {Y}";
        }

        public static bool operator ==(Point p1, Point p2) //парная операция(должен быть еще оператор !=)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2) //парная операция(должен быть еще оператор ==)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Point p1, int n)
        {
            return p1.X == n && p1.Y == n;
        }

        public static bool operator !=(Point p1, int n)
        {
            return !(p1 == n);
        }

        public static bool operator >(Point p1, Point p2) //парная операция
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) >
                   Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public static bool operator <(Point p1, Point p2) //парная операция
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) <
                   Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }
        public static bool operator false(Point p)
        {
            return p.X != 0 && p.Y != 0;
        }

        public static Point operator |(Point p1, Point p2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0)) //логическое сложение
                return p2;

            return new Point(); //если нет, вернем начальный объект без инициализации
        }
        public static Point operator &(Point p1, Point p2)
        {
            if ((p1.X != 0 && p1.Y != 0) && (p2.X != 0 && p2.Y != 0))
                return p2;

            return new Point(); //если нет, вернем начальный объект без инициализации
        }

    }

    class Fraction
    {
        public int Numerator { get; set; }
        public int Denomerator{ get; set; }

        public override bool Equals(object obj) 
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode(); 
        }

        public override string ToString()
        {
            return $"Fraction: numerator = {Numerator}, denomerator = {Denomerator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction()
            {
                Numerator = f2.Denomerator * f1.Numerator + f1.Denomerator * f2.Numerator,
                Denomerator = f1.Denomerator * f2.Denomerator,
            };            
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator >(Fraction f1, Fraction f2) //парная операция
        {
            return f1.Numerator > f2.Numerator;
        }
        public static bool operator <(Fraction f1, Fraction f2) //парная операция
        {
            return f1.Numerator < f2.Numerator;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction
            {
                Numerator = 3,
                Denomerator = 4
            };
            Fraction f2 = new Fraction
            {
                Numerator = 6,
                Denomerator = 4
            };
            Console.WriteLine($"f1 + f2 = {f1 + f2}");

            Console.WriteLine($"f1 == f2 {f1 == f2}");
            Console.WriteLine($"f1 != f2 {f1 != f2}");
            int a = 10;

            //Point p1 = new Point
            //{
            //    X = 10,
            //    Y = 20
            //};

            //Point p2 = new Point
            //{
            //    X = 20,
            //    Y = 30
            //};

            //Console.WriteLine(p1); //вызовется то что написали в ToString
            //Console.WriteLine(p2);

            //Console.WriteLine($"p1 == p2 {p1 == p2}");
            //Console.WriteLine($"p1 != p2 {p1 != p2}");

            //Console.WriteLine($"p1 > p2 {p1 > p2}");
            //Console.WriteLine($"p1 < p2 {p1 < p2}");

            //p1.X = p1.Y = 0;

            //if(p1) //возможно благодаря перегрузке операторов
            //    Console.WriteLine("Точка не в начале координат");
            //else
            //    Console.WriteLine("Точка в начале координат"); 

            //if(p1 && p2)
            //    Console.WriteLine("&& true");
            //else
            //    Console.WriteLine("&& false");

            //if(p1||p2)
            //    Console.WriteLine("|| true");
            //else
            //    Console.WriteLine("|| false");

        }
    }
}
