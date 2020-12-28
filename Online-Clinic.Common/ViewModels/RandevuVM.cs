using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Common.ViewModels
{
    public class RandevuVM
    {
        public int RandevuID { get; set; }

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

        public void SetRandevu(string adSoyad, string bölüm, string tel, string mail, DateTime tarih)
        {
            this.AdSoyad = adSoyad;
            this.Bölüm = bölüm;
            this.Telefon = tel;
            this.Email = mail;
            this.Tarih = tarih;
        }

    }
}
