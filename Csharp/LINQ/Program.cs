using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Languages { get; set; }
            public User()
            {
                Languages = new List<string>();
            }
        }

        static void Main(string[] args)
        {
           List<User> users = new List<User>
           {
               new User
               {
                    Name = "Том",
                    Age = 23,
                    Languages = new List<string>{"английский","немецкий"}
               },
               new User
               {
                    Name = "Джек",
                    Age = 25,
                    Languages = new List<string>{"английский","немецкий"}
               },
               new User
               {
                    Name = "Джон",
                    Age = 23,
                    Languages = new List<string>{"немецкий"}
               },
           };

            var resUser = (from us in users
                          where us.Age < 26 && us.Languages.Contains("английский")
                          select us).ToList();
            foreach(var item in resUser)
            {
                Console.WriteLine($"{item.Name}, {item.Languages.Contains("английский")}");
            }

            Console.WriteLine("\n******************************");

            var resUser2 = from us in users
                           select new
                           {
                               us.Name,
                               DateOfBirth = DateTime.Now.Year - us.Age,                                
                           };

            foreach (var item in resUser2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n******************************");






            int[] arrayInt = { 5, 34, 67, 12, 94, 42, 102, 88 };

            //IEnumerable<int> result = from i in arrayInt   //отложенное выполнение запроса
            //                          where i % 2 == 0
            //                          orderby i descending
            //                          select i;

            var result = arrayInt.Where(val => val % 2 == 0).OrderByDescending(val => val); //тожесамое

            //IEnumerable<int> result2 = (from i in arrayInt   //запрос выполняется сразу
            //                          select i).ToList();

            foreach (int n in result)
            {
                Console.Write(" {0}", n);
            }
            Console.WriteLine();

            arrayInt[0] = 100;
            foreach (int n in result) //запрос выполняется в момент foreach
            {
                Console.Write(" {0}", n);
            }
            Console.WriteLine();
            Console.WriteLine("\n******************************");
            //IEnumerable<IGrouping<int, int>> query = from i in arrayInt
            //                                          group i by i % 10; //групировать по последней цифре каждого числа

            //но лучше написать через var!!!
            var query = from i in arrayInt
                        group i by i % 10 into res //групировать по последней цифре каждого числа
                        where res.Count() > 1      //где в группе больше 1 числа
                        select res;

            foreach (var group in query)
            {
                Console.WriteLine($"group key : {group.Key}"); //Key в данном случае i % 10
                foreach (var item in group)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************************");

            string[] poem = {"All the world's a stage,", 
                            "And all the men and women" +
                            " merely players; ", "They have" +
                            " their exits and their" +
                            " entrances,", "And one man in" +
                            " his time plays many parts,",
                            "His acts being seven ages…"};

            var queryPoem = from p in poem
                            let words = p.Split(' ', ';', ',') // делим на слова
                            from w in words
                            where w.Count() > 5   //слова в которых больше 5 букв
                            select w;        


            foreach(var item in queryPoem)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine("\n******************************");

            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var teamsB = teams.Where(str => str.StartsWith("Б")).ToArray();

            //var teamsB = from team in teams
            //               where team.StartsWith("Б")
            //               select team;
            
            foreach (var item in teamsB)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine("\n******************************");

            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            var resNumbers = numbers.Where(num => num % 2 == 0 && num > 10).ToArray();

            //var resNumbers = from num in numbers
            //                 where num % 2 == 0 && num > 10
            //                 select num;

            foreach (var item in resNumbers)
            {
                Console.WriteLine(" " + item);
            }




        }
    }
}
