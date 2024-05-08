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
            await db.Clients.AddAsync(newClient);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Client>> GetAllAsync()
        {
            return await db.Clients.ToListAsync();
        }

        public async Task<Client> GetOneAsync(int id)
        {
            return await db.Clients.FirstOrDefaultAsync(c => c.ClientId == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Client updatedClient)
        {
            if (!(GetOneAsync(id) == null))
            {
                Client tempClient = await db.Clients.FirstOrDefaultAsync(Client => Client.ClientId == id);
                tempClient = updatedClient;
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
                db.Clients.Remove(await db.Clients.FirstAsync(Client => Client.ClientId == id));
                return true;
            }
            return false;
        }
    }
}
