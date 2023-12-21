
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CHRDevelopment.DataAccess.DataAccess;

public class SqlDataAccess(IConfiguration config) : ISqlDataAccess
{
    private readonly IConfiguration _config = config;

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedures, U parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryAsync<T>(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedures, T parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }
}

