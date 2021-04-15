using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{

    interface IWorker
    {
        string Name { get; }
    }
    interface IPart
    {
        void Do(House house);
    }

    class Basement : IPart
    {
        public void Do(House house)
        {
            house.basement = new Basement();
        }
    }

    class Walls : IPart
    {
        public void Do(House house)
        {
            house.walls.Add(new Walls());
        }
    }

    class Door : IPart
    {
        public void Do(House house)
        {
            house.door = new Door();
        }
    }

    class Window : IPart
    {
        public void Do(House house)
        {
            house.window.Add(new Window());
        }
    }

    class Roof : IPart
    {
        public void Do(House house)
        {
            house.roof = new Roof();
        }
    }

    class House
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Window> window;
        public Door door;
        public Roof roof;

        public void Paint(TeamLeader t)
        {
            if (t.report.Count == 11)
            {

                string domik = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

                Console.WriteLine(domik);
            }
            else Console.WriteLine("The house is not built yet");
        }
    }

    class Team : IWorker
    {
        public TeamLeader t;
        public List<Worker> w;
        public string Name { get => "КриворожБудСТрой"; }

        public Team()
        {
            t = new TeamLeader("Sebastian");
            w = new List<Worker> { new Worker("Lucas"), new Worker("Petr"), new Worker("Alvaro"), new Worker("Christian") };
        }


    }

    class Worker : IWorker
    {
        string Name { get; set; }

        string IWorker.Name => Name;

        public Worker(string name)
        { Name = name; }

        public void Build(House house, TeamLeader t)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Do(house);
                t.report.Add($"Worker {Name} builded is basement!");
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null) house.walls = new List<Walls>();
                Walls wall = new Walls();
                wall.Do(house);
                t.report.Add($"Worker {Name} builded is wall {house.walls.Count}!");
            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.Do(house);
                t.report.Add($"Worker {Name} builded is door!");

            }

            else if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null) house.window = new List<Window>();
                Window window = new Window();
                window.Do(house);
                t.report.Add($"Worker {Name} builded is window {house.window.Count}!");
                 
            }

            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.Do(house);
                t.report.Add($"Worker {Name} builded is roof!");

            }

        }
    }

    class TeamLeader : IWorker
    {
        string Name { get; set; }
        public List<string> report = new List<string>();
        string IWorker.Name => Name;

        public TeamLeader(string name)
        { Name = name; }
        public void Report()
        {
            double d = (report.Count / 11.0) * 100;
            Console.WriteLine($"{(int)d} % of work completed!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();

            Console.WriteLine(team.Name);

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }

            foreach (var a in team.t.report)
            {
                Console.WriteLine(a);
            }

            team.t.Report();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }

            foreach (var a in team.t.report)
            {
                Console.WriteLine(a);
            }
            team.t.Report();

            house.Paint(team.t);
            Console.ReadKey();
        }
    }
}
