using Microsoft.EntityFrameworkCore;
using Models;
using System.Data.SqlClient;

namespace DataAccess
{
    public class AppliedServiceDbAccess
    {
        SqlDbContext db;

        public AppliedServiceDbAccess()
        {
            db = new SqlDbContext();
        }

        // Create
        public async Task CreateAsync(AppliedService newService)
        {
            await db.AppliedServices.AddAsync(newService);
            await db.SaveChangesAsync();
        }

        public bool CreateSql(AppliedService newService)
        {
            string connectionString = db.Database.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO AppliedServices (Note, UnitCount, UnitCostActual, StartPaymentActual, ServicePerformed, ServiceId, LawyerId)
                                 VALUES (@Note, @UnitCount, @UnitCostActual, @StartPaymentActual, @ServicePerformed, @ServiceId, @LawyerId);";
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Parameters.AddWithValue("@Note",newService.Note ?? string.Empty);
                    command.Parameters.AddWithValue("@UnitCount", newService.UnitCount ?? 0);
                    command.Parameters.AddWithValue("@UnitCostActual", newService.UnitCostActual ?? 0.0);
                    command.Parameters.AddWithValue("@StartPaymentActual", newService.StartPaymentActual ?? 0.0);
                    command.Parameters.AddWithValue("@ServicePerformed", newService.ServicePerformed);
                    command.Parameters.AddWithValue("@ServiceId", newService.Service.Id);
                    command.Parameters.AddWithValue("@LawyerId",newService.Lawyer.Id);

                    if(command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
        }


        // Get (Read)
        public async Task<List<AppliedService>> GetAllAsync()
        {
            return await db.AppliedServices
                .Include(m => m.Service)
                .Include(m => m.Lawyer)
                .ToListAsync();
        }

        public async Task<AppliedService> GetOneAsync(int id)
        {
            return await db.AppliedServices
                .Include(m => m.Service)
                .Include(m => m.Lawyer)
                .FirstOrDefaultAsync(Service => Service.Id == id);
        }

        // Update
        public async Task<bool> UpdateAsync(int id, AppliedService updatedService)
        {
            if (!(GetOneAsync(id) == null))
            {
                AppliedService tempService = await db.AppliedServices.FirstOrDefaultAsync(Service => Service.Id == id);
                tempService = updatedService;
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
                db.AppliedServices.Remove(await db.AppliedServices.FirstAsync(Service => Service.Id == id));
                return true;
            }
            return false;
        }
    }
}
