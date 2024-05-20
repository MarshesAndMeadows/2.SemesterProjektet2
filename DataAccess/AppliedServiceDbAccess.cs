using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class AppliedServiceDbAccess
    {
        SqlDbContext db;

        public AppliedServiceDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(AppliedService newService)
        {
            await db.AppliedServices.AddAsync(newService);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<AppliedService>> GetAllAsync()
        {
            return await db.AppliedServices
                .Include(m => m.Service)
                .Include(m => m.Lawyer)
                .ToListAsync();
        }

        public async Task<AppliedService> GetOneAsync(int id)
        {
            return await db.AppliedServices
                .Include(m => m.Service)
                .Include(m => m.Lawyer)
                .FirstOrDefaultAsync(Service => Service.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, AppliedService updatedService)
        {
            if (!(GetOneAsync(id) == null))
            {
                AppliedService tempService = await db.AppliedServices.FirstOrDefaultAsync(Service => Service.Id == id);
                tempService = updatedService;
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
                db.AppliedServices.Remove(await db.AppliedServices.FirstAsync(Service => Service.Id == id));
                return true;
            }
            return false;
        }
    }
}
