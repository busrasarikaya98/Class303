using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class HesapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Giris()
        {
            return View();
        }
        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //data güvenliği için token
        public IActionResult Kayit(string usernamee)
        {
            string a = "Ali" + usernamee;
            return View(a);
        }
        public IActionResult SifreSifirla()
        {
            return View();
        }
        public IActionResult HukumveKosullar()
        {
            return View();
        }
    }
}
