using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Increment
    {
        private int _count;

        public Increment(int count)
        {
            _count = count;
        }

        public int MyIncrement()
        {
            Console.WriteLine("MyIncrement from Namespase");
            for (var i = 0; i < 5; i++)
                _count += 10;

            return _count;
        }       

    }
}
