using Microsoft.AspNetCore.Mvc;
using Mission5_Jergensen.Models;
using System.Diagnostics;

namespace Mission5_Jergensen.Controllers
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
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }
    }
}
