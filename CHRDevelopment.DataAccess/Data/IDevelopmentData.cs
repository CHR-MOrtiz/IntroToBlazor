using CHRDevelopment.DataAccess.Models;

namespace CHRDevelopment.DataAccess.Data
{
    public interface IDevelopmentData
    {
        Task DeleteDeveloper(int? id);
        Task<DeveloperModel> GetDeveloper(int? id);
        Task<IEnumerable<DeveloperModel>> GetDevelopers();
        Task InsertDeveloper(DeveloperModel developer);
        Task UpdateDeveloper(DeveloperModel developer);
    }
}