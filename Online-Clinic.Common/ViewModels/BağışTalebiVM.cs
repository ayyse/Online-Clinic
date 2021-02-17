using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class BağışTalebiVM
    {
        public int TalepID { get; set; }

        public string HastaID { get; set; }
        public HastaVM Hasta { get; set; }

        public string AdSoyad { get; set; }
        public DateTime TalepTarihi { get; set; }
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }
        public bool İptal { get; set; }
    }
}
