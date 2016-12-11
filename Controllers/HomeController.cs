using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "ABOUT US";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "CONTACT US";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
