using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    public class Doktor
    {
        [Key]
        [Required]
        public int DoktorID { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string AdSoyad { get; set; }
        public string DoğumTarihi { get; set; }
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
        //public int Rating { get; internal set; }
        // public object Operation { get; internal set; }
    }
}
