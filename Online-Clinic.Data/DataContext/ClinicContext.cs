﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Data.DataContext
{
    public class ClinicContext : IdentityDbContext
    {
        public ClinicContext()
        {
        }

        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
            
        }

        public DbSet<BağışTalebi> HastaBağışTalepleri { get; set; }

        public DbSet<Randevu> Randevular { get; set; }

    }
}
