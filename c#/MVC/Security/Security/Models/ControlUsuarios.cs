using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.Models
{
    public class ControlUsuarios
    {
        public String Role { get; set; }
        public Boolean ExisteUsuario(String usuario,String password)
        {
            if (usuario.ToUpper() == "ADMIN" && password.ToUpper() == "ADMIN") 
            {
                this.Role = "Administrador";
                return true;

            }else if (usuario.ToUpper() == "USER" && password.ToUpper() == "USER")
            {
                this.Role = "Usuario";
                return true;

            }

            return false;
        }
    }
}