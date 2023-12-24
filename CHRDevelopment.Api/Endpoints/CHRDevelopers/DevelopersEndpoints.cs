namespace CHRDevelopment.Api.EndPoints.CHRDevelopers;

public static class DevelopersEndpoints
{
    public static void ConfigureDevelopersEndpoints(this WebApplication app)//Extension method
    {
        //All mappings for developers
        //Get all developers
        app.MapGet("/developers", GetDevelopers);
        //Get developer by id
        app.MapGet("/developers/{id}", GetDeveloper);
        //Insert developer
        app.MapPost("/developers", InsertDeveloper);
        //Update developer
        app.MapPut("/developers", UpdateDeveloper);
        //Delete developer
        app.MapDelete("/developers/{id}", DeleteDeveloper);
    }

    private static async Task<IResult> GetDevelopers(IDevelopmentData developers)
    {
        try
        {
            return Results.Ok(await developers.GetDevelopers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    /// <summary>
    /// This method combines where the parameters' origin.
    /// </summary>
    /// <param name="id">This comes from the endpoint</param>
    /// <param name="data">This comes from Dependecy Injection</param>
    /// <returns></returns>
    private static async Task<IResult> GetDeveloper(int id, IDevelopmentData developers)
    {
        try
        {
            var results = await developers.GetDeveloper(id);

            if (results is null) return Results.NotFound("Developer not found.");

            return Results.Ok(results);

        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertDeveloper(DeveloperModel developer, IDevelopmentData developers)
    {
        try
        {
            await developers.InsertDeveloper(developer);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateDeveloper(DeveloperModel developer, IDevelopmentData developers)
    {
        try
        {
            var exists = await developers.GetDeveloper(developer.Id);

            if (exists is null) return Results.NotFound("Developer not found.");

            developer.FirstName = developer.FirstName ?? exists.FirstName;
            developer.LastName = developer.LastName ?? exists.LastName;
            developer.Title = developer.Title ?? exists.Title;
            developer.City = developer.City ?? exists.City;

            await developers.UpdateDeveloper(developer);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteDeveloper(int id, IDevelopmentData developers)
    {
        try
        {
            var exists = await developers.GetDeveloper(id);

            if (exists is null) return Results.NotFound("Developer not found.");

            await developers.DeleteDeveloper(exists.Id);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
