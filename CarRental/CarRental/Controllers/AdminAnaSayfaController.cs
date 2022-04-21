using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminAnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
