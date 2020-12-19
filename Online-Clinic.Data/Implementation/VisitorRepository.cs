using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class VisitorRepository : Repository<Visitor>, IVisitorRepository
    {
        private readonly ClinicContext _ctx;

        public VisitorRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
