using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class RangeOfArray
    {
        private int subscript;
        private int superscript;
        private int[] arr;
        private int size; 

        public RangeOfArray(int _subscript, int _superscript)
        {
            subscript = _subscript;
            superscript = _superscript;
        }
        public int GetSize()
        {
            size = superscript - subscript;
            return size;
        }
        //public RangeOfArray this[int indx]
        //{
        //    get
        //    {
        //        for (int i = subscript; i <= superscript; i++) 
        //        {
        //            return arr[i];
        //        }
        //        if (indx >= 0 && indx < laptops.Length)
        //        {
        //            return laptops[indx];
        //        }
        //        throw new IndexOutOfRangeException();
        //    }
        //    set
        //    {
        //        laptops[indx] = value;
        //    }
        //}

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
