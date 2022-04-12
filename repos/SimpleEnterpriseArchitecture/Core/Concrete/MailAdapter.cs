using Core.Abstract;
using Core.Utilities.Results;
using Integrations.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{  
    public class MailAdapter : IMailService
    {
        public IResult Send(List<string> recipientEmails, string subject, string content)
        {
            SmtpMailIntegration smtpMailIntegration = new SmtpMailIntegration();
            smtpMailIntegration.Send(recipientEmails,subject,content);
            return new SuccessResult("Mail gönderildi.");
        }

        public IResult Send(string recipientEmail, string subject, string content)
        {
            SmtpMailIntegration smtpMailIntegration = new SmtpMailIntegration();
            smtpMailIntegration.Send(recipientEmail, subject, content);
            return new SuccessResult("Mail gönderildi.");
        }
    }
}
