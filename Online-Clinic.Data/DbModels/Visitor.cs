using Microsoft.AspNetCore.Identity;
using System;

namespace Online_Clinic.Data.DbModels
{
    public class Visitor : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Şifre { get; set; }
        public string Image { get; set; }

    }
}
