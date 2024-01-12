using System.Text.Json.Serialization;

namespace IntroToBlazor.Client.Models;

public record class EmailRecord(int? Id, int? DeveloperId)
{
    [JsonConstructor]
    public EmailRecord(int? Id, int? DeveloperId, string email) : this(Id, DeveloperId)
    {
        Email = email;
    }

    public string? Email { get; set; }
}