using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class BağışçıController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bireysel()
        {
            return View();
        }

        public IActionResult Kurumsal()
        {
            return View();
        }
    }
}
