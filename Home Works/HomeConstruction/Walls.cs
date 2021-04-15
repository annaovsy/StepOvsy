using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Walls : IPart
    {
        public void Create(Home home)
        {
            home.walls.Add(new Walls());
        }
    }
}
