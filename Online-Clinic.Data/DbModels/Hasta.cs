using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Data.DbModels
{
    public class Hasta : IdentityUser
    {
        //[Required]
        //public int HastaID { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string HastalıkGeçmişi { get; set;}

        public string KronikHastalıklar { get; set; }

        public string TedaviEdenDoktor { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Şifre { get; set; }

        [NotMapped]
        public List<Doktor> Doktorlar { get; set; }
    }
}
