using System.Threading.Tasks;

namespace Dapr.EventBus.Data;

public interface IEventBusDbSchemaMigrator
{
    Task MigrateAsync();
}
