using System;

namespace Online_Clinic.Common.ViewModels
{
    public class DoktorVM
    {
        public string DoktorID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Şifre { get; set; }
        public string Branş { get; set; }
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }
        public string Kurum { get; set; }
        public bool IsSuccess { get; set; }
        public string Role { get; set; }

    }
}
