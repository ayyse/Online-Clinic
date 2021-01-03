using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class TalepOnayController : Controller
    {
        private readonly ITalepOnayService _onayService;

        public TalepOnayController(ITalepOnayService onayService)
        {
            _onayService = onayService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
