using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Hikaye
    {
        [ForeignKey("HikayeID")]
        public int HikayeID { get; set; }
        public Hasta Hasta { get; set; }

        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public string HastalıkGeçmişi { get; set; }
        //public string KronikHastalıklar { get; set; }
        //public string TedaviEdenDoktor { get; set; }
    }
}
