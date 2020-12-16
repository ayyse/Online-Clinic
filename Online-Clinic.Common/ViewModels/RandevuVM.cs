using System;

namespace Online_Clinic.Common.ViewModels
{
    public class RandevuVM
    {
        public string RandevuID { get; set; }
        public string TamAd { get; set; }
        public string Doktor { get; set; }
        public string Bölüm { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
    }
}
