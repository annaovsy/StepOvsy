using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director
            {
                LastName = "Иванов",
                FirstName = "Иван",
                BirthDate = new DateTime(1998, 10, 12),
                Position = "Директор",
                Salary = 12000
            };
            IWorker seller = new Seller
            {
                LastName = "Beam",
                FirstName = "Jim",
                BirthDate = new DateTime(1956, 5, 23),
                Position = "Продавец",
                Salary = 3780
            };

            director.ListOfWorkers = new List<IWorker> 
            {
                seller, 
                new Cashier 
                { 
                    LastName = "Smith",
                    FirstName = "Nicole",
                    BirthDate = new DateTime(1956, 5, 23),
                    Position = "Кассир", 
                    Salary = 3780 
                },
                new Storekeeper 
                { 
                    LastName = "Ross",
                    FirstName = "Bob",
                    BirthDate = new DateTime(1956, 5, 23),
                    Position = "Кладовщик",
                    Salary = 4500 
                }
            };

            Console.WriteLine(director);
            director.Control();

            foreach (IWorker workers in director.ListOfWorkers)
            {
                Console.WriteLine(workers);
                workers.Work();
            }
        }
    }
}
