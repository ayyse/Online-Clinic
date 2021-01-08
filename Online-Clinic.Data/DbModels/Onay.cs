using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Clinic.Data.DbModels
{
    public class Onay
    {
        public int TalepID { get; set; }
        [ForeignKey("TalepID")]
        public BağışTalebi BağışTalebi { get; set; }
    }
}
