using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models;
using TCAP_2._0.Models.Class;
using TCAP_2._0.Models.Tools;

namespace TCAP_2._0.Repositories
{
    public class RepositoryAccount : IRepositoryAccount
    {
        TCAPContext context;
        public RepositoryAccount(TCAPContext context)
        {
            this.context = context;
        }

        //Comprueba si el email existe en la base de datos.
        private Boolean ExistsEmail(String email)
        {
            int linq = (from d in context.Users
                        where d.Email_User == email
                        select d.Id_User).FirstOrDefault();

            if (linq == 0)
            {
                return false;
            }
            return true;
        }
        //Comprueba si el nick existe en la base de datos.
        private Boolean ExistsNick(String nick)
        {
            int linq = (from d in context.Players
                        where d.Nick_Player == nick
                        select d.Id_User).FirstOrDefault();

            if (linq == 0)
            {
                return false;
            }
            return true;
        }
        //Comprueba si el DNI existe en la base de datos.
        private Boolean ExistsDNI(String dni)
        {
            int linq = (from d in context.Clients
                        where d.DNI_Client == dni
                        select d.Id_User).FirstOrDefault();

            if (linq == 0)
            {
                return false;
            }
            return true;
        }
        //Se encarga de validar el Token de confirmación.
        private int ValidateToken(String token)
        {

            var exists = (from data in context.Tokens
                          where data.Value_Token.Contains(token)
                          select data.Id_User).FirstOrDefault();

            if (exists != 0)
            {
                var time = (from data in context.Tokens
                            where data.Id_User == exists
                            && data.End_Token > DateTime.Now
                            select data.Id_User).FirstOrDefault();

                if (time != 0)
                {
                    return time;
                }

                return -1;
            }

            return 0;
        }
        //Genera un token aleatorio.
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

        private Boolean ValidatePassword(String pass)
        {
            Regex r = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])([A-Za-z\d$@$!%*?&]|[^ ]){8,15}$");
            if (r.IsMatch(pass))
            {
                return true;
            }
            return false;
        }
        private Boolean EqualPassword(String pass,String repPass)
        {
            if (pass == repPass)
            {
                return true;
            }
            return false;
        }

        //Se encarga de introducir a un nuevo usuario en la Base de datos.
        public Boolean Register(User user,String pass,String repPass,HttpPostedFileBase file,ref String error)
        {
            //Valida la existencia del email.
            if (!ExistsEmail(user.Email_User))
            {
                if (ValidatePassword(pass))
                {
                    if (EqualPassword(pass,repPass))
                    {
                        //Rellena los campos adicionales.
                        user.Image_User = ToolFile.UploadImage(user.Image_User,file);
                        user.Password_User = Hashing.HashPassword(pass);
                        user.Created_User = DateTime.Now;
                        user.Updated_User = DateTime.Now;
                        user.Status_User = 1;

                        //Inserta el usuario.
                        context.Users.Add(user);
                        context.SaveChanges();

                        //Generamos el Token de Confirmación de la cuenta.
                        Token token = new Token()
                        {
                            Id_User = user.Id_User,
                            Value_Token = CreateToken(),
                            Start_Token = DateTime.Now,
                            End_Token = DateTime.Now.AddMinutes(15)
                        };

                        //Inserta el token.
                        context.Tokens.Add(token);
                        context.SaveChanges();

                        //Enviamos el email de confirmación.
                        SMTPService smtp = new SMTPService();
                        smtp.SendEmail(user.Email_User, token.Value_Token);

                        return true;
                    }
                    else
                    {
                        error = "Las contraseñas no coinciden.";
                    }
                }
                else
                {
                    error = "La Contraseña debe estar compuesta de entre 8 y 15 caracteres, por lo menos un digito y un alfanumérico, y un caracter espacial.";
                }
               
            }
            else
            {
                error = "El email ya se ha registrado.";
            }

            return false;
        }

        //Obtenemos el usuario para confirmar su cuenta.
        public User Confirm(String token)
        {
            //Validamos que el Token existe y no esta caducado.
            int id = ValidateToken(token);

            User user = new User();

            if(id != -1 && id != 0)
            {
                User linq = (from data in context.Users
                              where data.Id_User == id
                              && data.Status_User == 1
                              select data).First();
                user = linq;
            }
            else
            {
                user.Id_User = id;
            }
            
            return user;
        }

        //Confirma a un Cliente.
        public Boolean ClientConfirm(Client client, ref String error)
        {
            if (!(ExistsDNI(client.DNI_Client))){
                //Insertamos los datos del cliente.
                context.Clients.Add(client);
                context.SaveChanges();

                //Eliminamos el token de confirmación.
                Token token = (from data in context.Tokens
                               where data.Id_User == client.Id_User
                               select data).FirstOrDefault();
                context.Tokens.Remove(token);
                context.SaveChanges();

                //Cambiamos el estado al usuario.
                User user = (from data in context.Users
                             where data.Id_User == client.Id_User
                             select data).FirstOrDefault();
                user.Status_User = 2;
                context.SaveChanges();

                return true;
            }

            error = "El DNI ya está en uso.";
            return false;

        }

        //Confirma a un Jugador.
        public Boolean PlayerConfirm(Player player, ref String error)
        {
            if (!(ExistsNick(player.Nick_Player)))
            {
                //Insertamos los datos del cliente.
                player.Level_Player = 1;
                context.Players.Add(player);
                context.SaveChanges();

                //Eliminamos el token de confirmación.
                Token token = (from data in context.Tokens
                               where data.Id_User == player.Id_User
                               select data).FirstOrDefault();
                context.Tokens.Remove(token);
                context.SaveChanges();

                //Cambiamos el estado al usuario.
                User user = (from data in context.Users
                             where data.Id_User == player.Id_User
                             select data).FirstOrDefault();
                user.Status_User = 2;
                context.SaveChanges();

                return true;
            }

            error = "El nick ya está en uso.";
            return false;
            

        }

        //Inicia la sesión del usuario correspondiente.
        public User Login(String email,String password,ref String error)
        {
            if (ExistsEmail(email))
            {
                User correctUser = (from data in context.Users
                                    where data.Email_User == email
                                    && data.Status_User == 2
                                    select data).FirstOrDefault();


                if (!(correctUser is null) && Hashing.ValidatePassword(password, correctUser.Password_User))
                {     
                    return correctUser;
                }
            }

            error = "El Email o la Contraseña son incorrectos.";
            return null;
        }
    }
}