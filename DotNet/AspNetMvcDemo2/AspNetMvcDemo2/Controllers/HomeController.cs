using AspNetMvcDemo2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string SayHello()
        {
            return "Hello World!";
        }

        public int FileSum()
        {
            string filename = "C:\\Bootcamp\\Vaasa\\Numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value;   // sum = sum + value;
            }

            return sum;
        }

        public IActionResult SecondPage()
        {
            return View();
        }

        public IActionResult Index()
        {
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
