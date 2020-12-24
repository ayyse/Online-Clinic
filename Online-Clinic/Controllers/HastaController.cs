using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    //[Authorize(Roles = ResultConstant.HastaRole)]

    public class HastaController : Controller
    {
        private readonly IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }
        public IActionResult Index()
        {
            var data = _hastaService.GetAllHasta();
            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View(data);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(HastaVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _hastaService.Register(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
    }
}
