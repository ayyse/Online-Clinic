using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class BağışTalebiRepository : Repository<BağışTalebi>, IBağışTalebiRepository
    {
        private readonly ClinicContext _ctx;

        public BağışTalebiRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
