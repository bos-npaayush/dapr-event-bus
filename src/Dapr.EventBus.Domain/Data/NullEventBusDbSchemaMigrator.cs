using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dapr.EventBus.Data;

/* This is used if database provider does't define
 * IEventBusDbSchemaMigrator implementation.
 */
public class NullEventBusDbSchemaMigrator : IEventBusDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
