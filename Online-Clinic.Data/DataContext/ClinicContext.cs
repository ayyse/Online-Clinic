using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Data.DataContext
{
    public class ClinicContext : IdentityDbContext
    {

        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
            
        }
        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<Doktor> Doktorlar { get; set; }

        public DbSet<Hasta> Hastalar { get; set; }

        public DbSet<Bağışçı> Bağışçılar { get; set; }

        public DbSet<BağışTalebi> BağışTalepleri { get; set; }

        public DbSet<Randevu> Randevular { get; set; }
    }
}
