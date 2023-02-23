using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Dapr.EventBus;

public class EventBusWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<EventBusWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
