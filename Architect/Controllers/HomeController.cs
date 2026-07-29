using Architect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Architect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
