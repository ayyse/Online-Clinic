using System;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {

        IBağışTalebiRepository bağışTalebi { get; }
        IRandevuRepository randevuRepository { get; }
        IVisitorRepository visitorRepository { get; }
        IDoktorRepository doktorRepository { get; }

        void Save();
    }
}
