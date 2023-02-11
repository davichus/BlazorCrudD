using System;
using System.Net;
using System.Net.Mail;

namespace BlazorCRUD.Model
{
    public class CN_Mail
    {
        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        public bool enviarcorreo(string from, string pass, string to, string mensaje)
        {
            try
            {
                m.From = new MailAddress(from);
                m.To.Add(new MailAddress(to));

                m.Body = mensaje;
                m.Subject = "Recuperar Contraseña";
                smtp.Host = "SMTP.Office365.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.EnableSsl = true;


                smtp.Send(m);
                m.IsBodyHtml = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
                throw;
            }

        }
    }
}
