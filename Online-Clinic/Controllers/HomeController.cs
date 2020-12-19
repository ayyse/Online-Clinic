using Microsoft.AspNetCore.Mvc;

namespace Online_Clinic.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
