﻿using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Services.Contracts
{
    public interface ITalepOnayService
    {
        Result<BağışTalebiVM> GetSendTalepOnayı();
    }
}
