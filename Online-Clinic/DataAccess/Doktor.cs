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
        public string Ad { get; set; }

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }
    }
}
