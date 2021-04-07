using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    class Shop
    {
        Laptop[] laptops;

        public Shop(int size)
        {
            laptops = new Laptop[size];
        }

        public int Length => laptops.Length;
        
        public Laptop this[int indx]
        {
            get
            {
                if (indx >= 0 && indx < laptops.Length) 
                {
                    return laptops[indx];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptops[indx] = value;
            }
        }
        public Laptop this[string name]
        {
            get
            {
                for(int i = 0; i < laptops.Length; i++)
                {
                    if (name == laptops[i].Vendor)
                        return laptops[i];
                }
                throw new Exception("Laptop not found");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop(5);
            myShop[0] = new Laptop
            {
                Price = 30000,
                Vendor = "HP"
            };
            myShop[1] = new Laptop
            {
                Price = 45000,
                Vendor = "Samsung"
            };
            myShop[2] = new Laptop
            {
                Price = 50000,
                Vendor = "Asus"
            };
            for (int i = 0; i < myShop.Length; i++) 
            {
                Console.WriteLine(myShop[i]);
            }
            Console.WriteLine(myShop["Asus"]);
        }
    }
}
