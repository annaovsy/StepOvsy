using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Home
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Window> window;
        public Door door;
        public Roof roof;

        public void Output(TeamLeader teamLeader)
        {
            if (teamLeader.report.Count == 11)
            {
                string house = "\t*** Дом построен! ***";
                Console.WriteLine(house);
            }
            else Console.WriteLine("Дом еще не построен");
        }
    }
}
