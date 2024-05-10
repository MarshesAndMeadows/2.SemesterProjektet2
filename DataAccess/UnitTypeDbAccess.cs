using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitTypeDbAccess
    {
        SqlDbContext db;

        public UnitTypeDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(UnitType unitType)
        {
            await db.UnitTypes.AddAsync(unitType);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<UnitType>> GetAllAsync()
        {
            return await db.UnitTypes.ToListAsync();
        }

        public async Task<UnitType> GetOneAsync(int id)
        {
            return await db.UnitTypes.FirstOrDefaultAsync(Unittype => Unittype.Id == id);
        }

        // Update
        public async Task<bool> UpdateUnitTypeAsync(int id, UnitType updatedUnitType)
        {
            if (!(GetOneAsync(id) == null))
            {
                UnitType tempUnitType = await db.UnitTypes.FirstOrDefaultAsync(Unittype => Unittype.Id == id);
                tempUnitType = updatedUnitType;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Delete
        public async Task<bool> DeleteUnitTypeAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.UnitTypes.Remove(await db.UnitTypes.FirstOrDefaultAsync(Unittype => Unittype.Id == id));
                return true;
            }
            return false;
        }
    }
}