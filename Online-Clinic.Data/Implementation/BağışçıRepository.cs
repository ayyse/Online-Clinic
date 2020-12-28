using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class BağışçıRepository : Repository<Bağışçı>, IBağışçıRepository
    {
        private readonly ClinicContext _ctx;

        public BağışçıRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
