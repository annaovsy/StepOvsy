using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstInt = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lstInt.Add(i + 1);
            }
            foreach(var item in lstInt)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("lstInt.Count = {0}", lstInt.Count);

            lstInt.Remove(5);
            foreach (var item in lstInt)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("lstInt.Count = {0}", lstInt.Count);

            List<string> lstString = new List<string>();
            lstString.Add("one");
            foreach (var item in lstString)
            {
                Console.WriteLine($"{item} ");
            }

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["Gr1"] = 10;
            dictionary.Add("Gr2", 15);
            dictionary.Add("Gr3", 19);
            dictionary.Add("Gr4", 25);

            dictionary["Gr1"] = 150;

            foreach(/*KeyValuePair<string, int>*/var item in dictionary)
            {
                Console.WriteLine($"Key = {item.Key} value = {item.Value}");
            }

            try
            {
                dictionary.Add("Gr1", 55);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }

            // int number = dictionary["Gr100"];
            if (dictionary.TryGetValue("Gr100", out var number))
            {
                Console.WriteLine($"Key = Gr100 value = {number}");
            }
            else
                Console.WriteLine("Not Found!");

            Point2D<int> point = new Point2D<int>()
            {
                X = 10,
                Y = 20
            };

            Console.WriteLine($"x = {point.X} y = {point.Y}");
            Console.WriteLine(typeof(Point2D<int>));

            Point2D<double> point2 = new Point2D<double>()
            {
                X = 2.056,
                Y = 5.23
            };
            Console.WriteLine($"x = {point2.X} y = {point2.Y}");
            Console.WriteLine(typeof(Point2D<double>));

            Point2D<string> pointStr = new Point2D<string>();

        }
    }
}
