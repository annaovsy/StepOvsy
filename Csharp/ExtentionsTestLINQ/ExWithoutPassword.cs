using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsTestLINQ
{
    static class ExWithoutPassword
    {
        public static User WithoutPassword(this User user) //метод расширения
        {
            return new User
            {
                Password = null,
                Login = user.Login,
                Role = user.Role,
                Token = user.Token
            };
        }

        public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(user => user.WithoutPassword()); 

            //var res = from user in users
            //          select user.WithoutPassword();
            //return res;
        }

    }
}
