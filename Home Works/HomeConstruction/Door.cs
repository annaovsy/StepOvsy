﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Door : IPart
    {
        public void Create(Home home)
        {
            home.door = new Door();
        }
    }
}