using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class HikayeRepository : Repository<Hikaye>, IHikayeRepository
    {
        private readonly ClinicContext _ctx;

        public HikayeRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
