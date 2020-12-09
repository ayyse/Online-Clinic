using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Clinic.Data.DbModels
{
    public class Randevu : Hasta
    {
        public string RandevuID { get; set; }
        public string Doktor { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }

        //public string DoktorID { get; set; }
        //[ForeignKey("DoktorID")]
        //public Doktor Doktorlar { get; set; }

        public string HastaID { get; set; }
        [ForeignKey("HastaID")]
        public Hasta Hasta { get; set; }
    }
}
