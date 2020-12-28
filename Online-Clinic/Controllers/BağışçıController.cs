using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class BağışçıController : Controller
    {
        private readonly IBağışçıService _bağışçıService;

        public BağışçıController(IBağışçıService bağışçıService)
        {
            _bağışçıService = bağışçıService;
        }

        public IActionResult Index()
        {
            var bağışçı = _bağışçıService.GetAllBağışçı();
            if (bağışçı.IsSuccess)
            {
                var result = bağışçı.Data;
                return View(result);
            }
            return View(bağışçı);
        }
    }
}
