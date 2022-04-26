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
        public string Name { get; set; }
        public double IMDB { get; set; }
        public string Description { get; set; }
        public int TimeId { get; set; }
        public int SaloonId { get; set; }

        public Movie()
        {
        }
        public Movie(int id,int saloonId,int timeId,string name,double imdb,string description)
        {
            Id = id;
            Name = name;
            IMDB = imdb;
            Description = description;
            TimeId = timeId;
            SaloonId = saloonId;
        }
    }
}
