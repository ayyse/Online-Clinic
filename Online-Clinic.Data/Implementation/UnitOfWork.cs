using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;

namespace Online_Clinic.Data.Implementation
{
    public class UnitOFWork : IUnitOfWork
    {
        private readonly ClinicContext _ctx;

        public UnitOFWork(ClinicContext ctx)
        {
            _ctx = ctx;
            bağışTalebi = new BağışTalebiRepository(_ctx);
            randevu = new RandevuRepository(_ctx);
        }

        public IBağışTalebiRepository bağışTalebi { get; private set; }

        public IRandevuRepository randevu { get; private set; }

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
