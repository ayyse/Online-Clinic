using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class BağışTalebiVM
    {
        public int TalepID { get; set; }

        public string AdSoyad { get; set; }

        [Required]
        public DateTime TalepTarihi { get; set; }


        [Required]
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }
        public bool İptal { get; set; }

        //public string HastaID { get; set; }
        //[ForeignKey("HastaID")]
        //public Hasta Hasta { get; set; }

        //public string AdminID { get; set; }
        //[ForeignKey("AdminID")]
        //public Admin Admin { get; set; }
    }
}
