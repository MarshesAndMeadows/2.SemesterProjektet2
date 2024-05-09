using Microsoft.EntityFrameworkCore;
using Models;
using System.ComponentModel;
using UIModels;

namespace DataAccess
{
    public class CaseDbAccess
    {
        SqlDbContext db;

        public CaseDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Case newCase)
        {
            await db.Cases.AddAsync(newCase);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Case>> GetAllAsync()
        {
            return await db.Cases.ToListAsync();
        }

        public async Task<Case> GetOneAsync(int id)
        {
            return await db.Cases.FirstOrDefaultAsync(c => c.CaseId == id);
        }

        // Update


        // Delete

        // ------------ Test, Skal slettes fra Master (Matias) ------------------
        public async Task CreateEmployeeAsync(Employee newEmployee)
        {
            await db.Employees.AddAsync(newEmployee);
            await db.SaveChangesAsync();
        }
        public async Task CreateLawyerAsync(Lawyer newLawyer)
        {
            await db.Employees.AddAsync(newLawyer);
            await db.SaveChangesAsync();
        }


        public async Task<Lawyer> GetOneLawyerAsync(int id)
        {
            return await db.Lawyers.FirstOrDefaultAsync(l => l.EmployeeId == id);
        }

        public async Task<Employee> GetOneEmployeeAsync(int id)
        {
            return await db.Employees.FirstOrDefaultAsync(l => l.EmployeeId == id);
        }

        // ---------------------------------------------------------

    }
}