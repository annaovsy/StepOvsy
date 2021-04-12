using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    class RangeOfArray
    {
        private object[] _array;
        private int _size;
        private int _start;
        private int _end;

        public RangeOfArray(int start, int end)
        {
            _start = start;
            _end = end;
            _size = end - start + 1;
            _array = new object[_size];
        }

        public int Start
        {
            get { return _start; }
            set
            {
                _start = value;
            }
        }
        public int End
        {
            get { return _end; }
            set
            {
                _end = value;
            }
        }

        public object this[int i]
        {
            get
            {
                return _array[i - Start];
            }
            set
            {
                _array[i - Start] = value; 
            }
        }
    }
}
