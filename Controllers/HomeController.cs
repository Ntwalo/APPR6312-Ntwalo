using Ntwalo_APPR6312.Models;
using Microsoft.AspNetCore.Mvc;
using Ntwalo_APPR6312.Models;
using System.Diagnostics;

namespace Ntwalo_APPR6312.Controllers
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

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        public IActionResult Disaster()
        {
            return View();
        }

        public IActionResult DonationItem()
        {
            return View();
        }

        public IActionResult DonationMoney()
        {
            return View();
        }

        public IActionResult Catagory()
        {
            return View();
        }

        public IActionResult ApplicationUser()
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