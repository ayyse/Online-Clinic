using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Services.Contracts;

namespace Online_Clinic.Controllers
{
    public class HastaController : Controller
    {
        private readonly IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }
        public IActionResult Index()
        {
            var hasta = _hastaService.GetAllHasta();
            if (hasta.IsSuccess)
            {
                var result = hasta.Data;
                return View(result);
            }
            return View(hasta);
        }
    }
}
