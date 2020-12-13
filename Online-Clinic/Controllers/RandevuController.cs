using Microsoft.AspNetCore.Mvc;
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

        public ActionResult Index()
        {
            var data = _randevuService.GetAllRandevu();

            if(data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }
    }
}
