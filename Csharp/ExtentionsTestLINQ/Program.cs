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
                Login = "operator",
                Password = "123",
                Role = "admin",
                Token = "fxg"
            };

            var user = user1.WithoutPassword();



        }
    }
}
