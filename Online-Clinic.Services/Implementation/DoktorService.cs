using AutoMapper;
using Online_Clinic.Common.ResultModels;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Clinic.Services.Implementation
{
    public class DoktorService : IDoktorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoktorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<List<DoktorVM>> GetAllDoktor()
        {
            var data = _unitOfWork.doktorRepository.GetAll().ToList();
            var doktorlar = _mapper.Map<List<Doktor>, List<DoktorVM>>(data);
            return new Result<List<DoktorVM>>(true, "Başarılı", doktorlar);
        }

        public Result<DoktorVM> Register(DoktorVM model)
        {
            if (model != null)
            {
                try
                {
                    var doktor = _mapper.Map<DoktorVM, Doktor>(model);
                    _unitOfWork.doktorRepository.Add(doktor);
                    _unitOfWork.Save();
                    return new Result<DoktorVM>(true, "Kaydınız başarılı.");
                }
                catch (Exception ex)
                {
                    return new Result<DoktorVM>(false, "Kayıt olurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<DoktorVM>(false, "Boş Olamaz");
        }
    }
}
