using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    public class Hasta
    {
        [Key]
        [Required]
        public int HastaID { get; set; }
        public string AdSoyad { get; set; }

        [NotMapped]
        public List<Doktor> Doktorlar { get; set; }
    }
}
