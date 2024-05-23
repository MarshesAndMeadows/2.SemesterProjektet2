using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class LawyerDbAccess
    {
        SqlDbContext db;

        public LawyerDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Lawyer newLawyer)
        {
            await db.Lawyers.AddAsync(newLawyer);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Lawyer>> GetAllAsync()
        {
            return await db.Lawyers
                .Include(m => m.AppliedServices)
                .Include(m => m.Educations)
                .ToListAsync();
        }

        public async Task<Lawyer> GetOneAsync(int id)
        {
            return await db.Lawyers
                .Include(m => m.AppliedServices)
                .Include(m => m.Educations)
                .FirstOrDefaultAsync(Lawyer => Lawyer.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Lawyer updatedLawyer)
        {
            if (!(GetOneAsync(id) == null))
            {
                Lawyer tempLawyer= await db.Lawyers.FirstOrDefaultAsync(Lawyer => Lawyer.Id == id);
                tempLawyer = updatedLawyer;
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
                db.Lawyers.Remove(await db.Lawyers.FirstAsync(Lawyer => Lawyer.Id == id));
                return true;
            }
            return false;
        }
    }
}
