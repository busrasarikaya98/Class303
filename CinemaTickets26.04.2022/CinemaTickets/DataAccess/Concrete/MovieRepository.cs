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
        public List<Movie> GetAllByTimeId(int timeId)
        {
            using (var context = new CinemaTicketDbContext())
            {
                return context.Set<Movie>().Where(t => t.TimeId == timeId).ToList();
            }
        }
        public List<Movie> GetAllBySaloonId(int saloonId)
        {
            using (var context = new CinemaTicketDbContext())
            {
                return context.Set<Movie>().Where(t => t.SaloonId == saloonId).ToList();
            }
        }
        public List<MovieDto> GetAllWithTimeandSaloon()
        {
            using (var context = new CinemaTicketDbContext())
            {
                var result = from m in context.Movies
                             join t in context.Times on m.TimeId equals t.Id
                             join s in context.Saloons on m.SaloonId equals s.Id
                             select new MovieDto()
                             {
                                 Id = m.Id,
                                 Name = m.Name,
                                 Description = m.Description,
                                 IMDB = m.IMDB,                                 
                                 Time = t.MovieTime,                                 
                                 Saloon=s.Name
                             };
                return result.ToList();
            }
        }

    }
}
