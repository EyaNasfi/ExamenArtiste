using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var _connectionString = @"server=localhost;database=NasfiEyaConcert;uid=root;password=;";
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConcertConfig());
            //modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveMaxLength(50);
        }


        public DbSet<Chanson> Chanson { get; set; }
        public DbSet<Artiste> Artiste { get; set; }
        public DbSet<Concert> Concert { get; set; }
        public DbSet<Festival> Festival { get; set; }
        //public DbSet<Staff> Staff { get; set; }

    }
}
