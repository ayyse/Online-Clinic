using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Clinic.Data.DbModels
{
    public class Hasta : Visitor
    {
        public string HastalıkGeçmişi { get; set; }
        public string KronikHastalıklar { get; set; }
        public string TedaviEdenDoktor { get; set; }

        [NotMapped]
        public List<Doktor> Doktorlar { get; set; }

        [NotMapped]
        public List<Randevu> Randevular { get; set; }

        [NotMapped]
        public List<BağışTalebi> BağışTalepleri { get; set; }

        public Hikaye Hikaye { get; set; }
    }
}
