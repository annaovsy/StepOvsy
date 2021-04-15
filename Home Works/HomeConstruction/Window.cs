using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Window : IPart
    {
        public void Create(Home home)
        {
            home.window.Add(new Window());
        }
    }
}
