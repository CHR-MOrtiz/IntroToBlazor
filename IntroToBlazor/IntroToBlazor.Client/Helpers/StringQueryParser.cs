using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace IntroToBlazor.Client.Helpers;

public static class StringQueryParser
{
    public static string ParseQueryString(Uri uri, string key)
    {
        try
        {
            if (QueryHelpers.ParseQuery(uri!.Query).TryGetValue(key!, out var outUri))
            {
                return outUri!;
            }
        }
        catch (Exception)
        {
            throw;
        }

        return default!;
    }
}
