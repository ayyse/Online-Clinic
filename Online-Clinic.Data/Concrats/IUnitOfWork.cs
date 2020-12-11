using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
