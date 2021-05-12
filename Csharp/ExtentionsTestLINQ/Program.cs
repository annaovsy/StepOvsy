using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsTestLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User
            {
                Login = "operator1",
                Password = "123",
                Role = "admin",
                Token = "fxg"
            };
            User user2 = new User
            {
                Login = "operator2",
                Password = "123",
                Role = "admin",
                Token = "fxg"
            };
            User user3 = new User
            {
                Login = "operator3",
                Password = "123",
                Role = "admin",
                Token = "fxg"
            };

            List<User> users = new List<User>()
            {
                user1,
                user2,
                user3
            };

            var user = user1.WithoutPassword();
           // user.Print();

            var copyUsers = users.WithoutPasswords().ToList();


        }
    }
}
