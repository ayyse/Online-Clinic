using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Doktor : Visitor
    {
        public string Branş { get; set; }
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }
        public string Kurum { get; set; }

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }

        [NotMapped]
        public List<Randevu> Randevular { get; set; }
    }
}
