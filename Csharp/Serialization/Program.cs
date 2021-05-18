using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ClassLib;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> lstPC = new List<PC>();
            lstPC.Add(
                new PC()
                {
                    Brand = "brand1",
                    Model = "model1",
                    SerialNumber = 111
                });
            lstPC.Add(
                new PC()
                {
                    Brand = "brand2",
                    Model = "model2",
                    SerialNumber = 222
                });

            Serialize("PC.xml", lstPC);

        }

        static void Serialize(string path, List<PC> pCs)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<PC>)); //сериализуем
            using (var file = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(file, pCs);
            }
        }
    }
}
