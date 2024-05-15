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
            if (await db.Clients.FindAsync(newCase.Client.ID) != null)
            {
                db.Clients.Attach(newCase.Client);
            }
            if (await db.Employees.FindAsync(newCase.Employee.Id) != null)
            {
                db.Employees.Attach(newCase.Employee);
            }

            try
            {
                await db.Cases.AddAsync(newCase);
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Get (Read)
        public async Task<List<Case>> GetAllAsync()
        {
            return await db.Cases
                .Include(m => m.Employee)
                .Include(m => m.Client)
                .Include(m => m.AppliedServices)
                .ToListAsync();
        }

        public async Task<Case> GetOneAsync(int id)
        {
            return await db.Cases
                .Include(m => m.Employee)
                .Include(m => m.Client)
                .Include(m => m.AppliedServices)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Case updatedCase)
        {
            if (!(GetOneAsync(id) == null))
            {
                Case tempCase = await db.Cases.FirstOrDefaultAsync(Case => Case.Id == id);
                tempCase = updatedCase;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Delete
        public async Task<bool> DeleteAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.Cases.Remove(await db.Cases.FirstAsync(Case => Case.Id == id));
                return true;
            }
            return false;
        }

        // ---------------------------------------------------------

    }
}




