using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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
