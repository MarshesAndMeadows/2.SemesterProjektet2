using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDbAccess
    {
        SqlDbContext db;

        public EmployeeDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(Employee newEmployee)
        {
            await db.Employees.AddAsync(newEmployee);
            await db.SaveChangesAsync();
        }

        // Get (Read)
        public async Task<List<Employee>> GetAllAsync()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task<Employee> GetOneAsync(int id)
        {
            return await db.Employees.FirstOrDefaultAsync(Employee => Employee.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, Employee updatedEmployee)
        {
            if (!(GetOneAsync(id) == null))
            {
                Employee tempEmployee = await db.Employees.FirstOrDefaultAsync(Employee => Employee.Id == id);
                tempEmployee = updatedEmployee;
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
                db.Employees.Remove(await db.Employees.FirstAsync(Employee => Employee.Id == id));
                return true;
            }
            return false;
        }
    }
}
