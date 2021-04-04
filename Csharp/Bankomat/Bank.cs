using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientNamespase;
using AccountNamespase;

namespace BankNamespase
{
    class Bank
    {
        private readonly List<Client> _clients = new List<Client>();

        public void AddClient(Client client, string nameClient, string login, string passwd, double balanse)
        {
            try
            {
                var account = new Account()
                {
                    Balanse = balanse,
                    Login = login,
                    Pass = passwd,
                };
                var client = new Client()
                {
                    Name = nameClient,
                    Account = account,
                };
                _clients.Add(client);

                return client.Account.Number;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Add Client" + ex.Message);
            }
        }
            
        public bool CheckPasswrd(int numberAccount, string passwrd)
        {
            foreach(var client in _clients)
            {
                if (client.Number.Value == numberAccount && client.Account.Pass == passwrd)
                    return true;
            }          
            return false;
        }



    }
}
