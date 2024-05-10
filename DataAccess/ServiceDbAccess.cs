using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDbAccess
    {
        SqlDbContext db;

        public ServiceDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Service newService)
        {
            await db.Services.AddAsync(newService);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Service>> GetAllAsync()
        {
            return await db.Services.ToListAsync();
        }

        public async Task<Service> GetOneAsync(int id)
        {
            return await db.Services.FirstOrDefaultAsync(Service => Service.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Service updatedService)
        {
            if (!(GetOneAsync(id) == null))
            {
                Service tempService = await db.Services.FirstOrDefaultAsync(Service => Service.Id == id);
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
                db.Services.Remove(await db.Services.FirstAsync(Service => Service.Id == id));
                return true;
            }
            return false;
        }
    }
}
