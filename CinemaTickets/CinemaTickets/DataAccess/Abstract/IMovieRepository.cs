using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Core.DataAccess.Abstract;
using WebApi.Models;

namespace WebApi.DataAccess.Abstract
{
    public interface IMovieRepository:IBaseRepository<Movie>
    {
        List<Movie> GetAllByCinemaId(int cinemaId);
        List<Movie> GetAllByTimeId (int timeId);
}
}
