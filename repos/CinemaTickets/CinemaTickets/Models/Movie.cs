using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Core.Model;

namespace WebApi.Models
{
    public class Movie:IModel
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int TimeId { get; set; }
        public string Name { get; set; }
        public double IMDB { get; set; }
        public string Description { get; set; }

        public Movie()
        {
        }
        public Movie(int id,int cinemaId,int timeId,string name,double imdb,string description)
        {
            Id = id;
            CinemaId = cinemaId;
            TimeId = timeId;
            Name = name;
            IMDB = imdb;
            Description = description;
        }
    }
}
