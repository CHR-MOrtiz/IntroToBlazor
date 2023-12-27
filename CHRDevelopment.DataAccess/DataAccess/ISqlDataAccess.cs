
namespace CHRDevelopment.DataAccess.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedures, U parameters, string connectionId = "Default");
        Task CommandDataAsync<T>(string storedProcedures, T parameters, string connectionId = "Default");
    }
}