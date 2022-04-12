using Core.Entities;

namespace Entities.Concrete
{
    public class PostLike : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
}
