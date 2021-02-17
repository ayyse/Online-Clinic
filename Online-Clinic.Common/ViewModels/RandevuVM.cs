using Online_Clinic.Data.DbModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Common.ViewModels
{
    public class RandevuVM
    {
        public int RandevuID { get; set; }

        public string DoktorID { get; set; }
        public DoktorVM Doktor { get; set; }

        public string HastaID { get; set; }
        public HastaVM Hasta { get; set; }

        [Required]
        public string AdSoyad { get; set; }

        [Required]
        public string Bölüm { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        public string Telefon { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
