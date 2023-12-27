using CHRDevelopment.DataAccess.DataAccess;
using CHRDevelopment.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRDevelopment.DataAccess.Data;
public class EmailData(ISqlDataAccess db) : IEmailData
{
    private readonly ISqlDataAccess _db = db;

    //Pull from DB
    public async Task<IEnumerable<EmailRecord>> GetEmails()
        => await _db.QueryDataAsync<EmailRecord, dynamic>("dbo.Developers_GetAllEmails", new { });

    public async Task<EmailRecord?> GetEmailByDeveloperId(int? developerId)
        => (await _db.QueryDataAsync<EmailRecord?, dynamic>("dbo.Developers_GetEmailByDeveloperId", new { DeveloperId = developerId })).FirstOrDefault();

    //Push to DB
    public async Task UpdateEmail(EmailRecord email)
        => await _db.CommandDataAsync("dbo.Developers_UpdateEmail", new { email.DeveloperId, email.Email });
}
