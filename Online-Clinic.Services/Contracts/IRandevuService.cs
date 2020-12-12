using Online_Clinic.Common.ResultModels;
using Online_Clinic.Data.DbModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IRandevuService
    {
        Result<List<Randevu>> GetAllRandevu();
    }
}
