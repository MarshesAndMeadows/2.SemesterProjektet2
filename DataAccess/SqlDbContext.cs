using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Models;
using UIModels;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<AppliedService> AppliedServices { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Zipcode> Zipcodes { get; set; }
        public DbSet<Models.Case> Cases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Michael-PC;Database=LawHouseDB;Trusted_Connection=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
 
        public async Task ClearAllDataAsync()
        {
            await ClearDbSetAsync(AppliedServices);
            await ClearDbSetAsync(Services);
            await ClearDbSetAsync(Clients);
            await ClearDbSetAsync(Cases);
            await ClearDbSetAsync(Employees);
            await ClearDbSetAsync(Lawyers);
            await ClearDbSetAsync(Educations);
            await ClearDbSetAsync(UnitTypes);
            await ClearDbSetAsync(Zipcodes);
        }

        private async Task ClearDbSetAsync<TEntity>(DbSet<TEntity> dbSet) where TEntity : class
        {
            var entities = await dbSet.ToListAsync();

            foreach (var entity in entities)
            {
                Entry(entity).State = EntityState.Detached;
            }

            dbSet.RemoveRange(entities);
            await SaveChangesAsync();
        }
    }
}

/* protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     // konfigurer TPT (Table-Per-Type) nedarvning til Employee og Lawyer, istedet for TPH (Table-Per-Inheritance)
     base.OnModelCreating(modelBuilder);

     modelBuilder.Entity<Employee>().ToTable("Employees");
     modelBuilder.Entity<Lawyer>().ToTable("Lawyers");
 }*/