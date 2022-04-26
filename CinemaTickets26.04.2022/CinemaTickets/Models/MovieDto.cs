using System;

namespace WebApi.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double IMDB { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public string Saloon { get; set; }
    }
}
