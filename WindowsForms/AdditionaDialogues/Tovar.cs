using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionaDialogues
{
    public class Tovar
    {
        private double _price;
        public string Name { get; set; } = "unknown";
        public string Madein { get; set; } = "unknown";
        public double Price 
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new Exception("Цена не может быть меньше нуля!");
                _price = value;
            }
        }

        public override string ToString()
        {
            return Name + " Изготовитель: " + Madein + " Цена: " + Price;
        }

    }
}
