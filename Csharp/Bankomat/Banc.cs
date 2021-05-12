using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountNamespace;
using ClientNamespace;

namespace BankNamespace
{
    class Banc
    {
        private readonly List<Client> _clients = new List<Client>();

        public int AddClient(string nameClient, string login, string passwd, double balance)
        {
            try
            {
                var account = new Account()
                {
                    Balance = balance,
                    Login = login,
                    Pass = passwd
                };
                var client = new Client()
                {
                    Name = nameClient,
                    Account = account
                };

                _clients.Add(client);

                return client.Account.Number;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error AddClient " + ex.Message);
                return 0;
            }
        }

        public bool CheckPasswd(int numberAccout, string passwd)
        {
            foreach (var client in _clients)
            {
                if (client.Number == numberAccout && client.Passwd == passwd)
                    return true;
            }
            return false;
        }

        public void PrintBalance()
        {
            foreach (var client in _clients)
            {
                Console.WriteLine(client.Account.Balance);
            }
        }

        public void Refill(double refill)
        {
            foreach (var client in _clients)
            {
                client.Account.Balance += refill;
                Console.WriteLine("Операция выполнена успешно!");
            }
        }

        public void WithdrawMoney(double money)
        {
            foreach (var client in _clients)
            {
                if(client.Account.Balance < money)
                {
                    Console.WriteLine("Недостаточно средств!");
                    break;
                }
                else
                {
                    client.Account.Balance -= money;
                    Console.WriteLine("Операция выполнена успешно!");
                }
                  
            }
        }
    }
}
