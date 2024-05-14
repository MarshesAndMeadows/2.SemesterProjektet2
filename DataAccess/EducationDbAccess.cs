using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EducationDbAccess
    {
        SqlDbContext db;

        public EducationDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Education newEducation)
        {
            await db.Educations.AddAsync(newEducation);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Education>> GetAllAsync()
        {
            return await db.Educations
                .Include(m => m.Lawyer)
                .ToListAsync();
        }

        public async Task<Education> GetOneAsync(int id)
        {
            return await db.Educations
                .Include(m => m.Lawyer)
                .FirstOrDefaultAsync(Education => Education.Id == id);
        }

        // Update
        public async Task<bool> UpdateEducationAsync(int id, Education updatedEducation)
        {
            if (!(GetOneAsync(id) == null))
            {
                Education tempEducation = await db.Educations.FirstOrDefaultAsync(Education => Education.Id == id);
                tempEducation = updatedEducation;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Delete
        public async Task<bool> DeleteEducationAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.Educations.Remove(await db.Educations.FirstAsync(Education => Education.Id == id));
                return true;
            }
            return false;
        }
    }
}
