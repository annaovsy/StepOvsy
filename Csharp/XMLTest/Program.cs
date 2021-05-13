using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLTest
{
    class Program
    {
        static void Main(string[] args)
        {
           /* using (XmlTextWriter writer = new XmlTextWriter("Cars.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented; //форматирование
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars");
                writer.WriteStartElement("Car");
                writer.WriteAttributeString("Image", "MyCar.jpeg");
                writer.WriteElementString("Manufactured", "dgfzksgnld");
                writer.WriteElementString("Model", "Alfonso");
                writer.WriteElementString("Color", "Black");
                writer.WriteElementString("Year", "1912");
                writer.WriteElementString("Speed", "130");
                writer.WriteEndElement();
                writer.WriteEndElement();
            }*/

            XmlDocument doc = new XmlDocument();
            doc.Load("Cars.xml");
            // OutputNode(doc.DocumentElement);
            var listCars = RoadFromXML("Cars.xml");
        }

        static void OutputNode(XmlNode node)
        {
            Console.WriteLine($"NodeType = {node.NodeType}, \tName = {node.Name}," +
                $"  \tValue = {node.Value}");

            if (node.Attributes != null)
            {
                foreach(XmlAttribute attr in node.Attributes) //здесь именно НЕ var
                {
                    Console.WriteLine($"Type = {attr.NodeType},  \tName = {attr.Name}," +
                   $" \t Value = {attr.Value}");
                }
            }

            if(node.HasChildNodes)
            {
                foreach(XmlNode child in node.ChildNodes)
                {
                    OutputNode(child);
                }
            }
        }

        static List<Car> RoadFromXML(string path)
        {
            var listCar = new List<Car>();

            XmlDocument doc = new XmlDocument();
            doc.Load("Cars.xml");
            XmlNode root = doc.DocumentElement;

            if (!root.HasChildNodes)
                throw new Exception("Error Wrong Xml File");

            foreach (XmlNode carNode in root.ChildNodes)
            {
                if (carNode.Attributes.Count != 1)
                    throw new Exception("Error Wrong Xml File.Wrong attributes");

                var car = new Car();
                car.Image = carNode.Attributes["Image"].Value;
                foreach (XmlNode child in carNode.ChildNodes)
                {
                    if (child.Name == "Manufactured")
                        car.Manufactured = child.FirstChild.Value;

                    else if (child.Name == "Model")
                        car.Model = child.FirstChild.Value;

                    else if (child.Name == "Year")
                        car.Year = int.Parse(child.FirstChild.Value);

                    else if (child.Name == "Color")
                        car.Color = child.FirstChild.Value;

                    else if (child.Name == "Speed")
                        car.Speed = double.Parse(child.FirstChild.Value);

                }
                listCar.Add(car);
            }
           
            
            return listCar;

        }
    }
}
