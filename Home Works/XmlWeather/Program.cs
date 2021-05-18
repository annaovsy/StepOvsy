using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = null;

            Console.WriteLine("Выберите город:");
            Console.WriteLine("1 - Москва");
            Console.WriteLine("2 - Вильнюс");
            Console.WriteLine("3 - Баку");
            Console.WriteLine("4 - Астана");
            Console.WriteLine("5 - Рига");
            string str = Console.ReadLine();
            if (str == "1")
            {
                reader = new XmlTextReader("http://informer.gismeteo.by/rss/26730.xml");
            }
            try
            {
                reader.WhitespaceHandling = WhitespaceHandling.None;
                 
                while (reader.Read())
                {
                    if (reader.IsStartElement("item"))
                    {
                        while (reader.Read())
                        {
                            if (reader.Name == "title")
                            {
                                Console.WriteLine(reader.ReadString());
                            }
                            if (reader.Name == "description")
                            {
                                Console.WriteLine(reader.ReadString());
                                Console.WriteLine();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
