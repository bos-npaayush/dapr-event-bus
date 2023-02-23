using Dapr.EventBus.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dapr.EventBus;

[DependsOn(
    typeof(EventBusEntityFrameworkCoreTestModule)
    )]
public class EventBusDomainTestModule : AbpModule
{

}
