using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBestOil
{
    struct Products
    {
        string name;
        double price;
        double quantity;
    }
    class MiniCafe
    {
        List<Products> products = new List<Products>();
    }
}
