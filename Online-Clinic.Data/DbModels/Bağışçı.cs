using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Bağışçı : Visitor
    {
        public string Tür { get; set; } //Kurumsal mı bireysel mi?
        public string Kurum { get; set; } //Eğer kurumsal ise
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }
    }
}
