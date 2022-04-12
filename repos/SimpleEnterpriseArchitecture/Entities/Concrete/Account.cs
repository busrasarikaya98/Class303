using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsVerification { get; set; }
        public string WebSite { get; set; }
        public string Biography { get; set; }
    }
}
