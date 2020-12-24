using AutoMapper;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Services.Contracts;

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
    }
}
