using Core.Entities;
using System;

namespace Entities.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
