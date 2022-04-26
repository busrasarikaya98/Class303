using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataAccess.Abstract;
using WebApi.DataAccess.Concrete;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository _movieRepository;
        private ISaloonRepository _saloonRepository;
        private ITimeRepository _timeRepository;
        public MoviesController() 
        {
            _movieRepository = new MovieRepository();
            _timeRepository = new TimeRepository();
            _saloonRepository = new SaloonRepository();
        }
        public IActionResult Index()
        {
            ViewBag.movies = this._movieRepository.GetAllWithTimeandSaloon();
            return View();
        }
        public IActionResult Add(string message)
        {
            ViewBag.times = this._timeRepository.GetAll();
            ViewBag.saloons = this._saloonRepository.GetAll();
            ViewBag.message = message;
            return View();
        }
        public IActionResult Update(int id, string message)
        {
            var movie = this._movieRepository.GetById(id);
            if (movie == null)
            {
                RedirectToAction("Index");
            }
            ViewBag.movie = movie;
            ViewBag.message = message;
            return View();
        }
        public IActionResult Delete(int id)
        {
            this._movieRepository.DeleteById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Save(Movie movie)
        {
            string route = (movie.Id == 0) ? "Add" : "Update";
            if (movie.Id == 0)
            {
                this._movieRepository.Add(movie);
            }
            else
            {
                this._movieRepository.Update(movie);
            }
            if (movie.SaloonId == 0)
            {
                return RedirectToAction(route, new ErrorResult(movie.Id, "Please Select Saloon!"));
            }
            if(movie.TimeId == 0)
            {
                return RedirectToAction(route, new ErrorResult(movie.Id, "Please Select Seanse!"));
            }
            if(movie.Name ==null)
            {
                return RedirectToAction(route, new ErrorResult(movie.Id, "Please Enter Movie Name!"));
            }
            if (movie.IMDB == 0)
            {
                return RedirectToAction(route, new ErrorResult(movie.Id, "Please Enter IMDB Point!"));
            }
            if (movie.Description == null)
            {
                return RedirectToAction(route, new ErrorResult(movie.Id, "Please Enter Description About Movie!"));
            }
            return RedirectToAction("Index");
        }
    }
}
