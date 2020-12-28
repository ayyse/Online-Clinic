using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Services.Contracts;

namespace Online_Clinic.Controllers
{
    public class DoktorController : Controller
    {
        private readonly IDoktorService _doktorService;

        public DoktorController(IDoktorService doktorService)
        { 
            _doktorService = doktorService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var doktor = _userManager.Users.ToListAsync(); 
        //    return View(doktor);
        //}

        public IActionResult Index()
        {
            var doktor = _doktorService.GetAllDoktor();
            if (doktor.IsSuccess)
            {
                var result = doktor.Data;
                return View(result);
            }
            return View(doktor);
        }

    }
}
