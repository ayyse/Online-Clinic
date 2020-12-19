using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Doktor 
    {
        [Key]
        public string DoktorID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Şifre { get; set; }
        public string Image { get; set; }
        public string Branş { get; set; }
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }
        public string Kurum { get; set; }

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }
    }
}
