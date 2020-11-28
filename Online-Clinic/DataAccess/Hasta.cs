using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    [Table("Hastalar")]
    public class Hasta
    {
        [Column("HastaID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int HastaID { get; set; }

        [Column("Hasta Adı Soyadı")]
        [Required]
        [StringLength(100)]
        public string Ad { get; set; }

        [ForeignKey("HastaID")]
        public virtual List<Doktor> Doktorlar { get; set; }
    }
}
