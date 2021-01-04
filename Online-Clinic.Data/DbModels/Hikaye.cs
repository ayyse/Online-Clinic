using System.ComponentModel.DataAnnotations;

namespace Online_Clinic.Data.DbModels
{
    public class Hikaye
    {
        [Key]
        public int HikayeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }
    }
}
