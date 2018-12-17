using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCAP.Models.Helpers
{
    public class HelperLogin
    {
        Connect c;
        public HelperLogin()
        {
            c = new Connect("TCAP");
        }

        private Boolean ValidateField(String field)
        {
            if (field is null)
            {
                return false;
            }
            return true;
        }

        public Boolean ValidateLogin(String email,String password)
        {
            if (ValidateField(email) && ValidateField(password))
            {
                User u = new User();
                u.Email = email;
                u.Password = password;
                if (Hashing.ValidatePassword(password,c.SelectUser("SELECTUSER",u)))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}