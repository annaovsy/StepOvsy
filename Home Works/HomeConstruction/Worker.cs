using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Worker : IWorker
    {
        public string Name { get; }

        public Worker(string name)
        {
            Name = name;
        }

        public void Build(Home home, TeamLeader teamLeader)
        {
            if(home.basement == null)
            {
                Basement basement = new Basement();
                basement.Create(home);
                teamLeader.report.Add($"Рабочий {Name} построил фундамент!");               
            }
            else if(home.walls == null || home.walls.Count < 4)
            {
                if (home.walls == null)
                    home.walls = new List<Walls>();

                Walls wall = new Walls();
                wall.Create(home);
                teamLeader.report.Add($"Рабочий {Name} построил стену {home.walls.Count}!");
            }
            else if (home.door == null)
            {
                Door door = new Door();
                door.Create(home);
                teamLeader.report.Add($"Рабочий {Name} построил дверь!");
            }
            else if (home.window == null || home.window.Count < 4)
            {
                if (home.window == null)
                    home.window = new List<Window>();

                Window window = new Window();
                window.Create(home);
                teamLeader.report.Add($"Рабочий {Name} построил окно {home.window.Count}!");
            }
            else if (home.roof == null)
            {
                Roof roof = new Roof();
                roof.Create(home);
                teamLeader.report.Add($"Рабочий {Name} построил крышу!");
            }
        }
    }
}
