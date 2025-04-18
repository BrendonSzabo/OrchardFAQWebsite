using Microsoft.AspNetCore.Http;
using OrchardCore.DisplayManagement.Theming;
using System;
using System.Drawing.Printing;
using System.Threading.Tasks;

public class FAQThemeSelector : IThemeSelector
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public FAQThemeSelector(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Task<ThemeSelectorResult> GetThemeAsync()
    {
        var path = _httpContextAccessor.HttpContext.Request.Path.Value;

        // Apply FAQTheme to URLs starting with /faq
        if (path.StartsWith("faq"))
        {
            Console.WriteLine("FAQThemeSelector: Applying FAQTheme to path: " + path);
            return Task.FromResult(new ThemeSelectorResult
            {
                Priority = 100, // Higher priority to override other selectors
                ThemeName = "FAQTheme" // Name of your theme
            });
        }

        // Return null to let other selectors decide the theme
        return Task.FromResult<ThemeSelectorResult>(null);
    }
}
