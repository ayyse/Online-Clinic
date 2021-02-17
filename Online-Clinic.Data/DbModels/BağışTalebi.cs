using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Data.DbModels
{
    public class BağışTalebi 
    {
        [Key]
        public int TalepID { get; set; }
        public string HastaID { get; set; }
        public Hasta Hasta { get; set; }
        public string AdSoyad { get; set; }
        public DateTime TalepTarihi { get; set; }
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }
        public bool İptal { get; set; }
    }
}
