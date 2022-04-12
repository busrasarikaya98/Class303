using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MailTransaction:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool Status { get; set; }
    }
}
