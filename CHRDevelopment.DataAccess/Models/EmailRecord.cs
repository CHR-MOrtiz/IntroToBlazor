using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CHRDevelopment.DataAccess.Models;
public  record class EmailRecord(int? Id, int? DeveloperId)
{
    [JsonConstructor]
    public EmailRecord(int? Id, int? DeveloperId, string email): this(Id, DeveloperId)
    {
        Email = email;
    }

    public string? Email { get; set; }
}

