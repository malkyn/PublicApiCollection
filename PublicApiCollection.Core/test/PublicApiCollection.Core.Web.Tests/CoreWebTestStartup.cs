using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace PublicApiCollection.Core;

public class CoreWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<CoreWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
