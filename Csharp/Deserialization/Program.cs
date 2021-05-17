using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClassLib;

namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstPC = Deserialization(@"C:\Users\Взрослая академия\source\repos\StepOvsy\Csharp\Serialization\bin\Debug\PC.xml");

            var res = lstPC.Where(pc => pc.SerialNumber == 111);
            var xdoc = XDocument.Load(@"C:\Users\Взрослая академия\source\repos\StepOvsy\Csharp\Serialization\bin\Debug\PC.xml");

            var resDoc = xdoc.Element("ArrayOfPC")
                .Elements("PC")
                .Where(pc => int.Parse(pc.Element("SerialNumber").Value) == 111);

        }

        static List<PC> Deserialization(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<PC>));
            using (var reader = new FileStream(path, FileMode.Open))
            {
                var lstPC = (List<PC>)formatter.Deserialize(reader);
                return lstPC;
            }

        }
    }
}
