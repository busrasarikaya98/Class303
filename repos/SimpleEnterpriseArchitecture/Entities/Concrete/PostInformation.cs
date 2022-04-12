using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class PostInformation : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime SharedDate { get; set; }
    }
}
