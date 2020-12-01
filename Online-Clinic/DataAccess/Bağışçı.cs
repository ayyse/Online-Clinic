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
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Şifre { get; set; }

        [NotMapped]
        public List<Bağışçı> Bağışçılar { get; set; }
    }
}
