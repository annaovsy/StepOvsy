using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class TeamLeader : IWorker
    {
        public string Name { get; }
        public List<string> report = new List<string>();

        public TeamLeader(string name)
        {
            Name = name;
        }
        
        public void Report()
        {
            double d = (report.Count / 11.0) * 100;
            Console.WriteLine($"{(int)d} % дома построено!");
        }

    }
}
