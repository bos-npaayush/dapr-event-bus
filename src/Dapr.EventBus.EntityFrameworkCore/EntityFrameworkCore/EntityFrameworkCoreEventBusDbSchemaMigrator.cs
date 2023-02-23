using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dapr.EventBus.Data;
using Volo.Abp.DependencyInjection;

namespace Dapr.EventBus.EntityFrameworkCore;

public class EntityFrameworkCoreEventBusDbSchemaMigrator
    : IEventBusDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEventBusDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EventBusDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EventBusDbContext>()
            .Database
            .MigrateAsync();
    }
}
