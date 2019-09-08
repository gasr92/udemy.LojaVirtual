using System.Net;
using System.Net.Mail;
using LojaVirtual.Models;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato p_contato)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("xxxxxxx@gmail.com", "");
            smtp.EnableSsl = true;

            var msg  = new MailMessage();
            msg.From = new MailAddress("xxxxxxxx@gmail.com") ;
            msg.To.Add(new MailAddress(p_contato.Email));
            msg.Subject = $"Contato loja virtual {p_contato.Nome}";
            msg.Body = "Esta é a mensagem do e-mail";
            msg.IsBodyHtml = true;

            smtp.Send(msg);
        }
    }
}