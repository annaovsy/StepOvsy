using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LINQtoXml
{
    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* XDocument xdoc = new XDocument();
             XElement iphone = new XElement("phone"); //первый элемент
             XAttribute attr = new XAttribute("name", "IPhone 6");
             XElement company = new XElement("Company", "Apple");
             XElement price = new XElement("Price", "40000");

             iphone.Add(attr);
             iphone.Add(company);
             iphone.Add(price);

             XElement samsung = new XElement("phone");
             XAttribute attrSam = new XAttribute("name", "Samsung Galaxy");
             XElement company2 = new XElement("Company", "Samsung");
             XElement priceSa2 = new XElement("Price", "30000");

             samsung.Add(attrSam);
             samsung.Add(company2);
             samsung.Add(priceSa2);

             XElement phones = new XElement("phones");
             phones.Add(iphone);
             phones.Add(samsung);
             xdoc.Add(phones);*/

            //вместо можно  так:
            XDocument xdoc = new XDocument(new XElement("phones",
                new XElement("phone",
                    new XAttribute("name", "IPhone 6"),
                    new XElement("Company", "Apple"),
                    new XElement("Price", "40000")),
                new XElement("phone",
                    new XAttribute("name", "Samsung Galaxy"),
                    new XElement("Company", "Samsung"),
                    new XElement("Price", "30000"))));

            xdoc.Save("Phone.xml");

           // ShowXml("Phone.xml");
            var lstPhone = ReadXml("Phone.xml");
            foreach(var phone in lstPhone)
            {
                Console.WriteLine($"{phone.Name}");
            }

            List<Person> persones = new List<Person>();
            persones.Add(
                new Person()
                {
                    Name = "Иванов",
                    Age = 45,
                    Comp = new Company
                    {
                        Name = "Шаг",
                        Address = "xcbhfhzf"
                    }
                });
            persones.Add(
                 new Person()
                 {
                     Name = "Петров",
                     Age = 34,
                     Comp = new Company
                     {
                         Name = "Шаг",
                         Address = "xcbhfhzf"
                     }
                 });


            Serialize("persons.xml", persones);
            var lstPerson = Deserialization("persons.xml");

        }

        static void Serialize(string path, List<Person> persons)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>)); //сериализуем
            using (var file = new FileStream("persons.xml", FileMode.Create))
            {
                formatter.Serialize(file, persons);
            }
        }

        static List<Person> Deserialization(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
            using (var reader = new FileStream("persons.xml", FileMode.Open))
            {
                var listPersons = (List<Person>)formatter.Deserialize(reader);
                return listPersons;
            }            

        }

        static void ShowXml(string path)
        {
            var xdoc = XDocument.Load(path); //загрузка файла
            foreach(var element in xdoc.Element("phones").Elements("phone"))
            {
                var attr = element.Attribute("name");
                var company = element.Element("Company");
                var price = element.Element("Price");

                Console.WriteLine($"Телефон: {attr.Value}\nКомпания: {company.Value}\nЦена: {price.Value}");
                Console.WriteLine();
            }
        }

        static List<Phone> ReadXml(string path)
        {
            var xdoc = XDocument.Load(path);

            var result = xdoc.Element("phones")
                .Elements("phone")
                .Where(el => el.Element("Company").Value == "Samsung")
                .Select(el => new Phone
                {
                    Name = el.Attribute("name").Value,
                    Company = el.Element("Company").Value,
                    Price = el.Element("Price").Value
                    //Price = double.Parse(el.Element("Price").Value)
                }).ToList();

            return result;
        }


    }
}
