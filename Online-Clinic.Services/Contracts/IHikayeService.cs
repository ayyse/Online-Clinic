using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IHikayeService
    {
        Result<List<HikayeVM>> GetAllHikaye(string userId);

        Result<HikayeVM> CreateHikaye(HikayeVM model, SessionContext user);
    }
}
