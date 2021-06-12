using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;

namespace Online_Clinic.Controllers
{
    public class HikayeController : Controller
    {
        private readonly IHikayeService _hikayeService;

        //Service katmanını inject etmek için constructor oluşturdum
        public HikayeController(IHikayeService hikayeService)
        {
            _hikayeService = hikayeService;
        }

        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            var hikaye = _hikayeService.GetAllHikaye(user.LoginID);
            if (hikaye.IsSuccess)
            {
                return View(hikaye.Data);
            }
            return View(user);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HikayeVM model)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            if (ModelState.IsValid)
            {
                var data = _hikayeService.CreateHikaye(model, user);

                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            return View();
        }

        //public IActionResult Index()
        //{
        //    var data = _hikayeService.GetAllHikaye();
        //    if (data.IsSuccess)
        //    {
        //        var result = data.Data;
        //        return View(result);
        //    }
        //    return View(data);
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public ActionResult Create(HikayeVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var data = _hikayeService.CreateHikaye(model);
        //        if (data.IsSuccess)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        return View(model);
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}


    }
}
