using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.DbModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IRandevuService
    {
        Result<List<RandevuVM>> GetAllRandevu();

        Result<RandevuVM> CreateRandevu(RandevuVM model);
    }
}
