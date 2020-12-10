using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Clinic.Data.DbModels
{
    public class BağışTalebi : Hasta
    {
        //TODO: Talepte bulunan hastalar için
        public string HastaID { get; set; }
        [ForeignKey("HastaID")]
        public Hasta Hasta { get; set; }


        //TODO: Talebi onaylayan doktor için
        public string DoktorID { get; set; }
        [ForeignKey("DoktorID")]
        public Doktor Doktor { get; set; }



        public DateTime TalepTarihi { get; set; }
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }
    }
}
