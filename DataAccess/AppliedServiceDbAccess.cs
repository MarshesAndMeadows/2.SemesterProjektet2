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
        public async Task<bool> CreateAsync(AppliedService newService, int relatedCaseId)
        {
            string query = @"INSERT INTO AppliedServices (Note, UnitCount, UnitCostActual, StartPaymentActual, ServicePerformed, ServiceId, LawyerId, CaseId)
                                 VALUES (@Note, @UnitCount, @UnitCostActual, @StartPaymentActual, @ServicePerformed, @ServiceId, @LawyerId, @CaseId);";

            using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                SqlTransaction transaction = connection.BeginTransaction();
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(query, connection, transaction);
                        {
                            command.Parameters.AddWithValue("@Note", newService.Note ?? string.Empty);
                            command.Parameters.AddWithValue("@UnitCount", newService.UnitCount ?? 0);
                            command.Parameters.AddWithValue("@UnitCostActual", newService.UnitCostActual ?? 0.0);
                            command.Parameters.AddWithValue("@StartPaymentActual", newService.StartPaymentActual ?? 0.0);
                            command.Parameters.AddWithValue("@ServicePerformed", newService.ServicePerformed);
                            command.Parameters.AddWithValue("@ServiceId", newService.Service.Id);
                            command.Parameters.AddWithValue("@LawyerId", newService.Lawyer.Id);
                            command.Parameters.AddWithValue("@CaseId", relatedCaseId);
                            command.Connection = connection;
                            await command.ExecuteNonQueryAsync();

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
        public async Task<AppliedService> GetOneAsync(int serviceId)
        {
            string query = "SELECT * FROM AppliedServices WHERE Id = @ServiceId;";
            AppliedService result = null;
            using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceId", serviceId);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            result = new AppliedService
                            {   
                                Id = (int)reader["Id"],
                                Note = reader["Note"].ToString(),
                                UnitCount = (int)reader["UnitCount"],
                                UnitCostActual = (double)reader["UnitCostActual"],
                                StartPaymentActual = (double)reader["StartPaymentActual"],
                                ServicePerformed = (DateTime)reader["ServicePerfomed"],
                                Service = new Service
                                {
                                    Id = (int)reader["ServiceId"],
                                },
                                Lawyer = new Lawyer
                                {
                                    Id = (int)reader["LawyerId"],
                                }
                            };
                        }
                    }
                }
            }
            return result;
        }

        public async Task<List<AppliedService>> GetAllAsync()
        {
            string query = "SELECT * FROM AppliedServices;";
            using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        List<AppliedService> listResult = new List<AppliedService>();
                        while (await reader.ReadAsync())
                        {
                            AppliedService result = new AppliedService
                            {
                                Id = (int)reader["Id"],
                                Note = reader["Note"].ToString(),
                                UnitCount = (int)reader["UnitCount"],
                                UnitCostActual = (double)reader["UnitCostActual"],
                                StartPaymentActual = (double)reader["StartPaymentActual"],
                                ServicePerformed = (DateTime)reader["ServicePerfomed"],
                                Service = new Service
                                {
                                    Id = (int)reader["ServiceId"],
                                },
                                Lawyer = new Lawyer
                                {
                                    Id = (int)reader["LawyerId"],
                                }
                            };
                            listResult.Add(result);
                        }
                        return listResult;
                    };
                }
            }
        }

        // Update
        public async Task<bool> UpdateAsync(int id, AppliedService updatedService)
        {
            if (!(GetOneAsync(id) == null))
            {
                string query = @"UPDATE AppliedServices 
                SET Note = @Note, UnitCount = @UnitCount, UnitCostActual = @UnitCostActual," +
                "StartPaymentActual = @StartPaymentActual, ServicePerformed = @ServicePerformed, ServiceId = @ServiceId, Lawyer = @LawyerId WHERE Id = @Id";
                using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
                {
                    await connection.OpenAsync();
                    SqlTransaction transaction = connection.BeginTransaction();
                    {
                        try
                        {
                            SqlCommand command = connection.CreateCommand();
                            command.CommandText = query;
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@Note", updatedService.Note ?? string.Empty);
                            command.Parameters.AddWithValue("@UnitCount", updatedService.UnitCount ?? 0);
                            command.Parameters.AddWithValue("@UnitCostActual", updatedService.UnitCostActual ?? 0.0);
                            command.Parameters.AddWithValue("@StartPaymentActual", updatedService.StartPaymentActual ?? 0.0);
                            command.Parameters.AddWithValue("@ServicePerformed", updatedService.ServicePerformed);
                            command.Parameters.AddWithValue("@ServiceId", updatedService.Service.Id);
                            command.Parameters.AddWithValue("@LawyerId", updatedService.Lawyer.Id);
                            command.Parameters.AddWithValue("@Id", updatedService.Id);
                            await command.ExecuteNonQueryAsync();
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
            return false;
        }

        // Delete
        public async Task<bool> DeleteAsync(int id)
        {
            if (!(GetOneAsync(id) == null))
            {
                string query = "DELETE FROM AppliedServices WHERE Id = @Id";
                using (SqlConnection connection = new SqlConnection(db.Database.GetConnectionString()))
                {
                    await connection.OpenAsync();
                    SqlTransaction transaction = connection.BeginTransaction();
                    {
                        try
                        {
                            SqlCommand command = connection.CreateCommand();
                            command.Parameters.AddWithValue("@Id", id);
                            command.CommandText = query;
                            command.Transaction = transaction;

                            await command.ExecuteNonQueryAsync();
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
            return false;
        }
    }
}
