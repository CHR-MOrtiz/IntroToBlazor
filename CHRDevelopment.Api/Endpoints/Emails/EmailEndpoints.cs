namespace CHRDevelopment.Api.Endpoints.Emails;

public static class EmailEndpoints
{
    public static void ConfigureEmailsEndpoints(this WebApplication app)//Extension method
    {
        //All mappings for emailss
        //Get all emails
        app.MapGet("/emails", GetEmails);
        //Get email by developer id
        app.MapGet("/emails/{developerid}", GetEmail);
        //Update email by developer id
        app.MapPut("/emails/", UpdateEmail);
    }

    private static async Task<IResult> GetEmails(IEmailData emails)
    {
        try
        {
            return Results.Ok(await emails.GetEmails());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


    private static async Task<IResult> GetEmail(int developerId, IEmailData emails)
    {
        try
        {
            var results = await emails.GetEmailByDeveloperId(developerId);

            if (results is null) return Results.NotFound("Developer not found.");

            return Results.Ok(results);

        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateEmail(EmailRecord email, IEmailData emails)
    {
        try
        {
            var exists = await emails.GetEmailByDeveloperId(email.DeveloperId);

            if (exists is null) return Results.NotFound("developer not found.");

            await emails.UpdateEmail(email);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
