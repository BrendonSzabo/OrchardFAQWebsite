using Microsoft.AspNetCore.Http;
using OrchardCore.DisplayManagement.Theming;
using System;
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

        if (path.StartsWith("faq"))
        {
            Console.WriteLine("FAQThemeSelector: Applying FAQTheme to path: " + path);
            return Task.FromResult(new ThemeSelectorResult
            {
                Priority = 100,
                ThemeName = "FAQTheme"
            });
        }

        return Task.FromResult<ThemeSelectorResult>(null);
    }
}
