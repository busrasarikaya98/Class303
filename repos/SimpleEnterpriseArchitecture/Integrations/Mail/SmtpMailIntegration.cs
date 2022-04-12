using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.Mail
{
    public class SmtpMailIntegration
    {
        public Task Send(List<string> recipientEmails, string subject, string content)
        {
            MailMessage mailMessage = new MailMessage();
            foreach (var adresses in recipientEmails)
            {
                mailMessage.To.Add(adresses);
            }
            mailMessage.Subject = subject;
            mailMessage.Body = content;
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress("classmail@signedsoftware.com", "Yakup EYİSAN");
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "mail.signedsoftware.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("classmail@signedsoftware.com", "Class303..");
            smtpClient.EnableSsl = true;
            return smtpClient.SendMailAsync(mailMessage);
        }
        public Task Send(string recipientEmail, string subject, string content)
        {
            return this.Send(new List<string>() { recipientEmail }, subject, content);
        }
    }
}
