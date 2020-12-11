using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Common.ViewModels
{
    public class RandevuVM
    {
        public string RandevuID { get; set; }
        public string Doktor { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
    }
}
