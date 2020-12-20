using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Hasta : Visitor
    {
        //[Key]
        //public string HastaID { get; set; }
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public DateTime DoğumTarihi { get; set; }
        //public string Cinsiyet { get; set; }
        //public string Şifre { get; set; }
        //public string Image { get; set; }
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }
        

        [NotMapped]
        public List<Doktor> Doktorlar { get; set; }
    }
}
