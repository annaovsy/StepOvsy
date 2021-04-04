using AccountNamespase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNamespase
{
    class Client
    {
        private string _name;

        private Account _account;

        public Account Account
        {
            get { return _account; }

            set
            {
                _account = value ?? throw new ArgumentNullException(nameof(_account));
            }
        }

        public int? Number => Account?.Number;

        public string Name
        {
            get { return _name; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }


    }
}
