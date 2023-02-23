using Dapr.EventBus.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dapr.EventBus.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EventBusEntityFrameworkCoreModule),
    typeof(EventBusApplicationContractsModule)
    )]
public class EventBusDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
