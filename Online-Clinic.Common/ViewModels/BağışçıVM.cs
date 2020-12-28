using System;
namespace Online_Clinic.Common.ViewModels
{
    public class BağışçıVM
    {
        public string BağışçıID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Şifre { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Tür { get; set; } //Kurumsal mı bireysel mi?
        public string Kurum { get; set; } //Eğer kurumsal ise
        public string Özgeçmiş { get; set; }
        public string Adres { get; set; }
    }
}
