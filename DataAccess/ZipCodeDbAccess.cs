using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ZipCodeDbAccess
    {
        SqlDbContext db;

        public ZipCodeDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Zipcode zipCode)
        {
            await db.Zipcodes.AddAsync(zipCode);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Zipcode>> GetAllAsync()
        {
            return await db.Zipcodes.ToListAsync();
        }

        public async Task<Zipcode> GetOneAsync(int id)
        {
            return await db.Zipcodes.FirstOrDefaultAsync(Zipcode => Zipcode.Id == id);
        }

        // Update
        public async Task<bool> UpdateZipcodeAsync(int id, Zipcode updatedZip)
        {
            if (!(GetOneAsync(id) == null))
            {
                Zipcode tempZip= await db.Zipcodes.FirstOrDefaultAsync(Zipcode => Zipcode.Id == id);
                tempZip = updatedZip;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Delete
        public async Task<bool> DeleteZipcodeAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.Zipcodes.Remove(await db.Zipcodes.FirstAsync(Zipcode => Zipcode.Id == id));
                return true;
            }
            return false;
        }


    }
}
