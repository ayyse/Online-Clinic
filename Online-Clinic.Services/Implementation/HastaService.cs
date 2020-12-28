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
    public class HastaService : IHastaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HastaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Result<List<HastaVM>> GetAllHasta()
        {
            var data = _unitOfWork.hastaRepository.GetAll().ToList();
            var doktorlar = _mapper.Map<List<Hasta>, List<HastaVM>>(data);
            return new Result<List<HastaVM>>(true, "Başarılı", doktorlar);
        }

        public Result<HastaVM> Register(HastaVM model)
        {
            if (model != null)
            {
                try
                {
                    var hasta = _mapper.Map<HastaVM, Hasta>(model);
                    _unitOfWork.hastaRepository.Add(hasta);
                    _unitOfWork.Save();
                    return new Result<HastaVM>(true, "Kaydınız başarılı.");

                }
                catch (Exception ex)
                {
                    return new Result<HastaVM>(false, "Kayıt olurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<HastaVM>(false, "Boş Olamaz");
        }
    }
}
