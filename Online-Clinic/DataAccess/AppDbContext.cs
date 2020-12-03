using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.DataAccess
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Bağışçı> Bağışçılar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.; initial catalog=MyNewDb; integrated security=true");
            //optionsBuilder.UseSqlServer(@"server=LAPTOP-E9A13GPT; initial catalog=MyNewDb; integrated security=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Doktor>().ToTable("Doktorlar");
        //    modelBuilder.Entity<Doktor>().Property(doktor => doktor.DoktorID);
        //    modelBuilder.Entity<Doktor>().Property(doktor => doktor.AdSoyad);

        //    modelBuilder.Entity<Hasta>().ToTable("Hastalar");
        //    modelBuilder.Entity<Hasta>().Property(hasta => hasta.HastaID);
        //    modelBuilder.Entity<Hasta>().Property(hasta => hasta.AdSoyad);

        //    modelBuilder.Entity<Bağışçı>().ToTable("Bağışçılar");
        //    modelBuilder.Entity<Bağışçı>().Property(bağışçı => bağışçı.BağışçıID);
        //    modelBuilder.Entity<Bağışçı>().Property(bağışçı => bağışçı.AdSoyad);

        //}
    }
}
