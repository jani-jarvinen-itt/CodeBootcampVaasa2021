using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantRandomizer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRandomizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //                indexes:   0     1     2     3
            string[] allRestaurants = { "R1", "R2", "R3", "R4" };

            Random random = new();
            int index = random.Next(0, allRestaurants.Length);
            string selected = allRestaurants[index];
            /*string first = allRestaurants[0];
            string second = allRestaurants[1];*/
            
            ViewBag.RestaurantToGoToToday = selected;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
