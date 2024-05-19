using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using UIModels;

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
            if (await db.Clients.FindAsync(newCase.Client.ID) != null)
            {
                db.Clients.Attach(newCase.Client);
            }
            if (await db.Employees.FindAsync(newCase.Employee.Id) != null)
            {
                db.Employees.Attach(newCase.Employee);
            }

            try
            {
                await db.Cases.AddAsync(newCase);
            }
            catch (Exception)
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
        public async Task<bool> UpdateAsync(int id, Case updatedCase)
        {
            using SqlDbContext dbLocal = new SqlDbContext(); // "Using" anvendes for at sikre 'dbLocal' bliver Korrekt disposed.
            // Derudover oprettes der en lokal instans af DbContext, for at undgå komplikationer med uhensigtsmæssig sporing fra EF.

            bool caseFound = await dbLocal.Cases.AnyAsync(c => c.Id == updatedCase.Id); // ".Any" for at finde et match på Id'et.
            if (caseFound)
            {
                dbLocal.Cases.Update(updatedCase); // ".Update" fordi vi ønsker at update hele entiteten inkl. sub-entiteter.
                await dbLocal.SaveChangesAsync();
                return true;
            }
            return false;
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




