using Online_Clinic.Common.ResultModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using Online_Clinic.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Clinic.Services.Implementation
{
    public class RandevuService : IRandevuService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RandevuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Result<List<Randevu>> GetAllRandevu()
        {
            var data = _unitOfWork.randevu.GetAll().ToList();


            List<Randevu> returnData = new List<Randevu>();
            if (data != null)
            {
                foreach (var item in data)
                {
                    returnData.Add(new Randevu()
                    {
                        Id = item.Id,
                        Doktor = item.Doktor,
                        Tarih = item.Tarih,
                        Saat = item.Saat

                    });
                }
                return new Result<List<Randevu>>(true, "İşleminiz başarılı...", returnData);
            }
            else
                return new Result<List<Randevu>>(false, "Veri bulunamadı");
        }
    }
}
