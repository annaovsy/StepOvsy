using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudent
{
    class Student : IComparable<Student>, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard studentCard { get; set; }

        public object Clone()
        {
            Student temp = (Student)MemberwiseClone(); //поверхностное копирование для FirstName,LastName,BirthDate
            temp.studentCard = new StudentCard //для ссылочных типов глубокое копирование
            {
                Number = this.studentCard.Number,
                Series = this.studentCard.Series
            };
            return temp;
        }

        //public int CompareTo(object obj) //необобщенный интерфейс
        //{
        //    if(obj is Student)
        //    {
        //        return FirstName.CompareTo((obj as Student).FirstName);
        //    }
        //    throw new NotImplementedException();
        //}

        public int CompareTo(Student other) //обобщенный интерфейс!!!
        {
            return FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return $"Имя: {LastName} \nФамилия: {FirstName}\nДата рождения: {BirthDate.ToLongDateString()}\nСтуденческий билет: {studentCard}\n";
        }

    }
}
