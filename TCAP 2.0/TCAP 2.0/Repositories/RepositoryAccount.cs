using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Repositories
{
    public class RepositoryAccount : IRepositoryAccount
    {
        TCAPContext context;
        public RepositoryAccount(TCAPContext context)
        {
            this.context = context;
        }

        //Se encarga de introducir a un nuevo usuario en la Base de datos.
        public void Register(User user)
        {
            //***Aqui una clase que valide el usuario que entra***

            //Si no hay errores:
            //aqui se inserta el usuario en la base de datos.
            user.Created_User = DateTime.Now;
            user.Updated_User = DateTime.Now;
            user.Status_User = 1;
            user.Session_User = null;

            context.Users.Add(user);
            context.SaveChanges();

        }
    }
}