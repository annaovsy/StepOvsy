using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwCar
{
    public partial class Car
    {
        private string _brand;
        private string _model;
        private int _fuelConsumption;         //расход топлива
        private int _engineVolume;            //объем двигателя
        private static bool _automaticTransmission = true;  //коробка передач
        public static int _price;

        public Car() { }
        public Car(string brand, string model, int price = 10000)
        {
            _brand = brand;
            _model = model;
        }
        public Car(string brand, string model, int fuelConsumption, int engineVolume, bool automaticTransmission, int price)
        {
            _brand = brand;
            _model = model;
            _fuelConsumption = fuelConsumption;
            _engineVolume = engineVolume;
            _automaticTransmission = automaticTransmission;
            _price = price;
        }
        static Car()
        {
            _price = 20000;
        }

        public void Print()
        {
            Console.WriteLine($"Марка: {_brand}");
            Console.WriteLine($"Модель: {_model}");
            Console.WriteLine($"Расход топлива: {_fuelConsumption}");
            Console.WriteLine($"Объем двигателя: {_engineVolume}");
            Console.WriteLine($"Автоматическая коробка передач: {_automaticTransmission}");
            Console.WriteLine($"Цена: {_price}");
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car("Audi", "Q5", 10, 3, true, 25000),
                new Car("Mercedes-Benz", "SLC", 10, 3, false, 25000),
                new Car("BMW", "X5", 10, 5, true, 15000),
                new Car("Citroen", "C4", 15, 3, true, 25000),
                new Car("Skoda", "Fabia", 16, 4, true, 15000),
            };
            for (int i = 0; i < cars.Length; i++) 
            {
                cars[i].Print();
                cars[i].PrintPartial();
                Console.WriteLine();
            }
        }
    }
}
