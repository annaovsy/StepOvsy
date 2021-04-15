using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Roof : IPart
    {
        public void Create(Home home)
        {
            home.roof = new Roof();
        }
    }
}
