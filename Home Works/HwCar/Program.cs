using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwCar
{
    class Program
    {
        class Car
        {
            private string brand;
            private string model;
            private int fuelConsumption;         //расход топлива
            private int engineVolume;            //объем двигателя
            private bool automaticTransmission = true;  //коробка передач
        }
        Car()
        {

        }

        static bool IsAutomat(ref bool automaticTransmission)
        {
            if (automaticTransmission == true)
                return automaticTransmission;
            else
                return false;
        }


        static void Main(string[] args)
        {
            Car car1;
            

        }
    }
}
