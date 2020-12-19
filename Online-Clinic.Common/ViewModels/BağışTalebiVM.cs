using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class BağışTalebiVM
    {
        public DateTime TalepTarihi { get; set; }
        public string TalepAçıklaması { get; set; }
        public bool Onay { get; set; }

        public string HastaID { get; set; }
        public VisitorVM HastaVm { get; set; }

        public string DoktorID { get; set; }
        public HastaVM DoktorVm { get; set; }
    }
}
