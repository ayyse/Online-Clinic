using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Models;
using System.Diagnostics;
using Online_Clinic.Areas.Identity;

namespace Online_Clinic.Controllers
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
            ClinicContext context = new ClinicContext();
            return View();
        }

        public IActionResult Login()
        {
            
            return View();
        }
        public IActionResult Register()
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
