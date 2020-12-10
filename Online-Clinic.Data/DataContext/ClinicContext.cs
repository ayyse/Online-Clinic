using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.Data.DbModels;
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

        public DbSet<Doktor> Doktorlar { get; set; }

        public DbSet<Hasta> Hastalar { get; set; }

        public DbSet<Bağışçı> Bağışçılar { get; set; }

        public DbSet<BağışTalebi> HastaBağışTalepleri { get; set; }
        public DbSet<Randevu> Randevular { get; set; }

    }
}
