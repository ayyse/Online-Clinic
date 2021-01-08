using AutoMapper;
using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Services.Contracts
{
    public class TalepOnayService : ITalepOnayService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TalepOnayService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<BağışTalebiVM> GetSendTalepOnayı()
        {
            throw new NotImplementedException();
        }
    }
}
