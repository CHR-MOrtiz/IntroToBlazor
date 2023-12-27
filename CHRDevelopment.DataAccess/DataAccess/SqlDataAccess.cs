
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CHRDevelopment.DataAccess.DataAccess;

public class SqlDataAccess(IConfiguration config) : ISqlDataAccess
{
    private readonly IConfiguration _config = config;

    //CQRS (Command Query Responsibilty Separation)

    /// <summary>
    /// Loads data from DB
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <param name="storedProcedures"></param>
    /// <param name="parameters"></param>
    /// <param name="connectionId"></param>
    /// <returns>Results of type<typeparamref name="T"/></returns>
    public async Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedures, U parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryAsync<T>(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }

    /// <summary>
    /// Saves data to DB
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storedProcedures"></param>
    /// <param name="parameters"></param>
    /// <param name="connectionId"></param>
    /// <returns></returns>
    public async Task CommandDataAsync<T>(string storedProcedures, T parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }
}

