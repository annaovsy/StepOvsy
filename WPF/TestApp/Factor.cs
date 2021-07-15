using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace TestApp
{
    public class FactorClass : INotifyPropertyChanged
    {
        private float _factor;
        private Point[] _pointsTransform = new Point[4];
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

        public Point[] PointsTransform
        {
            get { return _pointsTransform; }
            set
            {
                if (value.Length == _pointsTransform.Length)
                    _pointsTransform = value;
            }
        }
    }
}
