using System;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {

        IBağışTalebiRepository bağışTalebiRepository { get; }
        IRandevuRepository randevuRepository { get; }
        IVisitorRepository visitorRepository { get; }
        IDoktorRepository doktorRepository { get; }
        IBağışçıRepository bağışçıRepository { get; }
        IHastaRepository hastaRepository { get; }



        void Save();
    }
}
