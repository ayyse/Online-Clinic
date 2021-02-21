using AutoMapper;
using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.SessionOperations;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Clinic.Services.Implementation
{
    public class RandevuService : IRandevuService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RandevuService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public Result<List<RandevuVM>> GetAllRandevu(string userId)
        {
            var data = _unitOfWork.randevuRepository.GetAll(u => u.HastaID == userId).ToList();
            var randevular = _mapper.Map<List<Randevu>, List<RandevuVM>>(data);
            return new Result<List<RandevuVM>>(true, "Başarılı", randevular);

        }

        public Result<RandevuVM> CreateRandevu(RandevuVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var randevu = _mapper.Map<RandevuVM, Randevu>(model);
                    randevu.HastaID = user.LoginID;
                    _unitOfWork.randevuRepository.Add(randevu);
                    _unitOfWork.Save();
                    return new Result<RandevuVM>(true, "Randevu işleminiz başarılı.");
                }
                catch (Exception ex)
                {
                    return new Result<RandevuVM>(false, "Randevu oluşturulurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<RandevuVM>(false, "Boş Olamaz");
        }
    }
}
