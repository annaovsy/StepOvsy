using System;

namespace ClassLib
{
    public class PC
    {
        public string Brand{ get; set; }
        public int SerialNumber { get; set; }
        public string Model { get; set; }

        public PC() { }

        public void TurningOn()
        {
            Console.WriteLine("Включение");
        }
        public void Shutdown()
        {
            Console.WriteLine("Выключение");
        }
        public void Reboot()
        {
            Console.WriteLine("Перезагрузка");
        }

    }
}
