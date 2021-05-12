using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsTestLINQ
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public string Token { get; set; }

        public void Print()
        {
            Console.WriteLine($"Login = {Login}");

            Console.WriteLine($"Password = {Password}");

            Console.WriteLine($"Role = {Role}");

            Console.WriteLine($"Token = {Token}");
        }
    }
}
