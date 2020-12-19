using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Services.Implementation
{
    public class DoktorService : IDoktorService
    {
        public Result<List<DoktorVM>> GetAllDoktor()
        {
            throw new NotImplementedException();
        }

        public Result<DoktorVM> Register(DoktorVM doktor)
        {
            throw new NotImplementedException();
        }
    }
}
