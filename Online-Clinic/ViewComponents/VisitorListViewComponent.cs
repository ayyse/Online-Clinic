using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.ViewComponents
{
    public class VisitorListViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VisitorListViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var data = _unitOfWork.visitorRepository.GetAll(e => e.IsActive == true && e.IsAdmin != true).ToList();

            if (data != null)
            {
                var mappingData = _mapper.Map<List<Visitor>, List<VisitorVM>>(data);
                ViewBag.EmployeeList = mappingData;
                return View(mappingData);
            }
            return View();
        }
    }
}
