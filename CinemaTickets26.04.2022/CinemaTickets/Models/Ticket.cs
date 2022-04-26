namespace WebApi.Models
{
    public class Ticket
    {
        public int Id { get; set; } 
        public int MovieId { get; set; } 
        public int SaloonId { get; set; } 
        public int SeatId { get; set; }
    }
}
