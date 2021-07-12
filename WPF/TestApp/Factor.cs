using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestApp
{
    public class FactorClass : INotifyPropertyChanged
    {
        private float _factor;

        public float FactorTest
        {
            get { return _factor; }
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(FactorTest));                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
