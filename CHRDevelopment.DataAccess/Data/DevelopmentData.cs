using CHRDevelopment.DataAccess.DataAccess;
using CHRDevelopment.DataAccess.Models;

namespace CHRDevelopment.DataAccess.Data;

public class DevelopmentData(ISqlDataAccess db) : IDevelopmentData
{
    private readonly ISqlDataAccess _db = db;

    public async Task<IEnumerable<DeveloperModel>> GetDevelopers()
        => await _db.LoadData<DeveloperModel, dynamic>("dbo.Developers_GetAll", new { });

    public async Task<DeveloperModel?> GetDeveloper(int id)
        => (await _db.LoadData<DeveloperModel, dynamic>("dbo.Developers_GetById", new { Id = id })).FirstOrDefault();

    public async Task InsertDeveloper(DeveloperModel developer)
        => await _db.SaveData("dbo.Developer_Insert", new { developer.FirstName, developer.LastName, developer.Title, developer.City });

    public async Task UpdateDeveloper(DeveloperModel developer)
        => await _db.SaveData("dbo.Developer_Update", developer);

    public async Task DeleteDeveloper(int id)
        => await _db.SaveData("dbo.Developer_Delete", new { Id = id });
}
