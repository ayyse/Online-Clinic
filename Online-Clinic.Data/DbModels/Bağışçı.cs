using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Data.DbModels
{
    public class Bağışçı : Visitor
    {
        //    [Key]
        //    public string BağışçıID { get; set; }
        public string Tür { get; set; } //Kurumsal mı bireysel mi?
        public string Kurum { get; set; } //Eğer kurumsal ise
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }

        [NotMapped]
        public List<Hasta> Hastalar { get; set; }
    }
}
