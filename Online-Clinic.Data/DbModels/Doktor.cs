using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Data.DbModels
{
    public class Doktor : IdentityUser
    {
        [Required]
        public int DoktorID { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Branş { get; set; }
        public string Özgeçmiş { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Adres { get; set; }
        public string Kurum { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Şifre { get; set; }
        

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }
    }
}
