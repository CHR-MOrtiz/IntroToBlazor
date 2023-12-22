
namespace CHRDevelopment.DataAccess.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedures, U parameters, string connectionId = "Default");
        Task SaveDataAsync<T>(string storedProcedures, T parameters, string connectionId = "Default");
    }
}