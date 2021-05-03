using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventTest2
{
    public class PropertyEventArgs : EventArgs
    {
        public string Name { get; set; }
    }

    public delegate void PropertyeventHendler(object sender, PropertyEventArgs e);

    interface IPropertyChanged
    {
        event PropertyeventHendler PropertyChanged;
    }
}
