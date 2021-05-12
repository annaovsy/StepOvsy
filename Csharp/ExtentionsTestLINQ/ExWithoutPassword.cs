using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsTestLINQ
{
    static class ExWithoutPassword
    {
        public static User WithoutPassword(this User user)
        {
            User temp = new User();
            temp.Password = null;
            temp.Login = user.Login;
            temp.Role = user.Role;
            temp.Token = user.Token;            

            return temp;
        }

    }
}
