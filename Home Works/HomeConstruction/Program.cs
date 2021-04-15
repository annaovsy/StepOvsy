using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            Team team = new Team();

            Console.WriteLine($"\t Бригада {team.Name}");

            Random rand = new Random();

            for (int i = 0; i <= 5; i++)
            {
                team.workers[rand.Next(0, 3)].Build(home, team.teamLeader);
            }
            foreach (var temp in team.teamLeader.report)
            {
                Console.WriteLine(temp);
            }
            team.teamLeader.Report();

            for (int i = 0; i <= 5; i++)
            {
                team.workers[rand.Next(0, 3)].Build(home, team.teamLeader);
            }
            foreach (var temp in team.teamLeader.report)
            {
                Console.WriteLine(temp);
            }
            team.teamLeader.Report();

            home.Output(team.teamLeader);
        }
    }
}
