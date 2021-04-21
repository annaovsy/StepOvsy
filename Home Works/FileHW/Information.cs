using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHW
{
    class Information
    {
        public double[,] arrayDouble;
        //public int[,] arrayInt;
        public int numberOfLines;
        public int numberOfСolumns;
        public string surname;
        public string name;
        public DateTime birthday;

        public Information(/*double[,] arrayDouble, int[,] arrayInt,*/ int numberOfLines, int numberOfСolumns, string surname, string name, DateTime birthday)
        {
            Random rand = new Random();
            this.numberOfLines = numberOfLines;
            this.numberOfСolumns = numberOfСolumns;
            arrayDouble = new double[numberOfLines, numberOfСolumns];
            for (int i = 0; i < numberOfLines; i++) 
            {
                for (int j = 0; j < numberOfСolumns; j++)
                {
                    arrayDouble[i, j] = rand.NextDouble();
                }                
            }
            this.surname = surname;
            this.name = name;
            this.birthday = new DateTime();
        }

        public void Print()
        {

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfСolumns; j++)
                {
                    Console.Write($"{i} {j}");
                }
                Console.WriteLine();
            }
           
        }

    }
}
