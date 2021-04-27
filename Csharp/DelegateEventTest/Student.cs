using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventTest
{
    class Student : IPropertyChanged
    {
        private string _name;
        private double _mark;
        private string _group;
        public string Name 
        { 
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
            get
            {
                return _name;
            }
        }
        public double Mark 
        { 
            set
            {
                _mark = value;
                OnPropertyChanged(nameof(Mark));
            }                
            get 
            { 
                return _mark;
            } 
        }
        public string Group 
        { 
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
            get
            {
                return _group;
            }
        }
       
        public event PropertyeventHendler PropertyChanged;

        private void OnPropertyChanged(string name)  //генерация события
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs() { Name = name });
        }
    }
}
