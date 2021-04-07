using AccountNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNamespace
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
                _account = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public int Number => _account.Number;

        public string Passwd => _account?.Pass;

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
