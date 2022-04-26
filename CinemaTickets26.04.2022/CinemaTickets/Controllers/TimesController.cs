using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataAccess.Abstract;
using WebApi.DataAccess.Concrete;

namespace WebApi.Controllers
{
    public class TimesController : Controller
    {
        private ITimeRepository _timeRepository;
        public TimesController()
        {
            _timeRepository = new TimeRepository();
        }
    }
}
