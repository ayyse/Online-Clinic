using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IBağışçıService
    {
        Result<List<BağışçıVM>> GetAllBağışçı();

        Result<BağışçıVM> Register(BağışçıVM bağışçı);
    }
}
