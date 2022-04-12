using Core.Entities;

namespace Entities.Dtos
{
    public class UserForStartResetPasswordDto : IDto
    {
        public string UserName { get; set; }
    }
    public class UserForResetPasswordDto : IDto
    {
        public string Code { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
