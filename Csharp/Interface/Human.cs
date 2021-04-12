using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"\nФамилия: { LastName} Имя: { FirstName} Дата рождения: { BirthDate.ToLongDateString()}";
        }
    }
}
