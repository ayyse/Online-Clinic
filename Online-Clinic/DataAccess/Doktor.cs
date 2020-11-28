using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    [Table("Doktorlar")]
    public class Doktor
    {
        [Column("DoktorID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DoktorID { get; set; }

        [Column("Doktor Adı Soyadı")]
        [Required]
        [StringLength(100)]
        public string Ad { get; set; }

        [ForeignKey("DoktorID")]
        public virtual List<Hasta> Hastalar { get; set; }
    }
}
