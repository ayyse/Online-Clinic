using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Data.DbModels
{
    public class Randevu
    {
        [Key]
        public int RandevuID { get; set; }

        public string DoktorID { get; set; }
        public Doktor Doktor { get; set; }

        public string HastaID { get; set; }
        public Hasta Hasta { get; set; }

        public string AdSoyad { get; set; }
        public string Bölüm { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Tarih { get; set; }
    }
}
