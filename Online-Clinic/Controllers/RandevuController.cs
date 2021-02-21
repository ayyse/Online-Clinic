using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;

namespace Online_Clinic.Controllers
{
    public class RandevuController : Controller
    {
        //Service katmanıyla bağlantı kurabilmek için
        private readonly IRandevuService _randevuService;

        //Service katmanını inject etmek için constructor oluşturdum
        public RandevuController(IRandevuService randevuService)
        {
            _randevuService = randevuService;
        }

        //public IActionResult Index()
        //{
        //    var data = _randevuService.GetAllRandevu();
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
            var randevu = _randevuService.GetAllRandevu(user.LoginID);
            if (randevu.IsSuccess)
            {
                return View(randevu.Data);
            }
            return View(user);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RandevuVM model)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            if (ModelState.IsValid)
            {
                var data = _randevuService.CreateRandevu(model, user);

                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(RandevuVM model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var data = _randevuService.CreateRandevu(model);
        //        if(data.IsSuccess)
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
