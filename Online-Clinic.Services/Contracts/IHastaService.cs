using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Services.Contracts
{
    public interface IHastaService
    {
        Result<List<HastaVM>> GetAllHasta();

        Result<HastaVM> Register(HastaVM model);
    }
}
