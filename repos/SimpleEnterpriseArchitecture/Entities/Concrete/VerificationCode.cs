using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class VerificationCode:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Code { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
