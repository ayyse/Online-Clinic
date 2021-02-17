using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class HikayeVM
    {
        public int HikayeID { get; set; }

        public string HastaID { get; set; }
        public HastaVM Hasta { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }
    }
}
