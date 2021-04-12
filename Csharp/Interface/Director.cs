using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("Контролирую работу!");
        }
        public void MakeBudget()
        {
            Console.WriteLine("Формирую бюджет!");
        }
        public void Organize()
        {
            Console.WriteLine("Организую работу!");
        }
    }
}
