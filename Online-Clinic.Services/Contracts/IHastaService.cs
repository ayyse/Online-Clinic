using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IHastaService
    {
        Result<List<HastaVM>> GetAllHasta();

        Result<HastaVM> Register(HastaVM model);
    }
}
