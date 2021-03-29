using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex
    {
        private int val;

        public int Num  //это СВОЙСТВО. вместо сеттеров и геттеров
        {
            get { return val; }

            set 
            {
                if (value >= 0 && value <= 100)
                    val = value; 
            }
        }

       // public int Numm => val; //Свойство только для чтения (только get) 

        public void SetSize(int _val)
        {
            val = _val;
        }
        public int GetVal()
        {
            return val;
        }
    }
}
