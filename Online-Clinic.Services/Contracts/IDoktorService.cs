﻿using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System.Collections.Generic;

namespace Online_Clinic.Services.Contracts
{
    public interface IDoktorService
    {
        Result<List<DoktorVM>> GetAllDoktor();

        //Result<DoktorVM> Register(DoktorVM model);
    }
}
