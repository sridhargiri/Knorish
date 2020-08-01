using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment.Models;
using Assessment.Services;

namespace Assessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBoatService _boatService;

        public HomeController(ILogger<HomeController> logger, IBoatService boatService)
        {
            _logger = logger;
            _boatService = boatService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBoat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBoat(BoatDataModel boat)
        {
            int id = _boatService.AddBoat(boat);
            ViewData["boatid"] = id;
            return View();
        }

        public IActionResult RentBoat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RentBoat(RentBoatModel rentBoatModel)
        {
            string status = _boatService.RentBoat(rentBoatModel);
            ViewData["status"] = status;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
