using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {

        IBağışTalebiRepository bağışTalebi { get; }

        IRandevuRepository randevuRepository { get; }
        void Save();
    }
}
