using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CHRDevelopment.DataAccess.Models;


public record class DeveloperModel(int? Id)
{
    /*[JsonConstructor] Attribute Necessary to avoid:
     * System.NotSupportedException: Deserialization of types without a parameterless constructor,
     * a singular parameterized constructor, or a parameterized constructor annotated with 'JsonConstructorAttribute' is not supported. */
    [JsonConstructor]
    public DeveloperModel(int? Id, string firstName, string lastName, string title, string city, bool isActive) : this(Id)
    {
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        City = city;
        IsActive = isActive;
    }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? City { get; set; }

    public bool IsActive { get; set; }
};
