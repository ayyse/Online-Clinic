using System;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {

        IBağışTalebiRepository bağışTalebiRepository { get; }
        IRandevuRepository randevuRepository { get; }
        IHikayeRepository hikayeRepository { get; }
        IVisitorRepository visitorRepository { get; }

        void Save();
    }
}
