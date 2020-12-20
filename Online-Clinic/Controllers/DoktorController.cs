using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class DoktorController : Controller
    {
        private readonly IDoktorService _doktorService;

        public DoktorController(IDoktorService doktorService)
        {
            _doktorService = doktorService;
        }


        [Authorize(Roles = ResultConstant.DoktorRole)]
        public IActionResult Index()
        {
            var data = _doktorService.GetAllDoktor();
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
        public ActionResult Register(DoktorVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _doktorService.Register(model);
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
