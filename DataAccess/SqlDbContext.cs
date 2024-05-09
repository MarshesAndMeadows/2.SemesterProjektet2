using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Models;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Models.Case> Cases { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<AppliedService> AppliedServices { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<LawyerEducation> LawyerEducations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DGD9QGL; Database=LawHouseDB;Integrated Security=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}