using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Core.DataAccess.Concrete;
using WebApi.DataAccess.Abstract;
using WebApi.Models;

namespace WebApi.DataAccess.Concrete
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public List<Movie> GetAllByCinemaId(int cinemaId)
        {
            using (var context = new CinemaTicketDbContext())
            {
                return context.Set<Movie>().Where(m => m.CinemaId == cinemaId).ToList();
            }
        }
        public List<Movie> GetAllByTimeId(int timeId)
        {
            using (var context = new CinemaTicketDbContext())
            {
                return context.Set<Movie>().Where(t => t.TimeId == timeId).ToList();
            }
        }
    }
}
