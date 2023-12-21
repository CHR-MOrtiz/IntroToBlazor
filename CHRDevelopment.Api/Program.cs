var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var developers = new List<Developer>
{
    new(1, "", "Weiss", "Lead Developer", "Souix Falls" ),
    new(2, "Dennis", "Winkley", "Senior Developer", "Sioux Falls" ),
    new(3, "Cassidy", "Hodgin", "Senior Developer", "Sioux Falls" ),
    new(4, "Ron", "Vander Wal", "Senior Developer", "Sioux Falls" ),
    new(5, "Ryan", "Quasney", "DevOps", "Rapid City" ),
    new(6, "Gian", "Villaronte", "Junior Developer", "Calabarzon" ),
    new(7, "Mateo", "Ortiz", "Developer", "Orlando" ),

};

app.MapGet("/developers", () =>
{
    return developers;
});

app.MapGet("/developers/{id}", (int id) =>
{
    var developer = developers.Find(d => d.Id == id);

    if (developer is null)
    {
        return Results.NotFound("Developer not found.");
    }

    return Results.Ok(developer);
});

app.MapPost("/developers", (Developer developer) =>
{
    developers.Add(developer);
    return developers;
});

app.MapPut("/developers/{id}", (Developer updateDeveloper,int id) =>
{
    var developer = developers.Find(d => d.Id == id);

    if (developer is null)
    {
        return Results.NotFound("Developer not found.");
    }

    developer.FirstName = updateDeveloper.FirstName ?? developer.FirstName;
    developer.LastName = updateDeveloper.LastName ?? developer.LastName;
    developer.Title = updateDeveloper.Title ?? developer.Title;
    developer.City = updateDeveloper.City ?? developer.City;

    return Results.Ok(developers);
});

app.MapDelete("/developers/{id}", (int id) =>
{
    var developer = developers.Find(d => d.Id == id);

    if (developer is null)
    {
        return Results.NotFound("Developer not found.");
    }

    developers.Remove(developer);

    return Results.Ok(developers);
});


app.Run();

public record class Developer(int? Id)
{
       public Developer(int id, string firstName, string lastName, string title, string city) : this(id)
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
