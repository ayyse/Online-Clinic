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
    public class BağışçıService : IBağışçıService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BağışçıService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Result<List<BağışçıVM>> GetAllBağışçı()
        {
            var data = _unitOfWork.bağışçıRepository.GetAll().ToList();
            var bağışçılar = _mapper.Map<List<Bağışçı>, List<BağışçıVM>>(data);
            return new Result<List<BağışçıVM>>(true, "Başarılı", bağışçılar);
        }

        public Result<BağışçıVM> Register(BağışçıVM model)
        {
            if (model != null)
            {
                try
                {
                    var bağışçı = _mapper.Map<BağışçıVM, Bağışçı>(model);
                    _unitOfWork.bağışçıRepository.Add(bağışçı);
                    _unitOfWork.Save();
                    return new Result<BağışçıVM>(true, "Kaydınız başarılı.");
                }
                catch (Exception ex)
                {
                    return new Result<BağışçıVM>(false, "Kayıt olurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<BağışçıVM>(false, "Boş Olamaz");
        }
    }
}
