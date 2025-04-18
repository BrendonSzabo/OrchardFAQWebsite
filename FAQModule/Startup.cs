using FAQModule.Drivers;
using FAQModule.Handlers;
using FAQModule.Indexes;
using FAQModule.Migrations;
using FAQModule.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.DisplayManagement.Theming;
using OrchardCore.Modules;
using System;
using YesSql.Indexes;

namespace FAQModule
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddContentPart<FAQPart>()
                .UseDisplayDriver<FAQPartDisplayDriver>()
                .AddHandler<FAQPartHandler>();

            services.AddScoped<IDataMigration, FAQMigrations>();
            services.AddSingleton<IIndexProvider, FAQPartIndexProvider>();
            services.AddScoped<IThemeSelector, FAQThemeSelector>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "FAQModule",
                pattern: "faq",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}