using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        //Se encarga de introducir a un nuevo usuario en la Base de datos.
        public Boolean Register(User user,ref String error)
        {
            //Instancia de la clase validationAccount.
            ToolAccount tool = new ToolAccount();

            //Valida la existencia del email.
            if (!ExistsEmail(user.Email_User))
            {
                //Rellena los campos adicionales.
                user.Image_User = tool.UploadImage(user);
                user.TruePassword_User = Hashing.HashPassword(user.Password_User);
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
                    Value_Token = tool.CreateToken(),
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
                error = "El email ya se ha registrado.";
            }

            return false;
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
            //Insertamos los datos del cliente.
            context.Clients.Add(client);
            context.SaveChanges();

            //Eliminamos el token de confirmación.
            Token token = (from data in context.Tokens
                           where data.Id_User == client.Id_User
                           select data).FirstOrDefault();
            context.Tokens.Remove(token);
            context.SaveChanges();

            return true;

        }

        //Confirma a un Jugador.
        public Boolean PlayerConfirm(Player player, ref String error)
        {
            //******Falta validar nick*******
            //Insertamos los datos del cliente.
            context.Players.Add(player);
            context.SaveChanges();

            //Eliminamos el token de confirmación.
            Token token = (from data in context.Tokens
                           where data.Id_User == player.Id_User
                           select data).FirstOrDefault();
            context.Tokens.Remove(token);
            context.SaveChanges();

            return true;

        }
    }
}