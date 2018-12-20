using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using TCAP.Models;

namespace TCAP.Models.Helpers
{
    public class HelperAccount
    {

       
        //CAMBIAR TODO A LINQ Y SIN USAR PROCEDURES
        //REALIZAR AQUÍ LA VALIDACIÓN
        public HelperAccount()
        {

           
        }
        private String CreateToken()
        {
            int longitud = 12;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String key = "";
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                key += alfabeto[indice];
            }

            String token = Hashing.HashPassword(key);

            return token;
        }
        private Boolean ValidateField(String field)
        {
            if (field is null)
            {
                return false;
            }
            return true;
        }
        private Boolean ExistsEmail(String email)
        {
            int? linq = (from d in c.USERS
                       where d.EMAIL_USER == email
                       select d.ID_USER).FirtOrDefault();

            if (linq is null)
            {
                return true;
            }
            return false;
            
        }
        private void ValidateToken(String token) { }
        public Boolean Register(String user, String name, String surname, String email, String password)
        {
            if (ExistsEmail(email))
            {
                USERS u = new USERS();
                u.ID_ROL = user;
                u.NAME_USER = name;
                u.SURNAME_USER = surname;
                u.EMAIL_USER = email;
                u.PASSWORD_USER = Hashing.HashPassword(password);
                //insertar usuario

                TOKENS t = new TOKENS();
                t.ID_USER = u.ID_USER;
                t.VALUE_TOKEN = CreateToken();
                t.START_TOKEN = new DateTime();
                t.END_TOKEN = new DateTime(t.START_TOKEN).AddMinutes(15);
                //insertar token

                return true;
            }

            return false;
        }
        public void  Login(String email, String password)
        {
        }        
      
    }
}