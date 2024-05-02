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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BO1PTSK; Database=LawHouseDB;Integrated Security=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}



/*string conString = ConfigurationManager.ConnectionStrings["Matias"].ConnectionString;*/



/* using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public async Task UpdateCaseAsync(Case updatedCase)
{
    try
    {
        _dbContext.Cases.Attach(updatedCase); // Knyt det opdaterede objekt til DbContext'en
        _dbContext.Entry(updatedCase).State = EntityState.Modified; // Angiv ændringen til DbContext'en

        await _dbContext.SaveChangesAsync(); // Gem ændringerne i databasen
    }
    catch (Exception ex)
    {
        // Håndter fejl
    }
}

I dette eksempel bliver Attach metoden brugt til at knytte det opdaterede objekt til DbContext'en, og derefter bliver Entry.State angivet til EntityState.Modified, 
hvilket fortæller DbContext'en, at objektet er blevet ændret og skal opdateres i databasen. Til sidst kaldes SaveChangesAsync() metoden for at gemme ændringerne i databasen.
*/