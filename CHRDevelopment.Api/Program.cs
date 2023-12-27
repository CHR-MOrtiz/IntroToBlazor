using CHRDevelopment.Api.Endpoints.Emails;
using CHRDevelopment.Api.EndPoints.CHRDevelopers;
using CHRDevelopment.DataAccess.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IDevelopmentData, DevelopmentData>();
builder.Services.AddSingleton<IEmailData, EmailData>();

//Cors Allow
var MyAllowSpecificOrigin = "_myAllowSpecificOrigins";

builder.Services.AddCors(options => {
    options.AddPolicy(MyAllowSpecificOrigin,
    policy => {
        policy.WithOrigins("https://localhost:7204","http://localhost:5204")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Allow Cors
app.UseCors(MyAllowSpecificOrigin);

app.ConfigureDevelopersEndpoints();//Quarter back method (calls and arragins the plays)

app.ConfigureEmailsEndpoints();

app.Run();