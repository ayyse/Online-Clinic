using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class RandevuRepository : Repository<Randevu>, IRandevuRepository
    {
        private readonly ClinicContext _ctx;

        public RandevuRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
