using MapsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleController : ControllerBase
    {
        [HttpGet]
        public IList<Hotel>Get()
        {
            IList<Hotel> hotels = new List<Hotel>();
            hotels.Add(new Hotel { Name = "Busra", HotelName = "Papatya", PhoneNumber = "+902168549756", lat = 40.98867000000007f, lng = 29.02732000000003f });
            hotels.Add(new Hotel { Name = "Busra", HotelName = "Lale", PhoneNumber = "+902168549756", lat = 39.768669f, lng = 30.507332f });
            hotels.Add(new Hotel { Name = "Busra", HotelName = "Zambak", PhoneNumber = "+902168549756", lat = 39.779669f, lng = 30.507332f });
            hotels.Add(new Hotel { Name = "Busra", HotelName = "Orkide", PhoneNumber = "+902168549756", lat = 39.782669f, lng = 30.507332f });
            return hotels;
            //veya new Hotel(içine bilgiler)
        }
    }
}
