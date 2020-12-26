using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Common.ViewModels
{
    public class RandevuVM
    {
        public string RandevuID { get; set; }

        [Required]
        public string AdSoyad { get; set; }
        public HastaVM hastaVM { get; set; }

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
