using Core.Entities;

namespace Entities.Dtos
{
    public class UserForVerificationDto : IDto
    {
        public int UserId { get; set; }
        public string Code { get; set; }
    }
}
