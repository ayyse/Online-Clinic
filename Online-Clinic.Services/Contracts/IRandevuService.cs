using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IRandevuService
    {
        Result<List<RandevuVM>> GetAllRandevu(string userId);

        Result<RandevuVM> CreateRandevu(RandevuVM model, SessionContext user);
    }
}
