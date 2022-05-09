using WebApi.Core.Model;

namespace WebApi.Models
{
    public class Price:IModel
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Price()
        {
        }
        public Price(int id, int value)
        {
            Id = id;
            Value = value;
        }
    }
}
