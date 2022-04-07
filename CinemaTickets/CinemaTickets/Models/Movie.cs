using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Core.Model;

namespace WebApi.Models
{
    public class Movie:IModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double IMDB { get; set; }
        public string Description { get; set; }
        int IModel.Id { get; set; }
    }
}
