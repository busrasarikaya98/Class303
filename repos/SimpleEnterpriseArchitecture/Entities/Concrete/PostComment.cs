using Core.Entities;

namespace Entities.Concrete
{
    public class PostComment : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
    }
}
