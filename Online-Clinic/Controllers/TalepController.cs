using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;

namespace Online_Clinic.Controllers
{
    public class TalepController : Controller
    {
        private readonly ITalepService _talepService;

        public TalepController(ITalepService talepService)
        {
            _talepService = talepService;
        }

        //public IActionResult Index()
        //{
        //    var data = _talepService.GetAllTalep();
        //    if (data.IsSuccess)
        //    {
        //        var result = data.Data;
        //        return View(result);
        //    }
        //    return View(data);
        //}

        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            var talep = _talepService.GetAllTalep(user.LoginID);
            if (talep.IsSuccess)
            {
                return View(talep.Data);
            }
            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BağışTalebiVM model)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            if (ModelState.IsValid)
            {
                var data = _talepService.CreateTalep(model, user);

                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            return View();
        }


        //[HttpPost]
        //public ActionResult Create(BağışTalebiVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var data = _talepService.CreateTalep(model);
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









        //public IActionResult Index()
        //{
        //    var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
        //    var requestModel = _talepService.GetAllTalepByUserId(user.LoginID);
        //    if (requestModel.IsSuccess)
        //    {
        //        return View(requestModel.Data);
        //    }
        //    return View(user);
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(BağışTalebiVM model)
        //{
        //    var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

        //    if (ModelState.IsValid)
        //    {
        //        var data = _talepService.CreateBağışTalebi(model, user);
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
