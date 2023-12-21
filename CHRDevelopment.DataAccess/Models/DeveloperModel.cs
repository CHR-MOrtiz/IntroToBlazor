using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRDevelopment.DataAccess.Models;

public record class DeveloperModel(int? Id)
{
    public DeveloperModel(int id, string firstName, string lastName, string title, string city) : this(id)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        City = city;
    }

    //public int Id { get; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Title { get; set; }
    public string? City { get; set; }
};
