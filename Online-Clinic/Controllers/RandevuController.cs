using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var data = _randevuService.GetAllRandevu();
            if (data.IsSuccess)
            {  
                var result = data.Data;
                return View(result);
            }
            return View(data);
        }

   
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RandevuVM model)
        {
            if(ModelState.IsValid)
            {
                var data = _randevuService.CreateRandevu(model);
                if(data.IsSuccess)
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
