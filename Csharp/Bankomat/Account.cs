using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNamespace
{
    class Account
    {
        private string _login;
        private string _pass;
        private double _balance;

        public Account()
        {
            Number = new Random().Next(100, 200);
        }

        public string Login
        {
            get { return _login; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    _login = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public string Pass
        {
            get { return _pass; }

            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 3)
                    _pass = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public int Number { get; }

        public double Balance
        {
            get { return _balance; }

            set
            {
                if (value <= 0)
                    throw new Exception("Wrong set balance");

                _balance = value;
            }
        }


    }
}
