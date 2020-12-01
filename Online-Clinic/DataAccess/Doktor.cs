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
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Şifre { get; set; }

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }
       // public object Operation { get; internal set; }
    }
}
