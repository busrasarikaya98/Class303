using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IMailService
    {
        public IResult Send(List<string> recipientEmails, string subject, string content); 
        public IResult Send(string recipientEmail, string subject, string content); 
    }
}
