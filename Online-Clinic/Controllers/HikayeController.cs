using Microsoft.AspNetCore.Mvc;
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
            var data = _hikayeService.GetAllHikaye();
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
        public ActionResult Create(HikayeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _hikayeService.CreateHikaye(model);
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
