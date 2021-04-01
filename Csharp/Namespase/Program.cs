using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExample;
//using Example; //если подключить будет конфликтовать, тогда объявляем через точку 
                 //для этого пространства имен 

namespace Namespase
{
    class Program
    {
        //class Student
        //{
        //    //private string _surname;
        //   // private string _name;
        //  // private string _patronymic;
        //    //private string _group;
        //   // private int _age;
        //    //private int[] _programming;
        //    //private int[] _administation;
        //    //private int[] _design;

        //    public string Surname { get; set; }
        //    public string Name { get; set; }
        //    public string Patronymic { get; set; }
        //    public string Group { get; set; }
        //    public string Age { get; set; }


        //}

        static void Main(string[] args)
        {
            Increment test = new Increment(5);
            test.MyIncrement();
            Example.Increment test2 = new Example.Increment(10);
            test2.MyIncrement();
            //Student student1 = new Student();
            //student1.Surname = "Иванов";
            //student1.Name = "Иван";
            //student1.Patronymic = "Иванович";
            //Console.WriteLine(student1);

        }
    }
}
