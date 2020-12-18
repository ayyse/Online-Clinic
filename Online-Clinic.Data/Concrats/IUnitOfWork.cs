using System;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {

        IBağışTalebiRepository bağışTalebi { get; }
        IRandevuRepository randevuRepository { get; }
        IBağışçıRepository bağışçıRepository { get; }
        IDoktorRepository doktorRepository { get; }
        IHastaRepository hastaRepository { get; }
        void Save();
    }
}
