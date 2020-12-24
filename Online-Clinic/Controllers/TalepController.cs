using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.SessionOperations;
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

        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            return View(user);
        }
    }
}
