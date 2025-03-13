using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
   public class LoginValidator
    {
        public static bool ValidateLoginData(object userObject)
        {
            User user= (User)userObject;
            if (user.Username == "admin" && user.Password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
