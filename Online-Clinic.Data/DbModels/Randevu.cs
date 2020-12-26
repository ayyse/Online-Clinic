using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Randevu
    {
        [Key]
        public string RandevuID { get; set; }
        public string AdSoyad { get; set; }
        public string Bölüm { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        //public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
        //public DateTime Saat { get; set; }


        public string HastaID { get; set; }
        [ForeignKey("HastaID")]
        public Hasta Hasta { get; set; }


        public string DoktorID { get; set; }
        [ForeignKey("DoktorID")]
        public Doktor Doktor { get; set; }
    }
}
