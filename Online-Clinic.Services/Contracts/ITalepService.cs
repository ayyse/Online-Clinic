using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Services.Contracts
{
    public interface ITalepService
    {
        Result<List<BağışTalebiVM>> GetAllTalep();

        Result<BağışTalebiVM> CreateTalep(BağışTalebiVM model);


        //Result<List<BağışTalebiVM>> GetAllTalepByUserId(string userId);
        //Result<BağışTalebiVM> CreateBağışTalebi(BağışTalebiVM model, SessionContext user);
    }
}
