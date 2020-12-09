using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Data.DataContext
{
    public class ClinicContext : IdentityDbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
            
        }

    }
}
