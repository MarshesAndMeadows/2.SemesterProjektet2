using DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class CaseDbAccess
    {
        SqlDbContext db;

        public CaseDbAccess()
        {
            db = new SqlDbContext();
        }

        public async Task CreateAsync(Case newCase)
        {
            using SqlDbContext dbLocal = new SqlDbContext();

            try
            {
                if (await dbLocal.Clients.FindAsync(newCase.Client.ID) != null)
                {
                    dbLocal.Clients.Attach(newCase.Client);
                }
                if (await dbLocal.Employees.FindAsync(newCase.Employee.Id) != null)
                {
                    dbLocal.Employees.Attach(newCase.Employee);
                }

                await dbLocal.Cases.AddAsync(newCase);
                await dbLocal.SaveChangesAsync();
            }
            catch (SqlException e)
            { /*Send en besked til UI for at specificer problemer med SQL forbindelsen.*/ }
            catch (Exception e) 
            { /*Send en besked til UI.*/ }
        }

        // Get (Read)
        public async Task<List<Case>> GetAllAsync()
        {
            return await db.Cases
                .Include(m => m.Employee)
                .Include(m => m.Client)
                .Include(m => m.AppliedServices)
                .ToListAsync();
        }

        public async Task<Case> GetOneAsync(int id)
        {
            return await db.Cases
                .Include(m => m.Employee)
                .Include(m => m.Client)
                .Include(m => m.AppliedServices)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(Case updatedCase)
        {
            using SqlDbContext dbLocal = new SqlDbContext(); // "Using" anvendes for at sikre 'dbLocal' bliver Korrekt disposed.
            try                                             // Derudover oprettes der en lokal instans af DbContext, for at undgå komplikationer med uhensigtsmæssig sporing fra EF.
            {
                bool caseFound = await dbLocal.Cases.AnyAsync(c => c.Id == updatedCase.Id); // ".Any" for at finde et match på Id'et.
                if (caseFound)
                {
                    dbLocal.Cases.Update(updatedCase); // ".Update" fordi vi ønsker at update hele entiteten inkl. sub-entiteter.
                    await dbLocal.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            { return false; /*Send en besked til UI.*/ }
        }

        // Delete
        public async Task<bool> DeleteAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                db.Cases.Remove(await db.Cases.FirstAsync(Case => Case.Id == id));
                return true;
            }
            return false;
        }

        // ---------------------------------------------------------

    }
}