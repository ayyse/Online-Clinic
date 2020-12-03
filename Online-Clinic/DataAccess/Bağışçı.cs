using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    public class Bağışçı
    {
        [Key]
        [Required]
        public int BağışçıID { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string AdSoyad { get; set; }
        public string DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Tür { get; set; } //Kurumsal mı bireysel mi?
        public string Kurum { get; set; } //Eğer kurumsal ise
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Şifre { get; set; }

        [NotMapped]
        public List<Bağışçı> Bağışçılar { get; set; }
    }
}
