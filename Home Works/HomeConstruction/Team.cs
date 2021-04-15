using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Team : IWorker
    {
        public string Name { get => "ДОНСТРОЙ"; }
        public TeamLeader teamLeader;
        public List<Worker> workers;

        public Team()
        {
            teamLeader = new TeamLeader("Петр");
            workers = new List<Worker>
            { 
                new Worker("Андрей"), 
                new Worker("Александр"), 
                new Worker("Олег"), 
                new Worker("Дмитрий")
            };
        }

    }
}
