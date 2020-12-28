using System;

namespace Online_Clinic.Common.ViewModels
{
    public class HastaVM
    {
        public string HastaID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Şifre { get; set; }
        public string Image { get; set; }
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }
        public string Role { get; set; }
    }
}
