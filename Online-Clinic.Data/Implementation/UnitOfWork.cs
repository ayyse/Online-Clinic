using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;

namespace Online_Clinic.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicContext _ctx;

        public UnitOfWork(ClinicContext ctx)
        {
            _ctx = ctx;
            bağışTalebiRepository = new BağışTalebiRepository(_ctx);
            randevuRepository = new RandevuRepository(_ctx);
            visitorRepository = new VisitorRepository(_ctx);
            doktorRepository = new DoktorRepository(_ctx);
            hastaRepository = new HastaRepository(_ctx);
            bağışçıRepository = new BağışçıRepository(_ctx);
            hikayeRepository = new HikayeRepository(_ctx);
        }

        public IBağışTalebiRepository bağışTalebiRepository { get; private set; }
        public IRandevuRepository randevuRepository { get; private set; }
        public IVisitorRepository visitorRepository { get; private set; }
        public IDoktorRepository doktorRepository { get; private set; }
        public IBağışçıRepository bağışçıRepository { get; private set; }
        public IHastaRepository hastaRepository { get; private set; }
        public IHikayeRepository hikayeRepository { get; private set; }



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
