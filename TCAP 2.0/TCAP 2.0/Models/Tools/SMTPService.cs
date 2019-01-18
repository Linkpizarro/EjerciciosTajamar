using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace TCAP_2._0.Models.Tools
{
    public class SMTPService
    {
        SmtpClient smtp;

        public SMTPService()
        {
            smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("daniel.pizarro@iberpixel.com", "Iberpixel123"),
                EnableSsl = true
            };
        }

        public void SendEmail(String to, String token)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(to));
            email.From = new MailAddress("daniel.pizarro@iberpixel.com");
            email.Subject = "Verificación de Cuenta TCAP";
            email.Body = "<h1>The Coins Are Points?</h1><hr /><h2>Verificación de Cuenta</h2><p>Para verificar su cuenta haga click <a href='servidor/Account/UserConfirm?token=" + token + "'>aquí</a></p>";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            String output = null;

            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
                Console.WriteLine(output);
            }

            Console.WriteLine(output);
        }

    }
}