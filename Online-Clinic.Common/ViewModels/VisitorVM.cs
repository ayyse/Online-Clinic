using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class VisitorVM
    {
        public string HastaID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }
        public string Email { get; set; }
        public string Şifre { get; set; }
    }
}
