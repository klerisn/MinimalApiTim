using System.Net.NetworkInformation;

namespace MinimalApiTim;

public static class Api
{

    public static void ConfigureApi(this WebApplication app)
    {
        // All of my Api endpoint mapping
        app.MapGet("/Users", GetUsers);
    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(data.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
