using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = ReadXml("http://informer.gismeteo.by/rss/26730.xml");

            Console.WriteLine("Выберите город:");
            Console.WriteLine("1 - Москва");
            Console.WriteLine("2 - Вильнюс");
            Console.WriteLine("3 - Баку");
            Console.WriteLine("4 - Астана");
            Console.WriteLine("5 - Рига");
            string str = Console.ReadLine();
            
            switch (str)
            {
                case "1":
                    city = ReadXml("http://informer.gismeteo.by/rss/27612.xml");
                    break;

                case "2":
                    city = ReadXml("http://informer.gismeteo.by/rss/26730.xml");
                    break;

                case "3":
                    city = ReadXml("http://informer.gismeteo.by/rss/37850.xml");
                    break;

                case "4":
                    city = ReadXml("http://informer.gismeteo.by/rss/35188.xml");
                    break;

                case "5":
                    city = ReadXml("http://informer.gismeteo.by/rss/26422.xml");
                    break;
            }

            foreach (var item in city)
            {
                Console.WriteLine($"{item.City}");
                Console.WriteLine($"{item.WeatherToday}");
                Console.WriteLine();
            }
        }

        static List<Weather> ReadXml(string path)
        {
            var xdoc = XDocument.Load(path);

            var result = xdoc.Element("rss")
                .Element("channel")
                .Elements("item")
                .Select(el => new Weather
                { 
                    City = el.Element("title").Value,
                    WeatherToday = el.Element("description").Value
                }).ToList();

            return result;
        }
    }
}
