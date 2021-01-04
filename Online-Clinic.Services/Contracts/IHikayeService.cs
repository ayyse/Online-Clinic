using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IHikayeService
    {
        Result<List<HikayeVM>> GetAllHikaye();

        Result<HikayeVM> CreateHikaye(HikayeVM model);
    }
}
