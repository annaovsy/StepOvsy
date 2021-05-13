using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    class Program
    {
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
                    Age = 28,
                    Languages = new List<string>{"английский","немецкий"}
               },
               new User
               {
                    Name = "Джон",
                    Age = 30,
                    Languages = new List<string>{"немецкий"}
               },
            };

            var resAge = users.Where(user => user.Age > 25).ToArray();

            foreach (var item in resAge)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

            Console.WriteLine($"****************************");

            var resLang = users.Where(user => user.Languages.Contains("английский"))
                .ToArray();

            foreach (var item in resLang)
            {
                Console.WriteLine($"Английский изучает {item.Name}");
            }

            Console.WriteLine($"****************************");

            var resDay = users.Select(user => new
            {
                user.Name,
                DayOfBirth = DateTime.Now.Year - user.Age
            }).ToArray();   //проекция с новым полем DayOfBirth

            foreach(var item in resDay)
            {
                Console.WriteLine($"{item.Name} {item.DayOfBirth}");
            }

            var resMax = users.Max(user => user.Age);
            var resMin = users.Min(user => user.Age);
            var resAver = users.Average(user => user.Age);

            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            var max = numbers.Max();
            var min = numbers.Min();
            var aver = numbers.Average();

            Console.WriteLine($"\n\tTeamPlayer");

            List<Team> teams = new List<Team>
            {
                new Team
                {
                    Name = "First",
                    Country = "Rus"
                },
                new Team
                {
                    Name = "Second",
                    Country = "France"
                }
            };

            List<Player> players1 = new List<Player>
            {
                new Player
                {
                    Name = "Tom",
                    Team = "First"
                },
                new Player
                {
                    Name = "Tim",
                    Team = "Second"
                },
                new Player
                {
                    Name = "Tomm",
                    Team = "First"
                }
            };

            var resTeamPlayer = players1.Join(teams, player => player.Team, team => team.Name,
                (pl, tm) =>
                new
                {
                    pl.Name,
                    pl.Team,
                    tm.Country

                }).ToList();

            foreach (var item in resTeamPlayer)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"****************************");
            var resGroup = resTeamPlayer.GroupBy(tmPl => tmPl.Team).Select(gr => new
            {
                nameTeam = gr.Key,
                CountPlayers = gr.Count()
            });

            foreach (var item in resGroup)
            {
                Console.WriteLine($"{item}");
            }




        }
    }
}
