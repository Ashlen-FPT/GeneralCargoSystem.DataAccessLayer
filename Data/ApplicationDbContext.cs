using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GeneralCargoSystem.Models;
using GeneralCargoSystem.Models.GC;
using Microsoft.AspNetCore.Identity;

namespace GeneralCargoSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=DBN-LP-ANAIDOO\\SQLEXPRESS;Database=GeneralCargoSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    }
        //}

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Vessels> Vessels { get; set; }
        public DbSet<LogisticalTransporter> LogisticalTransporters { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<GCBooking> GCBookings { get; set; }
        public DbSet<FPTSites> FPTSites { get; set; }
    }
}