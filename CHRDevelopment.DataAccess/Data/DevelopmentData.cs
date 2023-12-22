using CHRDevelopment.DataAccess.DataAccess;
using CHRDevelopment.DataAccess.Models;

namespace CHRDevelopment.DataAccess.Data;

public class DevelopmentData(ISqlDataAccess db) : IDevelopmentData
{
    private readonly ISqlDataAccess _db = db;

    //Pull from DB
    public async Task<IEnumerable<DeveloperModel>> GetDevelopers()
        => await _db.LoadDataAsync<DeveloperModel, dynamic>("dbo.Developers_GetAll", new { });

    public async Task<DeveloperModel?> GetDeveloper(int? id)
        => (await _db.LoadDataAsync<DeveloperModel?, dynamic>("dbo.Developers_GetById", new { Id = id })).FirstOrDefault();
    //Push to DB
    public async Task InsertDeveloper(DeveloperModel developer)
        => await _db.SaveDataAsync("dbo.Developers_Insert", new { developer.FirstName, developer.LastName, developer.Title, developer.City });

    public async Task UpdateDeveloper(DeveloperModel developer)
        => await _db.SaveDataAsync("dbo.Developers_Update", developer);

    public async Task DeleteDeveloper(int? id)
        => await _db.SaveDataAsync("dbo.Developers_Delete", new { Id = id });
}
