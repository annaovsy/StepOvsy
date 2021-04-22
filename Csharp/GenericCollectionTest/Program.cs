using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionTest
{
    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            return other.LastName.CompareTo(LastName);
        }
    }

    class Program
    {
        static T MaxElement<T>(/*T[]*/IEnumerable<T> arr) where T : IComparable<T> //IEnumerable для того, чтобы можно было использовать и массивы и списки
        {
            T max = arr.First();

            foreach(var val in arr)
            {
                if (val.CompareTo(max) > 0) 
                {
                    max = val;
                }                
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 55, 7, 4 };
            int max = MaxElement(arr);
            Console.WriteLine($"max = {max}");
            double[] arrDouble = new double[] { 1.23, 2.55, 77, 95.45 };
            double maxD = MaxElement(arrDouble);
            Console.WriteLine($"max = {maxD}");
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    FirstName = "Иванов",
                    LastName = "Аван"
                },
                new Student
                {
                    FirstName = "Aтров",
                    LastName = "Бчвар"
                }
            };
            var MaxStud = MaxElement(students);
            Console.WriteLine($"{MaxStud.LastName} {MaxStud.FirstName}");
            
        }
    }
}
