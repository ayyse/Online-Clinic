﻿using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.Implementation
{
    public class DoktorRepository : Repository<Doktor>, IDoktorRepository
    {
        private readonly ClinicContext _ctx;

        public DoktorRepository(ClinicContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
