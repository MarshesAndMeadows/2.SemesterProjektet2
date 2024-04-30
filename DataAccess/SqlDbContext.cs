using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Models;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<WorksOn> WorksOn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string conString = ConfigurationManager.ConnectionStrings["MatiasHome"].ConnectionString; - Kan ikke få den til at forbinde med min app.config fil... (Matias)

            optionsBuilder.UseSqlServer("Server=DESKTOP-DGD9QGL; Database=LawHouseDB;Integrated Security=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}