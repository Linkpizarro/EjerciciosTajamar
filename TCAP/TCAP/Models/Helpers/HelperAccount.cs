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
        TcapContext c;
        public HelperAccount()
        {
            c = new TcapContext();
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
        private int ExistsEmail(String email)
        {
            int linq = (from d in c.USERS
                       where d.EMAIL_USER == email
                       select d.ID_USER).FirstOrDefault();

            if (linq == 0)
            {
                return 0;
            }

            return linq;
            
        }
        private int ValidateToken(String token) {

            var exists = (from data in c.TOKENS
                        where data.VALUE_TOKEN.Contains(token)
                        select data.ID_USER).FirstOrDefault();

            if(exists != 0)
            {
                var time = (from data in c.TOKENS
                            where data.ID_USER == exists
                            && data.END_TOKEN > DateTime.Now
                            select data.ID_USER).FirstOrDefault();

                if (time != 0)
                {
                    return time;
                }

                return -1;
            }

            return 0;
        }
        public Boolean Register(String user, String name, String surname, String email, String password)
        {
            if (ExistsEmail(email) == 0)
            {
                USERS u = new USERS();
                u.ID_ROL = int.Parse(user);
                u.NAME_USER = name;
                u.SURNAME_USER = surname;
                u.EMAIL_USER = email;
                u.PASSWORD_USER = Hashing.HashPassword(password);
                u.IMAGE_USER = null;
                u.CREATED_USER = DateTime.Now;
                u.UPDATED_USER = DateTime.Now;
                u.STATUS_USER = 1;

                c.USERS.Add(u);
                c.SaveChanges();

                TOKENS t = new TOKENS();
                t.ID_USER = u.ID_USER;
                t.VALUE_TOKEN = CreateToken();
                t.START_TOKEN = DateTime.Now;
                t.END_TOKEN = t.START_TOKEN.AddMinutes(15);

                c.TOKENS.Add(t);
                c.SaveChanges();

                //envio de email aqui.

                return true;
            }

            return false;
        }
        public List<Object> Confirm(String token)
        {
            int id = ValidateToken(token);
            List<Object> result = new List<Object>();
            USERS u = new USERS();
            String error = null;

            if (id == 0)
            {
                error = "El enlace No existe.";
                u = null;
            }
            else if (id == -1)
            {
                error = "El enlace ha caducado.";
                u = null;
            }
            else
            {
                USERS linq = (from data in c.USERS
                            where data.ID_USER == id
                            && data.STATUS_USER == 1
                            select data).First();
                u = linq;
            }

            result.Add(u);
            result.Add(error);
            return result;

        }
        public Boolean ConfirmConfirm(String token,String nickname, String age, String sex, String description)
        {
            int id = (from data in c.TOKENS
                     where data.VALUE_TOKEN.Contains(token)
                     select data.ID_USER).FirstOrDefault();

            if (id != 0)
            {
                TOKENS t = (from data in c.TOKENS
                            where data.VALUE_TOKEN.Contains(token)
                            select data).FirstOrDefault();

                c.TOKENS.Remove(t);
                c.SaveChanges();

                USERS u = (from data in c.USERS
                           where data.ID_USER == id
                           select data).FirstOrDefault();

                u.STATUS_USER = 2;
                c.SaveChanges();

                PLAYERS p = new PLAYERS()
                {
                    ID_USER = id,
                    NICK_PLAYER = nickname,
                    AGE_PLAYER = int.Parse(age),
                    SEX_PLAYER = sex,
                    DESCRIPTION_PLAYER = description,
                    PP_PLAYER = 0,
                    NP_PLAYER = 0,
                    SEALS_PLAYER = 0,
                    LEVEL_PLAYER = 1
                };

                c.PLAYERS.Add(p);
                c.SaveChanges();

  

 

                return true;
            }

            return false;
        }
        public List<Object> Login(String email, String password){

            int id = ExistsEmail(email);
            List<Object> result = new List<Object>();
            USERS u = new USERS();
            String error = null;

            if (id != 0)
            {
                USERS linq = (from data in c.USERS
                             where data.ID_USER == id
                             && data.STATUS_USER == 2
                             select data).FirstOrDefault();

                if(!(linq is null))
                {
                    if (Hashing.ValidatePassword(password, linq.PASSWORD_USER))
                    {
                        u = linq;
                    }
                    else
                    {
                        error = "Email o Contraseña incorrectos.";
                        u = null;
                    }
                }
                else
                {
                    error = "Email o Contraseña incorrectos.";
                    u = null;
                }

            }
            else
            {
                error = "Email o Contraseña incorrectos.";
                u = null;
            }

           result.Add(u);
           result.Add(error);

           return result;
        }

    }
}