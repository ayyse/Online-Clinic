using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Controllers
{
    public class DoktorController : Controller
    {
        
        public IActionResult Index()
        {
            var doktorlar = new List<Doktor>();
            return View();
        }


        [HttpGet]
        public IActionResult Kayıt()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kayıt(Doktor doktor)
        {
            var doktorlar = new List<Doktor>();
            if (doktor.DoktorID == 0)
            {
                //yeni kayıt
            }
            else
            {
                //kayıt güncelle
            }
            return View(doktor);
        }
    }
}
