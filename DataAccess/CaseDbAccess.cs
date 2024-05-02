using Microsoft.EntityFrameworkCore;
using Models;
using System.ComponentModel;

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



    }
}