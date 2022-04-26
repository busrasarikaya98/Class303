using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccess.Abstract;
using WebApi.DataAccess.Concrete;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class SeatsController : Controller
    {
        private ISeatRepository _seatRepository;
        public SeatsController()
        {
            _seatRepository = new SeatRepository();    
        }
        public IActionResult Index()
        {
            ViewBag.seats = this._seatRepository.GetAll();
            return View();
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var saloon = this._seatRepository.GetById(id);
            if (saloon != null)
            {
                return Ok(saloon);
            }
            return BadRequest(new ErrorResult(saloon.Id, "Saloon is not found"));
        }
        public IActionResult Add(string message)
        {
            ViewBag.message = message;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Saloon saloon)
        {
            string route = (saloon.Id == 0) ? "Add" : "Update";
            if (saloon.Name == null)
            {
                return BadRequest(new ErrorResult(saloon.Id, "Please Enter Name"));
            }
            if (saloon.Id == 0)
            {
                this._seatRepository.Add(saloon);
            }
            else
            {
                this._seatRepository.Update(saloon);
            }
            return Ok(saloon);
        }
        [HttpDelete]
        public IActionResult DeleteById(Saloon saloon)
        {
            this._seatRepository.DeleteById(saloon.Id);
            return Ok(saloon);
        }
    }
}
