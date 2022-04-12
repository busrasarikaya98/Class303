using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> cinemas = new List<Movie>();
            cinemas.Add(new Movie { Id = 1, Name = "The Theory of Everything",IMDB=7.5,Description= "Her Şeyin Teorisi ya da orijinal adıyla The Theory of Everything, fizikçi Stephen Hawking'in hayatının konu edinildiği, bir İngiliz dram-biyografi filmidir." });
            cinemas.Add(new Movie { Id = 2, Name = "The Imitation Game",IMDB=8.2,Description= "Enigma, ABD yapımı uyarlama sinema filmi. Başrollerini Benedict Cumberbatch ve Keira Knightley'in paylaştığı filmin yönetmenliğini Morten Tyldum yapmaktadır." });
            return View(cinemas);
        }
    }
}
