using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DbModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Online_Clinic.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserNameViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userFromDb = _unitOfWork.visitorRepository.GetFirstorDefault(u => u.Id == claims.Value);

            var visitorToDb = _mapper.Map<Visitor, VisitorVM>(userFromDb);

            return View(visitorToDb);
        }
    }
}
