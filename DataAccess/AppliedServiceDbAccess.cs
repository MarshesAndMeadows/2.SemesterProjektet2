using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await db.AppliedServices.ToListAsync();
        }

        public async Task<AppliedService> GetOneAsync(int id)
        {
            return await db.AppliedServices.FirstOrDefaultAsync(Service => Service.Id == id);
        }

        // Update
        public async Task<bool> UpdateAppliedServiceAsync(int id, AppliedService updatedService)
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
        public async Task<bool> DeleteAppliedServiceAsync(int id)
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
