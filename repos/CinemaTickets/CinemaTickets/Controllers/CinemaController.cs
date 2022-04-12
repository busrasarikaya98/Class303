using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CinemaController : Controller
    {
        
        public IActionResult Index()
        {
            List<Cinema> cinemas = new List<Cinema>();
            cinemas.Add(new Cinema { Id = 1, Name = "Gold Class" });
            cinemas.Add(new Cinema { Id = 2, Name = "Starium" });
            return View(cinemas);
        }
    }
}
