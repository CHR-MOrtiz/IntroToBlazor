using CHRDevelopment.DataAccess.DataAccess;
using CHRDevelopment.DataAccess.Models;

namespace CHRDevelopment.DataAccess.Data;

public class DevelopmentData(ISqlDataAccess db) : IDevelopmentData
{
    private readonly ISqlDataAccess _db = db;

    //Pull from DB
    public async Task<IEnumerable<DeveloperModel>> GetDevelopers()
        => await _db.QueryDataAsync<DeveloperModel, dynamic>("dbo.Developers_GetAll", new { });

    public async Task<DeveloperModel?> GetDeveloper(int? id)
        => (await _db.QueryDataAsync<DeveloperModel?, dynamic>("dbo.Developers_GetById", new { Id = id })).FirstOrDefault();
    //Push to DB
    public async Task InsertDeveloper(DeveloperModel developer)
        => await _db.CommandDataAsync("dbo.Developers_Insert", new { developer.FirstName, developer.LastName, developer.Title, developer.City });

    public async Task UpdateDeveloper(DeveloperModel developer)
        => await _db.CommandDataAsync("dbo.Developers_Update", developer);

    public async Task ActivateDeactiveDeveloper(int? id)
       => await _db.CommandDataAsync("dbo.Developers_Activate_Deactivate", new { Id = id });

    public async Task DeleteDeveloper(int? id)
        => await _db.CommandDataAsync("dbo.Developers_Delete", new { Id = id });
}
