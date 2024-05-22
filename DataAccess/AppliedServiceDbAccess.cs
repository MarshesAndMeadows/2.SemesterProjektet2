using Microsoft.EntityFrameworkCore;
using Models;
using System.Data.SqlClient;
using SqlParameterStrategizer;
using static DataAccess.SqlParameterStrategizer;

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
        public async Task<bool> CreateSql(AppliedService newService)
        {
            string query = @"INSERT INTO AppliedServices (Note, UnitCount, UnitCostActual, StartPaymentActual, ServicePerformed, ServiceId, LawyerId)
                                 VALUES (@Note, @UnitCount, @UnitCostActual, @StartPaymentActual, @ServicePerformed, @ServiceId, @LawyerId);";

            using (SqlConnection connection = new SqlConnection(DbContext.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            ParameterStrategy parameterStrategy = new ParameterStrategy();
                            parameterStrategy.AddParameters(ref command, newService);

                            command.Connection = connection;
                            int rowsAffected = await command.ExecuteNonQueryAsync();
                            if (rowsAffected <= 0)
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        // Get (Read)

        public async Task<AppliedService> GetSqlAsync(int serviceId)
        {
            string query = "SELECT * FROM AppliedServices WHERE Id = @ServiceId;"
            AppliedService result = null;
            using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("ServiceId", serviceId);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            result = new AppliedService
                            {
                                result.Id = (int)reader["Id"],
                                result.Note = reader["Note"].ToString(),
                                result.UnitCount = (int)reader["UnitCount"],
                                result.UnitCostActual = (double)reader["UnitCostActual"],
                                result.StartPaymentActual = (double)reader["StartPaymentActual"],
                                result.ServicePerformed = (DateTime)reader["ServicePerfomed"],
                                result.Service.Id = (int)reader["ServiceId"],
                                result.Lawyer.Id = (int)reader["LawyerId"],
                                result.Case.Id = (int)reader["CaseId"],
                            };
                        }
                    }
                }
            }
            return result;
        }

        public async List<AppliedService> GetAllSql()
        {
            string query = "SELECT * FROM AppliedServices;"
            using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
            {
                await connection.OpenAsync()
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        List<AppliedService> listResult;
                        while(reader.ReadAsync())
                        {
                            AppliedService result = new AppliedService
                            {
                                result.Id = (int)reader["Id"],
                                result.Note = reader["Note"].ToString(),
                                result.UnitCount = (int)reader["UnitCount"],
                                result.UnitCostActual = (double)reader["UnitCostActual"],
                                result.StartPaymentActual = (double)reader["StartPaymentActual"],
                                result.ServicePerformed = (DateTime)reader["ServicePerfomed"],
                                result.Service.Id = (int)reader["ServiceId"],
                                result.Lawyer.Id = (int)reader["LawyerId"],
                                result.Case.Id = (int)reader["CaseId"],
                            };
                            listResult.Add(result)
                        }
                        return listResult;
                    }
                }
            }
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