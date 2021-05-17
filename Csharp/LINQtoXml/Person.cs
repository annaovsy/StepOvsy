using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoXml
{
    [Serializable] //аттрибут для сериализации
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Comp { get; set; }

        public Person() { } //обязательно для сериализации
    }

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Company() { }
    }

}
