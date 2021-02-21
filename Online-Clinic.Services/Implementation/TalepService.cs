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
    public class TalepService : ITalepService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TalepService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        public Result<List<BağışTalebiVM>> GetAllTalep(string userId)
        {
            var data = _unitOfWork.bağışTalebiRepository.GetAll(u => u.HastaID == userId).ToList();
            var talepler = _mapper.Map<List<BağışTalebi>, List<BağışTalebiVM>>(data);
            return new Result<List<BağışTalebiVM>>(true, "Başarılı", talepler);

        }

        public Result<BağışTalebiVM> CreateTalep(BağışTalebiVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var talep = _mapper.Map<BağışTalebiVM, BağışTalebi>(model);
                    talep.TalepTarihi = DateTime.Now;
                    talep.HastaID = user.LoginID;
                    _unitOfWork.bağışTalebiRepository.Add(talep);
                    _unitOfWork.Save();
                    return new Result<BağışTalebiVM>(true, "Randevu işleminiz başarılı.");
                }
                catch (Exception ex)
                {
                    return new Result<BağışTalebiVM>(false, "Randevu oluşturulurken bir hata oluştu." + ex.Message.ToString());
                }
            }
            else
                return new Result<BağışTalebiVM>(false, "Boş Olamaz");
        }

        




        //public Result<List<BağışTalebiVM>> GetAllTalepByUserId(string userId)
        //{
        //    var data = _unitOfWork.bağışTalebiRepository.GetAll(u => u.HastaID == userId, includeProperties:"Hasta").ToList();

        //    if (data != null)
        //    {
        //        List<BağışTalebiVM> returnData = new List<BağışTalebiVM>();
        //        foreach (var item in data)
        //        {
        //            returnData.Add(new BağışTalebiVM()
        //            {
        //                TalepID = item.TalepID,
        //                Onay = item.Onay,
        //                İptal = item.İptal,
        //                //HastaID = item.HastaID,
        //                TalepTarihi = item.TalepTarihi,
        //                //AdminID = item.AdminID,
        //                TalepAçıklaması = item.TalepAçıklaması
        //            });
        //        }
        //        return new Result<List<BağışTalebiVM>>(true, "Başarılı", returnData);
        //    }
        //    else
        //        return new Result<List<BağışTalebiVM>>(false, "Başarısız.");
        //}


        //public Result<BağışTalebiVM> CreateBağışTalebi(BağışTalebiVM model, SessionContext user)
        //{
        //    if (model != null)
        //    {
        //        try
        //        {
        //            var talep = _mapper.Map<BağışTalebiVM, BağışTalebi>(model);
        //            //talep.HastaID = user.LoginID;
        //            talep.İptal = false;
        //            talep.TalepTarihi = DateTime.Now;

        //            _unitOfWork.bağışTalebiRepository.Add(talep);
        //            _unitOfWork.Save();
        //            return new Result<BağışTalebiVM>(true, "Talep işleminiz başarılı.");
        //        }
        //        catch (Exception ex)
        //        {
        //            return new Result<BağışTalebiVM>(false, "Talep oluşturulurken bir hata oluştu." + ex.Message.ToString());
        //        }
        //    }
        //    else
        //        return new Result<BağışTalebiVM>(false, "Boş Olamaz");
        //}
    }
}
