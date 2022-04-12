using Core.Entities;

namespace Entities.Concrete
{
    public class AccountAvatar : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
    }
}
