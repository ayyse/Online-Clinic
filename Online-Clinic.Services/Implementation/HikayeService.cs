using AutoMapper;
using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Clinic.Services.Implementation
{
    public class HikayeService : IHikayeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HikayeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<List<HikayeVM>> GetAllHikaye()
        {
            var data = _unitOfWork.hikayeRepository.GetAll().ToList();
            var hikayeler = _mapper.Map<List<Hikaye>, List<HikayeVM>>(data);
            return new Result<List<HikayeVM>>(true, "Başarılı", hikayeler);

        }

        public Result<HikayeVM> CreateHikaye(HikayeVM model)
        {
            if (model != null)
            {
                try
                {
                    var hikaye = _mapper.Map<HikayeVM, Hikaye>(model);
                    _unitOfWork.hikayeRepository.Add(hikaye);
                    _unitOfWork.Save();
                    return new Result<HikayeVM>(true, "Hikaye işleminiz başarılı.");
                }
                catch (Exception ex)
                {
                    return new Result<HikayeVM>(false, "Hikaye oluşturulurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<HikayeVM>(false, "Boş Olamaz");
        }
    }
}
