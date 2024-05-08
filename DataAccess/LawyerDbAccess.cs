using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await db.Lawyers.ToListAsync();
        }

        public async Task<Lawyer> GetOneAsync(int id)
        {
            return await db.Lawyers.FirstOrDefaultAsync(Lawyer => Lawyer.EmployeeId == id);
        }

        // Update
        public async Task<bool> UpdateLawyerAsync(int id, Lawyer updatedLawyer)
        {
            if (!(GetOneAsync(id) == null))
            {
                Lawyer tempLawyer= await db.Lawyers.FirstOrDefaultAsync(Lawyer => Lawyer.EmployeeId == id);
                tempLawyer = updatedLawyer;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Delete
        public async Task<bool> DeleteLawyerAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.Lawyers.Remove(await db.Lawyers.FirstAsync(Lawyer => Lawyer.EmployeeId == id));
                return true;
            }
            return false;
        }
    }
}
