using CHRDevelopment.DataAccess.Models;

namespace CHRDevelopment.DataAccess.Data;
public interface IEmailData
{
    Task<EmailRecord?> GetEmailByDeveloperId(int? id);
    Task<IEnumerable<EmailRecord>> GetEmails();
    Task UpdateEmail(EmailRecord email);
}