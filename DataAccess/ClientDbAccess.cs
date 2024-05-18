using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientDbAccess
    {
        SqlDbContext db;

        public ClientDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Client newClient)
        {
            try
            {
                await db.Clients.AddAsync(newClient);
            }
            catch (OperationCanceledException)
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
        public async Task<List<Client>> GetAllAsync()
        {
            return await db.Clients
                .Include(m => m.Cases)
                .ToListAsync();
        }

        public async Task<Client> GetOneAsync(int id)
        {
            return await db.Clients
                .Include(m => m.Cases)
                .FirstOrDefaultAsync(c => c.ID == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Client updatedClient)
        {
            if (!(await GetOneAsync(id) == null))
            {
                Client tempClient = await db.Clients.FirstOrDefaultAsync(Client => Client.ID == id);
                tempClient = updatedClient;

                db.Entry(tempClient).State = EntityState.Modified; // <----- Vi skal gøre EF opmærksom på ændringen, fordi vi bruger ".NoTracking"
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
                db.Clients.Remove(await db.Clients.FirstAsync(Client => Client.ID == id));
                return true;
            }
            return false;
        }
    }
}
