using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DataAccess
{
    internal class SqlParameterStrategizer
    {
        SqlDbContext dbContext;

        readonly Dictionary<string, ISQLStrategy<object>> strategies;
        readonly ParameterStrategy addParameterHelper;

        public SqlParameterStrategizer(SqlDbContext db)
        {
            dbContext = db;
            parameterStrategy = new ParameterStrategy();

        }

        public interface ISQLStrategy<T>
        {
            //might need this to  return an SQLCommand, not sure if it will update the command otherwise :thonk:
            void AddParameters(ref SqlCommand command, T targetType);
        }

        public class ParameterStrategy
        {
            private readonly Dictionary<Type, object> strategies;

            public ParameterStrategy()
            {
                strategies = new Dictionary<Type, object>
                {
                    {"appliedservice", new AppliedServiceParameters()},
                };
            }

            public ISQLStrategy<T> GetStrategy<T>()
            {
                if (strategies.TryGetValue(typeof<T>, out var strategy))
                {
                    return (ISQLStrategy<T>)strategy;
                }
                throw new InvalidOperationException($"No strategy found for type {typeof(T).Name}")
            }

            public void AddStrategy<T>(ISQLStrategy<T> strategy)
            {
                strategies[typeof<T>] = strategy;
            }

            public void AddParameters<T>(SqlCommand command, T targetType)
            {
                var strategy = GetStrategy<T>();
                strategy.AddParameters(command, targetType);
            }
        }
        public class AppliedServiceParameters : ISQLStrategy<AppliedService>
        {
            public void AddParameters(ref SqlCommand command, AppliedService newService)
            {
                command.Parameters.AddWithValue("@Note", newService.Note ?? string.Empty);
                command.Parameters.AddWithValue("@UnitCount", newService.UnitCount ?? 0);
                command.Parameters.AddWithValue("@UnitCostActual", newService.UnitCostActual ?? 0.0);
                command.Parameters.AddWithValue("@StartPaymentActual", newService.StartPaymentActual ?? 0.0);
                command.Parameters.AddWithValue("@ServicePerformed", newService.ServicePerformed);
                command.Parameters.AddWithValue("@ServiceId", newService.Service.Id ?? null);
                command.Parameters.AddWithValue("@LawyerId", newService.Lawyer.Id ?? null);
            }
        }

        //SQLCommand command
        //-- needs to be passed into AddParameters by reference now.

        //var strategy = helper.GetStrategy<AppliedService>();
        //strategy.AddParameters(ref command, targetType);

        internal class SqlExecutor
        {

            readonly SqlDbContext dbContext;
            readonly string connString;
            readonly ParameterStrategy parameterStrategy;
            public SqlExecutor(SqlDbContext db, ParameterStrategy strategy)
            {
                dbContext = db;
                connString = db.Database.GetConnectionString();
                parameterStrategy = strategy;
            }

/*           Might be redundant, no time to try and figure it out AAAAAA
 *           sadness
 *           
 *           public async Task<int> ExecuteNonQueryAsync<T>(string commandText, T targetType)
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        parameterStrategy.AddParameters(command, targetType)
                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }

            public async Task<List<T>> ExecuteQueryAsync<T>(string commandText, Func<SqlDataReader, T> mapToModel)
            {
                List<T> results = new List<T>();

                using (SqlConnection connection = new SqlConnection(connString)) ;
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                results.Add(mapToModel(reader));
                            }
                        }
                    }
                }
                return results;
            }*/

        }
    }

}
