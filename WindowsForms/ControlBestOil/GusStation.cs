using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBestOil
{
    public struct Oils
    {
        string name;
        double price;
        double quantity;
        double sum;
    }

    class GusStation
    {
        List<Oils> oils = new List<Oils>();
    }
}
