using Core.Entities;

namespace Entities.Concrete
{
    public class TextMessage : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}
