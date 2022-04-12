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
        private ICinemaRepository _cinemaRepository;
        private ITimeRepository _timeRepository;
        public MoviesController() 
        {
            _timeRepository = new TimeRepository();
            _cinemaRepository = new CinemaRepository();
            _timeRepository = new TimeRepository();
        }
        public IActionResult Add(string message)
        {
            ViewBag.cinemas = this._cinemaRepository.GetAll();
            ViewBag.times = this._timeRepository.GetAll();
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
    }
}
