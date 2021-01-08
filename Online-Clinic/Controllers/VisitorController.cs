using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class VisitorController : Controller
    {
        private readonly UserManager<Visitor> _userManager;

        public VisitorController(UserManager<Visitor> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListDoktor()
        {
            var doktorlar = _userManager.Users;
            return View(doktorlar);
        }

        [HttpGet]
        public IActionResult ListHasta()
        {
            var hastalar = _userManager.Users;
            return View(hastalar);
        }

        [HttpGet]
        public IActionResult ListBağışçı()
        {
            var bağışçılar = _userManager.Users;
            return View(bağışçılar);
        }
    }
}
