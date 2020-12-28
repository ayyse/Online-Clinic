using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class HastaRepository : Repository<Hasta>, IHastaRepository
    {
        private readonly ClinicContext _ctx;

        public HastaRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
