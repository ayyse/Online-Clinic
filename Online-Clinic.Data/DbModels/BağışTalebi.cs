using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Data.DbModels
{
    public class BağışTalebi 
    {
        [Key]
        public string TalepID { get; set; }
        public DateTime TalepTarihi { get; set; }
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }

        
    }
}
