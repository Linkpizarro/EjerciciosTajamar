using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using TCAP.Models;
using System.Text.RegularExpressions;

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
        private Boolean ValidateField(String field,String pattern)
        {
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(field))
            {
                return true;
            }
            return false;

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
        private void Register(String user, String name, String surname, String email, String password)
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

            SMTPService smtp = new SMTPService();
            smtp.SendEmail(u.EMAIL_USER, t.VALUE_TOKEN);
        }

        public Boolean ValidateRegister(String user, String name, String surname, String email, String password, ref String error)
        {
            if (user == "1" || user == "2")
            {
                if (ValidateField(name, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ/\s/a-zA-ZñÑáéíóúÁÉÍÓÚ]{2,45}$"))
                {
                    if (ValidateField(surname, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ/\s/a-zA-ZñÑáéíóúÁÉÍÓÚ]{2,45}$"))
                    {

                        if (ValidateField(email, @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"))
                        {

                            if (ValidateField(password, @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"))
                            {
                                if (ExistsEmail(email) == 0)
                                {
                                    Register(user, name, surname, email, password);
                                    return true;
                                }
                                else
                                {
                                    error = "El email ya existe.";
                                }
                            }
                            else
                            {
                                error = "La contraseña debe de contener :" +
                                    "una letra mayúscula," +
                                    "una letra minúcula," +
                                    "un dígito y " +
                                    "una longitud de entre 8 y 16 caracteres.";
                            }
                        }
                        else
                        {
                            error = "El email no es válido.";
                        }
                    }
                    else
                    {
                        error = "El apellido no es válido.";
                    }
                }
                else
                {
                    error = "El nombre no es válido.";
                }
            }
            else
            {
                error = "No se ha seleccionado el tipo de usuario.";
            }

            return false;

        }
        public USERS Confirm(String token,ref String error)
        {
            int id = ValidateToken(token);
            List<Object> result = new List<Object>();
            USERS u = new USERS();

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


            return u;

        }
        public Boolean ValidatePlayerConfirm(String token, String nickname, String age, String sex, String description,ref String error)
        {
            int id = (from data in c.TOKENS
                      where data.VALUE_TOKEN.Contains(token)
                      select data.ID_USER).FirstOrDefault();

            if (id != 0)
            {
                int nick = (from data in c.PLAYERS
                           where data.NICK_PLAYER == nickname
                           select data.ID_PLAYER).FirstOrDefault();
                if (nick == 0)
                {
                    if (ValidateField(nickname, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ/\s/a-zA-ZñÑáéíóúÁÉÍÓÚ]{2,16}$"))
                    {
                        if (int.Parse(age) >= 18 && int.Parse(age)<= 99)
                        {
                            if (sex == "F" || sex == "M")
                            {
                                PlayerConfirm(id,token,nickname,age,sex,description);
                                return true;
                            }
                            else
                            {
                                error = "El sexo no es válido.";
                            }
                        }
                        else
                        {
                            error = "La edad no es válida.";
                        }
                    }
                    else
                    {
                        error = "El nickname no es válido.";
                    }
                }
                else
                {
                    error = "El nickname ya existe.";
                }
            }
            else
            {
                error = "Se ha producido un error.";
            }

            return false;
        }
        private void PlayerConfirm(int id,String token,String nickname, String age, String sex, String description)
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
        }

        public Boolean ValidateClientConfirm(String token, String dni, String telephone, String mobile,ref String error)
        {
            int id = (from data in c.TOKENS
                      where data.VALUE_TOKEN.Contains(token)
                      select data.ID_USER).FirstOrDefault();

            if (id != 0)
            {
                if (ValidateField(dni, @"^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$"))
                {
                    if (ValidateField(telephone, @"^$"))
                    {
                        if (ValidateField(mobile, @"^$"))
                        {

                        }
                        else
                        {
                            error = "El número de movil no es válido.";
                        }
                    }
                    else
                    {
                        error = "El número de teléfono no es válido.";
                    }
                }
                else
                {
                    error = "El DNI es incorrecto.";
                }
            }
            else
            {
                error = "Se ha producido un error.";
            }

            return false;
        }
        private void ClientConfirm(int id,String token, String dni, String telephone, String mobile)
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

            CLIENTS x = new CLIENTS()
            {
                ID_USER = id,
                DNI_CLIENT = dni,
                TELEPHONE_CLIENT = telephone,
                MOBILE_CLIENT = mobile
            };

            c.CLIENTS.Add(x);
            c.SaveChanges();
        }
        public USERS Login(String email, String password,ref String error){

            List<Object> result = new List<Object>();
            USERS u = null;

            if (ValidateField(email,@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"))
            {
                int id = ExistsEmail(email);
                if (id != 0)
                {
                    USERS linq = (from data in c.USERS
                                  where data.ID_USER == id
                                  && data.STATUS_USER == 2
                                  select data).FirstOrDefault();

                    if (!(linq is null))
                    {
                        if (Hashing.ValidatePassword(password, linq.PASSWORD_USER))
                        {
                            u = linq;
                            u.TOKEN_SESSION = CreateToken();
                            c.SaveChanges();
                            return u;
                        }
                    }        
                }
            }

            error = "Email o Contraseña incorrectos.";
            return u;
        }

    }
}