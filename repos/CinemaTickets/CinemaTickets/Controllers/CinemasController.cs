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
    public class CinemasController : Controller
    {
        private ICinemaRepository _cinemaRepository;
        public CinemasController()
        {
            _cinemaRepository = new CinemaRepository();
        }
    }
}
