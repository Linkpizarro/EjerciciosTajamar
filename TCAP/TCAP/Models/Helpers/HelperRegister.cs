using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCAP.Models
{
    public class HelperRegister
    {
        Connect c;
        public HelperRegister()
        {
            c = new Connect("TCAP");
        }

        public void InsertUser(String user, String name, String surname, String email, String password,
            String country, String cp_zip)
        {
            User u = new User();
            u.Rol = int.Parse(user);
            u.Name = name;
            u.Surname = surname;
            u.Email = email;
            u.Password = Hashing.HashPassword(password);
            u.Country = country;
            u.CpZip = cp_zip;
            c.InsertUser("INSERTUSER", u);
        }
    }
}